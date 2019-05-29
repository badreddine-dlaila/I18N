namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
    /// Cosmos i18n code: i18n_country_ruishi
    /// </summary>
    public static class Switzerland
    {
        private static readonly CountryInfo _country;

        static Switzerland()
        {
            _country = new CountryInfo
            {
                Country = Country.Switzerland,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Switzerland,
                UNCode = "756",
                Alpha2Code = "CH",
                Alpha3Code = "CHE",
                Name = "Swiss Confederation",
                ShorterForm = "Switzerland",
                ChineseName = "瑞士联邦",
                ChineseShorterForm = "瑞士",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
        /// Cosmos i18n code: i18n_country_ruishi
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_ruishi";
    }
}