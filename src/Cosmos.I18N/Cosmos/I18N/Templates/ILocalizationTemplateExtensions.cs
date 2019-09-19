using System;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Templates
{
    /// <summary>
    /// Extensions for Localization Template
    /// </summary>
    public static class LocalizationTemplateExtensions
    {
        /// <summary>
        /// Is such template an anonymous template
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool IsAnonymousTemplate(this ILocalizationTemplate template)
        {
            if (template == null)
                throw new ArgumentNullException(nameof(template));

            if (string.IsNullOrWhiteSpace(template.PackageKey) && string.IsNullOrWhiteSpace(template.Name))
                return true;

            if (template.PackageKey == TranslationManager.ANONYMOUS_PACKAGE_KEY &&
                template.Name == TranslationManager.ANONYMOUS_RESOURCE_NAME)
                return true;

            return false;
        }
    }
}