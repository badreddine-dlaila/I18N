using System;
using Cosmos.I18N.Adapters.Json.Core;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Json
{
    public class AnonymousJsonFileAdapter : BaseFileAdapter<AnonymousLocalizationTemplate>
    {
        public AnonymousJsonFileAdapter(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }
    }
}