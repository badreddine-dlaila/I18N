using System;

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

namespace Cosmos.I18N.Languages {
    internal static class LanguageTagMatcher {
        /// <summary>
        /// Performs 'language matching' between lang described by this (A)
        /// and language decibed by i_rhs (B). Essentially, returns an assessment of
        /// how well a speaker of A will understand B.
        /// The key points are as follows:
        ///   · The Script is almost as relevant as the language itself; that is, if
        ///     you speak a language but do not understand the script, you cannot
        ///     read that language. Thus a mismatch in Script should score low.
        ///   · The Region is less relevant than Script to understanding of language.
        ///     The one exception to this is where the Region has traditionally been
        ///     used to also indicate the Script. E.g.
        ///         zh-CH -> Chinese (Simplified)  i.e. zh-Hans
        ///         zh-TW -> Chinese (Traditional) i.e. zh-Hant
        ///     In these cases we normalize all legacy langtags to their new values
        ///     before matching. E.g. zh-CH is normalized to zh-Hans.
        /// «LX113»
        /// </summary>
        /// <param name="leftLanguageTag"></param>
        /// <param name="rightLanguageTag"></param>
        /// <param name="matchLevel"></param>
        /// <returns>
        /// Returns a score on to what extent the two languages match. The value ranges from
        /// 100 (exact match) down to 0 (fundamental language tag mismatch), with values 
        /// in between which may be used to compare quality of a match, larger the value
        /// meaning better quality.
        /// </returns>
        /// <remarks>
        /// Matching values:
        ///                                              RHS
        /// this                    lang    lang+script     lang+region     lang+script+region
        /// ----------------------------------------------------------------------------------
        /// lang                |   A       D               C               D
        /// lang+script         |   D       A               D               B
        /// lang+region         |   C       D               A               D
        /// lang+script+region  |   D       B               D               A
        /// 
        /// NB: For the purposes of the logic above, lang incorporates Language + PrivateUse subtags.
        /// 
        /// A. Exact match (100)
        ///     All three subtags match.
        /// B. Unbalanced Region Mismatch (99) [zh, zh-HK] [zh-Hans, zh-Hans-HK]
        ///     Language and Script match;
        ///     one side has Region set while the other doesn't.
        ///     Here there is the possibility that due to defaults Region matches.
        /// C. Balanced Region Mismatch (98) [zh-IK, zh-HK] [zh-Hans-IK, zh-Hans-HK]
        ///     Language and Script match;
        ///     both sides have Region set but to different values.
        ///     Here there is NO possibility that Region matches.
        /// D. Unbalanced Script Mismatch (97) [zh-HK, zh-Hant-HK]
        ///     Language matches, Region may match;
        ///     one side has Script set while the other doesn't.
        ///     Here there is the possibility that due to defaults Script matches.
        /// E. Balanced Script Mismatch (96)
        ///     Language matches, Region may match;
        ///     both sides have Script set but to different values.
        ///     Here there is NO possibility that Script matches.
        /// F. Language Mismatch (0)
        ///     Language doesn't match.
        /// </remarks>
        /// <seealso href="http://msdn.microsoft.com/en-us/library/windows/apps/jj673578.aspx"/>
        public static int Match(LanguageTag leftLanguageTag, LanguageTag rightLanguageTag, MatchLevel matchLevel = MatchLevel.LanguageMatch) {
            if (leftLanguageTag == null)
                throw new ArgumentNullException(nameof(leftLanguageTag));

            if (rightLanguageTag == null)
                throw new ArgumentNullException(nameof(rightLanguageTag));

            if (leftLanguageTag.Language.IsNullOrEmpty() || rightLanguageTag.Language.IsNullOrEmpty())
                return 0;

            //Init
            bool[] init(string l, string r) => new[] {0 == string.Compare(l, r, StringComparison.OrdinalIgnoreCase), l.IsNotNullNorEmpty(), r.IsNotNullNorEmpty()};
            var L = init(leftLanguageTag.Language, rightLanguageTag.Language);
            var S = init(leftLanguageTag.Script, rightLanguageTag.Script);
            var R = init(leftLanguageTag.Region, rightLanguageTag.Region);
            var P = init(leftLanguageTag.PrivateUse, rightLanguageTag.PrivateUse);

            // Language incorporates Language + PrivateUse subtags for our logic here.
            L[0] = L[0] && P[0];
            L[1] = L[1] || P[1];
            L[2] = L[2] || P[2];

            // Logic.
            int score = 100;

            // F.
            if (!L[0])
                return 0;

            // A.
            if (S[0] && R[0] && P[0]) {
                return score;
            }

            --score;
            if (matchLevel != MatchLevel.ExactMatch) {
                // B.
                if (S[0] && !R[0] && R[1] != R[2]) {
                    return score;
                }

                --score;
                if (matchLevel != MatchLevel.DefaultRegion) {
                    // C.
                    if (S[0] && !R[0] && R[1] == R[2]) {
                        return score;
                    }

                    --score;
                    if (matchLevel != MatchLevel.ScriptMatch) {
                        // D.
                        if (!S[0] && S[1] != S[2]) {
                            return score;
                        }

                        --score;
                        // E.
                        if (!S[0] && S[1] == S[2]) {
                            return score;
                        }
                    }

                    //--score;
                }
            }

            // F.
            return 0;
        }


        /// <summary>
        /// Looks up in the passed collection of supported AppLanguages the language that is best matched
        /// to this langtag. I.e. the written AppLanguage that a user understanding this langtag
        /// will most-likely understand.
        /// </summary>
        /// <param name="leftLanguageTag"></param>
        /// <param name="rightLanguageTags"></param>
        /// <param name="matchedTag"></param>
        /// <param name="matchLevel"></param>
        /// <returns>Selected CultureInfoEx instance from the AppLanguages collection or null if there was no match.</returns>
        public static int Match(LanguageTag leftLanguageTag, LanguageTag[] rightLanguageTags, out LanguageTag matchedTag, MatchLevel matchLevel = MatchLevel.LanguageMatch) {
            int matchedScore = 0;
            matchedTag = null;
            foreach (LanguageTag rightLanguageTag in rightLanguageTags) {
                int score = Match(leftLanguageTag, rightLanguageTag, matchLevel);
                if (score > matchedScore) {
                    matchedScore = score;
                    matchedTag = rightLanguageTag;
                    if (matchedScore == 100) {
                        // Can't beat an exact match.
                        break;
                    }
                }
            }

            return matchedScore;
        }
    }
}