namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 摩尔多瓦（Republic of Moldova，欧洲，MD，MDA，498），摩尔多瓦共和国 <br />
    /// Cosmos i18n code: i18n_country_moerduowa
    /// </summary>
    public static class Moldova
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Moldova()
        {
            _country = new CountryInfo
            {
                Country = Country.Moldova,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Moldova,
                UNCode = "498",
                Alpha2Code = "MD",
                Alpha3Code = "MDA",
                Name = "Republic of Moldova",
                ShorterForm = "Moldova",
                ChineseName = "摩尔多瓦共和国",
                ChineseShorterForm = "摩尔多瓦",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 摩尔多瓦（Republic of Moldova，欧洲，MD，MDA，498），摩尔多瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_moerduowa
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_moerduowa";
    }
}