using System;
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
        /// <param name="withMiddleware"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IApplicationBuilder UseCosmosLocalization(this IApplicationBuilder builder, bool withMiddleware) {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.UseCosmosLocalization();

            if (withMiddleware) {
                builder.UseMiddleware<ScopedLanguageTagMiddleware>();
            }

            return builder;
        }
    }
}