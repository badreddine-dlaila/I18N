namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 皮特肯岛（Pitcairn Islands，大洋洲，PN，PCN，612），皮特凯恩群岛 <br />
    /// Cosmos i18n code: i18n_country_piteken
    /// </summary>
    public static class Pitcairn {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Pitcairn() {
            _country = new CountryInfo {
                Country = Country.Pitcairn,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "612",
                Alpha2Code = "PN",
                Alpha3Code = "PCN",
                Name = "Pitcairn Islands",
                ShorterForm = "Pitcairn",
                ChineseName = "皮特凯恩群岛",
                ChineseShorterForm = "皮特肯岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 皮特肯岛（Pitcairn Islands，大洋洲，PN，PCN，612），皮特凯恩群岛 <br />
        /// Cosmos i18n code: i18n_country_piteken
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_piteken";
    }
}