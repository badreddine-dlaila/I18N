namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 斯威士兰（The Kingdom of Swaziland，非洲，SZ，SWZ，748），斯威士兰王国 <br />
    /// Cosmos i18n code: i18n_country_siweishilan
    /// </summary>
    public static class Swaziland {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Swaziland() {
            _country = new CountryInfo {
                Country = Country.Swaziland,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Swaziland,
                UNCode = "748",
                Alpha2Code = "SZ",
                Alpha3Code = "SWZ",
                Name = "The Kingdom of Swaziland",
                ShorterForm = "Swaziland",
                Alias = "The Kingdom of eSwatini",
                ChineseName = "斯威士兰王国",
                ChineseShorterForm = "斯威士兰",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯威士兰（The Kingdom of Swaziland，非洲，SZ，SWZ，748），斯威士兰王国 <br />
        /// Cosmos i18n code: i18n_country_siweishilan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_siweishilan";
    }
}