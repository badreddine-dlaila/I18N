using System;
using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Extensions.DependencyInjection
{
    public class MsdiLanguageServiceProvider : ILanguageServiceProvider
    {
        private readonly ILanguageManager _languageManager;
        private readonly TranslationProcessor _translationProcessor;

        public MsdiLanguageServiceProvider(LanguageManager manager, TranslationProcessor processor)
        {
            _languageManager = manager ?? throw new ArgumentNullException(nameof(manager));
            _translationProcessor = processor ?? throw new ArgumentNullException(nameof(processor));
        }

        public ILanguagePackage GetLanguagePackage(string langName) => _languageManager.GetLanguagePackage(langName);

        public ILanguagePackage GetLanguagePackage(Locale language) => _languageManager.GetLanguagePackage(language);
        
        public ILanguageManager GetLanguageManager() => _languageManager;

        public TranslationProcessor GetTranslationProcessor() => _translationProcessor;
    }
}