using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CountryNameAttribute : Attribute
    {
        public string Name { get; set; }

        public CountryNameAttribute(string name) => Name = name;
    }
}