using System;
using Autofac;
using Cosmos.Extensions.Dependency;
using Cosmos.Extensions.Dependency.Core;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Extensions.Autofac {
    /// <summary>
    /// I18n service collection for Autofac
    /// </summary>
    public class AutofacServiceCollection : II18NServiceCollection, IDisposable {
        private readonly AutofacProxyRegister _services;

        private readonly I18NOptions _options;
        private readonly TranslationManager _translationManager;

        /// <summary>
        /// I18N service collection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public AutofacServiceCollection(ContainerBuilder services = null, I18NOptions options = null) {
            _services = new AutofacProxyRegister(services);
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
        public II18NServiceCollection AddDependency(Action<DependencyProxyRegister> dependencyAction) {
            dependencyAction?.Invoke(_services);
            return this;
        }

        /// <summary>
        /// Add post action
        /// </summary>
        /// <param name="key"></param>
        /// <param name="postAction"></param>
        public void AddPostRegisterAction(string key, Action<ContainerBuilder> postAction) {
            _services.AddPostRegister(key, postAction);
        }

        /// <summary>
        /// Gets original services
        /// </summary>
        public ContainerBuilder OriginalServices => _services.RawServices;

        /// <inheritdoc />
        public void Dispose() => _services.Dispose();
    }
}