namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 瑞典（The Kingdom of Sweden，欧洲，SE，SWE，752），瑞典王国 <br />
    /// Cosmos i18n code: i18n_country_ruidian
    /// </summary>
    public static class Sweden
    {
        private static readonly CountryInfo _country;

        static Sweden()
        {
            _country = new CountryInfo
            {
                Country = Country.Sweden,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Sweden,
                UNCode = "752",
                Alpha2Code = "SE",
                Alpha3Code = "SWE",
                Name = "The Kingdom of Sweden",
                ShorterForm = "Sweden",
                ChineseName = "瑞典王国",
                ChineseShorterForm = "瑞典",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 瑞典（The Kingdom of Sweden，欧洲，SE，SWE，752），瑞典王国 <br />
        /// Cosmos i18n code: i18n_country_ruidian
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_ruidian";
    }
}