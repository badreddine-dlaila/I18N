namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 印度尼西亚（The Republic of Indonesia，亚洲，ID，IDN，360），印度尼西亚共和国 <br />
    /// Cosmos i18n code: i18n_country_yindunixiya
    /// </summary>
    public static class Indonesia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Indonesia() {
            _country = new CountryInfo {
                Country = Country.Indonesia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Indonesia,
                UNCode = "360",
                Alpha2Code = "ID",
                Alpha3Code = "IDN",
                Name = "The Republic of Indonesia",
                ShorterForm = "Indonesia",
                ChineseName = "印度尼西亚共和国",
                ChineseShorterForm = "印度尼西亚",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 印度尼西亚（The Republic of Indonesia，亚洲，ID，IDN，360），印度尼西亚共和国 <br />
        /// Cosmos i18n code: i18n_country_yindunixiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yindunixiya";
    }
}