using System;
using System.Reflection;
using EnumsNET;

// ReSharper disable once CheckNamespace
namespace Cosmos.I18N.Countries
{
    public static class CountryCodeExtensions
    {
        // ReSharper disable once InconsistentNaming
        public static string GetUNCode(this CountryCode code)
        {
            return code.GetCountryAttr<UNCodeAttribute>().UNCode;
        }

        public static string GetAlpha2Code(this CountryCode code)
        {
            return code.GetName();
        }

        public static string GetAlpha3Code(this CountryCode code)
        {
            return code.GetCountryAttr<Alpha3CodeAttribute>().Alpha3Code;
        }

        public static string GetCountryName(this CountryCode code)
        {
            return code.GetCountryAttr<CountryNameAttribute>().Name;
        }

        private static TAttribute GetCountryAttr<TAttribute>(this CountryCode code) where TAttribute : Attribute
        {
            var enumType = code.GetType();
            var field = enumType.GetField(Enum.GetName(enumType, code));
            return field.GetCustomAttribute<TAttribute>();
        }
    }
}