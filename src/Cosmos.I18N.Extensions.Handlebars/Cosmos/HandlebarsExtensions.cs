using Cosmos.I18N.Core;
using Cosmos.I18N.Handlebars;
using HandlebarsDotNet;

namespace Cosmos
{
    public static class HandlebarsExtensions
    {
        public static II18NServiceCollection AddHandlebars(this II18NServiceCollection services)
        {
            Handlebars.RegisterHelper("T", TranslateHelperRegister.Register);

            return services;
        }
    }
}