namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
    /// Cosmos i18n code: i18n_country_budan
    /// </summary>
    public static class Bhutan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bhutan()
        {
            _country = new CountryInfo
            {
                Country = Country.Bhutan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Bhutan,
                UNCode = "064",
                Alpha2Code = "BT",
                Alpha3Code = "BTN",
                Name = "Kingdom of Bhutan",
                ShorterForm = "Bhutan",
                ChineseName = "不丹王国",
                ChineseShorterForm = "不丹",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
        /// Cosmos i18n code: i18n_country_budan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_budan";
    }
}