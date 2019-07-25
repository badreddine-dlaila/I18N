namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
    /// Cosmos i18n code: i18n_country_aliteliya
    /// </summary>
    public static class Eritrea
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Eritrea()
        {
            _country = new CountryInfo
            {
                Country = Country.Eritrea,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Eritrea,
                UNCode = "232",
                Alpha2Code = "ER",
                Alpha3Code = "ERI",
                Name = "The State of Eritrea",
                ShorterForm = "Eritrea",
                ChineseName = "厄立特里亚国",
                ChineseShorterForm = "厄立特里亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
        /// Cosmos i18n code: i18n_country_aliteliya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aliteliya";
    }
}