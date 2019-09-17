using System;
using System.Linq;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Translate resource factory
    /// </summary>
    public static class TranslateResourceFactory
    {
        /// <summary>
        /// Create translate resource
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public static ITranslateResource Create(StandardLocalizationTemplate template) => Create<StandardLocalizationTemplate>(template);

        /// <summary>
        /// Create translate resource
        /// </summary>
        /// <param name="template"></param>
        /// <typeparam name="TTemplate"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITranslateResource Create<TTemplate>(TTemplate template) where TTemplate : StandardLocalizationTemplate, ILocalizationTemplate, new()
        {
            if (template == null)
                throw new ArgumentNullException(nameof(template));

            if (string.IsNullOrWhiteSpace(template.Name))
                throw new ArgumentNullException(nameof(template.Name));

            var languageTag = LanguageTagManager.Create(template.Language);

            if (languageTag == null)
                throw new ArgumentException($"Cannot resolve an instance of LanguageTag by '{template.Language}'.");

            return new TranslateResource(languageTag, template.Name, template.Contents.ToDictionary(k => k.Key.GetHashCode(), v => v.Value));
        }
    }
}