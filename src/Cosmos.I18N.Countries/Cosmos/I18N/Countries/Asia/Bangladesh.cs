namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
    /// Cosmos i18n code: i18n_country_mengjiala
    /// </summary>
    public static class Bangladesh {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bangladesh() {
            _country = new CountryInfo {
                Country = Country.Bangladesh,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Bangladesh,
                UNCode = "050",
                Alpha2Code = "BD",
                Alpha3Code = "BGD",
                Name = "People's Republic Of Bangladesh",
                ShorterForm = "Bangladesh",
                ChineseName = "孟加拉人民共和国",
                ChineseShorterForm = "孟加拉国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
        /// Cosmos i18n code: i18n_country_mengjiala
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mengjiala";
    }
}