using System;
using Cosmos.I18N;
using Cosmos.I18N.Core;

namespace Microsoft.Extensions.DependencyInjection {
    /// <summary>
    /// Extensions for service collection
    /// </summary>
    public static class ServiceCollectionExtensions {
        /// <summary>
        /// Add Cosmos.I18N
        /// </summary>
        /// <param name="services"></param>
        /// <param name="serviceAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddCosmosLocalization(this IServiceCollection services, Action<II18NServiceCollection> serviceAct) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            var serviceImpl = new StandardI18NServiceCollection(services);

            serviceAct?.Invoke(serviceImpl);

            serviceImpl.RegisterTranslationManager();

            serviceImpl.RegisterLanguageServiceProviders();

            serviceImpl.RegisterTranslationProcessor();

            return services;
        }

        /// <summary>
        /// Add Cosmos.I18N
        /// </summary>
        /// <param name="services"></param>
        /// <param name="serviceAct"></param>
        /// <param name="additionalAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddCosmosLocalization(this IServiceCollection services,
            Action<II18NServiceCollection> serviceAct,
            Action<II18NServiceCollection> additionalAct) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            var serviceImpl = new StandardI18NServiceCollection(services);

            serviceAct?.Invoke(serviceImpl);
            additionalAct?.Invoke(serviceImpl);

            serviceImpl.RegisterTranslationManager();

            serviceImpl.RegisterLanguageServiceProviders();

            serviceImpl.RegisterTranslationProcessor();

            return services;
        }
    }
}