using System;
using Cosmos.I18N.Adapters.Yaml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Yaml {
    /// <summary>
    /// Anonymous json file adapter
    /// </summary>
    public class AnonymousYamlFileAdapter : BaseFileAdapter<AnonymousLocalizationTemplate> {
        /// <inheritdoc />
        public AnonymousYamlFileAdapter(string path) {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }
    }
}