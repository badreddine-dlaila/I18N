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
        /// <param name="packageKey"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey)
        {
            return new Text(_translationProcessor, text, packageKey);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, parameters);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey, string languageTag)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey, string languageTag, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag, parameters);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey, ILanguageTag languageTag)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey, ILanguageTag languageTag, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag, parameters);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey, Locale locale)
        {
            return new Text(_translationProcessor, text, packageKey, locale);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey, Locale locale, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, locale, parameters);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider)
        {
            return new Text(_translationProcessor, text, packageKey)
            {
                CustomFormatProvider = formatProvider
            };
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, parameters)
            {
                CustomFormatProvider = formatProvider
            };
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider, string languageTag)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag)
            {
                CustomFormatProvider = formatProvider
            };
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider,
            string languageTag, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag, parameters)
            {
                CustomFormatProvider = formatProvider
            };
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider, ILanguageTag languageTag)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag)
            {
                CustomFormatProvider = formatProvider
            };
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider,
            ILanguageTag languageTag, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, languageTag, parameters)
            {
                CustomFormatProvider = formatProvider
            };
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider, Locale locale)
        {
            return new Text(_translationProcessor, text, packageKey, locale)
            {
                CustomFormatProvider = formatProvider
            };
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="locale"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IText Create(string text, string packageKey,
            Func<string, ILanguageTag, string, object[], string> formatProvider,
            Locale locale, params object[] parameters)
        {
            return new Text(_translationProcessor, text, packageKey, locale, parameters)
            {
                CustomFormatProvider = formatProvider
            };
        }

    }
}