namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 伊朗（The Islamic Republic of Iran，亚洲，IR，IRN，364），伊朗伊斯兰共和国 <br />
    /// Cosmos i18n code: i18n_country_yilang
    /// </summary>
    public static class Iran {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Iran() {
            _country = new CountryInfo {
                Country = Country.Iran,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Iran,
                UNCode = "364",
                Alpha2Code = "IR",
                Alpha3Code = "IRN",
                Name = "The Islamic Republic of Iran",
                ShorterForm = "Iran",
                ChineseName = "伊朗伊斯兰共和国",
                ChineseShorterForm = "伊朗",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 伊朗（The Islamic Republic of Iran，亚洲，IR，IRN，364），伊朗伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_yilang
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yilang";
    }
}