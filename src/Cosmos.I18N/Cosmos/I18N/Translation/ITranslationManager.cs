using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Translation manager
    /// </summary>
    public interface ITranslationManager
    {

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="packageKey"></param>
        /// <returns></returns>
        bool Contains(string packageKey);

        /// <summary>
        /// To get current language tag
        /// </summary>
        LanguageTag CurrentLanguageTag { get; }

        /// <summary>
        /// Get translation package
        /// </summary>
        /// <param name="packageKey"></param>
        /// <returns></returns>
        ITranslatePackage GetPackage(string packageKey);

        /// <summary>
        /// Get anonymous translation package
        /// </summary>
        /// <returns></returns>
        ITranslatePackage GetAnonymousPackage();

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        ITranslateResource GetResource(string packageKey, string languageTag);

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        ITranslateResource GetResource(string packageKey, LanguageTag languageTag);

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        ITranslateResource GetAnonymousResource(string languageTag);

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        ITranslateResource GetAnonymousResource(LanguageTag languageTag);
    }
}