namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 圣基茨和尼维斯（The Federation of Saint Kitts and Nevis，北美洲，KN，KNA，659），圣基茨和尼维斯联邦 <br />
    /// Cosmos i18n code: i18n_country_shengjiciniweisi
    /// </summary>
    public static class SaintKittsAndNevis {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintKittsAndNevis() {
            _country = new CountryInfo {
                Country = Country.SaintKittsAndNevis,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SaintKittsAndNevis,
                UNCode = "659",
                Alpha2Code = "KN",
                Alpha3Code = "KNA",
                Name = "The Federation of Saint Kitts and Nevis",
                ShorterForm = "Saint Kitts and Nevis",
                ChineseName = "圣基茨和尼维斯联邦",
                ChineseShorterForm = "圣基茨和尼维斯",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣基茨和尼维斯（The Federation of Saint Kitts and Nevis，北美洲，KN，KNA，659），圣基茨和尼维斯联邦 <br />
        /// Cosmos i18n code: i18n_country_shengjiciniweisi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengjiciniweisi";
    }
}