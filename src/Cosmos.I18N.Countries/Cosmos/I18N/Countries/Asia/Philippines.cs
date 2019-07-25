namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 菲律宾（Republic of the Philippines，亚洲，PH，PHL，6080），菲律宾共和国 <br />
    /// Cosmos i18n code: i18n_country_felvbin
    /// </summary>
    public static class Philippines
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Philippines()
        {
            _country = new CountryInfo
            {
                Country = Country.Philippines,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Philippines,
                UNCode = "608",
                Alpha2Code = "PH",
                Alpha3Code = "PHL",
                Name = "Republic of the Philippines",
                ShorterForm = "Philippines",
                ChineseName = "菲律宾共和国",
                ChineseShorterForm = "菲律宾",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 菲律宾（Republic of the Philippines，亚洲，PH，PHL，6080），菲律宾共和国 <br />
        /// Cosmos i18n code: i18n_country_felvbin
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_felvbin";
    }
}