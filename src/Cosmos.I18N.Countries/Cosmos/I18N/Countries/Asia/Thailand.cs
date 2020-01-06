namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 泰国（The Kingdom of Thailand，亚洲，TH，THA，764），泰王国 <br />
    /// Cosmos i18n code: i18n_country_taiguo
    /// </summary>
    public static class Thailand {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Thailand() {
            _country = new CountryInfo {
                Country = Country.Thailand,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Thailand,
                UNCode = "764",
                Alpha2Code = "TH",
                Alpha3Code = "THA",
                Name = "The Kingdom of Thailand",
                ShorterForm = "Thailand",
                ChineseName = "泰王国",
                ChineseShorterForm = "泰国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 泰国（The Kingdom of Thailand，亚洲，TH，THA，764），泰王国 <br />
        /// Cosmos i18n code: i18n_country_taiguo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_taiguo";
    }
}