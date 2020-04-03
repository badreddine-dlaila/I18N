using System;
using Cosmos.Extensions.Dependency;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Core.Internals {
    internal static class CoreRegisterExtensions {
        public static StandardI18NServiceCollection AddCosmosLocalizationServices(this IServiceCollection services, Action<I18NOptions> optionAct = null) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));
            return (StandardI18NServiceCollection) services.AddCosmosLocalization(optionAct);
        }

        public static void AppendOrOverride(this II18NServiceCollection services) {
            services.AddDependency(s => {
                s.AddSingleton<ICoreScopedLanguageTagFactory, HostedLanguageTagFactory>();
                s.AddScoped<IRequestedLanguageTagAccessor, RequestedLanguageTagAccessor>();
            });
        }

        public static void UpdateState(this StandardI18NServiceCollection services) {
            services.AddPostRegisterAction("FlagState", s => {
                StaticFlag.HasInit = true;
                StaticFlag.ExpectedServiceName = "HostImpl";
            });

        }
    }
}