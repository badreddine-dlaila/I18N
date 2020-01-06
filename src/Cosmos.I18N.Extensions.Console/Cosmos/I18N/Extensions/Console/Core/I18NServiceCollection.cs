using System;
using AspectCore.DependencyInjection;
using AspectCore.Extensions.DependencyInjection;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Extensions.Console.Core {
    /// <summary>
    /// I18N service collection
    /// </summary>
    public class I18NServiceCollection : II18NServiceCollection {
        private bool _hasBuild;
        private readonly IServiceCollection _services;

        private readonly I18NOptions _options;
        private readonly TranslationManager _translationManager;

        /// <summary>
        /// I18N service collection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public I18NServiceCollection(IServiceCollection services = null, I18NOptions options = null) {
            _services = services ?? new ServiceCollection();
            _options = options ?? new I18NOptions();
            _translationManager = new TranslationManager();

            AfterBuild(UpdateStaticResolver);
        }

        /// <inheritdoc />
        public II18NServiceCollection AppendOptionsAction(Action<I18NOptions> optionsAct) {
            if (_hasBuild) {
                throw new InvalidOperationException("Cannot update options after building.");
            }

            optionsAct?.Invoke(_options);
            return this;
        }

        /// <inheritdoc />
        public II18NServiceCollection AddDependency(Action<IServiceCollection> servicesAction) {
            if (_hasBuild) {
                throw new InvalidOperationException("Cannot add dependency after building.");
            }

            servicesAction?.Invoke(_services);
            return this;
        }

        /// <inheritdoc />
        public IServiceProvider Build() {
            if (_hasBuild) {
                throw new InvalidOperationException("Only can be built once.");
            }

            BeforeBuildAction?.Invoke(_services);

            var resolver = _services.ToServiceContext().Build();

            AfterBuildAction?.Invoke(resolver);

            _hasBuild = true;

            return resolver;
        }

        private Action<IServiceCollection> BeforeBuildAction { get; set; }
        private Action<IServiceProvider> AfterBuildAction { get; set; }

        /// <inheritdoc />
        public void BeforeBuild(Action<IServiceCollection> serviceAct) {
            if (serviceAct != null) {
                BeforeBuildAction += serviceAct;
            }
        }

        /// <inheritdoc />
        public void AfterBuild(Action<IServiceProvider> providerAct) {
            if (providerAct != null) {
                AfterBuildAction += providerAct;
            }
        }

        /// <inheritdoc />
        public I18NOptions ExposeOptions => _options;

        /// <inheritdoc />
        public TranslationManager ExposeTranslationManager => _translationManager;

        private static void UpdateStaticResolver(IServiceProvider resolver) {
            StaticInstanceForILanguageServiceProvider.SetInstance(resolver.GetRequiredService<ILanguageServiceProvider>());
            StaticInstanceForTextProvider.SetInstance(resolver.GetRequiredService<ITextProvider>());
        }
    }
}