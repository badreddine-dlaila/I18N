using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N
{
    /// <summary>
    /// Interface for Language service provider
    /// </summary>
    public interface ILanguageServiceProvider
    {
        /// <summary>
        /// Get anonymous translation package
        /// </summary>
        /// <returns></returns>
        ITranslatePackage GetTranslationPackage();
        
        /// <summary>
        /// Get translation package
        /// </summary>
        /// <param name="packageKey"></param>
        /// <returns></returns>
        ITranslatePackage GetTranslationPackage(string packageKey);

        /// <summary>
        /// Get translation manager
        /// </summary>
        /// <returns></returns>
        ITranslationManager GetTranslationManager();

        /// <summary>
        /// Get translation processor
        /// </summary>
        /// <returns></returns>
        TranslationProcessor GetTranslationProcessor();
    }
}