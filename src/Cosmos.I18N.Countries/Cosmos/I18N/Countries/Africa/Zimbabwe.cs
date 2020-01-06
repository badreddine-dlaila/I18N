namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
    /// Cosmos i18n code: i18n_country_jinbabuwei
    /// </summary>
    public static class Zimbabwe {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Zimbabwe() {
            _country = new CountryInfo {
                Country = Country.Zimbabwe,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Zimbabwe,
                UNCode = "716",
                Alpha2Code = "ZW",
                Alpha3Code = "ZWE",
                Name = "The Republic of Zimbabwe",
                ShorterForm = "Zimbabwe",
                ChineseName = "津巴布韦共和国",
                ChineseShorterForm = "津巴布韦",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
        /// Cosmos i18n code: i18n_country_jinbabuwei
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jinbabuwei";
    }
}