namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 墨西哥（The United Mexican States，北美洲，MX，MEX，484），墨西哥合众国 <br />
    /// Cosmos i18n code: i18n_country_moxige
    /// </summary>
    public static class Mexico {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mexico() {
            _country = new CountryInfo {
                Country = Country.Mexico,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Mexico,
                UNCode = "484",
                Alpha2Code = "MX",
                Alpha3Code = "MEX",
                Name = "The United Mexican States",
                ShorterForm = "Mexico",
                ChineseName = "墨西哥合众国",
                ChineseShorterForm = "墨西哥",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 墨西哥（The United Mexican States，北美洲，MX，MEX，484），墨西哥合众国 <br />
        /// Cosmos i18n code: i18n_country_moxige
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_moxige";
    }
}