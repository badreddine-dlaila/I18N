namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 圣卢西亚（Republic Of Iraq，北美洲，LC，LCA，662） <br />
    /// Cosmos i18n code: i18n_country_shengluxiya
    /// </summary>
    public static class SaintLucia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintLucia() {
            _country = new CountryInfo {
                Country = Country.SaintLucia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SaintLucia,
                UNCode = "662",
                Alpha2Code = "LC",
                Alpha3Code = "LCA",
                Name = "Saint Lucia",
                ChineseName = "圣卢西亚",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣卢西亚（Republic Of Iraq，北美洲，LC，LCA，662） <br />
        /// Cosmos i18n code: i18n_country_shengluxiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengluxiya";
    }
}