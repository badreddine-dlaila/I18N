namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 澳门（Macao, SAR China，亚洲，HK，HKG，344），中华人民共和国澳门特别行政区 <br />
    /// 澳门，中华人民共和国的一部分 <br />
    /// Macao, a part of China <br />
    /// Cosmos i18n code: i18n_country_aomen
    /// </summary>
    public static class Macao
    {
        private static readonly CountryInfo _country;

        static Macao()
        {
            _country = new CountryInfo
            {
                Country = Country.Macao,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.China,
                UNCode = "446",
                Alpha2Code = "MO",
                Alpha3Code = "MAC",
                Name = "Macao, SAR China",
                ShorterForm = "Macao",
                ChineseName = "中华人民共和国澳门特别行政区",
                ChineseShorterForm = "澳门",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 澳门（Macao, SAR China，亚洲，HK，HKG，344），中华人民共和国澳门特别行政区 <br />
        /// 澳门，中华人民共和国的一部分 <br />
        /// Macao, a part of China <br />
        /// Cosmos i18n code: i18n_country_aomen
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_aomen";
    }
}