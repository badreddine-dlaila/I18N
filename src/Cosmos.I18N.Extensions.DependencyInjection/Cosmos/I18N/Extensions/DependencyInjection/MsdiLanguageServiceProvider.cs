using System;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Extensions.DependencyInjection
{
    public class MsdiLanguageServiceProvider : ILanguageServiceProvider
    {
        private readonly ITranslationManager _translationManager;
        private readonly TranslationProcessor _translationProcessor;

        public MsdiLanguageServiceProvider(ITranslationManager manager, TranslationProcessor processor)
        {
            _translationManager = manager ?? throw new ArgumentNullException(nameof(manager));
            _translationProcessor = processor ?? throw new ArgumentNullException(nameof(processor));
        }
        
        public ITranslatePackage GetTranslationPackage(string packageKey) => _translationManager.GetPackage(packageKey);
     
        public ITranslationManager GetTranslationManager() => _translationManager;
        
        public TranslationProcessor GetTranslationProcessor() => _translationProcessor;
    }
}