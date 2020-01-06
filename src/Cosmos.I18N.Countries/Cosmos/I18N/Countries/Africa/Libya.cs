namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 利比亚（State of Libya，非洲，LY，LBY，434），利比亚国 <br />
    /// Cosmos i18n code: i18n_country_libiya
    /// </summary>
    public static class Libya {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Libya() {
            _country = new CountryInfo {
                Country = Country.Libya,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Libya,
                UNCode = "434",
                Alpha2Code = "LY",
                Alpha3Code = "LBY",
                Name = "State of Libya",
                ShorterForm = "Libya",
                ChineseName = "利比亚国",
                ChineseShorterForm = "利比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 利比亚（State of Libya，非洲，LY，LBY，434），利比亚国 <br />
        /// Cosmos i18n code: i18n_country_libiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_libiya";
    }
}