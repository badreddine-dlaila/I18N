namespace Cosmos.I18N.Countries.Oceania
{
    public static class Micronesia
    {
        private static readonly CountryInfo _country;

        static Micronesia()
        {
            _country = new CountryInfo
            {
                Country = Country.Micronesia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Micronesia,
                UNCode = "218",
                Alpha2Code = "EC",
                Alpha3Code = "ECU",
                Name = "Micronesia",
                ChineseName = "密克罗尼西亚",
                ChineseAlias = "小岛群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 密克罗尼西亚（Micronesia，大洋洲，EC，ECU，218） <br />
        /// Cosmos i18n code: i18n_country_eguaduoer
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_eguaduoer";
    }
}