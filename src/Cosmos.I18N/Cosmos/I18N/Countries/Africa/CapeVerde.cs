namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
    /// Cosmos i18n code: i18n_country_fodejiao
    /// </summary>
    public static class CapeVerde
    {
        private static readonly CountryInfo _country;

        static CapeVerde()
        {
            _country = new CountryInfo
            {
                Country = Country.CapeVerde,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.CapeVerde,
                UNCode = "132",
                Alpha2Code = "CV",
                Alpha3Code = "CPV",
                Name = "Republic of Cape Verde",
                ShorterForm = "Cape Verde",
                ChineseName = "佛得角共和国",
                ChineseShorterForm = "佛得角",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
        /// Cosmos i18n code: i18n_country_fodejiao
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_fodejiao";
    }
}