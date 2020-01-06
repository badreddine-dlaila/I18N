namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 利比里亚（Republic Of Liberia，非洲，LR，LBR，430），利比里亚共和国 <br />
    /// Cosmos i18n code: i18n_country_libiliya
    /// </summary>
    public static class Liberia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Liberia() {
            _country = new CountryInfo {
                Country = Country.Liberia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Liberia,
                UNCode = "430",
                Alpha2Code = "LR",
                Alpha3Code = "LBR",
                Name = "Republic Of Liberia",
                ShorterForm = "Liberia",
                ChineseName = "利比里亚共和国",
                ChineseShorterForm = "利比里亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 利比里亚（Republic Of Liberia，非洲，LR，LBR，430），利比里亚共和国 <br />
        /// Cosmos i18n code: i18n_country_libiliya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_libiliya";
    }
}