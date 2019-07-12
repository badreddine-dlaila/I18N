namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
    /// Cosmos i18n code: i18n_country_zhongfei
    /// </summary>
    public static class CentralAfrican
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CentralAfrican()
        {
            _country = new CountryInfo
            {
                Country = Country.CentralAfrican,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.CentralAfrican,
                UNCode = "180",
                Alpha2Code = "CF",
                Alpha3Code = "COD",
                Name = "Central African Republic",
                ChineseName = "中非共和国",
                ChineseShorterForm = "中非",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
        /// Cosmos i18n code: i18n_country_zhongfei
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zhongfei";
    }
}