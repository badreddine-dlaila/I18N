namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
    /// Cosmos i18n code: i18n_country_helan
    /// </summary>
    public static class Netherlands
    {
        private static readonly CountryInfo _country;

        static Netherlands()
        {
            _country = new CountryInfo
            {
                Country = Country.Netherlands,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Netherlands,
                UNCode = "528",
                Alpha2Code = "NL",
                Alpha3Code = "NLD",
                Name = "The Kingdom of the Netherlands",
                ShorterForm = "Netherlands",
                ChineseName = "荷兰王国",
                ChineseShorterForm = "荷兰",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
        /// Cosmos i18n code: i18n_country_helan
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_helan";
    }
}