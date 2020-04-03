namespace Cosmos.I18N.Core {
    /// <summary>
    /// Interface for getting scoped language tag
    /// </summary>
    public interface ICoreScopedLanguageTagFactory {
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        string Get(string antPosName = null);
    }
}