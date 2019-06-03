namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 巴拿马（The Republic of Panama，北美洲，PA，PAN，591），巴拿马共和国 <br />
    /// Cosmos i18n code: i18n_country_banama
    /// </summary>
    public static class Panama
    {
        private static readonly CountryInfo _country;

        static Panama()
        {
            _country = new CountryInfo
            {
                Country = Country.Panama,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Panama,
                UNCode = "591",
                Alpha2Code = "PA",
                Alpha3Code = "PAN",
                Name = "The Republic of Panama",
                ShorterForm = "Panama",
                ChineseName = "巴拿马共和国",
                ChineseShorterForm = "巴拿马",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴拿马（The Republic of Panama，北美洲，PA，PAN，591），巴拿马共和国 <br />
        /// Cosmos i18n code: i18n_country_banama
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_banama";
    }
}