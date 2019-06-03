using System.Collections.Generic;
using System.Linq;

namespace Cosmos.I18N.Countries
{
    public static partial class CountryManager
    {
        private static readonly Dictionary<Country, CountryCode> _nameAndCodeMap;
        private static readonly Dictionary<CountryCode, Country> _codeAndNameMap;
        private static readonly Dictionary<Country, CountryInfo> _countryInfoCache;

        static CountryManager()
        {
            _nameAndCodeMap = InitOpts.Map1;
            _codeAndNameMap = InitOpts.Map2;
            _countryInfoCache = InitOpts.Map3;
        }

        public static CountryInfo GetCountryInfo(Country country)
        {
            return _countryInfoCache[country];
        }

        public static CountryInfo GetCountryInfo(CountryCode code)
        {
            var country = _codeAndNameMap[code];
            return _countryInfoCache[country];
        }

        public static CountryInfo GetCountryInfo(string alphaCode)
        {
            if (string.IsNullOrWhiteSpace(alphaCode))
            {
                return null;
            }

            if (alphaCode.Length == 2)
            {
                var alpha2Code = alphaCode.ToUpper();
                return _countryInfoCache.Values.FirstOrDefault(x => x.Alpha2Code == alpha2Code);
            }

            if (alphaCode.Length == 3)
            {
                var alpha3Code = alphaCode.ToUpper();
                return _countryInfoCache.Values.FirstOrDefault(x => x.Alpha3Code == alpha3Code);
            }

            return null;
        }

        public static Country GetCountryEnum(CountryCode code)
        {
            return _codeAndNameMap[code];
        }

        public static CountryCode GetCountryCode(Country country)
        {
            return _nameAndCodeMap[country];
        }
    }
}