using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;
using Cosmos.Serialization.Json;

namespace Cosmos.I18N.Adapters.Json.Core {
    /// <summary>
    /// Base file adapter for Json adapter
    /// </summary>
    /// <typeparam name="TTemplate"></typeparam>
    public abstract class BaseFileAdapter<TTemplate> : IFileAdapter, ISpeakAsJson<TTemplate>, IDisposable
        where TTemplate : class, ILocalizationTemplate, new() {
        /// <inheritdoc />
        public string Path { get; protected set; }

        /// <summary>
        /// Speak cache
        /// </summary>
        protected TTemplate SpeakCache { get; set; }

        /// <inheritdoc />
        public virtual bool Process() {
            try {
                CheckFile();
                var text = File.ReadAllText(Path);
                SpeakCache = text.FromJson<TTemplate>();
            }
            catch {
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        public virtual async Task<bool> ProcessAsync() {
            try {
                CheckFile();
                var text = File.ReadAllText(Path);
                SpeakCache = await text.FromJsonAsync<TTemplate>();
            }
            catch {
                return false;
            }

            return true;
        }

        private void CheckFile() {
            if (!File.Exists(Path))
                throw new InvalidOperationException($"Failed to read file '{Path}'.");
        }

        /// <inheritdoc />
        public TTemplate Speak() {
            return SpeakCache ?? throw new InvalidOperationException($"Failed to read file '{Path}'.");
        }

        private bool _disposed;

        /// <inheritdoc />
        public void Dispose() {
            if (_disposed) return;

            Path = null;
            SpeakCache = null;

            _disposed = true;
        }
    }
}