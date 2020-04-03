using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.Console.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N {
    /// <summary>
    /// Extensions for done
    /// </summary>
    public static class DoneExtensions {
        /// <summary>
        /// ALl done
        /// </summary>
        /// <param name="services"></param>
        public static void AllDone(this II18NServiceCollection services) {
            SoloDependencyContainer.AllDone(services);
        }
    }
}