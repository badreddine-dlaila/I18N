namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 苏里南（The Republic of Suriname，非洲，SR，SUR，740），苏里南共和国 <br />
    /// Cosmos i18n code: i18n_country_sulinan
    /// </summary>
    public static class Suriname
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Suriname()
        {
            _country = new CountryInfo
            {
                Country = Country.Suriname,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Suriname,
                UNCode = "740",
                Alpha2Code = "SR",
                Alpha3Code = "SUR",
                Name = "The Republic of Suriname",
                ShorterForm = "Suriname",
                ChineseName = "苏里南共和国",
                ChineseShorterForm = "苏里南",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 苏里南（The Republic of Suriname，非洲，SR，SUR，740），苏里南共和国 <br />
        /// Cosmos i18n code: i18n_country_sulinan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sulinan";
    }
}