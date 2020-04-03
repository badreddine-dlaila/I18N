using System;
using Cosmos.Extensions.Dependency;
using Cosmos.I18N;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.DependencyInjection;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Microsoft.Extensions.DependencyInjection {
    /// <summary>
    /// Extensions for service collection
    /// </summary>
    public static class ServiceCollectionExtensions {
        /// <summary>
        /// Add Cosmos.I18N
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddCosmosLocalization(this IServiceCollection services, Action<I18NOptions> optionAct = null) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));
            return new StandardI18NServiceCollection(services, I18NOptions.Create(optionAct));
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection Done(this II18NServiceCollection services) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (services is StandardI18NServiceCollection serviceImpl) {

                var builder = serviceImpl.OriginalServices;

                if (!StaticFlag.HasInit) {

                    using (serviceImpl) {

                        serviceImpl.RegisterAllPackages();

                        serviceImpl.RegisterTranslationProcessor();

                        serviceImpl.RegisterTranslationProviders();

                        serviceImpl.RegisterTranslationAccessor();
                    }
                }

                return builder;

            }

            throw new ArgumentException("Unknown type of II18NServiceCollection");
        }

        private static void RegisterAllPackages(this II18NServiceCollection services) {
            var translationManager = services.ExposeTranslationManager;
            var translationSetter = (ITranslationManSetter) translationManager;

            foreach (var package in services.ExposeOptions.TranslationPackages) {
                var translationPackage = package.Value;
                translationSetter.RegisterPackage(translationPackage);
                services.AddDependency(s => s.AddSingleton(translationPackage));
            }

            services.AddDependency(s => {
                s.AddSingleton(translationManager);
                s.AddSingleton<ITranslationManager>(translationManager);
            });
        }

        private static void RegisterTranslationProcessor(this II18NServiceCollection services) {
            services.AddDependency(s => s.AddSingleton<TranslationProcessor>());
        }

        private static void RegisterTranslationProviders(this II18NServiceCollection services) {
            services.AddDependency(s => {
                s.AddSingleton<ITextProvider, TextProvider>();
                s.AddSingleton<ILanguageServiceProvider, StandardLanguageServiceProvider>();
            });
        }

        private static void RegisterTranslationAccessor(this II18NServiceCollection services) {
            var tagFactory = new DefaultLanguageTagFactory(LanguageTag.Current.ToString);
            services.AddDependency(s => {
                s.AddSingleton<ICoreScopedLanguageTagFactory>(tagFactory);
                s.AddScoped<ITranslationAccessor, DefaultTranslationAccessor>();
            });
        }
    }
}