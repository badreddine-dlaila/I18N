namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 特立尼达和多巴哥（Republic of Trinidad and Tobago，北美洲，TT，TTO，780），特立尼达和多巴哥共和国 <br />
    /// Cosmos i18n code: i18n_country_telinidaduobage
    /// </summary>
    public static class TrinidadAndTobago
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static TrinidadAndTobago()
        {
            _country = new CountryInfo
            {
                Country = Country.TrinidadAndTobago,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.TrinidadAndTobago,
                UNCode = "780",
                Alpha2Code = "TT",
                Alpha3Code = "TTO",
                Name = "Republic of Trinidad and Tobago",
                ShorterForm = "Trinidad and Tobago",
                ChineseName = "特立尼达和多巴哥共和国",
                ChineseShorterForm = "特立尼达和多巴哥",
                ChineseAlias = "特多",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 特立尼达和多巴哥（Republic of Trinidad and Tobago，北美洲，TT，TTO，780），特立尼达和多巴哥共和国 <br />
        /// Cosmos i18n code: i18n_country_telinidaduobage
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_telinidaduobage";
    }
}