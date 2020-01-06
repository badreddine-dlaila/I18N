namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 新西兰（New Zealand，大洋洲，NZ，NZL，554） <br />
    /// Cosmos i18n code: i18n_country_xinxilan
    /// </summary>
    public static class NewZealand {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static NewZealand() {
            _country = new CountryInfo {
                Country = Country.NewZealand,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.NewZealand,
                UNCode = "554",
                Alpha2Code = "NZ",
                Alpha3Code = "NZL",
                Name = "New Zealand",
                ChineseName = "新西兰",
                ChineseAlias = "纽西兰",
                Continent = Continent.Oceania,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 新西兰（New Zealand，大洋洲，NZ，NZL，554） <br />
        /// Cosmos i18n code: i18n_country_xinxilan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xinxilan";
    }
}