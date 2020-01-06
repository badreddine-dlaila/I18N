using System;
using Cosmos.I18N.Adapters.Xml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Xml {
    /// <summary>
    /// Anonymous xml content adapter
    /// </summary>
    public class AnonymousXmlContentAdapter : BaseContentAdapter<AnonymousLocalizationTemplate> {
        /// <inheritdoc />
        public AnonymousXmlContentAdapter(string content) {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginalContent = content;
        }
    }
}