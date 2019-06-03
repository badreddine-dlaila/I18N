namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 斯洛伐克（The Slovak Republic，欧洲，SK，SVK，703），斯洛伐克共和国 <br />
    /// Cosmos i18n code: i18n_country_siluofake
    /// </summary>
    public static class Slovakia
    {
        private static readonly CountryInfo _country;

        static Slovakia()
        {
            _country = new CountryInfo
            {
                Country = Country.Slovakia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Slovakia,
                UNCode = "703",
                Alpha2Code = "SK",
                Alpha3Code = "SVK",
                Name = "The Slovak Republic",
                ShorterForm = "Slovakia",
                ChineseName = "斯洛伐克共和国",
                ChineseShorterForm = "斯洛伐克",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯洛伐克（The Slovak Republic，欧洲，SK，SVK，703），斯洛伐克共和国 <br />
        /// Cosmos i18n code: i18n_country_siluofake
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_siluofake";
    }
}