namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 海地（The Republic of Haiti，北美洲，HT，HTI，332），海地共和国 <br />
    /// Cosmos i18n code: i18n_country_haidi
    /// </summary>
    public static class Haiti
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Haiti()
        {
            _country = new CountryInfo
            {
                Country = Country.Haiti,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Haiti,
                UNCode = "332",
                Alpha2Code = "HT",
                Alpha3Code = "HTI",
                Name = "The Republic of Haiti",
                ShorterForm = "Haiti",
                ChineseName = "海地共和国",
                ChineseShorterForm = "海地",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 海地（The Republic of Haiti，北美洲，HT，HTI，332），海地共和国 <br />
        /// Cosmos i18n code: i18n_country_haidi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// 18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_haidi";
    }
}