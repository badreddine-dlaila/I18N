namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 卢旺达（The Republic of Rwanda，非洲，RW，RWA，646），卢旺达共和国 <br />
    /// Cosmos i18n code: i18n_country_luwangda
    /// </summary>
    public static class Rwanda
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Rwanda()
        {
            _country = new CountryInfo
            {
                Country = Country.Rwanda,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Rwanda,
                UNCode = "646",
                Alpha2Code = "RW",
                Alpha3Code = "RWA",
                Name = "The Republic of Rwanda",
                ShorterForm = "Rwanda",
                ChineseName = "卢旺达共和国",
                ChineseShorterForm = "卢旺达",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 卢旺达（The Republic of Rwanda，非洲，RW，RWA，646），卢旺达共和国 <br />
        /// Cosmos i18n code: i18n_country_luwangda
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_luwangda";
    }
}