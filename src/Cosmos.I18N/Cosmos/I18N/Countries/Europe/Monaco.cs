namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 摩纳哥（The Principality of Monaco，欧洲，MC，MCO，492），摩纳哥公国 <br />
    /// Cosmos i18n code: i18n_country_monage
    /// </summary>
    public static class Monaco
    {
        private static readonly CountryInfo _country;

        static Monaco()
        {
            _country = new CountryInfo
            {
                Country = Country.Monaco,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Monaco,
                UNCode = "492",
                Alpha2Code = "MC",
                Alpha3Code = "MCO",
                Name = "The Principality of Monaco",
                ShorterForm = "Monaco",
                ChineseName = "摩纳哥公国",
                ChineseShorterForm = "摩纳哥",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 摩纳哥（The Principality of Monaco，欧洲，MC，MCO，492），摩纳哥公国 <br />
        /// Cosmos i18n code: i18n_country_monage
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_monage";
    }
}