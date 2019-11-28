using System;
using System.Threading.Tasks;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;
using Newtonsoft.Json;

namespace Cosmos.I18N.Adapters.Json.Core
{
    public class BaseContentAdapter<TTemplate> : IContentAdapter<string>, ISpeakAsJson<TTemplate>, IDisposable
        where TTemplate : class, ILocalizationTemplate, new()
    {
        public string OriginContent { get; protected set; }

        protected TTemplate SpeakCache { get; set; }

        public bool Process()
        {
            try
            {
                SpeakCache = JsonConvert.DeserializeObject<TTemplate>(OriginContent);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public Task<bool> ProcessAsync()
        {
            return Task.FromResult(Process());
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