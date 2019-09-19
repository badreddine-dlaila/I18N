using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Bridges.AbpBridge.I18N;
using Cosmos.I18N.Adapters.Formats;
using Cosmos.I18N.Templates;
using Newtonsoft.Json;

namespace Cosmos.I18N.Adapters.Json
{
    /// <summary>
    /// Abp Json file adapter
    /// </summary>
    public class AbpJsonFileAdapter : IFileAdapter, ISpeakAsJson<AnonymousLocalizationTemplate>, IDisposable
    {
        /// <summary>
        /// Create a new instance of <see cref="AbpJsonFileAdapter"/>
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AbpJsonFileAdapter(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            Path = path;
        }

        /// <summary>
        /// Path
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// Process
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public bool Process()
        {
            try
            {
                if (!File.Exists(Path))
                    throw new InvalidOperationException($"Failed to read file '{Path}'.");

                if (!CanParseFile(Path))
                    return false;

                var text = File.ReadAllText(Path);
                var abpVirtualJson = JsonConvert.DeserializeObject<AbpFormatResource>(text);
                SpeakCache = abpVirtualJson.SpeakInCosmos() as AnonymousLocalizationTemplate;
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Process async
        /// </summary>
        /// <returns></returns>
        public Task<bool> ProcessAsync()
        {
            return Task.FromResult(Process());
        }

        private static bool CanParseFile(string filePath)
        {
            var file = new FileInfo(filePath);
            return file.Name.EndsWith(".json", StringComparison.OrdinalIgnoreCase);
        }

        private AnonymousLocalizationTemplate SpeakCache { get; set; }

        /// <summary>
        /// Speak
        /// </summary>
        /// <returns></returns>
        public AnonymousLocalizationTemplate Speak()
        {
            return SpeakCache ?? throw new InvalidOperationException($"Failed to read file '{Path}'.");
        }


        private bool _disposed;

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            if (_disposed) return;

            Path = null;
            SpeakCache = null;

            _disposed = true;
        }
    }
}