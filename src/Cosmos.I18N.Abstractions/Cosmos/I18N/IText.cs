using System;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N {
    /// <summary>
    /// Interface for text
    /// </summary>
    public interface IText {
        /// <summary>
        /// Gets or sets custom format provider
        /// </summary>
        Func<string, ILanguageTag, string, object[], string> CustomFormatProvider { get; set; }

        /// <summary>
        /// To string.
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}