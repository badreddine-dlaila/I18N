namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 圣赫勒拿、阿森松与特里斯坦达库尼亚（Saint Helena, Ascension and Tristan da Cunha，非洲，SH，SHN，654） <br />
    /// Cosmos i18n code: i18n_country_shenghelena
    /// </summary>
    public static class SaintHelena {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintHelena() {
            _country = new CountryInfo {
                Country = Country.SaintHelena,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "654",
                Alpha2Code = "SH",
                Alpha3Code = "SHN",
                Name = "Saint Helena, Ascension and Tristan da Cunha",
                ChineseName = "圣赫勒拿、阿森松与特里斯坦达库尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣赫勒拿、阿森松与特里斯坦达库尼亚（Saint Helena, Ascension and Tristan da Cunha，非洲，SH，SHN，654） <br />
        /// Cosmos i18n code: i18n_country_shenghelena
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shenghelena";
    }
}