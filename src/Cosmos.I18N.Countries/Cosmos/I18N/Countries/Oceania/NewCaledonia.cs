namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 新喀里多尼亚（New Caledonia，大洋洲，NC，NCL，540） <br />
    /// Cosmos i18n code: i18n_country_xinkaliduoniya
    /// </summary>
    public static class NewCaledonia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static NewCaledonia() {
            _country = new CountryInfo {
                Country = Country.NewCaledonia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.NewCaledonia,
                UNCode = "540",
                Alpha2Code = "NC",
                Alpha3Code = "NCL",
                Name = "New Caledonia",
                ChineseName = "新喀里多尼亚",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 新喀里多尼亚（New Caledonia，大洋洲，NC，NCL，540） <br />
        /// Cosmos i18n code: i18n_country_xinkaliduoniya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xinkaliduoniya";
    }
}