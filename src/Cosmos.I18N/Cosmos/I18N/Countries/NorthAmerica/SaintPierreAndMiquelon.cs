namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 圣皮埃尔和密克隆群岛（The Islands of Saint Pierre and Miquelon，北美洲，PM，SPM，666），法国海外领土 <br />
    /// Cosmos i18n code: i18n_country_shengyiaiermkl
    /// </summary>
    public static class SaintPierreAndMiquelon
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintPierreAndMiquelon()
        {
            _country = new CountryInfo
            {
                Country = Country.SaintPierreAndMiquelon,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "666",
                Alpha2Code = "PM",
                Alpha3Code = "SPM",
                Name = "The Islands of Saint Pierre and Miquelon",
                ShorterForm = "Saint Pierre and Miquelon",
                ChineseName = "圣皮埃尔和密克隆群岛",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣皮埃尔和密克隆群岛（The Islands of Saint Pierre and Miquelon，北美洲，PM，SPM，666），法国海外领土 <br />
        /// Cosmos i18n code: i18n_country_shengyiaiermkl
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengyiaiermkl";
    }
}