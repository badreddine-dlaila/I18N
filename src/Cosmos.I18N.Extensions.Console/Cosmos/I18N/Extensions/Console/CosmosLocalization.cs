using Cosmos.I18N.Extensions.Console.Core;

namespace Cosmos.I18N.Extensions.Console
{
    public static class CosmosLocalization
    {
        public static I18NServiceCollection Initialize()
        {
            return SoloDependencyContainer.Initialize(new I18NServiceCollection());
        }
    }
}