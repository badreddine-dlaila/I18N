namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
    /// Cosmos i18n code: i18n_country_aiji
    /// </summary>
    public static class Egypt
    {
        private static readonly CountryInfo _country;

        static Egypt()
        {
            _country = new CountryInfo
            {
                Country = Country.Egypt,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Egypt,
                UNCode = "818",
                Alpha2Code = "EG",
                Alpha3Code = "EGY",
                Name = "The Arab Republic of Egypt",
                ShorterForm = "Egypt",
                ChineseName = "阿拉伯埃及共和国",
                ChineseShorterForm = "埃及",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
        /// Cosmos i18n code: i18n_country_aiji
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_aiji";

    }
}