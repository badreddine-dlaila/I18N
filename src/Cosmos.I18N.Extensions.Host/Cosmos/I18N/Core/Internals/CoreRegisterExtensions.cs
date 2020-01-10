using System;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Core.Internals {
    internal static class CoreRegisterExtensions {
        public static void RegisterCode(this IServiceCollection services, Action<II18NServiceCollection> config = null) {

#if NET451 || NET461 || NETSTANDARD2_0 || NETCOREAPP3_1
            services.AddCosmosLocalization(
                config,
                service => service.AddDependency(s => s.AddScoped<IRequestedLanguageTagAccessor, RequestedLanguageTagAccessor>()));
#else
            services.AddCosmosLocalization(config);
#endif
        }
    }
}