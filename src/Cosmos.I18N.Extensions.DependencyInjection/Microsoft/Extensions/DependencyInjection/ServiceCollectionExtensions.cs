using System;
using System.Linq;
using Cosmos.I18N;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.DependencyInjection;
using Cosmos.I18N.Extensions.DependencyInjection.Core;
using Cosmos.I18N.Translation;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCosmosLocalization(this IServiceCollection services, Action<I18NOptions> optionAct)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var options = new I18NOptions();
            optionAct?.Invoke(options);

            var translationManager = new TranslationManager();
            var translationSetter = translationManager as ITranslationManSetter;

            foreach (var package in options.TranslationPackages)
            {
                var translationPackage = package.Value;
                translationSetter.RegisterPackage(translationPackage);
                services.AddSingleton(translationPackage);
            }

            services.AddSingleton(translationManager);
            services.AddSingleton<ITranslationManager>(translationManager);
            services.AddSingleton<ITextProvider, TextProvider>();
            services.AddSingleton<ILanguageServiceProvider, MsdiLanguageServiceProvider>();
            services.AddSingleton(provider => new TranslationProcessor(provider.GetServices<ITranslatePackage>().ToDictionary(package => package.PackageKey.GetHashCode())));
            services.AddSingleton(StaticProviderHack.New);

            return services;
        }
    }
}