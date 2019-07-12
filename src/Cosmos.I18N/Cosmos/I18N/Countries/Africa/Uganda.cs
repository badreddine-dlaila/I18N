namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 乌干达（The Republic of Uganda，非洲，UG，UGA，800），乌干达共和国 <br />
    /// Cosmos i18n code: i18n_country_wuganda
    /// </summary>
    public static class Uganda
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Uganda()
        {
            _country = new CountryInfo
            {
                Country = Country.Uganda,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Uganda,
                UNCode = "800",
                Alpha2Code = "UG",
                Alpha3Code = "UGA",
                Name = "The Republic of Uganda",
                ShorterForm = "Uganda",
                ChineseName = "乌干达共和国",
                ChineseShorterForm = "乌干达",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 乌干达（The Republic of Uganda，非洲，UG，UGA，800），乌干达共和国 <br />
        /// Cosmos i18n code: i18n_country_wuganda
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wuganda";
    }
}