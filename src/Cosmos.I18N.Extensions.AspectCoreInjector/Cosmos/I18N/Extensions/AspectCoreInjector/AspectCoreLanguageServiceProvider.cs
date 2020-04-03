using System;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Extensions.AspectCoreInjector {
    /// <summary>
    /// AspectCore Injector language service provider
    /// </summary>
    public class AspectCoreLanguageServiceProvider : ILanguageServiceProvider {
        private readonly ITranslationManager _translationManager;
        private readonly TranslationProcessor _translationProcessor;
        
        /// <summary>
        /// Create a new instance of <see cref="AspectCoreLanguageServiceProvider"/>.
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="processor"></param>
        public AspectCoreLanguageServiceProvider(ITranslationManager manager, TranslationProcessor processor) {
            _translationManager = manager ?? throw new ArgumentNullException(nameof(manager));
            _translationProcessor = processor ?? throw new ArgumentNullException(nameof(processor));
        }

        /// <inheritdoc />
        public ITranslatePackage GetTranslationPackage() => _translationManager.GetAnonymousPackage();

        /// <inheritdoc />
        public ITranslatePackage GetTranslationPackage(string packageKey) => _translationManager.GetPackage(packageKey);

        /// <inheritdoc />
        public ITranslationManager GetTranslationManager() => _translationManager;

        /// <inheritdoc />
        public TranslationProcessor GetTranslationProcessor() => _translationProcessor;
    }
}