namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 萨尔瓦多（The Democratic Republic of Sao Tome and Principe，非洲，SV，SLV，222），萨尔瓦多共和国 <br />
    /// Cosmos i18n code: i18n_country_saerwaduo
    /// </summary>
    public static class ElSalvador {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static ElSalvador() {
            _country = new CountryInfo {
                Country = Country.ElSalvador,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.ElSalvador,
                UNCode = "222",
                Alpha2Code = "SV",
                Alpha3Code = "SLV",
                Name = "The Democratic Republic of Sao Tome and Principe",
                ShorterForm = "El Salvador",
                ChineseName = "萨尔瓦多共和国",
                ChineseShorterForm = "萨尔瓦多",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 萨尔瓦多（The Democratic Republic of Sao Tome and Principe，非洲，SV，SLV，222），萨尔瓦多共和国 <br />
        /// Cosmos i18n code: i18n_country_saerwaduo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saerwaduo";
    }
}