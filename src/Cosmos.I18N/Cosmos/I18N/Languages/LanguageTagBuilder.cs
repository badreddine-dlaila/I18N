using System;
using System.Globalization;
using Cosmos.I18N.Core.Extensions;

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
    internal class LanguageTagBuilder
    {
        public LanguageTagBuilder(string originalLangTag, string language, string script, string region, string privateUse)
        {
            OriginalLanguageTag = NotNull(originalLangTag);
            Language = NotNull(language);
            Script = script;
            Region = region;
            PrivateUse = privateUse;
        }

        public string OriginalLanguageTag { get; }

        public string Language { get; }

        public string Script { get; }

        public string Region { get; }

        public string PrivateUse { get; }

        private LanguageTag Parent { get; set; }

        private CultureInfo CultureInfo { get; set; }

        private string Alias { get; set; }

        public LanguageTagBuilder SetAlias(string alias)
        {
            if (!string.IsNullOrWhiteSpace(alias))
                Alias = alias;
            return this;
        }

        private void UpdateParent()
        {
            //load any parent:
            //l-s-r-p -> l-s-r
            //l-s-r   -> l-s
            //l-r     -> l
            //l-s     -> l
            //l       -> no parent
            if (Region.IsSet() && Script.IsSet() && PrivateUse.IsSet())
                Parent = GetParentLanguageTag($"{Language}-{Script}-{Region}");
            else if (Region.IsSet() && Script.IsSet())
                Parent = GetParentLanguageTag($"{Language}-{Script}");
            else if (Script.IsSet() || Region.IsSet())
                Parent = GetParentLanguageTag(Language);
            else
                Parent = default;
        }

        private void UpdateCultureInfo()
        {
            try
            {
                if (PrivateUse.IsSet())
                    CultureInfo = new CultureInfo(OriginalLanguageTag.Replace($"-x-{PrivateUse}", string.Empty));
                else
                    CultureInfo = new CultureInfo(OriginalLanguageTag);
            }
            catch (ArgumentException) { }
        }

        public LanguageTag Build()
        {
            //Load any parent
            UpdateParent();

            //Update culture info
            UpdateCultureInfo();

            var tag = new LanguageTag(OriginalLanguageTag, Language, Script, Region, PrivateUse, Parent, CultureInfo);

            //Update alias
            if (!string.IsNullOrWhiteSpace(Alias))
                tag.UpdateAlias(Alias);

            return tag;
        }

        #region Private static methods

        private static string NotNull(string originalText)
        {
            if (originalText.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(originalText), $"Text '{originalText}' cannot be null or empty.");
            return originalText;
        }

        private static LanguageTag GetParentLanguageTag(string langTag)
        {
            return LanguageTagManager.Create(langTag) as LanguageTag;
        }

        #endregion

    }
}