namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
    /// 香港，中华人民共和国的一部分 <br />
    /// Hong Kong, a part of China <br />
    /// Cosmos i18n code: i18n_country_xianggang
    /// </summary>
    public static class HongKong
    {
        private static readonly CountryInfo _country;

        static HongKong()
        {
            _country = new CountryInfo
            {
                Country = Country.HongKong,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.China,
                UNCode = "344",
                Alpha2Code = "HK",
                Alpha3Code = "HKG",
                Name = "Hong Kong, SAR China",
                ShorterForm = "Hong Kong",
                ChineseName = "中华人民共和国香港特别行政区",
                ChineseShorterForm = "香港",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
        /// 香港，中华人民共和国的一部分 <br />
        /// Hong Kong, a part of China <br />
        /// Cosmos i18n code: i18n_country_xianggang
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xianggang";
    }
}