using System;
using System.Threading;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// LanguageTag core manager
    /// </summary>
    public static class LanguageTagCoreManager
    {
        /// <summary>
        /// Update Current LanguageTag Changed handler
        /// </summary>
        /// <param name="languageTagChangedHandler"></param>
        public static void UpdateTagChangedHandler(Action<AsyncLocalValueChangedArgs<string>> languageTagChangedHandler)
        {
            if (languageTagChangedHandler == null)
                LanguageTag.SetCurrentLanguageTagChangedHandler(args => { });
            else
                LanguageTag.SetCurrentLanguageTagChangedHandler(languageTagChangedHandler);
        }

        /// <summary>
        /// Update Current LanguageTag
        /// </summary>
        /// <param name="languageTag"></param>
        public static void UpdateTag(string languageTag)
        {
            LanguageTag.SetCurrentLanguageTag(languageTag);
        }
    }
}