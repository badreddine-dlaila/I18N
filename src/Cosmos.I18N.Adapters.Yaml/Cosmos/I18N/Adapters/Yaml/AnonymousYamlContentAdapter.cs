using System;
using Cosmos.I18N.Adapters.Yaml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Yaml {
    /// <summary>
    /// Anonymous Yaml content adapter
    /// </summary>
    public class AnonymousYamlContentAdapter : BaseContentAdapter<AnonymousLocalizationTemplate> {
        /// <inheritdoc />
        public AnonymousYamlContentAdapter(string content) {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginalContent = content;
        }
    }
}