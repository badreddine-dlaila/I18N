using System;
using System.Reflection;
using EnumsNET;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    public static class CountryCodeExtensions
    {
        // ReSharper disable once InconsistentNaming
        public static string GetUNCode(this CountriesOf code)
        {
            return code.GetCountryAttr<UNCodeAttribute>().UNCode;
        }

        public static string GetAlpha2Code(this CountriesOf code)
        {
            return code.GetCountryAttr<Alpha2CodeAttribute>()?.Alpha2Code ?? code.GetName();
        }

        public static string GetAlpha3Code(this CountriesOf code)
        {
            return code.GetCountryAttr<Alpha3CodeAttribute>().Alpha3Code;
        }

        public static string GetCountryOrRegionNameName(this CountriesOf code)
        {
            return code.GetCountryAttr<CountryOrRegionNameAttribute>().Name;
        }

        private static TAttribute GetCountryAttr<TAttribute>(this CountriesOf code) where TAttribute : Attribute
        {
            var enumType = code.GetType();
            var field = enumType.GetField(Enum.GetName(enumType, code));
            return field.GetCustomAttribute<TAttribute>();
        }
    }
}