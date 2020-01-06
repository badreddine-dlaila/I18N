using System.Collections.Generic;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation {
    /// <summary>
    /// Translation manager
    /// </summary>
    public class TranslationManager : ITranslationManager, ITranslationManSetter {
        private readonly Dictionary<int, ITranslatePackage> _translatePackages;
        private static readonly int _hashOfAnonymousPackageKey = ANONYMOUS_PACKAGE_KEY.GetHashCode();
        private readonly object _translateLockObj = new object();

        /// <summary>
        /// Anonymous Package Key
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string ANONYMOUS_PACKAGE_KEY = "__anonymous_package_key";

        /// <summary>
        /// Anonymous Resource Name
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string ANONYMOUS_RESOURCE_NAME = "AnonymousResource";

        /// <summary>
        /// Hashcode of Anonymous Package Key
        /// </summary>
        public static int HashOfAnonymousPackageKey => _hashOfAnonymousPackageKey;

        /// <summary>
        /// Create a new instance of <see cref="TranslationManager"/>
        /// </summary>
        public TranslationManager() {
            _translatePackages = new Dictionary<int, ITranslatePackage> {
                {_hashOfAnonymousPackageKey, new TranslatePackage(ANONYMOUS_PACKAGE_KEY, FallbackExperimenter.Default)}
            };
        }

        #region Current language tag

        /// <summary>
        /// To get current language tag
        /// </summary>
        public LanguageTag CurrentLanguageTag => LanguageTag.Current;

        #endregion

        #region Contains translation package

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="packageKey"></param>
        /// <returns></returns>
        public bool Contains(string packageKey) {
            // ReSharper disable once InconsistentlySynchronizedField
            return !string.IsNullOrWhiteSpace(packageKey) && _translatePackages.ContainsKey(packageKey.GetHashCode());
        }

        #endregion

        #region Register translation package

        /// <summary>
        /// Register translation package
        /// </summary>
        /// <param name="translatePackage"></param>
        void ITranslationManSetter.RegisterPackage(ITranslatePackage translatePackage) {
            if (translatePackage == null)
                return;

            if (translatePackage.IsAnonymous) {
                var left = _translatePackages[_hashOfAnonymousPackageKey];
                var right = translatePackage;
                TranslatePackageMerger.Merge(left, right, MergeLevel.Level_2);
                return;
            }

            if (Contains(translatePackage.PackageKey))
                return;

            lock (_translateLockObj) {
                if (Contains(translatePackage.PackageKey))
                    return;

                _translatePackages.Add(translatePackage.PackageKey.GetHashCode(), translatePackage);
            }
        }

        /// <summary>
        /// Register translation packages
        /// </summary>
        /// <param name="translatePackages"></param>
        void ITranslationManSetter.RegisterPackages(IEnumerable<ITranslatePackage> translatePackages) {
            if (translatePackages == null)
                return;

            var setter = (ITranslationManSetter) this;

            foreach (var package in translatePackages)
                setter.RegisterPackage(package);
        }

        #endregion

        #region Get translation package

        /// <summary>
        /// Get translation package
        /// </summary>
        /// <param name="packageKey"></param>
        /// <returns></returns>
        public ITranslatePackage GetPackage(string packageKey) {
            if (string.IsNullOrWhiteSpace(packageKey))
                return default;
            return _translatePackages.TryGetValue(packageKey.GetHashCode(), out var package) ? package : default;
        }

        /// <summary>
        /// Get anonymous translation package
        /// </summary>
        /// <returns></returns>
        public ITranslatePackage GetAnonymousPackage() {
            return _translatePackages[_hashOfAnonymousPackageKey];
        }

        #endregion

        #region Register translation resource

        /// <summary>
        /// Register translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="translateResource"></param>
        void ITranslationManSetter.RegisterResource(string packageKey, ITranslateResource translateResource) {
            if (string.IsNullOrWhiteSpace(packageKey))
                return;

            if (translateResource == null)
                return;

            if (!Contains(packageKey))
                return;

            var packageInstance = GetPackage(packageKey);

            packageInstance?.AddResource(translateResource);
        }

        /// <summary>
        /// Register translation resources
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="translateResources"></param>
        void ITranslationManSetter.RegisterResources(string packageKey, IEnumerable<ITranslateResource> translateResources) {
            if (string.IsNullOrWhiteSpace(packageKey))
                return;

            if (translateResources == null)
                return;

            if (!Contains(packageKey))
                return;

            var packageInstance = GetPackage(packageKey);

            packageInstance?.AddResources(translateResources);
        }

        #endregion

        #region Get translation resource

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public ITranslateResource GetResource(string packageKey, string languageTag) {
            return GetPackage(packageKey)?.GetResource(languageTag);
        }

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public ITranslateResource GetResource(string packageKey, LanguageTag languageTag) {
            return GetPackage(packageKey)?.GetResource(languageTag);
        }

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public ITranslateResource GetAnonymousResource(string languageTag) {
            return GetAnonymousPackage()?.GetResource(languageTag);
        }

        /// <summary>
        /// Get translation resource
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public ITranslateResource GetAnonymousResource(LanguageTag languageTag) {
            return GetAnonymousPackage()?.GetResource(languageTag);
        }

        #endregion

    }
}