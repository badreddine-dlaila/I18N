namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 克罗地亚（Republic of Croatia，欧洲，HR，HRV，191），克罗地亚共和国 <br />
    /// Cosmos i18n code: i18n_country_keluodiya
    /// </summary>
    public static class Croatia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Croatia() {
            _country = new CountryInfo {
                Country = Country.Croatia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Croatia,
                UNCode = "191",
                Alpha2Code = "HR",
                Alpha3Code = "HRV",
                Name = "Republic of Croatia",
                ShorterForm = "Croatia",
                ChineseName = "克罗地亚共和国",
                ChineseShorterForm = "克罗地亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 克罗地亚（Republic of Croatia，欧洲，HR，HRV，191），克罗地亚共和国 <br />
        /// Cosmos i18n code: i18n_country_keluodiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_keluodiya";
    }
}