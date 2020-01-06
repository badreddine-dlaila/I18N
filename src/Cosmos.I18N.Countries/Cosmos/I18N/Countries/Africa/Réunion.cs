namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 留尼汪（Reunion Island，非洲，RE，REU，638），留尼旺岛 <br />
    /// Cosmos i18n code: i18n_country_liuniwang
    /// </summary>
    public static class Réunion {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Réunion() {
            _country = new CountryInfo {
                Country = Country.Réunion,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "638",
                Alpha2Code = "RE",
                Alpha3Code = "REU",
                Name = "Reunion Island",
                ShorterForm = "Réunion",
                ChineseName = "留尼旺岛",
                ChineseShorterForm = "留尼汪",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 留尼汪（Reunion Island，非洲，RE，REU，638），留尼旺岛 <br />
        /// Cosmos i18n code: i18n_country_liuniwang
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_liuniwang";
    }
}