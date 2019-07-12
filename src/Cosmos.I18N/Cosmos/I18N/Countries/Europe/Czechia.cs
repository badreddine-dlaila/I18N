namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
    /// Cosmos i18n code: i18n_country_jieke
    /// </summary>
    public static class Czechia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Czechia()
        {
            _country = new CountryInfo
            {
                Country = Country.Czechia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Czechia,
                UNCode = "203",
                Alpha2Code = "CZ",
                Alpha3Code = "CZE",
                Name = "The Czech Republic",
                ShorterForm = "Czechia",
                ChineseName = "捷克共和国",
                ChineseShorterForm = "捷克",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
        /// Cosmos i18n code: i18n_country_jieke
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jieke";
    }
}