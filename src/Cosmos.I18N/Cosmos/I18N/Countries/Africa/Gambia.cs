namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 冈比亚（Republic of The Gambia，非洲，GM，GMB，270），冈比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_gangbiya
    /// </summary>
    public static class Gambia
    {
        private static readonly CountryInfo _country;

        static Gambia()
        {
            _country = new CountryInfo
            {
                Country = Country.Gambia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Gambia,
                UNCode = "270",
                Alpha2Code = "GM",
                Alpha3Code = "GMB",
                Name = "Republic of The Gambia",
                ShorterForm = "Gambia",
                ChineseName = "冈比亚共和国",
                ChineseShorterForm = "冈比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 冈比亚（Republic of The Gambia，非洲，GM，GMB，270），冈比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gangbiya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_gangbiya";
    }
}