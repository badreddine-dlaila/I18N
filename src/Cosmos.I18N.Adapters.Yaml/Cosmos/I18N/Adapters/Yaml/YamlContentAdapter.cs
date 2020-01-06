using System;
using Cosmos.I18N.Adapters.Yaml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Yaml {
    /// <summary>
    /// Yaml content adapter
    /// </summary>
    public class YamlContentAdapter : BaseContentAdapter<StandardLocalizationTemplate> {
        /// <inheritdoc />
        public YamlContentAdapter(string content) {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginalContent = content;
        }
    }
}