namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 加纳（The Republic of Ghana，非洲，GH，GHA，288），加纳共和国 <br />
    /// Cosmos i18n code: i18n_country_jiana
    /// </summary>
    public static class Ghana
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Ghana()
        {
            _country = new CountryInfo
            {
                Country = Country.Ghana,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Ghana,
                UNCode = "288",
                Alpha2Code = "GH",
                Alpha3Code = "GHA",
                Name = "The Republic of Ghana",
                ShorterForm = "Ghana",
                ChineseName = "加纳共和国",
                ChineseShorterForm = "加纳",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 加纳（The Republic of Ghana，非洲，GH，GHA，288），加纳共和国 <br />
        /// Cosmos i18n code: i18n_country_jiana
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jiana";
    }
}