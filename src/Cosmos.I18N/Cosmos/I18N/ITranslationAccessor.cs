namespace Cosmos.I18N {
    /// <summary>
    /// Interface for translation accessor  ITranslationAccessor
    /// </summary>
    public interface ITranslationAccessor {
        /// <summary>
        /// Gets Text provider
        /// </summary>
        ITextProvider Text { get; }

        /// <summary>
        /// Gets language service provider
        /// </summary>
        ILanguageServiceProvider ServiceProvider { get; }

        /// <summary>
        /// Gets current language tag
        /// </summary>
        string CurrentLanguageTag { get; }
    }
}