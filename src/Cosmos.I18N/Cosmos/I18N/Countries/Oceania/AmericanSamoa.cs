namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
    /// 美属萨摩亚领地<br />
    /// Cosmos i18n code: i18n_country_ussamoya
    /// </summary>
    public static class AmericanSamoa
    {
        private static readonly CountryInfo _country;

        static AmericanSamoa()
        {
            _country = new CountryInfo
            {
                Country = Country.AmericanSamoa,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedStates,
                UNCode = "016",
                Alpha2Code = "AS",
                Alpha3Code = "ASM",
                Name = "American Samoa",
                ChineseName = "美属萨摩亚群岛",
                ChineseAlias = "美属萨摩亚领地",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
        /// 美属萨摩亚领地<br />
        /// Cosmos i18n code: i18n_country_ussamoya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_ussamoya";
    }
}