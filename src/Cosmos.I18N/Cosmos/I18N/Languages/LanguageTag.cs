using System;
using System.Globalization;
using Cosmos.I18N.Core.Extensions;

// ReSharper disable InconsistentNaming

// Reference to:
//  https://github.com/turquoiseowl/i18n/blob/master/src/i18n.Domain/Concrete/LanguageTag.cs
// Also see:
//  https://docs.microsoft.com/en-us/windows/win32/intl/pseudo-locales
//  https://www.w3.org/International/articles/language-tags/

//language-sub-tags:
//    language    mandatory, 2 or 3 alphachars
//    script      opt, 4 alphachars, or 5 alphachars in the special case of Ms Pseudo-Locales
//    region      opt, 2 alphachars(alpha2 code) or 3 decdigits, see Cosmos.I18N.Countries
//    private use opt, -x- followed by 4 or more alphanumeric chars

namespace Cosmos.I18N.Languages
{
    /// <summary>
    /// Language tag
    /// </summary>
    public class LanguageTag : ILanguageTag
    {
        // ReSharper disable once UnusedMember.Local
        private LanguageTag() { }

        internal LanguageTag(string originalLanguageTag, string language, string script, string region, string privateUse, LanguageTag parent, CultureInfo cultureInfo)
        {
            OriginalLanguageTag = originalLanguageTag;
            LowerCaseLanguageTag = originalLanguageTag.ToLowerInvariant();
            Language = language;
            Script = script;
            Region = region;
            PrivateUse = privateUse;

            Parent = parent;
            CultureInfo = cultureInfo;
            NativeNameTitleCase = CultureInfo != null ? CultureInfo.TextInfo.ToTitleCase(CultureInfo.NativeName) : "OriginalLangTag";

            GlobalKey = $"po:{OriginalLanguageTag}".ToLowerInvariant();
        }

        /// <summary>
        /// Parent node of such language tag
        /// </summary>
        private LanguageTag Parent { get; }

        /// <summary>
        /// Original language tag
        /// </summary>
        private string OriginalLanguageTag { get; }

        /// <summary>
        /// Language tag in lower-case
        /// </summary>
        private string LowerCaseLanguageTag { get; }

        /// <summary>
        /// Language
        /// </summary>
        public string Language { get; }

        /// <summary>
        /// Script
        /// </summary>
        public string Script { get; }

        /// <summary>
        /// Region
        /// </summary>
        public string Region { get; }

        /// <summary>
        /// PrivateUse
        /// </summary>
        public string PrivateUse { get; }

        /// <summary>
        /// Globak key
        /// </summary>
        public string GlobalKey { get; }

        /// <summary>
        /// Culture info
        /// </summary>
        public CultureInfo CultureInfo { get; }

        /// <summary>
        /// Native name in title-case
        /// </summary>
        public string NativeNameTitleCase { get; }

        #region Match

        /// <summary>
        /// Match
        /// </summary>
        /// <param name="appLanguage"></param>
        /// <param name="matchLevel"></param>
        /// <returns></returns>
        public int Match(LanguageTag appLanguage, MatchLevel matchLevel = MatchLevel.LanguageMatch)
        {
            return LanguageTagMatcher.Match(this, appLanguage, matchLevel);
        }

        /// <summary>
        /// Match
        /// </summary>
        /// <param name="appLanguages"></param>
        /// <param name="matchedTag"></param>
        /// <param name="matchLevel"></param>
        /// <returns></returns>
        public int Match(LanguageTag[] appLanguages, out LanguageTag matchedTag, MatchLevel matchLevel = MatchLevel.LanguageMatch)
        {
            return LanguageTagMatcher.Match(this, appLanguages, out matchedTag, matchLevel);
        }

        #endregion

        #region Url static methods

        /// <summary>
        /// Helper for detecting a URL prefixed with a langtag part, and if found outputs
        /// both the langtag and the URL with the prefix removed.
        /// </summary>
        /// <param name="url">Either an absolute or relative URL string, as specified by the uriKind parameter.</param>
        /// <param name="kind">
        /// Indicates the type of URI in the url parameter. If the URL is known to be relative, this method is more efficient if this 
        /// parameter is set to UriKind.Relative.
        /// </param>
        /// <param name="urlPatched">
        /// On success, set to the URL with the prefix path part removed.
        /// On failure, set to value of url param.
        /// </param>
        /// <remarks>
        /// This method does not check for the validity of the returned langtag other than
        /// it matching the pattern of a langtag as supported by this LanguageTag class.
        /// </remarks>
        /// <returns>On success a langtag string, otherwise null.</returns>
        /// <remarks>
        /// <para>
        /// For URL /zh-Hans/account/signup we return "zh-Hans" and output /account/signup.
        /// </para>
        /// </remarks>
        public static string GetTagFromUrl(string url, UriKind kind, out string urlPatched)
        {
            // If url is possibly absolute
            if (kind != UriKind.Relative)
            {
                // If absolute url (include host and optionally scheme)
                if (Uri.TryCreate(url, UriKind.Absolute, out _))
                {
                    var builder = new UriBuilder(url);
                    var newUrl = GetTagFromUrl(builder.Path, UriKind.Relative, out urlPatched);
                    // Match?
                    if (newUrl != null)
                    {
                        builder.Path = newUrl;
                        return builder.Uri.ToString(); // Go via Uri to avoid port 80 being added.
                    }

                    // No match.
                    urlPatched = url;
                    return null;
                }
            }

            // Url is relative. Parse it.
            var match = Core.LanguageTagParseRegexUtils.MatchUrl(url);
            // If successful
            if (match.Success && match.Groups.Count == 3)
            {
                // Extract the langtag value.
                var langtag = match.Groups[1].Value;
                // Patch the url.
                urlPatched = url.Substring(langtag.Length + 1);
                if (!urlPatched.StartsWith("/"))
                    urlPatched = "/" + urlPatched;

                // Success.
                return langtag;
            }

            // No match.
            urlPatched = url;
            return null;
        }

        /// <summary>
        /// Patches in the langtag into the passed url, replacing any extant langtag in the url if necessary.
        /// </summary>
        /// <param name="url">Either an absolute or relative URL string, as specified by the uriKind parameter.</param>
        /// <param name="kind">
        /// Indicates the type of URI in the url parameter. If the URL is known to be relative, this method is more efficient if this 
        /// parameter is set to UriKind.Relative.
        /// </param>
        /// <param name="langtag">
        /// Optional langtag to be patched into the URL, or null if any langtag 
        /// to be removed from the URL.
        /// </param>
        /// <returns>UriBuilder containing the modified version of url.</returns>
        /// <remarks>
        /// <para>"http://example.com/account/signup"         , "en" -> "http://example.com/en/account/signup"</para>
        /// <para>"http://example.com/zh-Hans/account/signup" , "en" -> "http://example.com/en/account/signup"</para>
        /// </remarks>
        public static string SetTagInUrl(string url, UriKind kind, string langtag)
        {
            GetTagFromUrl(url, kind, out var urlPatched);
            return urlPatched.UrlPrependPath(langtag);
        }

        #endregion

        #region Internal methods for interface

        string ILanguageTag.GetLanguage() => Language;
        string ILanguageTag.GetExtlang() => null;
        string ILanguageTag.GetScript() => Script;
        string ILanguageTag.GetRegion() => Region;
        string[] ILanguageTag.GetVariant() => null;
        string ILanguageTag.GetExtension() => null;
        string ILanguageTag.GetPrivateuse() => null;
        ILanguageTag ILanguageTag.GetParent() => Parent;
        int ILanguageTag.GetMaxParents() => 2;
        CultureInfo ILanguageTag.GetCultureInfo() => CultureInfo;
        string ILanguageTag.GetNativeNameTitleCase() => NativeNameTitleCase;

        #endregion

        #region Object methods

        // [Object]
        /// <returns>
        /// Language tag string.
        /// Supports a subset of BCP 47 language tag spec corresponding to the Windows
        /// support for language names, namely the following subtags:
        ///     language (mandatory, 2 alphachars)
        ///     script   (optional, 4 alphachars)
        ///     region   (optional, 2 alphachars | 3 decdigits)
        /// Example tags supported:
        ///     "en"            [language]
        ///     "en-US"         [language + region]
        ///     "zh"            [language]
        ///     "zh-HK"         [language + region]
        ///     "zh-123"        [language + region]
        ///     "zh-Hant"       [language + script]
        ///     "zh-Hant-HK"    [language + script + region]
        ///     "en-GB-x-ABCD" [language + region + privateuse]
        /// </returns>
        public override string ToString() => OriginalLanguageTag.IsNotNullNorEmpty() ? OriginalLanguageTag : string.Empty;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is LanguageTag rhs && Equals(rhs);

        /// <inheritdoc />
        public override int GetHashCode() => LowerCaseLanguageTag.GetHashCode();

        // [IEquatable<ILanguageTag>]
        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(ILanguageTag other)
        {
            return 0 == string.Compare(OriginalLanguageTag, other.ToString(), StringComparison.OrdinalIgnoreCase);
        }

        // [IEquatable<LanguageTag>]
        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(LanguageTag other)
        {
            return 0 == string.CompareOrdinal(LowerCaseLanguageTag, other.LowerCaseLanguageTag);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(string other)
        {
            var ltOther = LanguageTagCache.Get<LanguageTag>(other);
            return 0 == string.CompareOrdinal(LowerCaseLanguageTag, ltOther.LowerCaseLanguageTag);
        }

        #endregion

        #region IComparable methods

        // [IComparable<ILanguageTag>]
        /// <summary>
        /// CompareTo
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(ILanguageTag other)
        {
            return string.Compare(OriginalLanguageTag, other.ToString(), StringComparison.OrdinalIgnoreCase);
        }

        // [IComparable<LanguageTag>]
        /// <summary>
        /// CompareTo
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(LanguageTag other)
        {
            return string.CompareOrdinal(LowerCaseLanguageTag, other.LowerCaseLanguageTag);
        }

        /// <summary>
        /// CompareTo
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(string other)
        {
            var ltOther = LanguageTagCache.Get<LanguageTag>(other);
            return string.CompareOrdinal(LowerCaseLanguageTag, ltOther.LowerCaseLanguageTag);
        }

        #endregion

    }
}