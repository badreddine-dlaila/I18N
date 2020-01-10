using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Cosmos.Extensions.Autofac;
using Cosmos.Extensions.Autofac.Core;
using Cosmos.I18N;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos {
    /// <summary>
    /// Extensions for Autofac register
    /// </summary>
    public static class AutofacRegisterExtensions {
        /// <summary>
        /// Register Cosmos.I18N for autofac
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ContainerBuilder RegisterCosmosLocalization(this ContainerBuilder services, Action<I18NOptions> optionAct) {
            if (services is null) throw new ArgumentNullException(nameof(services));

            var options = new I18NOptions();
            optionAct?.Invoke(options);

            var translationManager = new TranslationManager();
            var translationSetter = (ITranslationManSetter) translationManager;

            foreach (var package in options.TranslationPackages) {
                var translationPackage = package.Value;
                translationSetter.RegisterPackage(translationPackage);
                services.RegisterInstance(translationPackage).SingleInstance();
            }

            services.RegisterInstance(translationManager).SingleInstance();
            services.RegisterInstance(translationManager).As<ITranslationManager>().SingleInstance();
            services.RegisterType<TextProvider>().As<ITextProvider>().SingleInstance();
            services.RegisterType<AutofacLanguageServiceProvider>().As<ILanguageServiceProvider>().SingleInstance();
            services.Register(provider => new TranslationProcessor(
                         provider.Resolve<IEnumerable<ITranslatePackage>>()
                                 .ToDictionary(package => package.PackageKey.GetHashCode())))
                    .SingleInstance();
            services.Register(StaticProviderHack.New).SingleInstance();

            return services;
        }
    }
}