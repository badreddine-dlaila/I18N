using System;
using Cosmos.I18N.Adapters.Json.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Json {
    /// <summary>
    /// Json file adapter
    /// </summary>
    public class JsonFileAdapter : BaseFileAdapter<StandardLocalizationTemplate> {
        /// <inheritdoc />
        public JsonFileAdapter(string path) {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }
    }
}