namespace Cosmos.I18N.Languages
{
    internal static class LanguageTagExtensions
    {
        public static bool IsValid(this ILanguageTag languageTag) => languageTag != null && languageTag.GetLanguage() != null;
    }
}