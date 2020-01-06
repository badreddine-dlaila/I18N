namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 诺福克岛（Norfolk Island，大洋洲，NF，NFK，574） <br />
    /// Cosmos i18n code: i18n_country_nuofuke
    /// </summary>
    public static class NorfolkIsland {
        private static readonly CountryInfo _country;

        static NorfolkIsland() {
            _country = new CountryInfo {
                Country = Country.NorfolkIsland,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Australia,
                UNCode = "574",
                Alpha2Code = "NF",
                Alpha3Code = "NFK",
                Name = "Norfolk Island",
                ChineseName = "诺福克岛",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 诺福克岛（Norfolk Island，大洋洲，NF，NFK，574） <br />
        /// Cosmos i18n code: i18n_country_nuofuke
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nuofuke";
    }
}