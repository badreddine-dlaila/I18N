using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core.Internals;

namespace Cosmos.I18N {
    /// <summary>
    /// Language tag ant, a wrapper of Language tag getter
    /// </summary>
    internal class Ant {
        /// <summary>
        /// Get language tag from
        /// </summary>
        public AntFrom From { get; }

        private List<string> _antPosNames;

        /// <summary>
        /// Get readonly body names
        /// </summary>
        public IReadOnlyList<string> AntPosNames => _antPosNames;

        /// <summary>
        /// Language tag ant
        /// </summary>
        /// <param name="from"></param>
        /// <param name="antPosNames"></param>
        public Ant(AntFrom from, params string[] antPosNames) {
            From = from;

            _antPosNames = new List<string>();

            if (antPosNames is null || antPosNames.Length == 0)
                _antPosNames.Add(AntPosNameConstants.LANGUAGE_TAG);
            else {
                _antPosNames.AddRange(antPosNames.Distinct());
            }
        }

        public Ant Next { get; set; }
    }
}