using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Xml.Core {
    /// <summary>
    /// Base file adapter for Xml adapter
    /// </summary>
    /// <typeparam name="TTemplate"></typeparam>
    public abstract class BaseFileAdapter<TTemplate> : IFileAdapter, ISpeakAsXml<TTemplate>, IDisposable
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
                using var reader = XmlReader.Create(Path);
                var xs = new XmlSerializer(typeof(StandardLocalizationTemplate));
                SpeakCache = (TTemplate) xs.Deserialize(reader);
            }
            catch {
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        public virtual Task<bool> ProcessAsync() {
            return Task.FromResult(Process());
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