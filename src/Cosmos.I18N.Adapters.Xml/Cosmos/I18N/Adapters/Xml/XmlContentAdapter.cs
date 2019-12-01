using System;
using Cosmos.I18N.Adapters.Xml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Xml
{
    public class XmlContentAdapter : BaseContentAdapter<StandardLocalizationTemplate>
    {
        public XmlContentAdapter(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginContent = content;
        }
    }
}