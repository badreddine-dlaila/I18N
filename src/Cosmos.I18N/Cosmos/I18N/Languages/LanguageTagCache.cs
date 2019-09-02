using System.Collections.Generic;

namespace Cosmos.I18N.Languages
{
    /// <summary>
    /// LanguageTag Cache manager
    /// </summary>
    internal static class LanguageTagCache
    {
        // ReSharper disable once InconsistentNaming
        private static readonly Dictionary<int, ILanguageTag> _languageTags = new Dictionary<int, ILanguageTag>();

        // ReSharper disable once InconsistentNaming
        private static readonly object _lockObj = new object();

        public static bool Contains(string languageTag)
        {
            if (languageTag.IsNullOrWhiteSpace())
                return false;
            return _languageTags.ContainsKey(languageTag.GetHashCode());
        }

        public static bool Contains(int hashOfLanguageTag)
        {
            return _languageTags.ContainsKey(hashOfLanguageTag);
        }

        public static bool TryGet(string languageTag, out ILanguageTag result)
        {
            result = null;
            if (Contains(languageTag))
                return _languageTags.TryGetValue(languageTag.GetHashCode(), out result);
            return false;
        }

        public static ILanguageTag Get(string languageTag)
        {
            if (TryGet(languageTag, out var result))
                return result;
            return null;
        }

        public static TLanguageTag Get<TLanguageTag>(string languageTag) where TLanguageTag : class, ILanguageTag
        {
            return Get(languageTag) as TLanguageTag;
        }

        public static void Add(string languageTag, ILanguageTag languageTagInstance)
        {
            if (languageTag.IsNullOrWhiteSpace())
                return;

            if (languageTagInstance == null)
                return;

            var hashOfLanguageTag = languageTag.GetHashCode();

            if (Contains(hashOfLanguageTag))
                return;

            lock (_lockObj)
            {
                if (Contains(hashOfLanguageTag))
                    return;

                _languageTags.Add(hashOfLanguageTag, languageTagInstance);
            }
        }

        public static void Remove(string languageTag)
        {
            if (languageTag.IsNullOrWhiteSpace())
                return;

            var hashOfLanguageTag = languageTag.GetHashCode();

            if (!Contains(hashOfLanguageTag))
                return;

            lock (_lockObj)
            {
                _languageTags.Remove(hashOfLanguageTag);
            }
        }
    }
}