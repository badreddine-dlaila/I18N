namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 英属印度洋领地（British Indian Ocean Territory，亚洲，IO，IOT，086） <br />
    /// Cosmos i18n code: i18n_country_yingshuying
    /// </summary>
    public static class BritishIndianOceanTerritory {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static BritishIndianOceanTerritory() {
            _country = new CountryInfo {
                Country = Country.BritishIndianOceanTerritory,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "086",
                Alpha2Code = "IO",
                Alpha3Code = "IOT",
                Name = "British Indian Ocean Territory",
                ChineseName = "英属印度洋领地",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 英属印度洋领地（British Indian Ocean Territory，亚洲，IO，IOT，086） <br />
        /// Cosmos i18n code: i18n_country_yingshuying
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yingshuying";
    }
}