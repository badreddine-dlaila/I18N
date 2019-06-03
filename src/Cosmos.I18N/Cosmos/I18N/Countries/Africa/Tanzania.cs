namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 坦桑尼亚（The United Republic of Tanzania，非洲，TZ，TZA，834），坦桑尼亚联合共和国 <br />
    /// Cosmos i18n code: i18n_country_tansangniya
    /// </summary>
    public static class Tanzania
    {
        private static readonly CountryInfo _country;

        static Tanzania()
        {
            _country = new CountryInfo
            {
                Country = Country.Tanzania,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Tanzania,
                UNCode = "834",
                Alpha2Code = "TZ",
                Alpha3Code = "TZA",
                Name = "The United Republic of Tanzania",
                ShorterForm = "Tanzania",
                ChineseName = "坦桑尼亚联合共和国",
                ChineseShorterForm = "坦桑尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 坦桑尼亚（The United Republic of Tanzania，非洲，TZ，TZA，834），坦桑尼亚联合共和国 <br />
        /// Cosmos i18n code: i18n_country_tansangniya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_tansangniya";
    }
}