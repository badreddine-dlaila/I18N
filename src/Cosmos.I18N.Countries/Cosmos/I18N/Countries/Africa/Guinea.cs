namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 几内亚（The Republic of Guinea，非洲，GN，GIN，324），几内亚共和国 <br />
    /// Cosmos i18n code: i18n_country_jineiya
    /// </summary>
    public static class Guinea {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guinea() {
            _country = new CountryInfo {
                Country = Country.Guinea,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Guinea,
                UNCode = "324",
                Alpha2Code = "GN",
                Alpha3Code = "GIN",
                Name = "The Republic of Guinea",
                ShorterForm = "Guinea",
                ChineseName = "几内亚共和国",
                ChineseShorterForm = "几内亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 几内亚（The Republic of Guinea，非洲，GN，GIN，324），几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jineiya";
    }
}