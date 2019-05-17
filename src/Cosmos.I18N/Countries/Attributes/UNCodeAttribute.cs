using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    // ReSharper disable once InconsistentNaming
    [AttributeUsage(AttributeTargets.Field)]
    public class UNCodeAttribute : Attribute
    {
        // ReSharper disable once InconsistentNaming
        public string UNCode { get; set; }

        public UNCodeAttribute(string code) => UNCode = code;
    }
}