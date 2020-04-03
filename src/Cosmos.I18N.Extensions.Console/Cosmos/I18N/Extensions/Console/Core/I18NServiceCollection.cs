using System;
using AspectCore.DependencyInjection;
using Cosmos.Extensions.Dependency.Core;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.AspectCoreInjector;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Extensions.Console.Core {
    /// <summary>
    /// I18N service collection
    /// </summary>
    public class I18NServiceCollection : AspectCoreI18NServiceCollection {
        private bool _hasBuild;

        /// <summary>
        /// I18N service collection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public I18NServiceCollection(IServiceContext services = null, I18NOptions options = null)
            : base(services ?? new ServiceContext(), options) {
            AfterBuild(UpdateStaticResolver);
        }

        /// <inheritdoc />
        public override II18NServiceCollection AppendOptionsAction(Action<I18NOptions> optionsAct) {
            if (_hasBuild) {
                throw new InvalidOperationException("Cannot update options after building.");
            }

            return base.AppendOptionsAction(optionsAct);
        }

        /// <inheritdoc />
        public override II18NServiceCollection AddDependency(Action<DependencyProxyRegister> dependencyAction) {
            if (_hasBuild) {
                throw new InvalidOperationException("Cannot add dependency after building.");
            }

            return base.AddDependency(dependencyAction);
        }

        /// <summary>
        /// Build
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public IServiceProvider Build() {
            if (_hasBuild) {
                throw new InvalidOperationException("Only can be built once.");
            }

            BeforeBuildAction?.Invoke(OriginalServices);

            var resolver = OriginalServices.Build();

            AfterBuildAction?.Invoke(resolver);

            _hasBuild = true;

            return resolver;
        }

        private Action<IServiceContext> BeforeBuildAction { get; set; }
        private Action<IServiceProvider> AfterBuildAction { get; set; }

        /// <summary>
        /// Before build
        /// </summary>
        /// <param name="serviceAct"></param>
        public void BeforeBuild(Action<IServiceContext> serviceAct) {
            if (serviceAct != null) {
                BeforeBuildAction += serviceAct;
            }
        }

        /// <summary>
        /// After build
        /// </summary>
        /// <param name="providerAct"></param>
        public void AfterBuild(Action<IServiceProvider> providerAct) {
            if (providerAct != null) {
                AfterBuildAction += providerAct;
            }
        }

        private static void UpdateStaticResolver(IServiceProvider resolver) {
            StaticInstanceForILanguageServiceProvider.SetInstance(resolver.GetRequiredService<ILanguageServiceProvider>());
            StaticInstanceForTextProvider.SetInstance(resolver.GetRequiredService<ITextProvider>());
        }
    }
}