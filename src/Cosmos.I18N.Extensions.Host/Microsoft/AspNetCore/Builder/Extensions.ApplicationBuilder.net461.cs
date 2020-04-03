#if NET461

using System;
using Cosmos.I18N;
using Cosmos.I18N.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Builder {
    /// <summary>
    /// Application builder extensions
    /// </summary>
    public static class ApplicationBuilderExtensions {
        /// <summary>
        /// Use cosmos localization
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseCosmosLocalization(this IApplicationBuilder builder) {

            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            var resolver = builder.ApplicationServices;

            StaticInstanceForILanguageServiceProvider.SetInstance(resolver.GetRequiredService<ILanguageServiceProvider>());
            StaticInstanceForTextProvider.SetInstance(resolver.GetRequiredService<ITextProvider>());

            return builder;
        }
    }
}

#endif