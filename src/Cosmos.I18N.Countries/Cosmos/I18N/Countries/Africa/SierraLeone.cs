namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 塞拉利昂（The Republic of Sierra Leone，非洲，SL，SLE，694），塞拉利昂共和国 <br />
    /// Cosmos i18n code: i18n_country_sailaliang
    /// </summary>
    public static class SierraLeone {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SierraLeone() {
            _country = new CountryInfo {
                Country = Country.SierraLeone,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SierraLeone,
                UNCode = "694",
                Alpha2Code = "SL",
                Alpha3Code = "SLE",
                Name = "The Republic of Sierra Leone",
                ShorterForm = "Sierra Leone",
                ChineseName = "塞拉利昂共和国",
                ChineseShorterForm = "塞拉利昂",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 塞拉利昂（The Republic of Sierra Leone，非洲，SL，SLE，694），塞拉利昂共和国 <br />
        /// Cosmos i18n code: i18n_country_sailaliang
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sailaliang";
    }
}