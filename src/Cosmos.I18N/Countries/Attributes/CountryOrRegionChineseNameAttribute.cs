using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CountryOrRegionChineseNameAttribute : Attribute
    {
        public string Name { get; }

        public string ShorterForm { get; set; }

        public string Alias { get; set; }

        public CountryType Type { get; }

        public CountryOrRegionChineseNameAttribute(string name, CountryType type)
        {
            Name = name;
            Type = type;
        }
    }
}