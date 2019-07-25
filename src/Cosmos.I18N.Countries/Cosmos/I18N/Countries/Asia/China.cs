namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
    /// Cosmos i18n code: i18n_country_china
    /// </summary>
    public static class China
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static China()
        {
            _country = new CountryInfo
            {
                Country = Country.China,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.China,
                UNCode = "156",
                Alpha2Code = "CN",
                Alpha3Code = "CNH",
                Name = "People's Republic of China",
                ShorterForm = "China",
                ChineseName = "中华人民共和国",
                ChineseShorterForm = "中国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
        /// Cosmos i18n code: i18n_country_china
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_china";
    }
}