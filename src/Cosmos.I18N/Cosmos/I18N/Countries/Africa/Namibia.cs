namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 纳米比亚（The Republic of Namibia，非洲，NA，NAM，516），纳米比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_manibiya
    /// </summary>
    public static class Namibia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Namibia()
        {
            _country = new CountryInfo
            {
                Country = Country.Namibia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Namibia,
                UNCode = "516",
                Alpha2Code = "NA",
                Alpha3Code = "NAM",
                Name = "The Republic of Namibia",
                ShorterForm = "Namibia",
                ChineseName = "纳米比亚共和国",
                ChineseShorterForm = "纳米比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 纳米比亚（The Republic of Namibia，非洲，NA，NAM，516），纳米比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_manibiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_manibiya";
    }
}