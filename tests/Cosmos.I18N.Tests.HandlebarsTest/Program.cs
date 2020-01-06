using System;
using System.IO;
using Cosmos.I18N.Adapters.Json;
using Cosmos.I18N.Extensions.Console;

namespace Cosmos.I18N.Tests.HandlebarsTest {
    class Program {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args) {

            try {
                CosmosLocalization.Initialize()
                                  .ToGlobal(c => c.SetPathBase(Directory.GetCurrentDirectory()).SetPathSegment("Resources/I18N"))
                                  .AddJsonResourceFrom("Main.*")
                                  .AddJsonAnonymousResourceFrom()
                                  .AddHandlebars()
                                  .AllDone();

                Console.WriteLine("Handlebars =====================");
                var template = @"{{T 'Hello world {0}', 'Main', 'zh-CN'}}";

                var compiledTemplate = HandlebarsDotNet.Handlebars.Compile(template);
                var context = new {Now = DateTime.Now, Number = 2, A = "Alex LEWIS"};
                var result = compiledTemplate(context);
                Console.WriteLine(result);

            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.Source);
                Console.WriteLine(exception.StackTrace);
            }


            Console.ReadLine();
        }
    }
}