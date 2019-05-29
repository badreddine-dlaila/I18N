namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
    /// Cosmos i18n code: i18n_country_boziwana
    /// </summary>
    public static class Botswana
    {
        private static readonly CountryInfo _country;

        static Botswana()
        {
            _country = new CountryInfo
            {
                Country = Country.Botswana,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Botswana,
                UNCode = "072",
                Alpha2Code = "BW",
                Alpha3Code = "BWA",
                Name = "The Republic of Botswana",
                ShorterForm = "Burundi",
                ChineseName = "博茨瓦纳共和国",
                ChineseShorterForm = "博茨瓦纳",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
        /// Cosmos i18n code: i18n_country_boziwana
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_boziwana";
    }
}