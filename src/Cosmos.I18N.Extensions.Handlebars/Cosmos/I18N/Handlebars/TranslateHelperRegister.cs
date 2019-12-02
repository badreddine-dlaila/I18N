using System.Collections.Generic;
using System.IO;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;
using HandlebarsDotNet;

namespace Cosmos.I18N.Handlebars
{
    public static class TranslateHelperRegister
    {
        public static void Register(TextWriter writer, object context, params object[] arguments)
        {
            var textProvider = StaticInstanceForTextProvider.Instance;
            var originalText = arguments[0] as string;

            string packageKey = null;
            if (arguments.Length > 1)
                packageKey = arguments[1] as string;
            if (string.IsNullOrWhiteSpace(packageKey))
                packageKey = TranslationManager.ANONYMOUS_PACKAGE_KEY;

            string languageTag = null;
            if (arguments.Length > 2)
                languageTag = arguments[2] as string;

            var parameters = new List<object>();
            if (arguments.Length > 3)
            {
                for (var i = 3; i < arguments.Length; i++)
                    parameters.Add(arguments[i]);
            }

            var text = textProvider.Create(originalText, packageKey, languageTag, parameters?.ToArray());

            writer.WriteSafeString(text);
        }
    }
}