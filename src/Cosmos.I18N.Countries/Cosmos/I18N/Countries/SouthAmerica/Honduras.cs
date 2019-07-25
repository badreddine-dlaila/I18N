namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 洪都拉斯（The Republic of Honduras，南美洲，HN，HND，340），洪都拉斯共和国 <br />
    /// Cosmos i18n code: i18n_country_hongdulasi
    /// </summary>
    public static class Honduras
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Honduras()
        {
            _country = new CountryInfo
            {
                Country = Country.Honduras,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Honduras,
                UNCode = "340",
                Alpha2Code = "HN",
                Alpha3Code = "HND",
                Name = "The Republic of Honduras",
                ShorterForm = "Honduras",
                ChineseName = "洪都拉斯共和国",
                ChineseShorterForm = "洪都拉斯",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 洪都拉斯（The Republic of Honduras，南美洲，HN，HND，340），洪都拉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_hongdulasi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hongdulasi";
    }
}