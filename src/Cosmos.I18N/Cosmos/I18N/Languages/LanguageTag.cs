using System.Globalization;

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

        #region Internal methods for interface

        string ILanguageTag.GetLanguage() => Language;

        #endregion

    }
}