using System;
using Autofac;
using Cosmos.I18N;
using Cosmos.I18N.Core;

namespace Cosmos.Extensions.Autofac.Core
{
    internal class StaticProviderHack
    {
        public StaticProviderHack(IComponentContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            StaticInstanceForILanguageServiceProvider.SetInstance(context.Resolve<ILanguageServiceProvider>());
            StaticInstanceForTextProvider.SetInstance(context.Resolve<ITextProvider>());
        }

        public static StaticProviderHack New(IComponentContext context)
        {
            return new StaticProviderHack(context);
        }
    }
}