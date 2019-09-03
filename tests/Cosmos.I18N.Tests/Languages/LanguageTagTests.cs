using System;
using Cosmos.I18N.Languages;
using Xunit;

namespace Cosmos.I18N.Tests.Languages
{
    public class LanguageTagTests
    {
        [Fact]
        public void MatchTest()
        {
            // Test language tag matching and priority score

            // 100 (A)
            MatchTagHelper(100, "zh-Hans-HK", "zh-Hans-HK");
            MatchTagHelper(100, "zh-Hans", "zh-Hans");
            MatchTagHelper(100, "zh-HK", "zh-HK");
            MatchTagHelper(100, "zh", "zh");

            // 99 (B)
            MatchTagHelper(99, "zh", "zh-HK");
            MatchTagHelper(99, "zh-Hans", "zh-Hans-HK");

            // 98 (C)
            MatchTagHelper(98, "zh-IK", "zh-HK");
            MatchTagHelper(98, "zh-Hans-IK", "zh-Hans-HK");

            // 97 (D)
            MatchTagHelper(97, "zh-HK", "zh-Hant-HK");
            MatchTagHelper(97, "zh-HK", "zh-Hant-IK");
            MatchTagHelper(97, "zh", "zh-Hant");
            MatchTagHelper(97, "zh-HK", "zh-Hant");
            MatchTagHelper(97, "zh", "zh-Hant-HK");

            // 96 (E)
            MatchTagHelper(96, "zh-Hans-HK", "zh-Hant-HK");
            MatchTagHelper(96, "zh-Hans-HK", "zh-Hant-IK");
            MatchTagHelper(96, "zh-Hans", "zh-Hant");
            MatchTagHelper(96, "zh-Hans-HK", "zh-Hant");
            MatchTagHelper(96, "zh-Hans", "zh-Hant-HK");

            // 0 (F)
            MatchTagHelper(0, "en-Hans-HK", "zh-Hans-HK");
            MatchTagHelper(0, "en-Hans", "zh-Hans");
            MatchTagHelper(0, "en-HK", "zh-HK");
            MatchTagHelper(0, "en", "zh");
            MatchTagHelper(0, "en", "zh-HK");
            MatchTagHelper(0, "en-Hans", "zh-Hans-HK");
            MatchTagHelper(0, "en-IK", "zh-HK");
            MatchTagHelper(0, "en-Hans-IK", "zh-Hans-HK");
            MatchTagHelper(0, "en-HK", "zh-Hant-HK");
            MatchTagHelper(0, "en-HK", "zh-Hant-IK");
            MatchTagHelper(0, "en", "zh-Hant");
            MatchTagHelper(0, "en-HK", "zh-Hant");
            MatchTagHelper(0, "en", "zh-Hant-HK");
            MatchTagHelper(0, "en-Hans-HK", "zh-Hant-HK");
            MatchTagHelper(0, "en-Hans-HK", "zh-Hant-IK");
            MatchTagHelper(0, "en-Hans", "zh-Hant");
            MatchTagHelper(0, "en-Hans-HK", "zh-Hant");
            // 

            // 0 (G)
            MatchTagHelper(0, "zh", "zh-x-efgh");
            MatchTagHelper(0, "zh-HK", "zh-HK-x-efgh");
            MatchTagHelper(0, "zh-Hans-HK", "zh-Hans-HK-x-efgh");
            MatchTagHelper(0, "zh-x-abcd", "zh-x-efgh");
            MatchTagHelper(0, "zh-HK-x-abcd", "zh-HK-x-efgh");
            MatchTagHelper(0, "zh-Hans-HK-x-abcd", "zh-Hans-HK-x-efgh");
            // PrivateUse subtag mismatch, but other tags match.
            MatchTagHelper(0, "zh-x-abcd", "zh-x-efgh");
            MatchTagHelper(0, "zh-IK-x-abcd", "zh-x-efgh");
            MatchTagHelper(0, "zh-Hans-x-abcd", "zh-x-efgh");
            MatchTagHelper(0, "zh-Hans-HK-x-abcd", "zh-x-efgh");
            MatchTagHelper(0, "zh-x-abcd", "zh-HK-x-efgh");
            MatchTagHelper(0, "zh-IK-x-abcd", "zh-HK-x-efgh");
            MatchTagHelper(0, "zh-Hans-x-abcd", "zh-HK-x-efgh");
            MatchTagHelper(0, "zh-Hans-HK-x-abcd", "zh-HK-x-efgh");
            MatchTagHelper(0, "zh-x-abcd", "zh-Hant-x-efgh");
            MatchTagHelper(0, "zh-IK-x-abcd", "zh-Hant-x-efgh");
            MatchTagHelper(0, "zh-Hans-x-abcd", "zh-Hant-x-efgh");
            MatchTagHelper(0, "zh-Hans-HK-x-abcd", "zh-Hant-x-efgh");
            // Mismatch in PrivateUse and other subtags.
        }

        private void MatchTagHelper1(
            int expected,
            string lhs,
            string rhs,
            MatchLevel matchLevel = MatchLevel.LanguageMatch)
        {
            Assert.Equal(expected, (LanguageTagManager.Create(lhs).Match(LanguageTagManager.Create(rhs), matchLevel)));
            Assert.Equal(expected, (LanguageTagManager.Create(rhs).Match(LanguageTagManager.Create(lhs), matchLevel)));
        }

        private void MatchTagHelper(
            int expected,
            string lhs,
            string rhs,
            MatchLevel matchLevel = MatchLevel.LanguageMatch)
        {
            MatchTagHelper1(expected, lhs, rhs, matchLevel);
            // If PrivateUse subtag not present in either tag...append such a subtag equally to both sides
            // and test again. This should have no effect on the result.
            if (-1 == lhs.IndexOf("-x-", StringComparison.OrdinalIgnoreCase) && -1 == rhs.IndexOf("-x-", StringComparison.OrdinalIgnoreCase))
            {
                MatchTagHelper1(expected, lhs + "-x-abcd", rhs + "-x-abcd", matchLevel);
            }
        }
    }
}