using System;
using System.Collections.Generic;
using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Extensions.Console
{
    public class ConsoleLanguageServiceProvider : ILanguageServiceProvider
    {

        private readonly ILanguageManager _languageManager;
        private readonly TranslationProcessor _translationProcessor;

        public ConsoleLanguageServiceProvider(LanguageManager manager, TranslationProcessor processor, IEnumerable<ILanguagePackage> languagePackages)
        {
            _languageManager = manager ?? throw new ArgumentNullException(nameof(manager));
            _translationProcessor = processor ?? throw new ArgumentNullException(nameof(processor));

            if (!(_languageManager is ILanguageManSetter languageManSetter))
                throw new ArgumentNullException(nameof(languageManSetter));
            languageManSetter.RegisterLanguagePackages(languagePackages);
        }

        public ILanguagePackage GetLanguagePackage(string langName) => _languageManager.GetLanguagePackage(langName);

        public ILanguagePackage GetLanguagePackage(Locale language) => _languageManager.GetLanguagePackage(language);

        public ILanguageManager GetLanguageManager() => _languageManager;

        public TranslationProcessor GetTranslationProcessor() => _translationProcessor;
    }
}