using System;
using System.IO;
using System.Threading;
using Cosmos.I18N.Adapters.Json;
using Cosmos.I18N.Core;
using Cosmos.I18N.Extensions.Console;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Tests.ConsoleTest
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
                    .AddJsonResourceFrom("Main.*.json")
                    .AllDone();

                Console.WriteLine("Basic =========================");

                Console.WriteLine(new Text("Hello world {0}", "Main", "zh-CN", DateTime.Now));
                Console.WriteLine(new Text("Hello world {0}", "Main", "en-US", DateTime.Now));
                Console.WriteLine(new Text("Hello world {0}", "Main", "en-GB", DateTime.Now));

                Console.WriteLine("Current LanguageTag ===========");

                LanguageTagCoreManager.UpdateTag("zh-CN");
                Console.WriteLine(new Text("Hello world {0}", "Main", DateTime.Now));

                Console.WriteLine("Fallback LanguageTag ==========");
                Console.WriteLine(new Text("Hello world {0}", "Main", "en-CA", DateTime.Now));

                Console.WriteLine("Update Current LanguageTag handler");
                LanguageTagCoreManager.UpdateTagChangedHandler(DisplayNewLanguageTag);
                LanguageTagCoreManager.UpdateTag("zh-CN");
                LanguageTagCoreManager.UpdateTag("zh-TW");
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
    }
}