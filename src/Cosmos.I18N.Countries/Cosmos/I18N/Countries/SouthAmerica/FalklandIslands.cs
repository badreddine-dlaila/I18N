namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
    /// Cosmos i18n code: i18n_country_fukelan
    /// </summary>
    public static class FalklandIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static FalklandIslands() {
            _country = new CountryInfo {
                Country = Country.FalklandIslands,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.FalklandIslands,
                UNCode = "238",
                Alpha2Code = "FK",
                Alpha3Code = "FLK",
                Name = "Falkland Islands",
                ShorterForm = "Ecuador",
                ChineseName = "马尔维纳斯群岛",
                ChineseAlias = "福克兰群岛",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
        /// Cosmos i18n code: i18n_country_fukelan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_fukelan";
    }
}