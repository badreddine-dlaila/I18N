using System.Collections.Generic;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Templates
{
    /// <summary>
    /// Standard Localization Template
    /// </summary>
    public class StandardLocalizationTemplate : ILocalizationTemplate
    {
        /// <summary>
        /// Belongs to package key
        /// </summary>
        public string PackageKey{get; set; }
        
        /// <summary>
        /// Language tag
        /// </summary>
        public string Language { get; set; }
        
        /// <summary>
        /// Name, also means resource name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contents
        /// </summary>
        public Dictionary<string, string> Contents { get; set; } = new Dictionary<string, string>();
    }
}