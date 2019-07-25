using System;
using System.Collections.Generic;
using System.Globalization;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Translation processor
    /// </summary>
    public class TranslationProcessor
    {
        private readonly Dictionary<Locale, ILanguagePackage> _languagePackages;

        /// <summary>
        /// Create a new instance of <see cref="TranslationProcessor"/>
        /// </summary>
        /// <param name="dictionary"></param>
        public TranslationProcessor(Dictionary<Locale, ILanguagePackage> dictionary)
        {
            _languagePackages = dictionary ?? throw new ArgumentNullException(nameof(dictionary));
        }

        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <param name="originText"></param>
        /// <returns></returns>
        public virtual string Translate(string resourceKey, string originText)
        {
            var cluture = CultureInfo.CurrentCulture;
            return Translate(cluture.Name, resourceKey, originText);
        }

        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="langName"></param>
        /// <param name="resourceKey"></param>
        /// <param name="originText"></param>
        /// <returns></returns>
        public virtual string Translate(string langName, string resourceKey, string originText)
        {
            return Translate(langName.ToLocale(), resourceKey, originText);
        }

        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="language"></param>
        /// <param name="resourceKey"></param>
        /// <param name="originText"></param>
        /// <returns></returns>
        public virtual string Translate(Locale language, string resourceKey, string originText)
        {
            // ReSharper disable once InconsistentNaming
            return _languagePackages.TryGetValue(language, out var __pkg) ? __pkg.Translate(resourceKey, originText) : string.Empty;
        }
    }
}