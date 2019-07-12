namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 卡塔尔（State of Qatar，亚洲，QA，QAT，634），卡塔尔国 <br />
    /// Cosmos i18n code: i18n_country_kataer
    /// </summary>
    public static class Qatar
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Qatar()
        {
            _country = new CountryInfo
            {
                Country = Country.Qatar,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Qatar,
                UNCode = "634",
                Alpha2Code = "QA",
                Alpha3Code = "QAT",
                Name = "State of Qatar",
                ShorterForm = "Qatar",
                ChineseName = "卡塔尔国",
                ChineseShorterForm = "卡塔尔",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 卡塔尔（State of Qatar，亚洲，QA，QAT，634），卡塔尔国 <br />
        /// Cosmos i18n code: i18n_country_kataer
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kataer";
    }
}