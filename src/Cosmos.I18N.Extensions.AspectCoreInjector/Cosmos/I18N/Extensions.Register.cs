using System;
using AspectCore.DependencyInjection;
using Cosmos.Extensions.Dependency;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.AspectCoreInjector;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N {
    /// <summary>
    /// Extensions for AspectCore register
    /// </summary>
    public static class AspectCoreRegisterExtensions {
        /// <summary>
        /// Register Cosmos.I18N for NCC AspectCore
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection RegisterCosmosLocalization(this IServiceContext services, Action<I18NOptions> optionAct = null) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            return new AspectCoreI18NServiceCollection(services, I18NOptions.Create(optionAct));
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceContext Done(this II18NServiceCollection services) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (services is AspectCoreI18NServiceCollection serviceImpl) {

                var builder = serviceImpl.OriginalServices;

                if (!StaticFlag.HasInit) {

                    using (serviceImpl) {

                        var options = serviceImpl.ExposeOptions;

                        serviceImpl.RegisterAllPackages(options);

                        serviceImpl.RegisterTranslationProcessor();

                        serviceImpl.RegisterTranslationProviders();

                        serviceImpl.RegisterTranslationAccessor();
                    }
                }

                return builder;

            }

            throw new ArgumentException("Unknown type of II18NServiceCollection");
        }

        private static void RegisterAllPackages(this II18NServiceCollection services, I18NOptions options) {
            var translationManager = new TranslationManager();
            var translationSetter = (ITranslationManSetter) translationManager;

            foreach (var package in options.TranslationPackages) {
                var translationPackage = package.Value;
                translationSetter.RegisterPackage(translationPackage);
                services.AddDependency(register => register.AddSingleton(translationPackage));
            }


            services.AddDependency(register => register.AddSingleton(translationManager));
            services.AddDependency(register => register.AddSingleton<ITranslationManager>(translationManager));
        }

        private static void RegisterTranslationProviders(this II18NServiceCollection services) {
            services.AddDependency(register => register.AddSingleton<ITextProvider, TextProvider>());
            services.AddDependency(register => register.AddSingleton<ILanguageServiceProvider, AspectCoreLanguageServiceProvider>());
        }

        private static void RegisterTranslationAccessor(this II18NServiceCollection services) {
            var tagFactory = new DefaultLanguageTagFactory(LanguageTag.Current.ToString);
            services.AddDependency(register => register.AddSingleton<ICoreScopedLanguageTagFactory>(tagFactory));
            services.AddDependency(register => register.AddScoped<ITranslationAccessor, DefaultTranslationAccessor>());
        }

        private static void RegisterTranslationProcessor(this II18NServiceCollection services) {
            services.AddDependency(s => s.AddSingleton<TranslationProcessor>());
        }


    }
}