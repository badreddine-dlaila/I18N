using System;
using System.Collections.Generic;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Translation processor
    /// </summary>
    public class TranslationProcessor
    {
        private readonly Dictionary<int, ITranslatePackage> _translatePackages;

        /// <summary>
        /// Create a new instance of <see cref="TranslationProcessor"/>
        /// </summary>
        /// <param name="dictionary"></param>
        public TranslationProcessor(Dictionary<int, ITranslatePackage> dictionary)
        {
            _translatePackages = dictionary ?? throw new ArgumentNullException(nameof(dictionary));
        }

        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public virtual string Translate(string packageKey, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback)
        {
            return Translate(LanguageTag.Current, packageKey, resourceKey, strategy);
        }

        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="packageKey"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public virtual string Translate(string languageTag, string packageKey, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback)
        {
            return LanguageTagManager.TryGet(languageTag, out var languageTagInstance)
                ? Translate(languageTagInstance, packageKey, resourceKey, strategy)
                : string.Empty;
        }

        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="packageKey"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public virtual string Translate(LanguageTag languageTag, string packageKey, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback)
        {
            return _translatePackages.TryGetValue(packageKey.GetHashCode(), out var package)
                ? package.TryGetTranslateValue(languageTag, resourceKey, out var translateValue, strategy)
                    ? translateValue
                    : string.Empty
                : string.Empty;
        }
    }
}