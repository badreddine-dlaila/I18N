namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 南苏丹（The Republic of South Sudan，非洲，SS，SSD，728），南苏丹共和国 <br />
    /// Cosmos i18n code: i18n_country_nansudan
    /// </summary>
    public static class SouthSudan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SouthSudan()
        {
            _country = new CountryInfo
            {
                Country = Country.SouthSudan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SouthSudan,
                UNCode = "728",
                Alpha2Code = "SS",
                Alpha3Code = "SSD",
                Name = "The Republic of South Sudan",
                ShorterForm = "South Sudan",
                ChineseName = "南苏丹共和国",
                ChineseShorterForm = "南苏丹",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 南苏丹（The Republic of South Sudan，非洲，SS，SSD，728），南苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_nansudan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nansudan";
    }
}