using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.Console.Core;

namespace Cosmos.I18N
{
    public static class DoneExtensions
    {
        public static void AllDone(this II18NServiceCollection services)
        {
            SoloDependencyContainer.AllDone(services);
        }
    }
}