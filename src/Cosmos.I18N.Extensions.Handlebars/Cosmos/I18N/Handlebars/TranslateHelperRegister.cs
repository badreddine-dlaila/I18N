using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using Cosmos.I18N.Core;
using Cosmos.I18N.Handlebars.Core;
using Cosmos.I18N.Translation;
using HandlebarsDotNet;

namespace Cosmos.I18N.Handlebars {
    /// <summary>
    /// Translate helper register
    /// </summary>
    public static class TranslateHelperRegister {
        /// <summary>
        /// Register
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="context"></param>
        /// <param name="arguments"></param>
        public static void Register(TextWriter writer, object context, params object[] arguments) {
            var textProvider = StaticInstanceForTextProvider.Instance;
            var (originalText, packageKey, languageTag) = GetMetadata(arguments);

            var members = context.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var parameters = (
                from property in members
                where property.CanRead
                select context.GetPropertyValue(property.Name)
            ).ToArray();

            var text = textProvider.Create(originalText, packageKey, languageTag, parameters);

            writer.WriteSafeString(text);
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private static (string OriginalText, string PackageKey, string LanguageTag) GetMetadata(object[] arguments) {
            var length = arguments.Length;
            string o, p, l;
            if (length == 0) {
                o = null;
                p = null;
                l = null;
            } else if (length == 1) {
                o = GetOriginalText(arguments);
                p = null;
                l = null;
            } else if (length == 2) {
                o = GetOriginalText(arguments);
                var a1 = arguments[1] as string;
                if (LanguageTagCheckingCache.IsValid(a1)) {
                    p = TranslationManager.ANONYMOUS_PACKAGE_KEY;
                    l = a1;
                } else {
                    p = a1;
                    l = null;
                }
            } else {
                // length >= 3
                o = GetOriginalText(arguments);
                p = GetPackageKey(arguments);
                l = GetLanguageTag(arguments);
            }

            return (o, p, l);

            string GetOriginalText(object[] _arguments, int expectIndex = 0) {
                if (_arguments is null)
                    return null;
                return GetExpectArg(_arguments, expectIndex);
            }

            string GetPackageKey(object[] _arguments, int expectIndex = 1) {
                string packageKey = GetExpectArg(_arguments, expectIndex);
                if (string.IsNullOrWhiteSpace(packageKey))
                    packageKey = TranslationManager.ANONYMOUS_PACKAGE_KEY;
                return packageKey;
            }

            string GetLanguageTag(object[] _arguments, int expectIndex = 2) {
                return GetExpectArg(_arguments, expectIndex);
            }

            string GetExpectArg(object[] _arguments, int expectIndex) {
                if (expectIndex < 0)
                    return null;
                if (_arguments.Length > expectIndex)
                    return _arguments[expectIndex] as string;
                return null;
            }
        }
    }
}