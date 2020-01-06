using System.Text.RegularExpressions;

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

namespace Cosmos.I18N.Core {
    internal static class LanguageTagParseRegexUtils {
        // ([a-zA-Z]{2,3})
        //      Matches language.
        // (?:-([a-zA-Z]{4,5}))?
        //      Matches script.
        //      NB: The inner group is wrapped in an outer non-capturing group that
        //      prefixed the former with the '-' which is thus not captured.
        //      NB: according to BCP47, Script subtage is always 4 chars; however, we have
        //      expanded this to allow 5 chars also so as to allow parsing all the Microsoft 
        //      Pseudo-Locale language tags (qps-ploc, qps-plocm, qps-ploca).
        //      If this causes a problem, consider explicitly matching (ploc|plocm|ploca).
        //      Ref Issue https://github.com/turquoiseowl/i18n/issues/195.
        // (?:-([a-zA-Z]{2}|[0-9]{3}))?
        //      Matches region.
        //      NB: The inner group is wrapped in an outer non-capturing group that
        //      prefixed the former with the '-' which is thus not captured.
        // (?:\+[a-zA-Z0-9]{4,})?
        //      Matches private use subtag
        //      eg en-ABCD-GB-x-AAAA
        private static Regex _langTagParseRegex = new Regex(@"^([a-zA-Z]{2,3})(?:-([a-zA-Z]{4,5}))?(?:-([a-zA-Z]{2}|[0-9]{3}))?(?:\-x-([a-zA-Z0-9]{4,}))?$",
            RegexOptions.CultureInvariant);

        // ^/
        // (                                # begin 1st and only capture group
        // [a-zA-Z]{2,3}                    # 2-letter or 3-letter country code
        // (?:-[a-zA-Z]{4,5})?              # optional script code - not a capture group itself
        // (?:-(?:[a-zA-Z]{2}|[0-9]{3}))?   # optional region code (2-letter or 3-digit) - not a capture group itself
        // (?:\-x-([a-zA-Z0-9]{4,}))?       # optional private use tag (-x- followed by 4+ alphanumericcharacters) - not a capture group itself
        // )                                # end 1st and only capture group
        // (?:$|/|\?|#)                     # match end of string or fwd-slash char or question-mark char or hash char - not a capture group itself

        private static Regex _urlParseRegex = new Regex(@"^/([a-zA-Z]{2,3}(?:-[a-zA-Z]{4,5})?(?:-(?:[a-zA-Z]{2}|[0-9]{3}))?(?:\-x-([a-zA-Z0-9]{4,}))?)(?:$|/|\?|#)",
            RegexOptions.CultureInvariant);

        public static Match MatchLanguageTag(string langTag) => _langTagParseRegex.Match(langTag);

        public static Match MatchUrl(string url) => _urlParseRegex.Match(url);
    }
}