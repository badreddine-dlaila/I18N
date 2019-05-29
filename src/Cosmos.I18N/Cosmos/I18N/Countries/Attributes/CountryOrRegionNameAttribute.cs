using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CountryOrRegionNameAttribute : Attribute
    {
        public string Name { get; }

        public string ShorterForm { get; set; }

        public string Alias { get; set; }

        public CountryType Type { get; }

        public CountryOrRegionNameAttribute(string name, CountryType type)
        {
            Name = name;
            Type = type;
        }
    }
}