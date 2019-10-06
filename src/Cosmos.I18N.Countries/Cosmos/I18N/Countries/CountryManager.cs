using System.Collections.Generic;
using System.Linq;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Country Manager
    /// </summary>
    public static partial class CountryManager
    {
        // ReSharper disable once InconsistentNaming
        private static readonly Dictionary<Country, CountryCode> _nameAndCodeMap;

        // ReSharper disable once InconsistentNaming
        private static readonly Dictionary<CountryCode, Country> _codeAndNameMap;

        // ReSharper disable once InconsistentNaming
        private static readonly Dictionary<Country, CountryInfo> _countryInfoCache;

        static CountryManager()
        {
            _nameAndCodeMap = InitOpts.Map1;
            _codeAndNameMap = InitOpts.Map2;
            _countryInfoCache = InitOpts.Map3;
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryInfo GetCountryInfo(Country country)
        {
            return _countryInfoCache[country];
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static CountryInfo GetCountryInfo(CountryCode code)
        {
            var country = _codeAndNameMap[code];
            return _countryInfoCache[country];
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via AlphaCode2 or AlphaCode3
        /// </summary>
        /// <param name="alphaCode"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets <see cref="Country"/> from <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Country GetCountryEnum(CountryCode code)
        {
            return _codeAndNameMap[code];
        }

        /// <summary>
        /// Gets <see cref="CountryCode"/> from <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryCode GetCountryCode(Country country)
        {
            return _nameAndCodeMap[country];
        }

        /// <summary>
        /// Gets Continent
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static Continent GetContinent(Country country)
        {
            return GetCountryInfo(country).Continent;
        }

        /// <summary>
        /// Gets Continent
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Continent GetContinent(CountryCode code)
        {
            return GetCountryInfo(code).Continent;
        }
    }
}