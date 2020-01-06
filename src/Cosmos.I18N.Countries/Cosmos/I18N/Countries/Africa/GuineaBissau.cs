namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 几内亚比绍（The Republic of Guinea-Bissau，非洲，GW，GNB，624），几内亚比绍共和国 <br />
    /// Cosmos i18n code: i18n_country_jineiyabishao
    /// </summary>
    public static class GuineaBissau {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static GuineaBissau() {
            _country = new CountryInfo {
                Country = Country.GuineaBissau,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.GuineaBissau,
                UNCode = "624",
                Alpha2Code = "GW",
                Alpha3Code = "GNB",
                Name = "The Republic of Guinea-Bissau",
                ShorterForm = "Guinea Bissau",
                ChineseName = "几内亚比绍共和国",
                ChineseShorterForm = "几内亚比绍",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 几内亚比绍（The Republic of Guinea-Bissau，非洲，GW，GNB，624），几内亚比绍共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiyabishao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jineiyabishao";
    }
}