using System;
using Cosmos.I18N.Core;

namespace Cosmos.I18N.Extensions.DependencyInjection.Core
{
    public class StaticProviderHack
    {
        public StaticProviderHack(ILanguageServiceProvider languageServiceProvider)
        {
            if (languageServiceProvider == null) throw new ArgumentNullException(nameof(languageServiceProvider));
            StaticInstanceForILanguageServiceProvider.SetInstance(languageServiceProvider);
        }
    }
}