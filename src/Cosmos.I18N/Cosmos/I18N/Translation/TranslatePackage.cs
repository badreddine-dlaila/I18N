using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Extensions;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Default implementation of translate package
    /// </summary>
    public class TranslatePackage : ITranslatePackage
    {
        private readonly FallbackExperimenter _fallbackExperimenter;
        private readonly Dictionary<string, ITranslateResource> _langAndResourceMapCache;
        private readonly Dictionary<LanguageTag, ITranslateResource> _resources;
        private readonly List<LanguageTag> _usedLanguageTags;
        private readonly object _resourceMapLockObj = new object();
        private readonly object _resourceLockObj = new object();

        /// <summary>
        /// Create a new instance of <see cref="TranslatePackage"/>
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="fallbackExperimenter"></param>
        public TranslatePackage(string packageKey, FallbackExperimenter fallbackExperimenter)
        {
            if (packageKey.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(packageKey));

            _fallbackExperimenter = fallbackExperimenter;
            _resources = new Dictionary<LanguageTag, ITranslateResource>();
            _langAndResourceMapCache = new Dictionary<string, ITranslateResource>();
            _usedLanguageTags = new List<LanguageTag>();

            PackageKey = packageKey;
        }

        #region Get package info

        /// <summary>
        /// Gets package key
        /// </summary>
        public string PackageKey { get; }

        /// <summary>
        /// Gets all used language tags
        /// </summary>
        public IReadOnlyList<LanguageTag> AllUsedLanguageTags => _usedLanguageTags;

        #endregion

        #region Has Resource

        internal bool HasResource(ITranslateResource resource)
        {
            if (resource == null)
                return false;

            return HasResource(resource.Binding);
        }

        internal bool HasResource(string languageTag)
        {
            if (string.IsNullOrWhiteSpace(languageTag))
                return false;

            var languageTagInstance = LanguageTagManager.Get(languageTag);

            return HasResource(languageTagInstance);
        }

        internal bool HasResource(LanguageTag languageTag)
        {
            if (languageTag == null)
                return false;

            if (!_usedLanguageTags.Contains(languageTag))
                return false;

            return _resources.TryGetValue(languageTag, out _);
        }

        #endregion

        #region Add Resource

        /// <summary>
        /// Add resource
        /// </summary>
        /// <param name="resource"></param>
        public void AddResource(ITranslateResource resource)
        {
            if (resource == null)
                return;

            if (_resources.ContainsKey(resource.Binding))
                return;

            lock (_resourceLockObj)
            {
                if (_resources.ContainsKey(resource.Binding))
                    return;

                _resources.Add(resource.Binding, resource);
                _usedLanguageTags.Add(resource.Binding);
            }
        }

        /// <summary>
        /// Add resources
        /// </summary>
        /// <param name="resources"></param>
        public void AddResources(IEnumerable<ITranslateResource> resources)
        {
            if (resources == null)
                return;

            foreach (var resource in resources)
                AddResource(resource);
        }

        #endregion

        #region Get Resource

        /// <summary>
        /// Get resource by given language tag
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public ITranslateResource GetResource(string languageTag)
        {
            if (string.IsNullOrWhiteSpace(languageTag))
                return null;

            // ReSharper disable once InconsistentlySynchronizedField
            if (_langAndResourceMapCache.TryGetValue(languageTag, out var resource))
                return resource;

            var languageTagInstance = LanguageTagManager.Get(languageTag);

            if (languageTagInstance == null)
                throw new ArgumentException($"Cannot resolve an instance of LanguageTag by '{languageTag}'.");

            if (_resources.TryGetValue(languageTagInstance, out resource))
                return resource;

            var suitableTags = _fallbackExperimenter.GetSuitableTags(languageTagInstance).ToList();

            if (!suitableTags.Any())
                throw new ArgumentException($"Cannot resolve a suitable LanguageTag by '{languageTag}'.");

            var theMostSuitableTag = suitableTags.First();

            if (_resources.TryGetValue(theMostSuitableTag, out resource))
                return CacheAndReturn(languageTag, resource);

            throw new ArgumentException($"Cannot resolve the resource by the given LanguageTag '{languageTag}'");
        }

        /// <summary>
        /// Get resource by given language tag
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public ITranslateResource GetResource(LanguageTag languageTag)
        {
            if (languageTag == null)
                return default;

            if (_resources.TryGetValue(languageTag, out var resource))
                return resource;

            var suitableTags = _fallbackExperimenter.GetSuitableTags(languageTag).ToList();
            var originalLanguageTag = languageTag.GetOriginalLanguageTag();

            if (!suitableTags.Any())
                throw new ArgumentException($"Cannot resolve a suitable LanguageTag by '{originalLanguageTag}'.");

            var theMostSuitableTag = suitableTags.First();

            if (_resources.TryGetValue(theMostSuitableTag, out resource))
                return CacheAndReturn(originalLanguageTag, resource);

            throw new ArgumentException($"Cannot resolve the resource by the given LanguageTag '{originalLanguageTag}'");
        }

        private ITranslateResource CacheAndReturn(string languageTag, ITranslateResource resource)
        {
            lock (_resourceMapLockObj)
            {
                if (_langAndResourceMapCache.ContainsKey(languageTag))
                    _langAndResourceMapCache[languageTag] = resource;
                else
                    _langAndResourceMapCache.Add(languageTag, resource);
            }

            return resource;
        }

        #endregion

        #region Can Translation

        /// <summary>
        /// Can translate
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public bool CanTranslate(string languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback)
        {
            if (string.IsNullOrWhiteSpace(languageTag))
                return false;

            if (string.IsNullOrWhiteSpace(resourceKey))
                return false;

            if (!LanguageTagManager.TryGet(languageTag, out var languageTagInstance))
                return false;

            switch (strategy)
            {
                case AttemptStrategy.Fallback:
                    return TranslationChecker.FallbackMode(languageTagInstance, resourceKey, _resources, _fallbackExperimenter);

                case AttemptStrategy.Sequence:
                    return TranslationChecker.SequenceMode(languageTagInstance, resourceKey, _resources);

                case AttemptStrategy.Strict:
                    return TranslationChecker.StrictMode(languageTagInstance, resourceKey, _resources);

                default:
                    return TranslationChecker.FallbackMode(languageTagInstance, resourceKey, _resources, _fallbackExperimenter);
            }
        }

        /// <summary>
        /// Can translate
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public bool CanTranslate(LanguageTag languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback)
        {
            if (languageTag == null)
                return false;

            if (string.IsNullOrWhiteSpace(resourceKey))
                return false;

            switch (strategy)
            {
                case AttemptStrategy.Fallback:
                    return TranslationChecker.FallbackMode(languageTag, resourceKey, _resources, _fallbackExperimenter);

                case AttemptStrategy.Sequence:
                    return TranslationChecker.SequenceMode(languageTag, resourceKey, _resources);

                case AttemptStrategy.Strict:
                    return TranslationChecker.StrictMode(languageTag, resourceKey, _resources);

                default:
                    return TranslationChecker.FallbackMode(languageTag, resourceKey, _resources, _fallbackExperimenter);
            }
        }

        #endregion

        #region Get Translation

        /// <summary>
        /// Get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public string GetTranslateValue(string languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback)
            => TryGetTranslateValue(languageTag, resourceKey, out var result, strategy) ? result : string.Empty;

        /// <summary>
        /// Get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public string GetTranslateValue(LanguageTag languageTag, string resourceKey, AttemptStrategy strategy = AttemptStrategy.Fallback)
            => TryGetTranslateValue(languageTag, resourceKey, out var result, strategy) ? result : string.Empty;

        /// <summary>
        /// Try get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="translateValue"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public bool TryGetTranslateValue(string languageTag, string resourceKey, out string translateValue, AttemptStrategy strategy = AttemptStrategy.Fallback)
        {
            translateValue = string.Empty;

            if (string.IsNullOrWhiteSpace(languageTag))
                return false;

            if (string.IsNullOrWhiteSpace(resourceKey))
                return false;

            if (!LanguageTagManager.TryGet(languageTag, out var languageTagInstance))
                return false;

            switch (strategy)
            {
                case AttemptStrategy.Fallback:
                    return TranslationGetter.FallbackMode(languageTagInstance, resourceKey, out translateValue, _resources, _fallbackExperimenter);

                case AttemptStrategy.Sequence:
                    return TranslationGetter.SequenceMode(languageTagInstance, resourceKey, out translateValue, _resources);

                case AttemptStrategy.Strict:
                    return TranslationGetter.StrictMode(languageTagInstance, resourceKey, out translateValue, _resources);

                default:
                    return TranslationGetter.FallbackMode(languageTagInstance, resourceKey, out translateValue, _resources, _fallbackExperimenter);
            }
        }

        /// <summary>
        /// Try get translate value
        /// </summary>
        /// <param name="languageTag"></param>
        /// <param name="resourceKey"></param>
        /// <param name="translateValue"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public bool TryGetTranslateValue(LanguageTag languageTag, string resourceKey, out string translateValue, AttemptStrategy strategy = AttemptStrategy.Fallback)
        {
            translateValue = string.Empty;

            if (languageTag == null)
                return false;

            if (string.IsNullOrWhiteSpace(resourceKey))
                return false;

            switch (strategy)
            {
                case AttemptStrategy.Fallback:
                    return TranslationGetter.FallbackMode(languageTag, resourceKey, out translateValue, _resources, _fallbackExperimenter);

                case AttemptStrategy.Sequence:
                    return TranslationGetter.SequenceMode(languageTag, resourceKey, out translateValue, _resources);

                case AttemptStrategy.Strict:
                    return TranslationGetter.StrictMode(languageTag, resourceKey, out translateValue, _resources);

                default:
                    return TranslationGetter.FallbackMode(languageTag, resourceKey, out translateValue, _resources, _fallbackExperimenter);
            }
        }

        #endregion

    }
}