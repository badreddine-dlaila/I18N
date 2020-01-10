using Cosmos.I18N.Core;
using Cosmos.I18N.Handlebars;
using HandlebarsDotNet;

namespace Cosmos {
    /// <summary>
    /// Extensions for Handlebars
    /// </summary>
    public static class HandlebarsExtensions {
        /// <summary>
        /// Add handlebars for Cosmos.I18N
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static II18NServiceCollection AddHandlebars(this II18NServiceCollection services) {
            Handlebars.RegisterHelper("A", AnonymousHelperRegister.Register);
            Handlebars.RegisterHelper("T", TranslateHelperRegister.Register);

            return services;
        }
    }
}