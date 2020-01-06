namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 莫桑比克（The Republic of Mozambique，非洲，MZ，MOZ，508），莫桑比克共和国 <br />
    /// Cosmos i18n code: i18n_country_mosangbike
    /// </summary>
    public static class Mozambique {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mozambique() {
            _country = new CountryInfo {
                Country = Country.Mozambique,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Mozambique,
                UNCode = "508",
                Alpha2Code = "MZ",
                Alpha3Code = "MOZ",
                Name = "The Republic of Mozambique",
                ShorterForm = "Mozambique",
                ChineseName = "莫桑比克共和国",
                ChineseShorterForm = "莫桑比克",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 莫桑比克（The Republic of Mozambique，非洲，MZ，MOZ，508），莫桑比克共和国 <br />
        /// Cosmos i18n code: i18n_country_mosangbike
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mosangbike";
    }
}