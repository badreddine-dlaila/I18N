using System;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Translation;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Interface of i18n service collection
    /// </summary>
    public interface II18NServiceCollection {
        /// <summary>
        /// Exposes options
        /// </summary>
        I18NOptions ExposeOptions { get; }

        /// <summary>
        /// Exposed translation manager
        /// </summary>
        TranslationManager ExposeTranslationManager { get; }

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
    }
}