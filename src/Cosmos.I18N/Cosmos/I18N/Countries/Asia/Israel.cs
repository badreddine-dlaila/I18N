namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 以色列（The State of Israel，亚洲，IL，ISR，376），以色列国 <br />
    /// Cosmos i18n code: i18n_country_yiselie
    /// </summary>
    public static class Israel
    {
        private static readonly CountryInfo _country;

        static Israel()
        {
            _country = new CountryInfo
            {
                Country = Country.Israel,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Israel,
                UNCode = "376",
                Alpha2Code = "IL",
                Alpha3Code = "ISR",
                Name = "The State of Israel",
                ShorterForm = "Israel",
                ChineseName = "以色列国",
                ChineseShorterForm = "以色列",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 以色列（The State of Israel，亚洲，IL，ISR，376），以色列国 <br />
        /// Cosmos i18n code: i18n_country_yiselie
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_yiselie";
    }
}