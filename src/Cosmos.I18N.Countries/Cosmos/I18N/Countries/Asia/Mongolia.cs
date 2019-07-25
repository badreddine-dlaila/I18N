namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 蒙古国（Outer Mongolia，亚洲，MN，MNG，496），外蒙古 <br />
    /// Cosmos i18n code: i18n_country_waimenggu
    /// </summary>
    public static class Mongolia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mongolia()
        {
            _country = new CountryInfo
            {
                Country = Country.Mongolia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Mongolia,
                UNCode = "496",
                Alpha2Code = "MN",
                Alpha3Code = "MNG",
                Name = "Outer Mongolia",
                ShorterForm = "Mongolia",
                ChineseName = "蒙古国",
                ChineseShorterForm = "外蒙古",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 蒙古国（Outer Mongolia，亚洲，MN，MNG，496），外蒙古 <br />
        /// Cosmos i18n code: i18n_country_waimenggu
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_waimenggu";
    }
}