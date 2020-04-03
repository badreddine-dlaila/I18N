using System;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Default translation accessor
    /// </summary>
    public class DefaultTranslationAccessor : ITranslationAccessor {
        private readonly ITextProvider _textProvider;
        private readonly ILanguageServiceProvider _languageServiceProvider;

        private string _currentLanguageTag;

        /// <summary>
        /// Create a new instance of <see cref="DefaultTranslationAccessor"/>.
        /// </summary>
        /// <param name="textProvider"></param>
        /// <param name="languageServiceProvider"></param>
        /// <param name="currentLanguageTagFactory"></param>
        public DefaultTranslationAccessor(
            ITextProvider textProvider,
            ILanguageServiceProvider languageServiceProvider,
            ICoreScopedLanguageTagFactory currentLanguageTagFactory) {
            _textProvider = textProvider ?? throw new ArgumentNullException(nameof(textProvider));
            _languageServiceProvider = languageServiceProvider ?? throw new ArgumentNullException(nameof(languageServiceProvider));
            _currentLanguageTag = (currentLanguageTagFactory ?? throw new ArgumentNullException(nameof(currentLanguageTagFactory))).Get();
        }


        /// <inheritdoc />
        public ITextProvider Text => _textProvider;

        /// <inheritdoc />
        public ILanguageServiceProvider ServiceProvider => _languageServiceProvider;

        /// <inheritdoc />
        public string CurrentLanguageTag => _currentLanguageTag;
    }
}