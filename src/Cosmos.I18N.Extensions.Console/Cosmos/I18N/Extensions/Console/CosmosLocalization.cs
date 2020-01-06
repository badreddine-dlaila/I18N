using Cosmos.I18N.Extensions.Console.Core;

namespace Cosmos.I18N.Extensions.Console {
    /// <summary>
    /// Cosmos localization helper
    /// </summary>
    public static class CosmosLocalization {
        /// <summary>
        /// Initialize
        /// </summary>
        /// <returns></returns>
        public static I18NServiceCollection Initialize() {
            return SoloDependencyContainer.Initialize(new I18NServiceCollection());
        }
    }
}