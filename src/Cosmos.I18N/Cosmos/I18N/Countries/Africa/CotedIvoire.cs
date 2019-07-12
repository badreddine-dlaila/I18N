namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
    /// Cosmos i18n code: i18n_country_ketediwa
    /// </summary>
    public static class CotedIvoire
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CotedIvoire()
        {
            _country = new CountryInfo
            {
                Country = Country.CotedIvoire,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.CotedIvoire,
                UNCode = "384",
                Alpha2Code = "CI",
                Alpha3Code = "CIV",
                Name = "The Republic of Côte d'Ivoire",
                ShorterForm = "Côte d'Ivoire",
                ChineseName = "科特迪瓦共和国",
                ChineseShorterForm = "科特迪瓦",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_ketediwa
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_ketediwa";
    }
}