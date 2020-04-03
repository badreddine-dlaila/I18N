using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Hosted language tag factory
    /// </summary>
    public class HostedLanguageTagFactory : ICoreScopedLanguageTagFactory {
#if !NETSTANDARD2_1
        private readonly IRequestedLanguageTagAccessor _requestedLanguageTagAccessor;

        /// <summary>
        /// Create a new instance of <see cref="HostedLanguageTagFactory"/>.
        /// </summary>
        /// <param name="requestedAccessor"></param>
        public HostedLanguageTagFactory(IRequestedLanguageTagAccessor requestedAccessor) {
            _requestedLanguageTagAccessor = requestedAccessor;
        }
#endif
        /// <inheritdoc />
        public string Get(string antPosName = null) {
#if !NETSTANDARD2_1
            if (_requestedLanguageTagAccessor != null && _requestedLanguageTagAccessor.HasContext)
                return _requestedLanguageTagAccessor.Get(antPosName);
#endif
            return LanguageTag.Current.ToString();
        }
    }
}