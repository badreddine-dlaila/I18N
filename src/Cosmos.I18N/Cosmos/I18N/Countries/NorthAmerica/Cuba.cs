namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
    /// Cosmos i18n code: i18n_country_guba
    /// </summary>
    public static class Cuba
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Cuba()
        {
            _country = new CountryInfo
            {
                Country = Country.Cuba,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Cuba,
                UNCode = "192",
                Alpha2Code = "CU",
                Alpha3Code = "CUB",
                Name = "The Republic of Cuba",
                ShorterForm = "Cuba",
                ChineseName = "古巴共和国",
                ChineseShorterForm = "古巴",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
        /// Cosmos i18n code: i18n_country_guba
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guba";
    }
}