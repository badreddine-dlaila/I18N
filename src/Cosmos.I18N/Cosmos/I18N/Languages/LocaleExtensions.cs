using Cosmos.I18N.Core.Extensions;
using EnumsNET;

namespace Cosmos.I18N.Languages {
    /// <summary>
    /// Locale extensions
    /// </summary>
    public static class LocaleExtensions {
        /// <summary>
        /// Convert <see cref="Locale"/> to <see cref="LanguageTag"/>.
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        public static LanguageTag AsLanguageTag(this Locale locale) {
            return LanguageTagManager.Create(locale.GetLanguageTagText());
        }

        /// <summary>
        /// Convert <see cref="LanguageTag"/> to <see cref="Locale"/>.
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public static Locale AsLocale(this LanguageTag languageTag) {
            if (languageTag == null)
                languageTag = LanguageTag.Current;

            if (languageTag.Region.IsSet()) {
                if (EnumsNET.Enums.TryParse(
                    $"{languageTag.Language}_{languageTag.Region.ToUpperInvariant()}",
                    true,
                    out Locale locale1)) {
                    return locale1;
                }
            }

            return EnumsNET.Enums.TryParse(languageTag.Language, true, out Locale locale2)
                ? locale2
                : LanguageTag.DefaultLocale;
        }

        internal static string GetLanguageTagText(this Locale locale) {
            return locale.GetName().Replace("_", "-");
        }
    }
}