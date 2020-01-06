namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 突尼斯（The Republic of Tunisia，非洲，TN，TUN，788），突尼斯共和国 <br />
    /// Cosmos i18n code: i18n_country_tunisi
    /// </summary>
    public static class Tunisia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tunisia() {
            _country = new CountryInfo {
                Country = Country.Tunisia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Tunisia,
                UNCode = "788",
                Alpha2Code = "TN",
                Alpha3Code = "TUN",
                Name = "The Republic of Tunisia",
                ShorterForm = "Tunisia",
                ChineseName = "突尼斯共和国",
                ChineseShorterForm = "突尼斯",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 突尼斯（The Republic of Tunisia，非洲，TN，TUN，788），突尼斯共和国 <br />
        /// Cosmos i18n code: i18n_country_tunisi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tunisi";
    }
}