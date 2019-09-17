using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Interface for TranslateResource
    /// </summary>
    public interface ITranslateResource
    {
        /// <summary>
        /// Binding to language tag
        /// </summary>
        LanguageTag Binding { get; }

        /// <summary>
        /// Translate resource's name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Can translate
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <returns></returns>
        bool CanTranslate(string resourceKey);

        /// <summary>
        /// Translate...
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <returns></returns>
        string Translate(string resourceKey);
    }
}