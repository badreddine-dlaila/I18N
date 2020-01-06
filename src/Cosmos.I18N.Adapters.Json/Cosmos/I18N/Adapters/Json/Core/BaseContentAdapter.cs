using System;
using System.Threading.Tasks;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;
using Cosmos.Serialization.Json;

namespace Cosmos.I18N.Adapters.Json.Core {
    /// <summary>
    /// Base content adapter for Json adapter
    /// </summary>
    /// <typeparam name="TTemplate"></typeparam>
    public class BaseContentAdapter<TTemplate> : IContentAdapter<string>, ISpeakAsJson<TTemplate>, IDisposable
        where TTemplate : class, ILocalizationTemplate, new() {
        /// <inheritdoc />
        public string OriginalContent { get; protected set; }

        /// <summary>
        /// Speak cache
        /// </summary>
        protected TTemplate SpeakCache { get; set; }

        /// <inheritdoc />
        public virtual bool Process() {
            try {
                SpeakCache = OriginalContent.FromJson<TTemplate>();
            }
            catch {
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        public virtual async Task<bool> ProcessAsync() {
            try {
                SpeakCache = await OriginalContent.FromJsonAsync<TTemplate>();
            }
            catch {
                return false;
            }

            return true;
        }


        /// <inheritdoc />
        public TTemplate Speak() {
            return SpeakCache ?? throw new InvalidOperationException("Failed to deserialize origin context.");
        }

        private bool _disposed;

        /// <inheritdoc />
        public void Dispose() {
            if (_disposed) return;

            OriginalContent = null;
            SpeakCache = null;

            _disposed = true;
        }
    }
}