namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
    /// Cosmos i18n code: i18n_country_riben
    /// </summary>
    public static class Japan
    {
        private static readonly CountryInfo _country;

        static Japan()
        {
            _country = new CountryInfo
            {
                Country = Country.Japan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Japan,
                UNCode = "302",
                Alpha2Code = "JP",
                Alpha3Code = "JPN",
                Name = "Japan",
                ChineseName = "日本国",
                ChineseShorterForm = "日本",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
        /// Cosmos i18n code: i18n_country_riben
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_riben";
    }
}