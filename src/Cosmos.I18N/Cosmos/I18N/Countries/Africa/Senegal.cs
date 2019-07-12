namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 塞内加尔（The Republic of Senegal，非洲，SN，SEN，686），塞内加尔共和国 <br />
    /// Cosmos i18n code: i18n_country_saineijiaer
    /// </summary>
    public static class Senegal
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Senegal()
        {
            _country = new CountryInfo
            {
                Country = Country.Senegal,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Senegal,
                UNCode = "686",
                Alpha2Code = "SN",
                Alpha3Code = "SEN",
                Name = "The Republic of Senegal",
                ShorterForm = "Senegal",
                ChineseName = "塞内加尔共和国",
                ChineseShorterForm = "塞内加尔",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 塞内加尔（The Republic of Senegal，非洲，SN，SEN，686），塞内加尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saineijiaer
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saineijiaer";
    }
}