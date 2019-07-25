namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
    /// Cosmos i18n code: i18n_country_buweidao
    /// </summary>
    public static class BouvetIsland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static BouvetIsland()
        {
            _country = new CountryInfo
            {
                Country = Country.BouvetIsland,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Norway,
                UNCode = "074",
                Alpha2Code = "BV",
                Alpha3Code = "BVT",
                Name = "Bouvet Island",
                ChineseName = "布韦岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
        /// Cosmos i18n code: i18n_country_buweidao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_buweidao";
    }
}