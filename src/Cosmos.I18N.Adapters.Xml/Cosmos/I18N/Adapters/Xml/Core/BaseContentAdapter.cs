using System;
using System.Threading.Tasks;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;
using Cosmos.Serialization.Xml;

namespace Cosmos.I18N.Adapters.Xml.Core {
    /// <summary>
    /// Base content adapter for Xml adapter
    /// </summary>
    /// <typeparam name="TTemplate"></typeparam>
    public class BaseContentAdapter<TTemplate> : IContentAdapter<string>, ISpeakAsXml<TTemplate>, IDisposable
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
                SpeakCache = OriginalContent.FromXml<TTemplate>();
            }
            catch {
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        public virtual async Task<bool> ProcessAsync() {
            try {
                SpeakCache = await OriginalContent.FromXmlAsync<TTemplate>();
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