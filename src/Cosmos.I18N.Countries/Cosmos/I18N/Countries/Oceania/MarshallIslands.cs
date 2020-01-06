namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 马绍尔群岛（The Republic of Marshall Islands，大洋洲，MH，MHL，584），马绍尔群岛共和国 <br />
    /// Cosmos i18n code: i18n_country_mashaoer
    /// </summary>
    public static class MarshallIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static MarshallIslands() {
            _country = new CountryInfo {
                Country = Country.MarshallIslands,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.MarshallIslands,
                UNCode = "584",
                Alpha2Code = "MH",
                Alpha3Code = "MHL",
                Name = "The Republic of Marshall Islands",
                ShorterForm = "Marshall Islands",
                ChineseName = "马绍尔群岛共和国",
                ChineseShorterForm = "马绍尔群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马绍尔群岛（The Republic of Marshall Islands，大洋洲，MH，MHL，584），马绍尔群岛共和国 <br />
        /// Cosmos i18n code: i18n_country_mashaoer
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mashaoer";
    }
}