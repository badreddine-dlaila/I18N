namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
    /// Cosmos i18n code: i18n_country_aolanqundao
    /// </summary>
    public static class AlandIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static AlandIslands() {
            _country = new CountryInfo {
                Country = Country.AlandIslands,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Finland,
                UNCode = "248",
                Alpha2Code = "AX",
                Alpha3Code = "ALA",
                Name = "Aland Island",
                Alias = "Ahvenanmaa",
                ChineseName = "奥兰群岛",
                ChineseAlias = "奥兰自治省",
                ChineseAlias2 = "阿赫韦南马群岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
        /// Cosmos i18n code: i18n_country_aolanqundao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aolanqundao";
    }
}