namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
    /// Cosmos i18n code: i18n_country_boliweiya
    /// </summary>
    public static class Bolivia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bolivia()
        {
            _country = new CountryInfo
            {
                Country = Country.Bolivia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Bolivia,
                UNCode = "068",
                Alpha2Code = "BO",
                Alpha3Code = "BOL",
                Name = "Plurinational State of Bolivia",
                ShorterForm = "Bolivia",
                ChineseName = "多民族玻利维亚国",
                ChineseShorterForm = "玻利维亚",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_boliweiya";
    }
}