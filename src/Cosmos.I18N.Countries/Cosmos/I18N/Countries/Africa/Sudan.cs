namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 苏丹（Republic of the Sudan，非洲，SD，SDN，736），苏丹共和国 <br />
    /// Cosmos i18n code: i18n_country_sudan
    /// </summary>
    public static class Sudan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Sudan() {
            _country = new CountryInfo {
                Country = Country.Sudan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Sudan,
                UNCode = "736",
                Alpha2Code = "SD",
                Alpha3Code = "SDN",
                Name = "Republic of the Sudan",
                ShorterForm = "Sudan",
                ChineseName = "苏丹共和国",
                ChineseShorterForm = "苏丹",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 苏丹（Republic of the Sudan，非洲，SD，SDN，736），苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_sudan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sudan";
    }
}