using System;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Static instance for language service provider
    /// </summary>
    public class StaticInstanceForTextProvider {
        /// <summary>
        /// Instance
        /// </summary>
        // ReSharper disable once InconsistentNaming
        private static ITextProvider _instance { get; set; }

        /// <summary>
        /// Sets instance
        /// </summary>
        /// <param name="textProvider"></param>
        public static void SetInstance(ITextProvider textProvider) {
            _instance = textProvider ?? throw new ArgumentNullException(nameof(textProvider));
        }

        /// <summary>
        /// Gets instance
        /// </summary>
        public static ITextProvider Instance => _instance;
    }
}