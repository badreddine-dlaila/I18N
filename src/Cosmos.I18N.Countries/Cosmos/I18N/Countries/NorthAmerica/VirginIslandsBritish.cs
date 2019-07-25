namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 维尔京群岛（The British Virgin Islands，北美洲，VG，VGB，092），英属维尔京群岛 <br />
    /// Cosmos i18n code: i18n_country_yingshuweierjing
    /// </summary>
    public static class VirginIslandsBritish
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static VirginIslandsBritish()
        {
            _country = new CountryInfo
            {
                Country = Country.VirginIslandsBritish,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "092",
                Alpha2Code = "VG",
                Alpha3Code = "VGB",
                Name = "The British Virgin Islands",
                ShorterForm = "Virgin Islands (British)",
                ChineseName = "英属维尔京群岛",
                ChineseShorterForm = "维尔京群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 维尔京群岛（The British Virgin Islands，北美洲，VG，VGB，092），英属维尔京群岛 <br />
        /// Cosmos i18n code: i18n_country_yingshuweierjing
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yingshuweierjing";
    }
}