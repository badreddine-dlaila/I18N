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
    /// Match level for <see cref="LanguageTag"/>
    /// </summary>
    public enum MatchLevel
    {
        /// <summary>
        /// Only consider a match where language and script and region and private use parts matchs.
        /// E.g. fr matches fr
        /// E.g. zh-Hans-HK matches zh-Hans-HK
        /// E.g. fr-FR-x-AAAA matches fr-FR-x-AAAA
        /// </summary>
        ExactMatch = 0,

        /// <summary>
        /// Only consider a match where language and script parts match, one region is set and the other region is not.
        /// E.g. fr matches fr-BE
        /// E.g. zh-Hans-HK matches zh-Hans
        /// </summary>
        DefaultRegion = 1,

        /// <summary>
        /// Only consider a match where language and script parts match. Region part need not match.
        /// E.g. fr-CA matches fr-BE
        /// E.g. zh-Hant-HK matches zh-Hant-TW
        /// </summary>
        ScriptMatch = 2,

        /// <summary>
        /// Only consider a match where language matches. Script and region parts need not match.
        /// E.g. zh-Hans-HK matches zh
        /// </summary>
        LanguageMatch = 3,

        /// <summary>
        /// Only consider a match where language matches. Script and region parts need not match.
        /// E.g. zh-Hans-HK matches zh
        /// </summary>
        // ReSharper disable once InconsistentNaming
        _MaxMatch = LanguageMatch,
    }
}