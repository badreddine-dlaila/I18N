namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 马恩岛（Isle of Man，欧洲，IM，IMN，833），英属马恩岛 <br />
    /// Cosmos i18n code: i18n_country_maendao
    /// </summary>
    public static class Mann {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mann() {
            _country = new CountryInfo {
                Country = Country.Mann,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "833",
                Alpha2Code = "IM",
                Alpha3Code = "IMN",
                Name = "Isle of Man",
                ShorterForm = "Mann",
                ChineseName = "英属马恩岛",
                ChineseShorterForm = "马恩岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马恩岛（Isle of Man，欧洲，IM，IMN，833），英属马恩岛 <br />
        /// Cosmos i18n code: i18n_country_maendao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maendao";
    }
}