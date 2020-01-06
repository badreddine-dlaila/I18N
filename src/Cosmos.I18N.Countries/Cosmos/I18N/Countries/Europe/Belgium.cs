namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
    /// Cosmos i18n code: i18n_country_bilishi
    /// </summary>
    public static class Belgium {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Belgium() {
            _country = new CountryInfo {
                Country = Country.Belgium,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Belgium,
                UNCode = "056",
                Alpha2Code = "BE",
                Alpha3Code = "BEL",
                Name = "The Kingdom of Belgium",
                ShorterForm = "Belgium",
                ChineseName = "比利时王国",
                ChineseShorterForm = "比利时",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
        /// Cosmos i18n code: i18n_country_bilishi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bilishi";
    }
}