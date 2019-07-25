namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 也门（The Republic Of Yemen，亚洲，YE，YEM，887），也门共和国 <br />
    /// Cosmos i18n code: i18n_country_yemen
    /// </summary>
    public static class Yemen
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Yemen()
        {
            _country = new CountryInfo
            {
                Country = Country.Yemen,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Yemen,
                UNCode = "887",
                Alpha2Code = "YE",
                Alpha3Code = "YEM",
                Name = "The Republic Of Yemen",
                ShorterForm = "Yemen",
                ChineseName = "也门共和国",
                ChineseShorterForm = "也门",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 也门（The Republic Of Yemen，亚洲，YE，YEM，887），也门共和国 <br />
        /// Cosmos i18n code: i18n_country_yemen
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yemen";
    }
}