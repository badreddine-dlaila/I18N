namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 黑山（Montenegro，欧洲，ME，MNE，499），黑山共和国 <br />
    /// Cosmos i18n code: i18n_country_heishan
    /// </summary>
    public static class Montenegro {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Montenegro() {
            _country = new CountryInfo {
                Country = Country.Montenegro,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Montenegro,
                UNCode = "499",
                Alpha2Code = "ME",
                Alpha3Code = "MNE",
                Name = "Montenegro",
                ChineseName = "黑山共和国",
                ChineseShorterForm = "黑山",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 黑山（Montenegro，欧洲，ME，MNE，499），黑山共和国 <br />
        /// Cosmos i18n code: i18n_country_heishan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_heishan";
    }
}