using System;
using Cosmos.I18N.Adapters.Xml.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Xml
{
    public class AnonymousXmlFileAdapter : BaseFileAdapter<AnonymousLocalizationTemplate>
    {
        public AnonymousXmlFileAdapter(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }
    }
}