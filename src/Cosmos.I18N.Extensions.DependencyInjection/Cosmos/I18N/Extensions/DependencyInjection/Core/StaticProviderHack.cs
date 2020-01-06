using System;
using Cosmos.I18N.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Extensions.DependencyInjection.Core {
    internal class StaticProviderHack {
        public StaticProviderHack(IServiceProvider provider) {
            if (provider == null) throw new ArgumentNullException(nameof(provider));
            StaticInstanceForILanguageServiceProvider.SetInstance(provider.GetRequiredService<ILanguageServiceProvider>());
            StaticInstanceForTextProvider.SetInstance(provider.GetRequiredService<ITextProvider>());
        }

        public static StaticProviderHack New(IServiceProvider provider) {
            return new StaticProviderHack(provider);
        }
    }
}