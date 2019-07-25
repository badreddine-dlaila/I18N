namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 秘鲁（The Republic of Peru，南美洲，PE，PER，604），秘鲁共和国 <br />
    /// Cosmos i18n code: i18n_country_bilu
    /// </summary>
    public static class Peru
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Peru()
        {
            _country = new CountryInfo
            {
                Country = Country.Peru,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Peru,
                UNCode = "604",
                Alpha2Code = "PE",
                Alpha3Code = "PER",
                Name = "The Republic of Peru",
                ShorterForm = "Peru",
                ChineseName = "秘鲁共和国",
                ChineseShorterForm = "秘鲁",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 秘鲁（The Republic of Peru，南美洲，PE，PER，604），秘鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_bilu
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bilu";
    }
}