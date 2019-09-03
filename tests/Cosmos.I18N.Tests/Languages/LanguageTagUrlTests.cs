using System;
using Xunit;

namespace Cosmos.I18N.Tests.Languages
{
    public class LanguageTagUrlTests
    {
        [Fact]
        public void GetLangTagFromHrlTest()
        {
            ExtractLangTagFromUrlHelper("/zh", "zh", "/");
            ExtractLangTagFromUrlHelper("/zh-HK", "zh-HK", "/");
            ExtractLangTagFromUrlHelper("/zh-123", "zh-123", "/");
            ExtractLangTagFromUrlHelper("/zh-Hans", "zh-Hans", "/");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK", "zh-Hans-HK", "/");
            ExtractLangTagFromUrlHelper("/zh-Hans-123", "zh-Hans-123", "/");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD", "zh-Hans-123-x-ABCD", "/");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123", "zh-Hans-123-x-ABCDEFG123", "/");

            // #383
            ExtractLangTagFromUrlHelper("/zh?", "zh", "/?");
            ExtractLangTagFromUrlHelper("/zh?qs", "zh", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-HK?qs", "zh-HK", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-123?qs", "zh-123", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans?qs", "zh-Hans", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK?qs", "zh-Hans-HK", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123?qs", "zh-Hans-123", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD?qs", "zh-Hans-123-x-ABCD", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123?qs", "zh-Hans-123-x-ABCDEFG123", "/?qs");

            ExtractLangTagFromUrlHelper("/zh#", "zh", "/#");
            ExtractLangTagFromUrlHelper("/zh#bm", "zh", "/#bm");
            ExtractLangTagFromUrlHelper("/zh-HK#bm", "zh-HK", "/#bm");
            ExtractLangTagFromUrlHelper("/zh-123#bm", "zh-123", "/#bm");
            ExtractLangTagFromUrlHelper("/zh-Hans#bm", "zh-Hans", "/#bm");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK#bm", "zh-Hans-HK", "/#bm");
            ExtractLangTagFromUrlHelper("/zh-Hans-123#bm", "zh-Hans-123", "/#bm");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD#bm", "zh-Hans-123-x-ABCD", "/#bm");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123#bm", "zh-Hans-123-x-ABCDEFG123", "/#bm");

            ExtractLangTagFromUrlHelper("/zh/?qs", "zh", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-HK/?qs", "zh-HK", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-123/?qs", "zh-123", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans/?qs", "zh-Hans", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK/?qs", "zh-Hans-HK", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123/?qs", "zh-Hans-123", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD/?qs", "zh-Hans-123-x-ABCD", "/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123/?qs", "zh-Hans-123-x-ABCDEFG123", "/?qs");

            ExtractLangTagFromUrlHelper("/zh/account", "zh", "/account");
            ExtractLangTagFromUrlHelper("/zh-HK/account", "zh-HK", "/account");
            ExtractLangTagFromUrlHelper("/zh-123/account", "zh-123", "/account");
            ExtractLangTagFromUrlHelper("/zh-Hans/account", "zh-Hans", "/account");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK/account", "zh-Hans-HK", "/account");
            ExtractLangTagFromUrlHelper("/zh-Hans-123/account", "zh-Hans-123", "/account");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD/account", "zh-Hans-123-x-ABCD", "/account");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123/account", "zh-Hans-123-x-ABCDEFG123", "/account");

            ExtractLangTagFromUrlHelper("/zh/account?qs", "zh", "/account?qs");
            ExtractLangTagFromUrlHelper("/zh-HK/account?qs", "zh-HK", "/account?qs");
            ExtractLangTagFromUrlHelper("/zh-123/account?qs", "zh-123", "/account?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans/account?qs", "zh-Hans", "/account?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK/account?qs", "zh-Hans-HK", "/account?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123/account?qs", "zh-Hans-123", "/account?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD/account?qs", "zh-Hans-123-x-ABCD", "/account?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123/account?qs", "zh-Hans-123-x-ABCDEFG123", "/account?qs");

            ExtractLangTagFromUrlHelper("/zh/account/", "zh", "/account/");
            ExtractLangTagFromUrlHelper("/zh-HK/account/", "zh-HK", "/account/");
            ExtractLangTagFromUrlHelper("/zh-123/account/", "zh-123", "/account/");
            ExtractLangTagFromUrlHelper("/zh-Hans/account/", "zh-Hans", "/account/");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK/account/", "zh-Hans-HK", "/account/");
            ExtractLangTagFromUrlHelper("/zh-Hans-123/account/", "zh-Hans-123", "/account/");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD/account/", "zh-Hans-123-x-ABCD", "/account/");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123/account/", "zh-Hans-123-x-ABCDEFG123", "/account/");

            ExtractLangTagFromUrlHelper("/zh/account/?qs", "zh", "/account/?qs");
            ExtractLangTagFromUrlHelper("/zh-HK/account/?qs", "zh-HK", "/account/?qs");
            ExtractLangTagFromUrlHelper("/zh-123/account/?qs", "zh-123", "/account/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans/account/?qs", "zh-Hans", "/account/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK/account/?qs", "zh-Hans-HK", "/account/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123/account/?qs", "zh-Hans-123", "/account/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD/account/?qs", "zh-Hans-123-x-ABCD", "/account/?qs");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123/account/?qs", "zh-Hans-123-x-ABCDEFG123", "/account/?qs");

            ExtractLangTagFromUrlHelper("/zh/account/x", "zh", "/account/x");
            ExtractLangTagFromUrlHelper("/zh-HK/account/x", "zh-HK", "/account/x");
            ExtractLangTagFromUrlHelper("/zh-123/account/x", "zh-123", "/account/x");
            ExtractLangTagFromUrlHelper("/zh-Hans/account/x", "zh-Hans", "/account/x");
            ExtractLangTagFromUrlHelper("/zh-Hans-HK/account/x", "zh-Hans-HK", "/account/x");
            ExtractLangTagFromUrlHelper("/zh-Hans-123/account/x", "zh-Hans-123", "/account/x");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCD/account/x", "zh-Hans-123-x-ABCD", "/account/x");
            ExtractLangTagFromUrlHelper("/zh-Hans-123-x-ABCDEFG123/account/x", "zh-Hans-123-x-ABCDEFG123", "/account/x");

            ExtractLangTagFromUrlHelper("/azh", "azh", "/");
            ExtractLangTagFromUrlHelper("/azh-HK", "azh-HK", "/");
            ExtractLangTagFromUrlHelper("/azh-123", "azh-123", "/");
            ExtractLangTagFromUrlHelper("/azh-Hans", "azh-Hans", "/");
            ExtractLangTagFromUrlHelper("/azh-Hans-HK", "azh-Hans-HK", "/");
            ExtractLangTagFromUrlHelper("/azh-Hans-123", "azh-Hans-123", "/");
            ExtractLangTagFromUrlHelper("/azh-Hans-123-x-ABCD", "azh-Hans-123-x-ABCD", "/");
            ExtractLangTagFromUrlHelper("/azh-Hans-123-x-ABCDEFG123", "azh-Hans-123-x-ABCDEFG123", "/");


            ExtractLangTagFromUrlHelper("/zh-a", null); // 1-char Script/Region subtag = bad
            ExtractLangTagFromUrlHelper("/zh-aHK", null); // 3-char Script/Region subtag = bad
            ExtractLangTagFromUrlHelper("/zh-a123", null); // 4-char Script/Region subtag = bad
            ExtractLangTagFromUrlHelper("/zh-aaHans", null); // 6-char Script/Region subtag = bad
            ExtractLangTagFromUrlHelper("/zh-aaHans-HK", null); // 6-char Script subtag = bad
            ExtractLangTagFromUrlHelper("/zh-aaHans-123", null); // 6-char Script subtag = bad
            ExtractLangTagFromUrlHelper("/zh-aaHans-123-x-ABCD", null); // 6-char Script subtag = bad
            ExtractLangTagFromUrlHelper("/zh-aaHans-HK-x-ABCDEFG123", null); // 6-char Script subtag = bad
            ExtractLangTagFromUrlHelper("/zh-Hans-HK-x-ABC", null); // < 4-char Private use subtag = bad
            ExtractLangTagFromUrlHelper("/zh-Hans-HK-x-", null); // < 4-char Private use subtag = bad
            ExtractLangTagFromUrlHelper("/zh-Hans-HK-x", null); // < 4-char Private use subtag = bad
            ExtractLangTagFromUrlHelper("/zh-Hans-HK-ABC", null); // Invalid subtag
            ExtractLangTagFromUrlHelper("/zh-Hans-HK-", null); // Invalid subtag

            ExtractLangTagFromUrlHelper("/zh-Hans-K", null); // Invalid Region
            ExtractLangTagFromUrlHelper("/zh-Hans-23", null);
            ExtractLangTagFromUrlHelper("/zh-Hans-aHK", null);
            ExtractLangTagFromUrlHelper("/zh-Hans-a123", null);
            ExtractLangTagFromUrlHelper("/zh-Hans-H23", null);
            ExtractLangTagFromUrlHelper("/zh-Hans-12K", null);
            ExtractLangTagFromUrlHelper("/zh-Hans-12", null);
            ExtractLangTagFromUrlHelper("/zh-Hans-12-x-ABCD", null);
            ExtractLangTagFromUrlHelper("/zh-Hans-12-x-ABCDEFG123", null);
        }

        private void ExtractLangTagFromUrlHelper(string url, string expectedLangTag, string expectedUrlPatched)
        {
            string urlPatched;
            string langtag;

            langtag = I18N.Languages.LanguageTag.GetTagFromUrl(url, UriKind.Relative, out urlPatched);
            Assert.Equal(expectedLangTag, langtag);
            Assert.Equal(expectedUrlPatched, urlPatched);

            langtag = I18N.Languages.LanguageTag.GetTagFromUrl(url, UriKind.RelativeOrAbsolute, out urlPatched);
            Assert.Equal(expectedLangTag, langtag);
            Assert.Equal(expectedUrlPatched, urlPatched);
        }

        private void ExtractLangTagFromUrlHelper(string url, string expectedLangTag)
        {
            ExtractLangTagFromUrlHelper(url, expectedLangTag, url);
        }
    }
}