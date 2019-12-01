using System;
using Cosmos.I18N.Adapters.Json.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Json
{
    public class JsonContentAdapter : BaseContentAdapter<StandardLocalizationTemplate>
    {
        public JsonContentAdapter(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException(nameof(content));
            OriginContent = content;
        }
    }
}