using System;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Static instance for language service provider
    /// </summary>
    public static class StaticInstanceForILanguageServiceProvider
    {
        /// <summary>
        /// Instance
        /// </summary>
        // ReSharper disable once InconsistentNaming
        private static ILanguageServiceProvider _instance { get; set; }

        /// <summary>
        /// Sets instance
        /// </summary>
        /// <param name="languageServiceProvider"></param>
        public static void SetInstance(ILanguageServiceProvider languageServiceProvider)
        {
            _instance = languageServiceProvider ?? throw new ArgumentNullException(nameof(languageServiceProvider));
        }

        /// <summary>
        /// Gets instance
        /// </summary>
        public static ILanguageServiceProvider Instance => _instance;
    }
}