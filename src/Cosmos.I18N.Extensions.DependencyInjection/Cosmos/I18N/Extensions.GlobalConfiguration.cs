using System;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;

namespace Cosmos.I18N {
    /// <summary>
    /// Global configuration extensions
    /// </summary>
    public static class GlobalConfigurationExtensions {
        /// <summary>
        /// Options to global
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection ToGlobal(this II18NServiceCollection services, Action<I18NOptions> optionsAct) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));
            if (optionsAct is null)
                throw new ArgumentNullException(nameof(optionsAct));

            services.AppendOptionsAction(optionsAct);

            return services;
        }
    }
}