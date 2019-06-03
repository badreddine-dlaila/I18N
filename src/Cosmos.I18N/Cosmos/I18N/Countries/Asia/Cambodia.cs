namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 柬埔寨（The Kingdom of Cambodia，亚洲，KH，KHM，116），柬埔寨王国 <br />
    /// Cosmos i18n code: i18n_country_jipuzhai
    /// </summary>
    public static class Cambodia
    {
        private static readonly CountryInfo _country;

        static Cambodia()
        {
            _country = new CountryInfo
            {
                Country = Country.Cambodia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Cambodia,
                UNCode = "116",
                Alpha2Code = "KH",
                Alpha3Code = "KHM",
                Name = "The Kingdom of Cambodia",
                ShorterForm = "Cambodia",
                ChineseName = "柬埔寨王国",
                ChineseShorterForm = "柬埔寨",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 柬埔寨（The Kingdom of Cambodia，亚洲，KH，KHM，116），柬埔寨王国 <br />
        /// Cosmos i18n code: i18n_country_jipuzhai
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_jipuzhai";
    }
}