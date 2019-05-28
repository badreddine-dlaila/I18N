using System.Collections.Generic;
using System.Linq;

namespace Cosmos.I18N.Countries
{
    public static class CountryManager
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


        private static class InitOpts
        {
            public static Dictionary<Country, CountryCode> Map1 = new Dictionary<Country, CountryCode>
            {
                {Country.Andorra, CountryCode.AD},
                {Country.Afghanistan, CountryCode.AF},
                {Country.AntiguaAndBarbuda, CountryCode.AG},
                {Country.Anguilla, CountryCode.AI},
                {Country.Armenia, CountryCode.AM},
                {Country.Angola, CountryCode.AO},
                {Country.Antarctica, CountryCode.AQ},
                {Country.Argentina,CountryCode.AR},
                {Country.AmericanSamoa, CountryCode.AS},
                {Country.Austria,CountryCode.AT},
                {Country.Australia,CountryCode.AU},
                {Country.AlandIslands,CountryCode.AX},
                {Country.Aruba,CountryCode.AW},
                {Country.China, CountryCode.CN},
                {Country.Finland,CountryCode.FI},
                {Country.HongKong, CountryCode.HK},
                {Country.Macao, CountryCode.MO},
                {Country.Netherlands,CountryCode.NL},
                {Country.Taiwan, CountryCode.TW},
                {Country.UnitedKingdom, CountryCode.GB},
                {Country.UnitedStates, CountryCode.US},
                {Country.UnitedArabEmirates, CountryCode.AE},
                {Country.Zimbabwe, CountryCode.ZW},
            };

            public static Dictionary<CountryCode, Country> Map2 = new Dictionary<CountryCode, Country>
            {
                {CountryCode.AD, Country.Andorra},
                {CountryCode.AE, Country.UnitedArabEmirates},
                {CountryCode.AF, Country.Afghanistan},
                {CountryCode.AG, Country.AntiguaAndBarbuda},
                {CountryCode.AI, Country.Anguilla},
                {CountryCode.AM, Country.Armenia},
                {CountryCode.AO, Country.Angola},
                {CountryCode.AQ, Country.Antarctica},
                {CountryCode.AR,Country.Argentina},
                {CountryCode.AS,Country.AmericanSamoa},
                {CountryCode.AT,Country.Austria},
                {CountryCode.AU,Country.Australia},
                {CountryCode.AW,Country.Aruba},
                {CountryCode.AX,Country.AlandIslands},
                {CountryCode.CN, Country.China},
                {CountryCode.FI,Country.Finland},
                {CountryCode.GB, Country.UnitedKingdom},
                {CountryCode.HK, Country.HongKong},
                {CountryCode.MO, Country.Macao},
                {CountryCode.NL,Country.Netherlands},
                {CountryCode.TW, Country.Taiwan},
                {CountryCode.US, Country.UnitedStates},
                {CountryCode.ZW, Country.Zimbabwe},
            };

            public static Dictionary<Country, CountryInfo> Map3 = new Dictionary<Country, CountryInfo>
            {
                {Country.Andorra, Europe.Andorra.Instance},
                {Country.Afghanistan, Asia.Afghanistan.Instance},
                {Country.AntiguaAndBarbuda, NorthAmerica.AntiguaAndBarbuda.Instance},
                {Country.Anguilla, NorthAmerica.Anguilla.Instance},
                {Country.Armenia, Europe.Armenia.Instance},
                {Country.Angola, Africa.Angola.Instance},
                {Country.Antarctica, CountryOf.Antarctica},
                {Country.Argentina, SouthAmerica.Argentina.Instance},
                {Country.AmericanSamoa, Oceania.AmericanSamoa.Instance},
                {Country.Austria, Europe.Austria.Instance},
                {Country.Australia, Oceania.Australia.Instance},
                {Country.Aruba, NorthAmerica.Aruba.Instance},
                {Country.AlandIslands, Europe.AlandIslands.Instance},
                {Country.China, Asia.China.Instance},
                {Country.Finland, Europe.Finland.Instance},
                {Country.HongKong, Asia.HongKong.Instance},
                {Country.Macao, Asia.Macao.Instance},
                {Country.Netherlands, Europe.Netherlands.Instance},
                {Country.Taiwan, Asia.Taiwan.Instance},
                {Country.UnitedArabEmirates, Asia.UnitedArabEmirates.Instance},
                {Country.UnitedKingdom, Europe.UnitedKingdom.Instance},
                {Country.UnitedStates, NorthAmerica.UnitedStates.Instance},
                {Country.Zimbabwe, Africa.Zimbabwe.Instance},
            };
        }
    }
}