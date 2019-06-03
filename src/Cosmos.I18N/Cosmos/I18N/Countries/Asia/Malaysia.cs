namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 大马（Malaysia，亚洲，MY，MYS，458），马来西亚 <br />
    /// Cosmos i18n code: i18n_country_malaixiya
    /// </summary>
    public static class Malaysia
    {
        private static readonly CountryInfo _country;

        static Malaysia()
        {
            _country = new CountryInfo
            {
                Country = Country.Malaysia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Malaysia,
                UNCode = "458",
                Alpha2Code = "MY",
                Alpha3Code = "MYS",
                Name = "Malaysia",
                ChineseName = "马来西亚",
                ChineseShorterForm = "大马",
                Continent = Continent.Asia,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 大马（Malaysia，亚洲，MY，MYS，458），马来西亚 <br />
        /// Cosmos i18n code: i18n_country_malaixiya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_malaixiya";
    }
}