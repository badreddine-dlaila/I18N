using System.Collections.Concurrent;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Handlebars.Core {
    internal static class LanguageTagCheckingCache {
        private static readonly ConcurrentDictionary<int, bool> _cachedResult;

        static LanguageTagCheckingCache() {
            _cachedResult = new ConcurrentDictionary<int, bool>();
        }

        public static bool IsValid(string languageTag) {
            if (string.IsNullOrWhiteSpace(languageTag))
                return false;

            var hash = languageTag.GetHashCode();

            if (_cachedResult.TryGetValue(hash, out var result))
                return result;

            result = LanguageTagChecker.IsValid(languageTag);
            if (_cachedResult.TryAdd(hash, result))
                return result;
            return false;
        }
    }
}