using System;

namespace Cosmos.I18N.Countries {
    /// <summary>
    /// Historical metadata
    /// </summary>
    public readonly struct HistoricalMetadata {
        /// <summary>
        /// Create a new instance of <see cref="HistoricalMetadata"/>
        /// </summary>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public HistoricalMetadata(int since, int? until) {
            if (until.HasValue && since > until)
                throw new ArgumentOutOfRangeException(nameof(since), "The value of since must be less than or equals to the value of until.");
            Since = since;
            Until = until;
        }

        /// <summary>
        /// Since
        /// </summary>
        public int Since { get; }

        /// <summary>
        /// Until
        /// </summary>
        public int? Until { get; }
    }
}