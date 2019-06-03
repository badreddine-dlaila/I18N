namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 帕劳（The Republic of Palau，大洋洲，PW，PLW，585），帕劳共和国 <br />
    /// Cosmos i18n code: i18n_country_palao
    /// </summary>
    public static class Palau
    {
        private static readonly CountryInfo _country;

        static Palau()
        {
            _country = new CountryInfo
            {
                Country = Country.Palau,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Palau,
                UNCode = "585",
                Alpha2Code = "PW",
                Alpha3Code = "PLW",
                Name = "The Republic of Palau",
                ShorterForm = "Palau",
                ChineseName = "帕劳共和国",
                ChineseShorterForm = "帕劳",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 帕劳（The Republic of Palau，大洋洲，PW，PLW，585），帕劳共和国 <br />
        /// Cosmos i18n code: i18n_country_palao
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_palao";
    }
}