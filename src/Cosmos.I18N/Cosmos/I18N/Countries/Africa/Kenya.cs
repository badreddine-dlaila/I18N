namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 肯尼亚（The Republic Of Kenya，非洲，KE，KEN，404），肯尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_kenniya
    /// </summary>
    public static class Kenya
    {
        private static readonly CountryInfo _country;

        static Kenya()
        {
            _country = new CountryInfo
            {
                Country = Country.Kenya,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Kenya,
                UNCode = "404",
                Alpha2Code = "KE",
                Alpha3Code = "KEN",
                Name = "The Republic Of Kenya",
                ShorterForm = "Kenya",
                ChineseName = "肯尼亚共和国",
                ChineseShorterForm = "肯尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 肯尼亚（The Republic Of Kenya，非洲，KE，KEN，404），肯尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_kenniya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_kenniya";
    }
}