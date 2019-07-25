namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 科威特（The State of Kuwait，亚洲，KW，KWT，414），科威特国 <br />
    /// Cosmos i18n code: i18n_country_keweite
    /// </summary>
    public static class Kuwait
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kuwait()
        {
            _country = new CountryInfo
            {
                Country = Country.Kuwait,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Kuwait,
                UNCode = "414",
                Alpha2Code = "KW",
                Alpha3Code = "KWT",
                Name = "The State of Kuwait",
                ShorterForm = "Kuwait",
                ChineseName = "科威特国",
                ChineseShorterForm = "科威特",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 科威特（The State of Kuwait，亚洲，KW，KWT，414），科威特国 <br />
        /// Cosmos i18n code: i18n_country_keweite
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_keweite";
    }
}