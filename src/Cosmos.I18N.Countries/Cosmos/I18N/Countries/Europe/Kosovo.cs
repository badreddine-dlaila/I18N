namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 科索沃（Kosovo，欧洲，XK，XKX，838），科索沃自治省 <br />
    /// Cosmos i18n code: i18n_country_kesuowo
    /// </summary>
    public static class Kosovo {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kosovo() {
            _country = new CountryInfo {
                Country = Country.Kosovo,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Serbia,
                UNCode = "838",
                Alpha2Code = "XK",
                Alpha3Code = "XKX",
                Name = "Kosovo",
                ChineseName = "科索沃自治省",
                ChineseShorterForm = "科索沃",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 科索沃（Kosovo，欧洲，XK，XKX，838），科索沃自治省 <br />
        /// Cosmos i18n code: i18n_country_kesuowo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kesuowo";
    }
}