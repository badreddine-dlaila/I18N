using System;
using Cosmos.I18N.Templates;
using Volo.Abp.Localization.Json;

namespace Cosmos.Bridges.AbpBridge.I18N {
    /// <summary>
    /// Extensions for AbpFx JsonLocalizationFile
    /// </summary>
    public static class JsonLocalizationFileExtensions {
        /// <summary>
        /// Make AbpFx Json Localization file speak in Cosmos.I18N way.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ILocalizationTemplate SpeakInCosmos(this JsonLocalizationFile file) {
            if (file == null)
                throw new ArgumentNullException(nameof(file));

            return new AnonymousLocalizationTemplate(file.Culture, file.Texts.DeepCopy());
        }

        /// <summary>
        /// Make AbpFx Json Localization file speak in Cosmos.I18N way.
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ILocalizationTemplate SpeakInCosmos(this AbpFormatResource resource) {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            return new AnonymousLocalizationTemplate(resource.Culture, resource.Texts);

        }
    }
}