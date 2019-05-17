using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CountryOrRegionNameAttribute : Attribute
    {
        public string Name { get; set; }

        public CountryOrRegionNameAttribute(string name) => Name = name;
    }
}