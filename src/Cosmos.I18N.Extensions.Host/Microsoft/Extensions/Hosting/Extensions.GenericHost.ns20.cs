#if NETSTANDARD2_0

using System;
using Cosmos.I18N;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Internals;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Hosting {
    /// <summary>
    /// Extensions for Microsoft generic host 
    /// </summary>
    public static class GenericHostExtensions {
        /// <summary>
        /// Add Cosmos I18N
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="optionsAct"></param>
        /// <param name="serviceConfigure"></param>
        /// <returns></returns>
        public static IHostBuilder AddCosmosLocalization(
            this IHostBuilder builder,
            Action<I18NOptions> optionsAct = null,
            Action<II18NServiceCollection> serviceConfigure = null) {

            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.ConfigureServices((ctx, services) => {
                
                // ReSharper disable once InconsistentNaming
                var i18nServices = services.AddCosmosLocalizationServices(optionsAct);

                serviceConfigure?.Invoke(i18nServices);

                i18nServices.AppendOrOverride();

                i18nServices.UpdateState();

                i18nServices.Done();
            });

            builder.ConfigureContainer<IServiceProvider>((ctx, resolver) => {
                StaticInstanceForILanguageServiceProvider.SetInstance(resolver.GetRequiredService<ILanguageServiceProvider>());
                StaticInstanceForTextProvider.SetInstance(resolver.GetRequiredService<ITextProvider>());
            });

            return builder;
        }
    }
}

#endif