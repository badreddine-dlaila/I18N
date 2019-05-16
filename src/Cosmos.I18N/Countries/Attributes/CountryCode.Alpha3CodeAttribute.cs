using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    [AttributeUsage(AttributeTargets.Field)]
    public class Alpha3CodeAttribute : Attribute
    {
        public string Alpha3Code { get; set; }

        public Alpha3CodeAttribute(string code) => Alpha3Code = code;
    }
}