using System;
using Cosmos.I18N.Adapters.Json.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Json {
    /// <summary>
    /// Anonymous json content adapter
    /// </summary>
    public class AnonymousJsonContentAdapter : BaseContentAdapter<AnonymousLocalizationTemplate> {
        /// <inheritdoc />
        public AnonymousJsonContentAdapter(string content) {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginalContent = content;
        }
    }
}