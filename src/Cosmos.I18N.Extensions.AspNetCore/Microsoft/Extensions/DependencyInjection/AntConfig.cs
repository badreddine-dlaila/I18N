using System.Collections.Generic;
using Cosmos.I18N;

namespace Microsoft.Extensions.DependencyInjection {
    /// <summary>
    /// Language tag touch from
    /// </summary>
    public class AntConfig {
        private readonly List<(AntFrom, string[])> _holding = new List<(AntFrom, string[])>();

        /// <summary>
        /// Detect
        /// </summary>
        /// <param name="from"></param>
        /// <param name="antPosNames"></param>
        /// <returns></returns>
        public AntConfig For(AntFrom from, params string[] antPosNames) {
            _holding.Add((from, antPosNames));
            return this;
        }

        /// <summary>
        /// Configure the LanguageTag read from cookie
        /// </summary>
        /// <returns></returns>
        public AntConfig FromCookie() {
            return For(AntFrom.Cookie, AntPosNameConstants.LANGUAGE_TAG);
        }

        /// <summary>
        /// Configure the LanguageTag read from route
        /// </summary>
        /// <returns></returns>
        public AntConfig FromRoute() {
            return For(AntFrom.Route, AntPosNameConstants.CULTURE);
        }

        internal List<(AntFrom, string[])> GetAllAnts() => _holding;
    }
}