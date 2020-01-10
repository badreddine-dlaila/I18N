#if !NETSTANDARD2_1

using System;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Internals;
using Microsoft.Extensions.Configuration;

namespace Microsoft.AspNetCore.Hosting {
    /// <summary>
    /// Extensions for Microsoft AspNetCore web host 
    /// </summary>
    public static class WebHostExtensions {
#if !NET451
        /// <summary>
        /// Add Cosmos I18N
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IWebHostBuilder AddCosmosLocalization(this IWebHostBuilder builder, Action<II18NServiceCollection> config = null) {
            if (builder is null) throw new ArgumentNullException(nameof(builder));
            builder.ConfigureServices((ctx, services) => services.RegisterCode());
            return builder;
        }
#endif

        /// <summary>
        /// Add Cosmos I18N
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configuration"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IWebHostBuilder AddCosmosLocalization(this IWebHostBuilder builder, IConfiguration configuration, Action<II18NServiceCollection> config = null) {
            if (builder is null) throw new ArgumentNullException(nameof(builder));
            builder.ConfigureServices(services => services.RegisterCode());
            return builder;
        }
    }
}

#endif