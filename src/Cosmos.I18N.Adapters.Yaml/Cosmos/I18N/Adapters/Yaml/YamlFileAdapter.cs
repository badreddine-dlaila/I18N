using System;
using Cosmos.I18N.Adapters.Yaml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Yaml {
    /// <summary>
    /// Yaml file adapter
    /// </summary>
    public class YamlFileAdapter : BaseFileAdapter<StandardLocalizationTemplate> {
        /// <inheritdoc />
        public YamlFileAdapter(string path) {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }
    }
}