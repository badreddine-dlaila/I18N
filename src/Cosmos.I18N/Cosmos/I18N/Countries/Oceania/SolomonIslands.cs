namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 所罗门群岛（Solomon Islands，大洋洲，SB，SLB，090） <br />
    /// Cosmos i18n code: i18n_country_suoluomen
    /// </summary>
    public static class SolomonIslands
    {
        private static readonly CountryInfo _country;

        static SolomonIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.SolomonIslands,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SolomonIslands,
                UNCode = "090",
                Alpha2Code = "SB",
                Alpha3Code = "SLB",
                Name = "Solomon Islands",
                ChineseName = "所罗门群岛",
                Continent = Continent.Oceania ,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 所罗门群岛（Solomon Islands，大洋洲，SB，SLB，090） <br />
        /// Cosmos i18n code: i18n_country_suoluomen
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_suoluomen";
    }
}