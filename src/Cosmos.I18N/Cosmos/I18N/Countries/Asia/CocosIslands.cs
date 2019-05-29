namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
    /// Cosmos i18n code: i18n_country_kekesi
    /// </summary>
    public static class CocosIslands
    {
        private static readonly CountryInfo _country;

        static CocosIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.CocosIslands,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Australia,
                UNCode = "166",
                Alpha2Code = "CC",
                Alpha3Code = "CCK",
                Name = "Cocos Islands",
                Alias = "Keeling Islands",
                ChineseName = "科科斯群岛",
                ChineseAlias = "基林群岛",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
        /// Cosmos i18n code: i18n_country_kekesi
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_kekesi";
    }
}