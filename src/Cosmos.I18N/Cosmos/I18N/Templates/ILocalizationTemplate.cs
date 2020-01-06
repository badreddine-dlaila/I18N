using System.Collections.Generic;

namespace Cosmos.I18N.Templates {
    /// <summary>
    /// Interface for localization template
    /// </summary>
    public interface ILocalizationTemplate {
        /// <summary>
        /// Belongs to package key
        /// </summary>
        string PackageKey { get; set; }

        /// <summary>
        /// Language tag
        /// </summary>
        string Language { get; set; }

        /// <summary>
        /// Name, also means resource name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Contents
        /// </summary>
        Dictionary<string, string> Contents { get; set; }
    }
}