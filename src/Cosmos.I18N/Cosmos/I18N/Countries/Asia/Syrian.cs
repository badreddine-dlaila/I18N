namespace Cosmos.I18N.Countries.Asia
{
    public static class Syrian
    {
        private static readonly CountryInfo _country;

        static Syrian()
        {
            _country = new CountryInfo
            {
                Country = Country.Syrian,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Syrian,
                UNCode = "760",
                Alpha2Code = "SY",
                Alpha3Code = "SYR",
                Name = "The Syrian Arab Republic",
                ShorterForm = "Syrian",
                ChineseName = "阿拉伯叙利亚共和国",
                ChineseShorterForm = "叙利亚",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 叙利亚（The Syrian Arab Republic，亚洲，SY，SYR，760），阿拉伯叙利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_xuliya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_xuliya";
    }
}