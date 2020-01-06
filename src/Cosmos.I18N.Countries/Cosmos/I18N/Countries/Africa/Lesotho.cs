namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 莱索托（Kingdom of Lesotho，非洲，LS，LSO，426），莱索托王国 <br />
    /// Cosmos i18n code: i18n_country_laisuotuo
    /// </summary>
    public static class Lesotho {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Lesotho() {
            _country = new CountryInfo {
                Country = Country.Lesotho,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Lesotho,
                UNCode = "426",
                Alpha2Code = "LS",
                Alpha3Code = "LSO",
                Name = "Kingdom of Lesotho",
                ShorterForm = "Lesotho",
                ChineseName = "莱索托王国",
                ChineseShorterForm = "莱索托",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 莱索托（Kingdom of Lesotho，非洲，LS，LSO，426），莱索托王国 <br />
        /// Cosmos i18n code: i18n_country_laisuotuo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_laisuotuo";
    }
}