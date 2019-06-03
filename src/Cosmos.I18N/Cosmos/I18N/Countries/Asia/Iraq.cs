namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 伊拉克（Republic Of Iraq，亚洲，IQ，IRQ，368），伊拉克共和国 <br />
    /// Cosmos i18n code: i18n_country_yilake
    /// </summary>
    public static class Iraq
    {
        private static readonly CountryInfo _country;

        static Iraq()
        {
            _country = new CountryInfo
            {
                Country = Country.Iraq,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Iraq,
                UNCode = "368",
                Alpha2Code = "IQ",
                Alpha3Code = "IRQ",
                Name = "Republic Of Iraq",
                ShorterForm = "Iraq",
                ChineseName = "伊拉克共和国",
                ChineseShorterForm = "伊拉克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 伊拉克（Republic Of Iraq，亚洲，IQ，IRQ，368），伊拉克共和国 <br />
        /// Cosmos i18n code: i18n_country_yilake
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_yilake";
    }
}