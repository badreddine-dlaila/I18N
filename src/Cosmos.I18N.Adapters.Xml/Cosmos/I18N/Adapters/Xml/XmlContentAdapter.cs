using System;
using Cosmos.I18N.Adapters.Xml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Xml {
    /// <summary>
    /// Xml content adapter
    /// </summary>
    public class XmlContentAdapter : BaseContentAdapter<StandardLocalizationTemplate> {
        /// <inheritdoc />
        public XmlContentAdapter(string content) {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginalContent = content;
        }
    }
}