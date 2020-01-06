namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 圣诞岛（Christmas Island，亚洲，CX，CXR，162） <br />
    /// Cosmos i18n code: i18n_country_balin
    /// </summary>
    public static class ChristmasIsland {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static ChristmasIsland() {
            _country = new CountryInfo {
                Country = Country.ChristmasIsland,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Australia,
                UNCode = "162",
                Alpha2Code = "CX",
                Alpha3Code = "CXR",
                Name = "Christmas Island",
                ChineseName = "圣诞岛",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣诞岛（Christmas Island，亚洲，CX，CXR，162） <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_balin";
    }
}