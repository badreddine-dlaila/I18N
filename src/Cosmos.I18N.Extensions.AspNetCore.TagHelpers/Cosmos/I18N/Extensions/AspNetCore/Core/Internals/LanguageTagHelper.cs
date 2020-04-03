namespace Cosmos.I18N.Extensions.AspNetCore.Core.Internals {
    internal static class LanguageTagHelper {
        public static string MayLanguageTag(this IRequestedLanguageTagAccessor accessor, string languageTag,string languageTagBodyName = null) {
            return string.IsNullOrWhiteSpace(languageTag) ? accessor.Get(languageTagBodyName) : languageTag;
        }
    }
}