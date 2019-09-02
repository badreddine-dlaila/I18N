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
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        IText Create(string text, string resourceKey, Locale language);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="text"></param>
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IText Create(string text, string resourceKey, Locale language, params object[] parameters);
    }
}