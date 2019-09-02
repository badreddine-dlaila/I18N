using System;
using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N
{
    /// <summary>
    /// Default text provider
    /// </summary>
    public class TextProvider : ITextProvider
    {
        private readonly TranslationProcessor _translationProcessor;

        /// <summary>
        /// Create a new instance of <see cref="TextProvider"/>
        /// </summary>
        /// <param name="translationProcessor"></param>
        public TextProvider(TranslationProcessor translationProcessor)
        {
            _translationProcessor = translationProcessor ?? throw new ArgumentNullException(nameof(translationProcessor));
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public IText Create(string text, string resourceKey, Locale language)
        {
            return new Text(_translationProcessor, text, resourceKey, language);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string resourceKey, Locale language, params object[] parameters)
        {
            return new Text(_translationProcessor, text, resourceKey, language, parameters);
        }
    }
}