namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
    /// Cosmos i18n code: i18n_country_andaoer
    /// </summary>
    public static class Andorra {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Andorra() {
            _country = new CountryInfo {
                Country = Country.Andorra,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Andorra,
                UNCode = "020",
                Alpha2Code = "AD",
                Alpha3Code = "AND",
                Name = "Andorra",
                ChineseName = "安道尔共和国",
                ChineseShorterForm = "安道尔",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
        /// Cosmos i18n code: i18n_country_andaoer
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_andaoer";
    }
}