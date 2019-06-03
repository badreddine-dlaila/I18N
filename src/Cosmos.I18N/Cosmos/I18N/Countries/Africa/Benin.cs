namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
    /// Cosmos i18n code: i18n_country_beining
    /// </summary>
    public static class Benin
    {
        private static readonly CountryInfo _country;

        static Benin()
        {
            _country = new CountryInfo
            {
                Country = Country.Benin,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Benin,
                UNCode = "204",
                Alpha2Code = "BJ",
                Alpha3Code = "BEN",
                Name = "The Republic of Benin",
                ShorterForm = "Benin",
                ChineseName = "贝宁共和国",
                ChineseShorterForm = "贝宁",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
        /// Cosmos i18n code: i18n_country_beining
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_beining";
    }
}