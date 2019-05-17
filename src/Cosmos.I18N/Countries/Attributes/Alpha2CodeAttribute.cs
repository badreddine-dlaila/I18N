using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    [AttributeUsage(AttributeTargets.Field)]
    public class Alpha2CodeAttribute : Attribute
    {
        public string Alpha2Code { get; set; }

        public Alpha2CodeAttribute(string code) => Alpha2Code = code;
    }
}