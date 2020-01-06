namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
    /// Cosmos i18n code: i18n_country_nanfei
    /// </summary>
    public static class SouthAfrica {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SouthAfrica() {
            _country = new CountryInfo {
                Country = Country.SouthAfrica,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SouthAfrica,
                UNCode = "710",
                Alpha2Code = "ZA",
                Alpha3Code = "ZAF",
                Name = "The Republic of South Africa",
                ChineseName = "南非共和国",
                ChineseShorterForm = "南非",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
        /// Cosmos i18n code: i18n_country_nanfei
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nanfei";
    }
}