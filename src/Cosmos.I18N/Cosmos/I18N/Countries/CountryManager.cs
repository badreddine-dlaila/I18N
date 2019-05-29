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
                {Country.Algeria, CountryCode.DZ},
                {Country.AntiguaAndBarbuda, CountryCode.AG},
                {Country.Anguilla, CountryCode.AI},
                {Country.Armenia, CountryCode.AM},
                {Country.Angola, CountryCode.AO},
                {Country.Antarctica, CountryCode.AQ},
                {Country.Argentina, CountryCode.AR},
                {Country.AmericanSamoa, CountryCode.AS},
                {Country.Austria, CountryCode.AT},
                {Country.Australia, CountryCode.AU},
                {Country.AlandIslands, CountryCode.AX},
                {Country.Aruba, CountryCode.AW},
                {Country.Azerbaijan, CountryCode.AZ},
                {Country.BosniaAndHerzegovina, CountryCode.BA},
                {Country.Barbados, CountryCode.BB},
                {Country.Bangladesh, CountryCode.BD},
                {Country.Belgium, CountryCode.BE},
                {Country.BurkinaFaso, CountryCode.BF},
                {Country.Bulgaria, CountryCode.BG},
                {Country.Bahrain, CountryCode.BH},
                {Country.Burundi, CountryCode.BI},
                {Country.Benin, CountryCode.BJ},
                {Country.Bermuda, CountryCode.BM},
                {Country.Brunei, CountryCode.BN},
                {Country.Bolivia, CountryCode.BO},
                {Country.Bonaire, CountryCode.BQ},
                {Country.Brazil, CountryCode.BR},
                {Country.Bahamas, CountryCode.BS},
                {Country.Bhutan, CountryCode.BT},
                {Country.BouvetIsland, CountryCode.BV},
                {Country.Botswana, CountryCode.BW},
                {Country.Belarus, CountryCode.BY},
                {Country.Belize, CountryCode.BZ},
                {Country.Cameroun, CountryCode.CM},
                {Country.Canada, CountryCode.CA},
                {Country.CapeVerde, CountryCode.CV},
                {Country.China, CountryCode.CN},
                {Country.Chile, CountryCode.CL},
                {Country.Colombia, CountryCode.CO},
                {Country.CongoBrazzaville, CountryCode.CG},
                {Country.CentralAfrican, CountryCode.CF},
                {Country.CongoKinshasa, CountryCode.CD},
                {Country.CocosIslands, CountryCode.CC},
                {Country.CostaRica, CountryCode.CR},
                {Country.CookIslands, CountryCode.CK},
                {Country.CotedIvoire, CountryCode.CI},
                {Country.Cuba, CountryCode.CU},
                {Country.Curaçao, CountryCode.CW},
                {Country.ChristmasIsland, CountryCode.CX},
                {Country.Cyprus, CountryCode.CY},
                {Country.Czechia, CountryCode.CZ},
                {Country.Denmark, CountryCode.DK},
                {Country.Dominica, CountryCode.DM},
                {Country.Dominican, CountryCode.DO},
                {Country.Ecuador, CountryCode.EC},
                {Country.Estonia, CountryCode.EE},
                {Country.Egypt, CountryCode.EG},
                {Country.Eritrea, CountryCode.ER},
                {Country.Ethiopia, CountryCode.ET},
                {Country.FalklandIslands, CountryCode.FK},
                {Country.Fiji, CountryCode.FJ},
                {Country.Finland, CountryCode.FI},
                {Country.France, CountryCode.FR},
                {Country.Germany, CountryCode.DE},
                {Country.HongKong, CountryCode.HK},
                {Country.Japan, CountryCode.JP},
                {Country.Macao, CountryCode.MO},
                {Country.Mayotte, CountryCode.YT},
                {Country.Netherlands, CountryCode.NL},
                {Country.Norway, CountryCode.NO},
                {Country.Russia, CountryCode.RU},
                {Country.SaintBarts, CountryCode.BL},
                {Country.SouthAfrica, CountryCode.ZA},
                {Country.Spain, CountryCode.ES},
                {Country.Switzerland, CountryCode.CH},
                {Country.Taiwan, CountryCode.TW},
                {Country.UnitedKingdom, CountryCode.GB},
                {Country.UnitedStates, CountryCode.US},
                {Country.UnitedArabEmirates, CountryCode.AE},
                {Country.WesternSahara, CountryCode.EH},
                {Country.Zambia, CountryCode.ZM},
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
                {CountryCode.AR, Country.Argentina},
                {CountryCode.AS, Country.AmericanSamoa},
                {CountryCode.AT, Country.Austria},
                {CountryCode.AU, Country.Australia},
                {CountryCode.AW, Country.Aruba},
                {CountryCode.AX, Country.AlandIslands},
                {CountryCode.AZ, Country.Azerbaijan},
                {CountryCode.BA, Country.BosniaAndHerzegovina},
                {CountryCode.BB, Country.Barbados},
                {CountryCode.BD, Country.Bangladesh},
                {CountryCode.BE, Country.Belgium},
                {CountryCode.BF, Country.BurkinaFaso},
                {CountryCode.BG, Country.Bulgaria},
                {CountryCode.BH, Country.Bahrain},
                {CountryCode.BI, Country.Burundi},
                {CountryCode.BJ, Country.Benin},
                {CountryCode.BL, Country.SaintBarts},
                {CountryCode.BM, Country.Bermuda},
                {CountryCode.BN, Country.Brunei},
                {CountryCode.BO, Country.Bolivia},
                {CountryCode.BQ, Country.Bonaire},
                {CountryCode.BR, Country.Brazil},
                {CountryCode.BS, Country.Bahamas},
                {CountryCode.BT, Country.Bhutan},
                {CountryCode.BV, Country.BouvetIsland},
                {CountryCode.BW, Country.Botswana},
                {CountryCode.BY, Country.Belarus},
                {CountryCode.BZ, Country.Belize},
                {CountryCode.CA, Country.Canada},
                {CountryCode.CC, Country.CocosIslands},
                {CountryCode.CD, Country.CongoKinshasa},
                {CountryCode.CF, Country.CentralAfrican},
                {CountryCode.CG, Country.CongoBrazzaville},
                {CountryCode.CN, Country.China},
                {CountryCode.CH, Country.Switzerland},
                {CountryCode.CI, Country.CotedIvoire},
                {CountryCode.CK, Country.CookIslands},
                {CountryCode.CL, Country.Chile},
                {CountryCode.CM, Country.Cameroun},
                {CountryCode.CO, Country.Colombia},
                {CountryCode.CR, Country.CostaRica},
                {CountryCode.CU, Country.Cuba},
                {CountryCode.CV, Country.CapeVerde},
                {CountryCode.CW, Country.Curaçao},
                {CountryCode.CX, Country.ChristmasIsland},
                {CountryCode.CY, Country.Cyprus},
                {CountryCode.CZ, Country.Czechia},
                {CountryCode.DE, Country.Germany},
                {CountryCode.DK, Country.Denmark},
                {CountryCode.DM, Country.Dominica},
                {CountryCode.DO, Country.Dominican},
                {CountryCode.DZ, Country.Algeria},
                {CountryCode.EC, Country.Ecuador},
                {CountryCode.EE, Country.Estonia},
                {CountryCode.EG, Country.Egypt},
                {CountryCode.EH, Country.WesternSahara},
                {CountryCode.ER, Country.Eritrea},
                {CountryCode.ES, Country.Spain},
                {CountryCode.ET, Country.Ethiopia},
                {CountryCode.FI, Country.Finland},
                {CountryCode.FJ, Country.Fiji},
                {CountryCode.FK, Country.FalklandIslands},
                {CountryCode.FR, Country.France},
                {CountryCode.GB, Country.UnitedKingdom},
                {CountryCode.HK, Country.HongKong},
                {CountryCode.JP, Country.Japan},
                {CountryCode.MO, Country.Macao},
                {CountryCode.NL, Country.Netherlands},
                {CountryCode.NO, Country.Norway},
                {CountryCode.RU, Country.Russia},
                {CountryCode.TW, Country.Taiwan},
                {CountryCode.US, Country.UnitedStates},
                {CountryCode.YT, Country.Mayotte},
                {CountryCode.ZA, Country.SouthAfrica},
                {CountryCode.ZM, Country.Zambia},
                {CountryCode.ZW, Country.Zimbabwe},
            };

            public static Dictionary<Country, CountryInfo> Map3 = new Dictionary<Country, CountryInfo>
            {
                {Country.Andorra, Europe.Andorra.Instance},
                {Country.Afghanistan, Asia.Afghanistan.Instance},
                {Country.Algeria, Africa.Algeria.Instance},
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
                {Country.Azerbaijan, Asia.Azerbaijan.Instance},
                {Country.BosniaAndHerzegovina, Europe.BosniaAndHerzegovina.Instance},
                {Country.Barbados, NorthAmerica.Barbados.Instance},
                {Country.Bangladesh, Asia.Bangladesh.Instance},
                {Country.Belgium, Europe.Belgium.Instance},
                {Country.BurkinaFaso, Africa.BurkinaFaso.Instance},
                {Country.Bulgaria, Europe.Bulgaria.Instance},
                {Country.Bahrain, Asia.Bahrain.Instance},
                {Country.Burundi, Africa.Burundi.Instance},
                {Country.Benin, Africa.Benin.Instance},
                {Country.Bermuda, NorthAmerica.Bermuda.Instance},
                {Country.Brunei, Asia.Brunei.Instance},
                {Country.Bolivia, SouthAmerica.Bolivia.Instance},
                {Country.Bonaire, NorthAmerica.Bonaire.Instance},
                {Country.BouvetIsland, Europe.BouvetIsland.Instance},
                {Country.Brazil, SouthAmerica.Brazil.Instance},
                {Country.Bahamas, NorthAmerica.Bahamas.Instance},
                {Country.Bhutan, Asia.Bhutan.Instance},
                {Country.Botswana, Africa.Botswana.Instance},
                {Country.Belarus, Europe.Belarus.Instance},
                {Country.Belize, NorthAmerica.Belize.Instance},
                {Country.Cameroun, Africa.Cameroun.Instance},
                {Country.Canada, NorthAmerica.Canada.Instance},
                {Country.CapeVerde, Africa.CapeVerde.Instance},
                {Country.CentralAfrican, Africa.CentralAfrican.Instance},
                {Country.China, Asia.China.Instance},
                {Country.Chile, SouthAmerica.Chile.Instance},
                {Country.ChristmasIsland, Asia.ChristmasIsland.Instance},
                {Country.CongoBrazzaville, Africa.CongoBrazzaville.Instance},
                {Country.CongoKinshasa, Africa.CongoKinshasa.Instance},
                {Country.CocosIslands, Asia.CocosIslands.Instance},
                {Country.Colombia, SouthAmerica.Colombia.Instance},
                {Country.CookIslands, Oceania.CookIslands.Instance},
                {Country.CostaRica, NorthAmerica.CostaRica.Instance},
                {Country.CotedIvoire, Africa.CotedIvoire.Instance},
                {Country.Cuba, NorthAmerica.Cuba.Instance},
                {Country.Curaçao, NorthAmerica.Curaçao.Instance},
                {Country.Cyprus, Asia.Cyprus.Instance},
                {Country.Czechia, Europe.Czechia.Instance},
                {Country.Denmark, Europe.Denmark.Instance},
                {Country.Dominica, NorthAmerica.Dominica.Instance},
                {Country.Dominican, NorthAmerica.Dominican.Instance},
                {Country.Ecuador, SouthAmerica.Ecuador.Instance},
                {Country.Estonia, Europe.Estonia.Instance},
                {Country.Egypt, Africa.Egypt.Instance},
                {Country.Eritrea, Africa.Eritrea.Instance},
                {Country.Ethiopia, Africa.Ethiopia.Instance},
                {Country.FalklandIslands, SouthAmerica.FalklandIslands.Instance},
                {Country.Fiji, Oceania.Fiji.Instance},
                {Country.Finland, Europe.Finland.Instance},
                {Country.France, Europe.France.Instance},
                {Country.Germany, Europe.Germany.Instance},
                {Country.HongKong, Asia.HongKong.Instance},
                {Country.Japan, Asia.Japan.Instance},
                {Country.Macao, Asia.Macao.Instance},
                {Country.Mayotte, Africa.Mayotte.Instance},
                {Country.Netherlands, Europe.Netherlands.Instance},
                {Country.Norway, Europe.Norway.Instance},
                {Country.Russia, Europe.Russia.Instance},
                {Country.SaintBarts, NorthAmerica.SaintBarts.Instance},
                {Country.SouthAfrica, Africa.SouthAfrica.Instance},
                {Country.Spain, Europe.Spain.Instance},
                {Country.Switzerland, Europe.Switzerland.Instance},
                {Country.Taiwan, Asia.Taiwan.Instance},
                {Country.UnitedArabEmirates, Asia.UnitedArabEmirates.Instance},
                {Country.UnitedKingdom, Europe.UnitedKingdom.Instance},
                {Country.UnitedStates, NorthAmerica.UnitedStates.Instance},
                {Country.WesternSahara, Africa.WesternSahara.Instance},
                {Country.Zambia, Africa.Zambia.Instance},
                {Country.Zimbabwe, Africa.Zimbabwe.Instance},
            };
        }
    }
}