namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
    /// Cosmos i18n code: i18n_country_babaduosi
    /// </summary>
    public static class Barbados {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Barbados() {
            _country = new CountryInfo {
                Country = Country.Barbados,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Barbados,
                UNCode = "052",
                Alpha2Code = "BB",
                Alpha3Code = "BRB",
                Name = "Barbados ",
                ChineseName = "巴巴多斯",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
        /// Cosmos i18n code: i18n_country_babaduosi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_babaduosi";
    }
}