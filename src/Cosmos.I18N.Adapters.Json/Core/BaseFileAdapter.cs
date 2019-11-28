using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;
using Newtonsoft.Json;

namespace Cosmos.I18N.Adapters.Json.Core
{
    public abstract class BaseFileAdapter<TTemplate> : IFileAdapter, ISpeakAsJson<TTemplate>, IDisposable
        where TTemplate : class, ILocalizationTemplate, new()
    {
        public string Path { get; protected set; }
        protected TTemplate SpeakCache { get; set; }

        public virtual bool Process()
        {
            try
            {
                if (!File.Exists(Path)) throw new InvalidOperationException($"Failed to read file '{Path}'.");
                var text = File.ReadAllText(Path);
                SpeakCache = JsonConvert.DeserializeObject<TTemplate>(text);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public virtual Task<bool> ProcessAsync()
        {
            return Task.FromResult(Process());
        }

        public TTemplate Speak()
        {
            return SpeakCache ?? throw new InvalidOperationException($"Failed to read file '{Path}'.");
        }

        private bool _disposed;

        public void Dispose()
        {
            if (_disposed) return;

            Path = null;
            SpeakCache = null;

            _disposed = true;
        }
    }
}