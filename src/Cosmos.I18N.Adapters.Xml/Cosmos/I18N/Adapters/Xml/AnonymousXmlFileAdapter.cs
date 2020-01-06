using System;
using Cosmos.I18N.Adapters.Xml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Xml {
    /// <summary>
    /// Anonymous xml file adapter
    /// </summary>
    public class AnonymousXmlFileAdapter : BaseFileAdapter<AnonymousLocalizationTemplate> {
        /// <inheritdoc />
        public AnonymousXmlFileAdapter(string path) {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }
    }
}