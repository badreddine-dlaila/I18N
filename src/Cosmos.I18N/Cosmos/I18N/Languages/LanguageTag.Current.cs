namespace Cosmos.I18N.Languages
{
    public partial class LanguageTag
    {
        /// <summary>
        /// Get current language tag
        /// </summary>
        public static LanguageTag Current => GetCurrentLanguageTag();

        /// <summary>
        /// Default locale string
        /// </summary>
        public static string DefaultLocaleStr = EnumsNET.Enums.GetName(DefaultLocale).Replace("_", "-");

        /// <summary>
        /// Default locale
        /// </summary>
        public static Locale DefaultLocale => _defaultLocale;


        private static Locale _defaultLocale = Locale.en_US;

        internal static void SetDefaultLocale(Locale locale)
        {
            _defaultLocale = locale;
        }

        private static LanguageTag GetCurrentLanguageTag()
        {
            return LanguageTagManager.Get(DefaultLocaleStr);
        }
    }
}