namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 毛里塔尼亚（The Islamic Republic of Mauritania，非洲，MR，MR，478），毛里塔尼亚伊斯兰共和国 <br />
    /// Cosmos i18n code: i18n_country_maolitaniya
    /// </summary>
    public static class Mauritania {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mauritania() {
            _country = new CountryInfo {
                Country = Country.Mauritania,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Mauritania,
                UNCode = "478",
                Alpha2Code = "MR",
                Alpha3Code = "MRT",
                Name = "The Islamic Republic of Mauritania",
                ShorterForm = "Mauritania",
                ChineseName = "毛里塔尼亚伊斯兰共和国",
                ChineseShorterForm = "毛里塔尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 毛里塔尼亚（The Islamic Republic of Mauritania，非洲，MR，MR，478），毛里塔尼亚伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_maolitaniya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maolitaniya";
    }
}