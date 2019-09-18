using System;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N
{
    /// <summary>
    /// Interface for Text Provider
    /// </summary>
    public interface ITextProvider
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, params object[] parameters);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, string languageTag);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, string languageTag, params object[] parameters);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, ILanguageTag languageTag);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, ILanguageTag languageTag, params object[] parameters);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Locale locale);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Locale locale, params object[] parameters);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider, params object[] parameters);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider, string languageTag);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider, string languageTag, params object[] parameters);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider, ILanguageTag languageTag);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider, ILanguageTag languageTag, params object[] parameters);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider, Locale locale);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="formatProvider"></param>
        /// <param name="locale"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string packageKey, Func<string, ILanguageTag, string, object[], string> formatProvider, Locale locale, params object[] parameters);
    }
}