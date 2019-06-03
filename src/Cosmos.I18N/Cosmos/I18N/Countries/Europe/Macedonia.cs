namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 北马其顿（The Republic of North Macedonia，欧洲，MK，MKD，807），北马其顿共和国 <br />
    /// Cosmos i18n code: i18n_country_maqidun
    /// </summary>
    public static class Macedonia
    {
        private static readonly CountryInfo _country;

        static Macedonia()
        {
            _country = new CountryInfo
            {
                Country = Country.Macedonia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Macedonia,
                UNCode = "807",
                Alpha2Code = "MK",
                Alpha3Code = "MKD",
                Name = "The Republic of North Macedonia",
                ShorterForm = "Macedonia",
                ChineseName = "北马其顿共和国",
                ChineseShorterForm = "北马其顿",
                ChineseAlias = "马其顿",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 北马其顿（The Republic of North Macedonia，欧洲，MK，MKD，807），北马其顿共和国 <br />
        /// Cosmos i18n code: i18n_country_maqidun
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_maqidun";
    }
}