namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 马里（The Republic of Mali，非洲，ML，MLI，466），马里共和国 <br />
    /// Cosmos i18n code: i18n_country_mali
    /// </summary>
    public static class Mali
    {
        private static readonly CountryInfo _country;

        static Mali()
        {
            _country = new CountryInfo
            {
                Country = Country.Mali,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Mali,
                UNCode = "466",
                Alpha2Code = "ML",
                Alpha3Code = "MLI",
                Name = "The Republic of Mali",
                ShorterForm = "Mali",
                ChineseName = "马里共和国",
                ChineseShorterForm = "马里",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马里（The Republic of Mali，非洲，ML，MLI，466），马里共和国 <br />
        /// Cosmos i18n code: i18n_country_mali
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_mali";
    }
}