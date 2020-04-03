using System;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Default language tag factory
    /// </summary>
    public class DefaultLanguageTagFactory : ICoreScopedLanguageTagFactory {
        private Func<string> _factoryImplFunc;

        /// <summary>
        /// Create a new instance of <see cref="DefaultLanguageTagFactory"/>.
        /// </summary>
        /// <param name="factoryImpl"></param>
        public DefaultLanguageTagFactory(Func<string> factoryImpl) {
            _factoryImplFunc = factoryImpl ?? LanguageTag.Current.ToString;
        }

        /// <summary>
        /// Get language tag
        /// </summary>
        /// <returns></returns>
        public string Get(string antPosName = null) => _factoryImplFunc();
    }
}