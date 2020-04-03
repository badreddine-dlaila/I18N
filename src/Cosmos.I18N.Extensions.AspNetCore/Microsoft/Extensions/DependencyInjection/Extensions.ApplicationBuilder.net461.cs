#if NET461

using System;
using Cosmos.I18N;
using Cosmos.I18N.Core;
using Microsoft.AspNetCore.Builder;

namespace Microsoft.Extensions.DependencyInjection {
    /// <summary>
    /// Application builder extensions
    /// </summary>
    public static class ApplicationBuilderExtensions {
        /// <summary>
        /// Use Cosmos I18N
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="antConfigure"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IApplicationBuilder UseCosmosLocalization(this IApplicationBuilder builder, Action<AntConfig> antConfigure) {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            var antConfig = new AntConfig();
            antConfigure?.Invoke(antConfig);

            builder.UseCosmosLocalization();

            AntHooks.Insert(antConfig.GetAllAnts());

            builder.UseMiddleware<ScopedLanguageTagMiddleware>();

            return builder;
        }
    }
}

#endif