namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
    /// Cosmos i18n code: i18n_country_boneihe
    /// </summary>
    public static class Bonaire {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bonaire() {
            _country = new CountryInfo {
                Country = Country.Bonaire,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Netherlands,
                UNCode = "535",
                Alpha2Code = "BQ",
                Alpha3Code = "BES",
                Name = "Bonaire, Sint Eustatius and Saba",
                ChineseName = "波内赫、圣尤斯特歇斯和萨巴",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
        /// Cosmos i18n code: i18n_country_boneihe
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_boneihe";
    }
}