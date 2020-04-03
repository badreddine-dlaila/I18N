using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using Cosmos.I18N.Core;
using Cosmos.I18N.Handlebars.Core;
using HandlebarsDotNet;

namespace Cosmos.I18N.Handlebars {
    /// <summary>
    /// Translate helper register
    /// </summary>
    public static class AnonymousHelperRegister {
        /// <summary>
        /// Anonymous helper Register
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="context"></param>
        /// <param name="arguments"></param>
        public static void Register(TextWriter writer, object context, params object[] arguments) {
            var textProvider = StaticInstanceForTextProvider.Instance;
            var (originalText, languageTag) = GetMetadata(arguments);

            var members = context.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var parameters = (
                from property in members
                where property.CanRead
                select context.GetPropertyValue(property.Name)
            ).ToArray();

            var text = textProvider.Anonymous(originalText, languageTag, parameters);

            writer.WriteSafeString(text);
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private static (string OriginalText, string LanguageTag) GetMetadata(object[] arguments) {
            var length = arguments.Length;
            string o, l;
            if (length == 0) {
                o = null;
                l = null;
            } else if (length == 1) {
                o = GetOriginalText(arguments);
                l = null;
            } else {
                // length >= 2
                o = GetOriginalText(arguments);
                var a1 = arguments[1] as string;
                if (LanguageTagCheckingCache.IsValid(a1)) {
                    l = a1;
                } else {
                    l = null;
                }
            }

            return (o, l);

            string GetOriginalText(object[] _arguments, int expectIndex = 0) {
                if (_arguments is null)
                    return null;
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