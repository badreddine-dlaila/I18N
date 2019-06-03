namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 土耳其（The Republic of Turkey，亚洲，TR，TUR，792），土耳其共和国 <br />
    /// Cosmos i18n code: i18n_country_tuerqi
    /// </summary>
    public static class Turkey
    {
        private static readonly CountryInfo _country;

        static Turkey()
        {
            _country = new CountryInfo
            {
                Country = Country.Turkey,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Turkey,
                UNCode = "792",
                Alpha2Code = "TR",
                Alpha3Code = "TUR",
                Name = "The Republic of Turkey",
                ShorterForm = "Turkey",
                ChineseName = "土耳其共和国",
                ChineseShorterForm = "土耳其",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 土耳其（The Republic of Turkey，亚洲，TR，TUR，792），土耳其共和国 <br />
        /// Cosmos i18n code: i18n_country_tuerqi
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_tuerqi";
    }
}