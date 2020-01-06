namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 卢森堡（The Grand Duchy of Luxembourg，欧洲，LU，LUX，442），卢森堡大公国 <br />
    /// Cosmos i18n code: i18n_country_lusenbao
    /// </summary>
    public static class Luxembourg {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Luxembourg() {
            _country = new CountryInfo {
                Country = Country.Luxembourg,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Luxembourg,
                UNCode = "442",
                Alpha2Code = "LU",
                Alpha3Code = "LUX",
                Name = "The Grand Duchy of Luxembourg",
                ShorterForm = "Luxembourg",
                ChineseName = "卢森堡大公国",
                ChineseShorterForm = "卢森堡",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 卢森堡（The Grand Duchy of Luxembourg，欧洲，LU，LUX，442），卢森堡大公国 <br />
        /// Cosmos i18n code: i18n_country_lusenbao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_lusenbao";
    }
}