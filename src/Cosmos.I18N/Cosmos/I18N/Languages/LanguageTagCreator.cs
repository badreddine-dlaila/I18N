using System;

namespace Cosmos.I18N.Languages
{
    internal static class LanguageTagCreator
    {
        public static LanguageTag Create(string langTag)
        {
            if (langTag.IsNullOrWhiteSpace())
                return default;

            if (LanguageTagCache.Contains(langTag))
                return LanguageTagCache.Get<LanguageTag>(langTag);

            var originalLanguageTag = ToNormalizeLangTags(langTag.Trim());
            var matchedResults = Core.LanguageTagParseRegexUtils.MatchLanguageTag(originalLanguageTag);
            if (matchedResults.Success && matchedResults.Groups.Count == 5)
            {
                var language = matchedResults.Groups[1].Value;
                var script = matchedResults.Groups[2].Value;
                var region = matchedResults.Groups[3].Value;
                var privateUse = matchedResults.Groups[4].Value;

                var builder = new LanguageTagBuilder(originalLanguageTag, language, script, region, privateUse);

                return builder.Build();
            }
            else
            {
                throw new ArgumentException($"Resolve language tag '{langTag}' failed.");
            }
        }

        #region Private static methods for normalize language tags

        private static readonly string[,] _normalizeLangTags =
        {
            {"zh-CN", "zh-Hans"},
            {"zh-TW", "zh-Hant"}
        };

        private static string ToNormalizeLangTags(string langTag)
        {
            for (var i = 0; i < _normalizeLangTags.GetLength(0); ++i)
            {
                if (0 == string.Compare(langTag, _normalizeLangTags[i, 0], StringComparison.OrdinalIgnoreCase))
                {
                    langTag = _normalizeLangTags[i, 1];
                    break;
                }
            }

            return langTag;
        }

        #endregion
        
    }
}