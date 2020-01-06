namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 马拉维（The Republic of Malawi，非洲，MW，MWI，454），马拉维共和国 <br />
    /// Cosmos i18n code: i18n_country_malawei
    /// </summary>
    public static class Malawi {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Malawi() {
            _country = new CountryInfo {
                Country = Country.Malawi,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Malawi,
                UNCode = "454",
                Alpha2Code = "MW",
                Alpha3Code = "MWI",
                Name = "The Republic of Malawi",
                ShorterForm = "Malawi",
                ChineseName = "马拉维共和国",
                ChineseShorterForm = "马拉维",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马拉维（The Republic of Malawi，非洲，MW，MWI，454），马拉维共和国 <br />
        /// Cosmos i18n code: i18n_country_malawei
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_malawei";
    }
}