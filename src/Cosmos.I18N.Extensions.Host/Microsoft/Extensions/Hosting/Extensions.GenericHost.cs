#if !NET451

using System;
using Cosmos.I18N;
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
        /// <param name="config"></param>
        /// <returns></returns>
        public static IHostBuilder AddCosmosLocalization(this IHostBuilder builder, Action<II18NServiceCollection> config = null) {
            if (builder is null) throw new ArgumentNullException(nameof(builder));
            builder.ConfigureServices((ctx, services) => services.RegisterCode());
            builder.ConfigureContainer<IServiceProvider>((ctx, resolver) => {
                StaticInstanceForILanguageServiceProvider.SetInstance(resolver.GetRequiredService<ILanguageServiceProvider>());
                StaticInstanceForTextProvider.SetInstance(resolver.GetRequiredService<ITextProvider>());
            });
            return builder;
        }
    }
}

#endif