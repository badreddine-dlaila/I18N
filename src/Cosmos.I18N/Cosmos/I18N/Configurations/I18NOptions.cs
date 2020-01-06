using System;
using System.Collections.Generic;
using System.Threading;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Configurations {
    /// <summary>
    /// Cosmos i18n options
    /// </summary>
    public class I18NOptions {
        // ReSharper disable once InconsistentNaming
        private readonly Dictionary<int, ITranslatePackage> __translationPackages;

        // ReSharper disable once InconsistentNaming
        private readonly object __lock_package = new object();

        // ReSharper disable once InconsistentNaming
        private readonly object __lock_resource = new object();

        private readonly FallbackExperimenter _fallbackExperimenter = FallbackExperimenter.Default;

        /// <summary>
        /// Create a new instance of <see cref="I18NOptions"/>
        /// </summary>
        public I18NOptions() {
            __translationPackages = new Dictionary<int, ITranslatePackage> {
                {TranslationManager.HashOfAnonymousPackageKey, new TranslatePackage(TranslationManager.ANONYMOUS_PACKAGE_KEY, _fallbackExperimenter)}
            };
        }

        #region Add package

        /// <summary>
        /// Add translation package
        /// </summary>
        /// <param name="packageProvider"></param>
        /// <param name="level"></param>
        /// <param name="customMergeProvider"></param>
        /// <returns></returns>
        public I18NOptions AddPackage(Func<ITranslatePackage> packageProvider, MergeLevel level = MergeLevel.Level_1,
            Func<ITranslatePackageMergeOps, ITranslatePackageMergeOps, ITranslatePackage> customMergeProvider = null) {
            return AddPackage(packageProvider(), level, customMergeProvider);
        }

        /// <summary>
        /// Add translation package
        /// </summary>
        /// <param name="package"></param>
        /// <param name="level"></param>
        /// <param name="customMergeProvider"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public I18NOptions AddPackage(ITranslatePackage package, MergeLevel level = MergeLevel.Level_1,
            Func<ITranslatePackageMergeOps, ITranslatePackageMergeOps, ITranslatePackage> customMergeProvider = null) {
            if (package == null)
                throw new ArgumentNullException(nameof(package));
            lock (__lock_package) {
                var hashOfPackageKey = package.PackageKey.GetHashCode();
                if (__translationPackages.TryGetValue(hashOfPackageKey, out var packageInstance)) {
                    var template = TranslatePackageMerger.Merge(packageInstance, package, level, customMergeProvider);
                    __translationPackages[hashOfPackageKey] = template;
                }
                else {
                    AddPackageInternal(package);
                }
            }

            return this;
        }

        private void AddPackageInternal(ITranslatePackage package) {
            __translationPackages.Add(package.PackageKey.GetHashCode(), package);
        }

        #endregion

        #region Add resource

        /// <summary>
        /// Add translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="resourceProvider"></param>
        /// <returns></returns>
        public I18NOptions AddResource(string packageKey, Func<ITranslateResource> resourceProvider) {
            return AddResource(packageKey, resourceProvider());
        }

        /// <summary>
        /// Add translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public I18NOptions AddResource(string packageKey, ITranslateResource resource) {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));
            if (string.IsNullOrWhiteSpace(packageKey))
                throw new ArgumentNullException(nameof(packageKey));
            if (resource.IsAnonymous)
                throw new ArgumentException($"Anonymous translation resource should use method '{nameof(AddAnonymousResource)}'.");

            lock (__lock_resource) {
                var hashOfPackageKey = packageKey.GetHashCode();
                if (TryRegisterLanguageTagOnce(resource.Binding)) {
                    if (__translationPackages.TryGetValue(hashOfPackageKey, out var package)) {
                        package.AddResource(resource);
                    }
                    else {
                        var future = new TranslatePackage(packageKey, _fallbackExperimenter);
                        future.AddResource(resource);
                        AddPackageInternal(future);
                    }
                }
                else {
                    throw new InvalidOperationException($"Something broken when add new resource '{resource.Name}'.");
                }
            }

            return this;
        }

        /// <summary>
        /// Add anonymous translation resource
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public I18NOptions AddAnonymousResource(ITranslateResource resource) {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));
            if (!resource.IsAnonymous)
                throw new ArgumentException($"Non-anonymous translation resource should use method '{nameof(AddResource)}'.");

            lock (__lock_resource) {
                if (TryRegisterLanguageTagOnce(resource.Binding)) {
                    var anonymousPackage = __translationPackages[TranslationManager.HashOfAnonymousPackageKey];
                    anonymousPackage.AddResource(resource);
                }
            }

            return this;
        }

        private bool TryRegisterLanguageTagOnce(LanguageTag languageTag) {
            if (languageTag == null)
                return false;

            if (_fallbackExperimenter.Contains(languageTag))
                return true;

            _fallbackExperimenter.RegisterTag(languageTag);

            return true;
        }

        #endregion

        #region Expose readonly properties

        /// <summary>
        /// To gets a readonly translation package table
        /// </summary>
        // ReSharper disable once InconsistentlySynchronizedField
        public IReadOnlyDictionary<int, ITranslatePackage> TranslationPackages => __translationPackages;

        #endregion

        #region Add base path

        /// <summary>
        /// Path base
        /// </summary>
        public string PathBase { get; private set; }

        /// <summary>
        /// Path segment
        /// </summary>
        public string PathSegment { get; set; }

        /// <summary>
        /// Set path base
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public I18NOptions SetPathBase(string path) {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            PathBase = path;
            return this;
        }

        /// <summary>
        /// Set path segment
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public I18NOptions SetPathSegment(string path) {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            PathSegment = path;
            return this;
        }

        #endregion

        #region Set Default Locale

        /// <summary>
        /// Gets or sets default locale
        /// </summary>
        public Locale DefaultLocale {
            get => LanguageTag.DefaultLocale;
            set => LanguageTag.SetDefaultLocale(value);
        }

        /// <summary>
        /// Sets default locale
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        public I18NOptions SetDefaultLocale(Locale locale) {
            DefaultLocale = locale;
            return this;
        }

        #endregion

        #region Set CurrentLanguageTag Changed Handler

        internal Action<AsyncLocalValueChangedArgs<string>> LanguageTagChangedHandler { get; private set; }

        /// <summary>
        /// Set LanguageTag changed handler
        /// </summary>
        /// <param name="languageTagChangedHandler"></param>
        /// <returns></returns>
        public I18NOptions SetLanguageTagChangedHandler(Action<AsyncLocalValueChangedArgs<string>> languageTagChangedHandler) {
            if (languageTagChangedHandler != null) {
                LanguageTagChangedHandler = languageTagChangedHandler;
            }

            return this;
        }

        /// <summary>
        /// Append LanguageTag changed handler
        /// </summary>
        /// <param name="languageTagChangedHandler"></param>
        /// <returns></returns>
        public I18NOptions AppendLanguageTagChangedHandler(Action<AsyncLocalValueChangedArgs<string>> languageTagChangedHandler) {
            if (languageTagChangedHandler != null) {
                LanguageTagChangedHandler += languageTagChangedHandler;
            }

            return this;
        }

        /// <summary>
        /// Remove all LanguageTag changed handler
        /// </summary>
        /// <returns></returns>
        public I18NOptions RemoveLanguageTagChangedHandler() {
            LanguageTagChangedHandler = null;
            return this;
        }

        #endregion

    }
}