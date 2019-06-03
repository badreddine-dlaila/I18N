namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 土库曼（Turkmenistan，亚洲，TM，TKM，795），土库曼斯坦 <br />
    /// Cosmos i18n code: i18n_country_tukumansitan
    /// </summary>
    public static class Turkmenistan
    {
        private static readonly CountryInfo _country;

        static Turkmenistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Turkmenistan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Turkmenistan,
                UNCode = "795",
                Alpha2Code = "TM",
                Alpha3Code = "TKM",
                Name = "Turkmenistan",
                ChineseName = "土库曼斯坦",
                ChineseShorterForm = "土库曼",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 土库曼（Turkmenistan，亚洲，TM，TKM，795），土库曼斯坦 <br />
        /// Cosmos i18n code: i18n_country_tukumansitan
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_tukumansitan";
    }
}