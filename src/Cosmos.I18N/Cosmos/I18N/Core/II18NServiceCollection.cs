using System;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Languages;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Interface of i18n service collection
    /// </summary>
    public interface II18NServiceCollection
    {
        /// <summary>
        /// Exposes options
        /// </summary>
        I18NOptions ExposeOptions { get; }

        /// <summary>
        /// Exposed language manager
        /// </summary>
        LanguageManager ExposeLanguageManager { get; }

        /// <summary>
        /// Append option action
        /// </summary>
        /// <param name="optionsAct"></param>
        /// <returns></returns>
        II18NServiceCollection AppendOptionsAction(Action<I18NOptions> optionsAct);

        /// <summary>
        /// Append dependency
        /// </summary>
        /// <param name="servicesAction"></param>
        /// <returns></returns>
        II18NServiceCollection AddDependency(Action<IServiceCollection> servicesAction);

        /// <summary>
        /// Build
        /// </summary>
        /// <returns></returns>
        IServiceProvider Build();

        /// <summary>
        /// Before build
        /// </summary>
        /// <param name="serviceAct"></param>
        void BeforeBuild(Action<IServiceCollection> serviceAct);

        /// <summary>
        /// After build
        /// </summary>
        /// <param name="providerAct"></param>
        void AfterBuild(Action<IServiceProvider> providerAct);
    }
}