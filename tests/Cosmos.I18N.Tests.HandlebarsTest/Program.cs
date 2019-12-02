using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cosmos.I18N.Adapters.Json;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.Console;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;
using HandlebarsDotNet;

namespace Cosmos.I18N.Tests.HandlebarsTest
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {

            try
            {
                CosmosLocalization.Initialize()
                    .ToGlobal(c => c.SetPathBase(Directory.GetCurrentDirectory()).SetPathSegment("Resources/I18N"))
                    .AddJsonResourceFrom("Main.*")
                    .AddJsonAnonymousResourceFrom()
                    .AddHandlebars()
                    .AllDone();

                var now = DateTime.Now;
                Console.WriteLine("Handlebars =====================");
                var template = @"{{T 'Hello world {0}', 'Main', 'zh-CN', now}}";

                var compiledTemplate = HandlebarsDotNet.Handlebars.Compile(template);
                var context = new {Parameters = new List<object> {DateTime.Now}};
                var result = compiledTemplate(context);
                Console.WriteLine(result);

//                Console.WriteLine("Basic =========================");
//
//                Console.WriteLine(new Text("Hello world {0}", "Main", "zh-CN", DateTime.Now));
//                Console.WriteLine(new Text("Hello world {0}", "Main", "en-US", DateTime.Now));
//                Console.WriteLine(new Text("Hello world {0}", "Main", "en-GB", DateTime.Now));
//
//                Console.WriteLine("Current LanguageTag ===========");
//
//                Console.WriteLine(new Text("Hello world {0}", "Main", DateTime.Now)); //en-US
//                LanguageTagCoreManager.UpdateTag("zh-CN");
//                Console.WriteLine(new Text("Hello world {0}", "Main", DateTime.Now)); //zh-CN
//
//                Console.WriteLine("Fallback LanguageTag ==========");
//                Console.WriteLine(new Text("Hello world {0}", "Main", "en-CA", DateTime.Now));
//
//                Console.WriteLine("Update Current LanguageTag handler");
//                LanguageTagCoreManager.UpdateTagChangedHandler(DisplayNewLanguageTag);
//                LanguageTagCoreManager.UpdateTag("zh-CN");
//                LanguageTagCoreManager.UpdateTag("zh-TW");
//
//                Console.WriteLine("Without Parameters ===========");
//                Console.WriteLine(new Text("Hello world {0}", "Main")); //zh-CN
//
//                Console.WriteLine("Custom Translate Format Provider ===========");
//                Console.WriteLine(new Text("Hello world {0}", "Main", DateTime.Now) {CustomFormatProvider = CustomFormatProvider}); //zh-CN
//
//                Console.WriteLine("Anonymous ==============================");
//                LanguageTagCoreManager.UpdateTag("zh-CN");
//                Console.WriteLine(new Text("Hello anonymous world {0}", TranslationManager.ANONYMOUS_PACKAGE_KEY, DateTime.Now)); //zn-CN
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.Source);
                Console.WriteLine(exception.StackTrace);
            }


            Console.ReadLine();
        }

        static void DisplayNewLanguageTag(AsyncLocalValueChangedArgs<string> handle)
        {
            Console.WriteLine($"before: {handle.PreviousValue}"); //zh-CN
            Console.WriteLine($"after: {handle.CurrentValue}"); //zh-TW
        }

        static string CustomFormatProvider(string packageKey, ILanguageTag languageTag, string text, object[] parameters)
        {
            return $"Custom format result: {string.Format(text, parameters)}, LangTag: {languageTag}";
        }
    }
}