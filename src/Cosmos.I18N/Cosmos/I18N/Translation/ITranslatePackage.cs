using System.Collections.Generic;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation {
    /// <summary>
    /// Interface for Translate Package
    /// </summary>
    public interface ITranslatePackage {
        /// <summary>
        /// Gets package key
        /// </summary>
        string PackageKey { get; }

        /// <summary>
        /// Gets all used language tags
        /// </summary>
        IReadOnlyList<LanguageTag> AllUsedLanguageTags { get; }

        /// <summary>
        /// Add resource
        /// </summary>
        /// <param name="resource"></param>
        void AddResource(ITranslateResource resource);

        /// <summary>
        /// Add resources
        /// </summary>
        /// <param name="resources"></param>
        void AddResources(IEnumerable<ITranslateResource> resources);

        /// <summary>
        /// Get resource by given language tag
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        ITranslateResource GetResource(string languageTag);

        /// <summary>
        /// Get resource by given language tag
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        ITranslateResource GetResource(LanguageTag languageTag);

        /// <summary>
        /// Can translate
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        bool CanTranslate(string languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback);

        /// <summary>
        /// Can translate
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        bool CanTranslate(LanguageTag languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback);

        /// <summary>
        /// Get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        string GetTranslateValue(string languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback);

        /// <summary>
        /// Get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        string GetTranslateValue(LanguageTag languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback);

        /// <summary>
        /// Try get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="translateValue"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        bool TryGetTranslateValue(string languageTag, string resourceKey, out string translateValue, AttemptStrategy strategy = AttemptStrategy.Fallback);

        /// <summary>
        /// Try get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="translateValue"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        bool TryGetTranslateValue(LanguageTag languageTag, string resourceKey, out string translateValue, AttemptStrategy strategy = AttemptStrategy.Fallback);

        /// <summary>
        /// To flag anonymous or not.
        /// </summary>
        bool IsAnonymous { get; }
    }
}