namespace Cosmos.I18N.Languages
{
    /// <summary>
    /// Manager for LanguageTag
    /// </summary>
    public static class LanguageTagManager
    {
        /// <summary>
        /// Create a new instance of <see cref="LanguageTag"/>
        /// </summary>
        /// <param name="langTag"></param>
        /// <returns></returns>
        public static LanguageTag Create(string langTag)
        {
            if (string.IsNullOrWhiteSpace(langTag))
                return default;

            if (LanguageTagCache.Contains(langTag))
                return LanguageTagCache.Get<LanguageTag>(langTag);

            var instance = LanguageTagCreator.Create(langTag);

            LanguageTagCache.Add(langTag, instance);

            return instance;
        }
    }
}