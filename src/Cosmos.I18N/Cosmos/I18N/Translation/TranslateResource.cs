using System;
using System.Collections.Generic;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Translate reource
    /// </summary>
    public class TranslateResource : ITranslateResource
    {
        private readonly LanguageTag _languageTag;

        private readonly Dictionary<int, string> _l;

        // ReSharper disable once InconsistentNaming
        private readonly object _l_lock = new object();

        /// <summary>
        /// Create a new instance of <see cref="TranslateResource"/>
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceName"></param>
        public TranslateResource(LanguageTag languageTag, string resourceName)
            : this(languageTag, resourceName, new Dictionary<int, string>()) { }

        /// <summary>
        /// Create a new instance of <see cref="TranslateResource"/>
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceName"></param>
        /// <param name="dictionary"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public TranslateResource(LanguageTag languageTag, string resourceName, Dictionary<int, string> dictionary)
        {
            if (resourceName.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(resourceName));

            _languageTag = languageTag ?? throw new ArgumentNullException(nameof(languageTag));
            _l = dictionary ?? throw new ArgumentNullException(nameof(dictionary));
            Name = resourceName;
        }

        /// <summary>
        /// Binding to language tag
        /// </summary>
        public LanguageTag Binding => _languageTag;

        /// <summary>
        /// Translate resource's name
        /// </summary>
        public string Name { get; }

        #region Internal Dictionary Opts

        /// <summary>
        /// Add...
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <param name="resourceTargetValue"></param>
        protected internal void Add(string resourceKey, string resourceTargetValue)
        {
            if (string.IsNullOrWhiteSpace(resourceKey))
                return;

            lock (_l_lock)
            {
                var k = Key(resourceKey);

                if (_l.ContainsKey(k))
                    _l[k] = resourceTargetValue;
                else
                    _l.Add(k, resourceTargetValue);
            }
        }

        /// <summary>
        /// Remove...
        /// </summary>
        /// <param name="resourceKey"></param>
        protected internal void Remove(string resourceKey)
        {
            lock (_l_lock)
            {
                var k = Key(resourceKey);

                if (_l.ContainsKey(k))
                    _l.Remove(k);
            }
        }

        #endregion

        #region Translate

        /// <summary>
        /// Can translate
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <returns></returns>
        // ReSharper disable once InconsistentlySynchronizedField
        public bool CanTranslate(string resourceKey) => _l.ContainsKey(Key(resourceKey));

        /// <summary>
        /// Translation...
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <returns></returns>
        // ReSharper disable once InconsistentlySynchronizedField
        public string Translate(string resourceKey) => _l.TryGetValue(Key(resourceKey), out var resourceTargetValue) ? resourceTargetValue : string.Empty;

        #endregion

        #region Private static methods

        private static int Key(string resourceKey) => string.IsNullOrWhiteSpace(resourceKey) ? 0 : resourceKey.GetHashCode();

        #endregion

    }
}