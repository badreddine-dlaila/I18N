namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 委内瑞拉（Bolivarian Republic of Venezuela，南美洲，VE，VEN，862），委内瑞拉玻利瓦尔共和国 <br />
    /// Cosmos i18n code: i18n_country_weineiruila
    /// </summary>
    public static class Venezuela
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Venezuela()
        {
            _country = new CountryInfo
            {
                Country = Country.Venezuela,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Venezuela,
                UNCode = "862",
                Alpha2Code = "VE",
                Alpha3Code = "VEN",
                Name = "Bolivarian Republic of Venezuela",
                ShorterForm = "Venezuela",
                ChineseName = "委内瑞拉玻利瓦尔共和国",
                ChineseShorterForm = "委内瑞拉",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 委内瑞拉（Bolivarian Republic of Venezuela，南美洲，VE，VEN，862），委内瑞拉玻利瓦尔共和国 <br />
        /// Cosmos i18n code: i18n_country_weineiruila
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_weineiruila";
    }
}