using System;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.DependencyInjection;
using Cosmos.I18N.Translation;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Cosmos.I18N {
    /// <summary>
    /// I18N service collection for Microsoft Dependency Injection
    /// </summary>
    public class StandardI18NServiceCollection : II18NServiceCollection {
        private readonly IServiceCollection _services;

        private readonly I18NOptions _options;
        private readonly TranslationManager _translationManager;

        /// <summary>
        /// I18N service collection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public StandardI18NServiceCollection(IServiceCollection services = null, I18NOptions options = null) {
            _services = services ?? new ServiceCollection();
            _options = I18NOptions.Create(options);
            _translationManager = new TranslationManager();
        }

        /// <inheritdoc />
        public I18NOptions ExposeOptions => _options;

        /// <inheritdoc />
        public TranslationManager ExposeTranslationManager => _translationManager;

        /// <inheritdoc />
        public II18NServiceCollection AppendOptionsAction(Action<I18NOptions> optionsAct) {
            optionsAct?.Invoke(_options);
            return this;
        }

        /// <inheritdoc />
        public II18NServiceCollection AddDependency(Action<IServiceCollection> servicesAction) {
            servicesAction?.Invoke(_services);
            return this;
        }

        /// <summary>
        /// Register TranslationManager
        /// </summary>
        /// <returns></returns>
        public II18NServiceCollection RegisterTranslationManager() {
            var translationSetter = _translationManager as ITranslationManSetter;

            foreach (var package in _options.TranslationPackages) {
                var translationPackage = package.Value;
                translationSetter.RegisterPackage(translationPackage);
                AddDependency(service => service.AddSingleton(translationPackage));
            }

            AddDependency(service => {
                service.AddSingleton(_translationManager);
                service.AddSingleton<ITranslationManager>(_translationManager);
            });

            return this;
        }

        /// <summary>
        /// Register LanguageServiceProviders
        /// </summary>
        /// <returns></returns>
        public II18NServiceCollection RegisterLanguageServiceProviders() {
            AddDependency(service => {
                service.AddSingleton<ITextProvider, TextProvider>();
                service.AddSingleton<ILanguageServiceProvider, StandardLanguageServiceProvider>();
            });

            return this;
        }

        /// <summary>
        /// Register TranslationProcessor
        /// </summary>
        /// <returns></returns>
        public II18NServiceCollection RegisterTranslationProcessor() {
            AddDependency(service => {
                service.AddSingleton(provider => new TranslationProcessor(provider.GetServices<ITranslatePackage>().ToDictionary(package => package.PackageKey.GetHashCode())));
            });
            return this;
        }
    }
}