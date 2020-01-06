namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 乌克兰（Ukraine，欧洲，UA，UKR，804） <br />
    /// Cosmos i18n code: i18n_country_wukelan
    /// </summary>
    public static class Ukraine {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Ukraine() {
            _country = new CountryInfo {
                Country = Country.Ukraine,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Ukraine,
                UNCode = "804",
                Alpha2Code = "UA",
                Alpha3Code = "UKR",
                Name = "Ukraine",
                ChineseName = "乌克兰",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 乌克兰（Ukraine，欧洲，UA，UKR，804） <br />
        /// Cosmos i18n code: i18n_country_wukelan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wukelan";
    }
}