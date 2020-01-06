namespace Cosmos.I18N.Languages {
    /// <summary>
    /// Manager for LanguageTag
    /// </summary>
    public static class LanguageTagManager {
        /// <summary>
        /// Create a new instance of <see cref="LanguageTag"/>
        /// </summary>
        /// <param name="langTag"></param>
        /// <returns></returns>
        public static LanguageTag Create(string langTag) {
            if (string.IsNullOrWhiteSpace(langTag))
                return default;

            if (LanguageTagCache.Contains(langTag))
                return LanguageTagCache.Get<LanguageTag>(langTag);

            var instance = LanguageTagCreator.Create(langTag);

            LanguageTagCache.Add(langTag, instance);

            return instance;
        }

        /// <summary>
        /// Create a new instance of <see cref="LanguageTag"/>
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        public static LanguageTag Create(Locale locale) {
            return Create(locale.GetLanguageTagText());
        }

        /// <summary>
        /// Get an instance of LanguageTag
        /// </summary>
        /// <param name="langTag"></param>
        /// <returns></returns>
        public static LanguageTag Get(string langTag) {
            return TryGet(langTag, out var result) ? result : default;
        }

        /// <summary>
        /// Get an instance of LanguageTag
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        public static LanguageTag Get(Locale locale) {
            return TryGet(locale, out var result) ? result : default;
        }

        /// <summary>
        /// Try get an instance of LanguageTag
        /// </summary>
        /// <param name="langTag"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryGet(string langTag, out LanguageTag result) {
            result = default;

            if (string.IsNullOrWhiteSpace(langTag))
                return false;

            if (!LanguageTagCache.Contains(langTag))
                return false;

            result = LanguageTagCache.Get<LanguageTag>(langTag);
            return true;
        }

        /// <summary>
        /// Try get an instance of LanguageTag
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryGet(Locale locale, out LanguageTag result) {
            return TryGet(locale.GetLanguageTagText(), out result);
        }
    }
}