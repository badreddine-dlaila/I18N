namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 印度（Republic of India，亚洲，IN，IND，356），印度共和国 <br />
    /// Cosmos i18n code: i18n_country_yindu
    /// </summary>
    public static class India
    {
        private static readonly CountryInfo _country;

        static India()
        {
            _country = new CountryInfo
            {
                Country = Country.India,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.India,
                UNCode = "356",
                Alpha2Code = "IN",
                Alpha3Code = "IND",
                Name = "Republic of India",
                ShorterForm = "India",
                ChineseName = "印度共和国",
                ChineseShorterForm = "印度",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 印度（Republic of India，亚洲，IN，IND，356），印度共和国 <br />
        /// Cosmos i18n code: i18n_country_yindu
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_yindu";
    }
}