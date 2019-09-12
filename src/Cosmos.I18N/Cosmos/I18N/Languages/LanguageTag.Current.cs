namespace Cosmos.I18N.Languages
{
    public partial class LanguageTag
    {
        /// <summary>
        /// Get current language tag
        /// </summary>
        public static LanguageTag Current => GetCurrentLanguageTag();

        private static readonly string _defaultLangTag = EnumsNET.Enums.GetName(Locale.en_US);

        private static LanguageTag GetCurrentLanguageTag()
        {
            return LanguageTagManager.Get(_defaultLangTag);
        }
    }
}