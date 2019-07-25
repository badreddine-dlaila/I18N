namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 萨摩亚（The Independent State of Samoa，大洋洲，WS，WSM，882），萨摩亚独立国 <br />
    /// Cosmos i18n code: i18n_country_samoya
    /// </summary>
    public static class Samoa
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Samoa()
        {
            _country = new CountryInfo
            {
                Country = Country.Samoa,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Samoa,
                UNCode = "882",
                Alpha2Code = "WS",
                Alpha3Code = "WSM",
                Name = "The Independent State of Samoa",
                ShorterForm = "Samoa",
                ChineseName = "萨摩亚独立国",
                ChineseShorterForm = "萨摩亚",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 萨摩亚（The Independent State of Samoa，大洋洲，WS，WSM，882），萨摩亚独立国 <br />
        /// Cosmos i18n code: i18n_country_samoya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_samoya";
    }
}