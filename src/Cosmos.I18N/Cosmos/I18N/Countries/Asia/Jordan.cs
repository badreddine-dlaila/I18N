namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 约旦（The Hashemite Kingdom of Jordan，亚洲，JO，JOR，400），约旦哈希姆王国 <br />
    /// Cosmos i18n code: i18n_country_yuedan
    /// </summary>
    public static class Jordan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Jordan()
        {
            _country = new CountryInfo
            {
                Country = Country.Jordan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Jordan,
                UNCode = "400",
                Alpha2Code = "JO",
                Alpha3Code = "JOR",
                Name = "The Hashemite Kingdom of Jordan",
                ShorterForm = "Jordan",
                ChineseName = "约旦哈希姆王国",
                ChineseShorterForm = "约旦",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 约旦（The Hashemite Kingdom of Jordan，亚洲，JO，JOR，400），约旦哈希姆王国 <br />
        /// Cosmos i18n code: i18n_country_yuedan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yuedan";
    }
}