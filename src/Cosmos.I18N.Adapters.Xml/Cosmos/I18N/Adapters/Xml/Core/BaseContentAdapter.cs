using System;
using System.Threading.Tasks;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;
using Cosmos.Serialization.Xml;

namespace Cosmos.I18N.Adapters.Xml.Core
{
    public class BaseContentAdapter<TTemplate> : IContentAdapter<string>, ISpeakAsXml<TTemplate>, IDisposable
        where TTemplate : class, ILocalizationTemplate, new()
    {
        public string OriginContent { get; protected set; }

        protected TTemplate SpeakCache { get; set; }

        public virtual bool Process()
        {
            try
            {
                SpeakCache = OriginContent.FromXml<TTemplate>();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public virtual async Task<bool> ProcessAsync()
        {
            try
            {
                SpeakCache = await OriginContent.FromXmlAsync<TTemplate>();
            }
            catch
            {
                return false;
            }

            return true;
        }


        public TTemplate Speak()
        {
            return SpeakCache ?? throw new InvalidOperationException("Failed to deserialize origin context.");
        }

        private bool _disposed;

        public void Dispose()
        {
            if (_disposed) return;

            OriginContent = null;
            SpeakCache = null;

            _disposed = true;
        }
    }
}