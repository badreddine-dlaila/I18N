using System.Collections.Generic;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Templates {
    /// <summary>
    /// Anonymous Localization Template
    /// </summary>
    public class AnonymousLocalizationTemplate : ILocalizationTemplate {
        /// <summary>
        /// Create a new instance of <see cref="AnonymousLocalizationTemplate"/>
        /// </summary>
        public AnonymousLocalizationTemplate() { }

        /// <summary>
        /// Create a new instance of <see cref="AnonymousLocalizationTemplate"/>
        /// </summary>
        /// <param name="language"></param>
        /// <param name="contents"></param>
        public AnonymousLocalizationTemplate(string language, Dictionary<string, string> contents) {
            Language = language;
            Contents = contents;
        }

        /// <summary>
        /// Belongs to package key
        /// </summary>
        public string PackageKey { get; set; } = TranslationManager.ANONYMOUS_PACKAGE_KEY;

        /// <summary>
        /// Language tag
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Name, also means resource name.
        /// </summary>
        public string Name { get; set; } = TranslationManager.ANONYMOUS_RESOURCE_NAME;

        /// <summary>
        /// Contents
        /// </summary>
        public Dictionary<string, string> Contents { get; set; } = new Dictionary<string, string>();

        internal bool CheckMySelf() {
            if (string.IsNullOrWhiteSpace(PackageKey) || PackageKey != TranslationManager.ANONYMOUS_PACKAGE_KEY)
                return false;

            if (string.IsNullOrWhiteSpace(Name) || Name != TranslationManager.ANONYMOUS_RESOURCE_NAME)
                return false;

            return true;
        }
    }
}