using System;
using System.Linq;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Extensions.Console.Core {
    internal static class SoloDependencyContainer {
        private static IServiceProvider ServiceResolver { get; set; }
        public static void SetResolver(IServiceProvider resolver) => ServiceResolver = resolver;

        internal static I18NServiceCollection Initialize(I18NServiceCollection serviceImpl) {
            return serviceImpl;
        }

        internal static void AllDone(II18NServiceCollection services) {
            if (services is I18NServiceCollection serviceImpl) {
                var translationManager = serviceImpl.ExposeTranslationManager;
                var translationSetter = translationManager as ITranslationManSetter;

                foreach (var package in serviceImpl.ExposeOptions.TranslationPackages) {
                    var translationPackage = package.Value;
                    translationSetter.RegisterPackage(translationPackage);
                    serviceImpl.AddDependency(s => s.AddSingleton(translationPackage));
                }

                serviceImpl.AddDependency(s => {
                    s.AddSingleton(translationManager);
                    s.AddSingleton<ITranslationManager>(translationManager);
                    s.AddSingleton<ITextProvider, TextProvider>();
                    s.AddSingleton<ILanguageServiceProvider, ConsoleLanguageServiceProvider>();
                    s.AddSingleton(provider => new TranslationProcessor(provider.GetServices<ITranslatePackage>().ToDictionary(package => package.PackageKey.GetHashCode())));
                });

                SetResolver(serviceImpl.Build());
            }
        }

        public static IServiceProvider GetServiceResolver() => ServiceResolver ?? throw new NullReferenceException(nameof(ServiceResolver));
    }
}