namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 北马里亚那群岛（Commonwealth of the Northern Mariana Islands，大洋洲，MP，MNP，580），北马里亚纳群岛自由邦 <br />
    /// Cosmos i18n code: i18n_country_beimaliyana
    /// </summary>
    public static class NorthernMarianaIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static NorthernMarianaIslands() {
            _country = new CountryInfo {
                Country = Country.NorthernMarianaIslands,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedStates,
                UNCode = "580",
                Alpha2Code = "MP",
                Alpha3Code = "MNP",
                Name = "Commonwealth of the Northern Mariana Islands",
                ShorterForm = "Northern Mariana Islands",
                ChineseName = "北马里亚纳群岛自由邦",
                ChineseShorterForm = "北马里亚那群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 北马里亚那群岛（Commonwealth of the Northern Mariana Islands，大洋洲，MP，MNP，580），北马里亚纳群岛自由邦 <br />
        /// Cosmos i18n code: i18n_country_beimaliyana
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_beimaliyana";
    }
}