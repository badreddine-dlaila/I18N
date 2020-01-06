namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 法属南部领地（French Southern Territories，非洲，TF，ATF，260） <br />
    /// Cosmos i18n code: i18n_country_faguonanbulingdi
    /// </summary>
    public static class FrenchSouthernTerritories {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static FrenchSouthernTerritories() {
            _country = new CountryInfo {
                Country = Country.FrenchSouthernTerritories,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "260",
                Alpha2Code = "TF",
                Alpha3Code = "ATF",
                Name = "French Southern Territories",
                ChineseName = "法属南部领地",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 法属南部领地（French Southern Territories，非洲，TF，ATF，260） <br />
        /// Cosmos i18n code: i18n_country_faguonanbulingdi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_faguonanbulingdi";
    }
}