namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
    /// Cosmos i18n code: i18n_country_duominijia
    /// </summary>
    public static class Dominican
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Dominican()
        {
            _country = new CountryInfo
            {
                Country = Country.Dominican,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Dominican,
                UNCode = "214",
                Alpha2Code = "DO",
                Alpha3Code = "DOM",
                Name = "The Dominican Republic",
                ShorterForm = "Dominican",
                ChineseName = "多米尼加共和国",
                ChineseShorterForm = "多米尼加",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
        /// Cosmos i18n code: i18n_country_duominijia
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_duominijia";
    }
}