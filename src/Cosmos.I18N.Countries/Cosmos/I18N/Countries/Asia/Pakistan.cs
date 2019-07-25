namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 巴基斯坦（Islamic Republic of Pakistan，亚洲，PK，PAK，586），巴基斯坦伊斯兰共和国 <br />
    /// Cosmos i18n code: i18n_country_bajisitan
    /// </summary>
    public static class Pakistan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Pakistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Pakistan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Pakistan,
                UNCode = "586",
                Alpha2Code = "PK",
                Alpha3Code = "PAK",
                Name = "Islamic Republic of Pakistan",
                ShorterForm = "Pakistan",
                ChineseName = "巴基斯坦伊斯兰共和国",
                ChineseShorterForm = "巴基斯坦",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴基斯坦（Islamic Republic of Pakistan，亚洲，PK，PAK，586），巴基斯坦伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_bajisitan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bajisitan";
    }
}