using System;
using System.Threading;

#if NET451
#endif

namespace Cosmos.I18N.Languages {
    public partial class LanguageTag {

        #region Default locale

        /// <summary>
        /// Default locale string
        /// </summary>
        public static string DefaultLocaleStr { get; private set; }
            = EnumsNET.Enums.GetName(Locale.en_US).Replace("_", "-");

        /// <summary>
        /// Default locale
        /// </summary>
        public static Locale DefaultLocale { get; private set; }
            = Locale.en_US;

        internal static void SetDefaultLocale(Locale locale) {
            DefaultLocale = locale;
            DefaultLocaleStr = EnumsNET.Enums.GetName(locale).Replace("_", "-");
        }

        #endregion

        #region Current LanguageTag

        /// <summary>
        /// Get current language tag
        /// </summary>
        public static LanguageTag Current => GetCurrentLanguageTag();

        private static AsyncLocal<string> _currentAsyncLocalLanguageTag = new AsyncLocal<string>();

        internal static void SetCurrentLanguageTagChangedHandler(Action<AsyncLocalValueChangedArgs<string>> handler) {
            _currentAsyncLocalLanguageTag = new AsyncLocal<string>(handler);
        }

        internal static void SetCurrentLanguageTag(string languageTag) {
            if (string.IsNullOrWhiteSpace(languageTag))
                _currentAsyncLocalLanguageTag.Value = DefaultLocaleStr;
            else
                _currentAsyncLocalLanguageTag.Value = languageTag;
        }

        private static LanguageTag GetCurrentLanguageTag() {
            var tag = _currentAsyncLocalLanguageTag.Value;

            if (string.IsNullOrWhiteSpace(tag))
                tag = DefaultLocaleStr;

            var ret = LanguageTagManager.Get(tag);

            if (ret == null) {
                SetCurrentLanguageTag(DefaultLocaleStr);
                ret = LanguageTagManager.Create(DefaultLocaleStr);
            }

            return ret;
        }

        #endregion

    }
}