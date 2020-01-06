using System;
using Cosmos.I18N.Adapters.Json.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Json {
    /// <summary>
    /// Json content adapter
    /// </summary>
    public class JsonContentAdapter : BaseContentAdapter<StandardLocalizationTemplate> {
        /// <inheritdoc />
        public JsonContentAdapter(string content) {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginalContent = content;
        }
    }
}