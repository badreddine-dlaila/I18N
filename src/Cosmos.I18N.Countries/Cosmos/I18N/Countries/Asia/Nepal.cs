namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 尼泊尔（Federal Democratic Republic of Nepal，亚洲，NP，NPL，524），尼泊尔联邦民主共和国 <br />
    /// Cosmos i18n code: i18n_country_niboer
    /// </summary>
    public static class Nepal {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Nepal() {
            _country = new CountryInfo {
                Country = Country.Nepal,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Nepal,
                UNCode = "524",
                Alpha2Code = "NP",
                Alpha3Code = "NP:",
                Name = "Federal Democratic Republic of Nepal",
                ShorterForm = "Nepal",
                ChineseName = "尼泊尔联邦民主共和国",
                ChineseShorterForm = "尼泊尔",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 尼泊尔（Federal Democratic Republic of Nepal，亚洲，NP，NPL，524），尼泊尔联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_niboer
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_niboer";
    }
}