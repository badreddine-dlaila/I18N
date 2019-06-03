namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 图瓦卢（Tuvalu，大洋洲，TV，TUV，798） <br />
    /// Cosmos i18n code: i18n_country_tuwalu
    /// </summary>
    public static class Tuvalu
    {
        private static readonly CountryInfo _country;

        static Tuvalu()
        {
            _country = new CountryInfo
            {
                Country = Country.Tuvalu,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Tuvalu,
                UNCode = "798",
                Alpha2Code = "TV",
                Alpha3Code = "TUV",
                Name = "Tuvalu",
                ChineseName = "图瓦卢",
                ChineseAlias = "埃利斯群岛",
                ChineseAlias2 = "潟湖群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 图瓦卢（Tuvalu，大洋洲，TV，TUV，798） <br />
        /// Cosmos i18n code: i18n_country_tuwalu
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_tuwalu";
    }
}