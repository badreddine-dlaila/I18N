using System;
using System.Linq;
using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Extensions.Console.Core
{
    internal static class SoloDependencyContainer
    {
        private static IServiceProvider ServiceResolver { get; set; }
        public static void SetResolver(IServiceProvider resolver) => ServiceResolver = resolver;

        internal static I18NServiceCollection Initialize(I18NServiceCollection serviceImpl)
        {
            return serviceImpl;
        }

        internal static void AllDone(II18NServiceCollection services)
        {
            if (services is I18NServiceCollection serviceImpl)
            {
                var languageManager = serviceImpl.ExposeLanguageManager;
                var languageSetter = languageManager as ILanguageManSetter;
                foreach (var lang in serviceImpl.ExposeOptions.RegisteredLanguages) languageManager.RegisterUsedLanguage(lang);
                foreach (var package in serviceImpl.ExposeOptions.LanguagePackages)
                {
                    var languagePackage = package.Value;
                    languageSetter.RegisterLanguagePackage(languagePackage);
                    serviceImpl.AddDependency(s => s.AddSingleton(languagePackage));
                }

                serviceImpl.AddDependency(s =>
                {
                    s.AddSingleton(languageManager);
                    s.AddSingleton<ITextProvider, TextProvider>();
                    s.AddSingleton<ILanguageServiceProvider, ConsoleLanguageServiceProvider>();
                    s.AddSingleton(provider => new TranslationProcessor(provider.GetServices<ILanguagePackage>().ToDictionary(package => package.Language)));
                    });


            }

            SetResolver(services.Build());
        }

        public static IServiceProvider GetServiceResolver() => ServiceResolver ?? throw new NullReferenceException(nameof(ServiceResolver));
    }
}