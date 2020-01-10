namespace Cosmos.I18N {
    /// <summary>
    /// Interface for current request language tag accessor
    /// </summary>
    public interface IRequestedLanguageTagAccessor {
        /// <summary>
        /// Get language tag from current request.
        /// </summary>
        /// <returns></returns>
        string Get();

        /// <summary>
        /// Has HttpContext
        /// </summary>
        bool HasContext { get; }
    }
}