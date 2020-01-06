using System;
using Cosmos.I18N.Adapters.Xml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Xml {
    /// <summary>
    /// Xml file adapter
    /// </summary>
    public class XmlFileAdapter : BaseFileAdapter<StandardLocalizationTemplate> {
        /// <inheritdoc />
        public XmlFileAdapter(string path) {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }
    }
}