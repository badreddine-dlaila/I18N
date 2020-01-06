namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
    /// Cosmos i18n code: i18n_country_kusuola
    /// </summary>
    public static class Curaçao {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Curaçao() {
            _country = new CountryInfo {
                Country = Country.Curaçao,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Netherlands,
                UNCode = "531",
                Alpha2Code = "CW",
                Alpha3Code = "CUW",
                Name = "Curaçao",
                ChineseName = "库拉索",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
        /// Cosmos i18n code: i18n_country_kusuola
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kusuola";
    }
}