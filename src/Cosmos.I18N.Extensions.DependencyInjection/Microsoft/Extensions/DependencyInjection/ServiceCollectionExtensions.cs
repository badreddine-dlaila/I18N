using System;
using System.Linq;
using Cosmos.I18N;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Extensions.DependencyInjection;
using Cosmos.I18N.Extensions.DependencyInjection.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCosmosLocalization(this IServiceCollection services, Action<I18NOptions> optionAct)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var options = new I18NOptions();
            optionAct?.Invoke(options);

            var languageManager = new LanguageManager();
            var languageSetter = languageManager as ILanguageManSetter;
            foreach (var lang in options.RegisteredLanguages) languageManager.RegisterUsedLanguage(lang);
            foreach (var package in options.LanguagePackages)
            {
                var languagePackage = package.Value;
                languageSetter.RegisterLanguagePackage(languagePackage);
                services.AddSingleton(languagePackage);
            }

            services.AddSingleton(languageManager);
            services.AddSingleton<ITextProvider, TextProvider>();
            services.AddSingleton<ILanguageServiceProvider, MsdiLanguageServiceProvider>();
            services.AddSingleton(provider => new TranslationProcessor(provider.GetServices<ILanguagePackage>().ToDictionary(package => package.Language)));
            services.AddSingleton(provider => new StaticProviderHack(provider.GetRequiredService<ILanguageServiceProvider>()));
           
            return services;
        }
    }
}