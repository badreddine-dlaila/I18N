namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 开曼群岛（Cayman Islands，北美洲，KY，CYM，136） <br />
    /// Cosmos i18n code: i18n_country_kaiman
    /// </summary>
    public static class CaymanIslands
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CaymanIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.CaymanIslands,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "136",
                Alpha2Code = "KY",
                Alpha3Code = "CYM",
                Name = "Cayman Islands",
                ChineseName = "开曼群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 开曼群岛（Cayman Islands，北美洲，KY，CYM，136） <br />
        /// Cosmos i18n code: i18n_country_kaiman
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kaiman";
    }
}