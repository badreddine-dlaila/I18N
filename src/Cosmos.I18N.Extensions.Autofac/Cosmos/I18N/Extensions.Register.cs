using System;
using Autofac;
using Cosmos.Extensions.Dependency;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.Autofac;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N {
    /// <summary>
    /// Extensions for Autofac register
    /// </summary>
    public static class AutofacRegisterExtensions {
        /// <summary>
        /// Register Cosmos.I18N for Autofac
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection RegisterCosmosLocalization(this ContainerBuilder builder, Action<I18NOptions> optionAct = null) {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            return new AutofacServiceCollection(builder, I18NOptions.Create(optionAct));
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ContainerBuilder Done(this II18NServiceCollection services) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (services is AutofacServiceCollection serviceImpl) {
                
                var builder = serviceImpl.OriginalServices;

                if (!StaticFlag.HasInit) {

                    using (serviceImpl) {

                        var options = serviceImpl.ExposeOptions;

                        serviceImpl.RegisterAllPackages(options);

                        serviceImpl.RegisterTranslationProcessor();

                        serviceImpl.RegisterTranslationProviders();

                        serviceImpl.RegisterTranslationAccessor();

                        serviceImpl.RegisterPostBuiltAction();
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
            services.AddDependency(register => register.AddSingleton<ILanguageServiceProvider, AutofacLanguageServiceProvider>());
        }

        private static void RegisterTranslationAccessor(this II18NServiceCollection services) {
            var tagFactory = new DefaultLanguageTagFactory(LanguageTag.Current.ToString);
            services.AddDependency(register => register.AddSingleton<ICoreScopedLanguageTagFactory>(tagFactory));
            services.AddDependency(register => register.AddScoped<ITranslationAccessor, DefaultTranslationAccessor>());
        }

        private static void RegisterTranslationProcessor(this II18NServiceCollection services) {
            services.AddDependency(s => s.AddSingleton<TranslationProcessor>());
        }

        private static void RegisterPostBuiltAction(this AutofacServiceCollection services) {
            services.AddPostRegisterAction("AfterBuild", builder =>
                builder.RegisterBuildCallback(container => {
                    StaticInstanceForILanguageServiceProvider.SetInstance(container.Resolve<ILanguageServiceProvider>());
                    StaticInstanceForTextProvider.SetInstance(container.Resolve<ITextProvider>());
                    StaticFlag.HasInit = true;
                    StaticFlag.ExpectedServiceName = "AutofacImpl";
                }));
        }
    }
}