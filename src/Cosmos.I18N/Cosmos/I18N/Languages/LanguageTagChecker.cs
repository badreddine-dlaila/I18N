namespace Cosmos.I18N.Languages {
    /// <summary>
    /// Language tag checker
    /// </summary>
    public static class LanguageTagChecker {
        /// <summary>
        /// Is valid
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public static bool IsValid(string languageTag) {
            try {
                var tag = LanguageTagCreator.Create(languageTag);
                return tag != null && tag.IsValid();
            } catch {
                return false;
            }
        }
    }
}