namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 塔吉克斯坦（The Republic of Tajikistan，亚洲，TJ，TJK，762），塔吉克斯坦共和国 <br />
    /// Cosmos i18n code: i18n_country_tajikesitan
    /// </summary>
    public static class Tajikistan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tajikistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Tajikistan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Tajikistan,
                UNCode = "762",
                Alpha2Code = "TJ",
                Alpha3Code = "TJK",
                Name = "The Republic of Tajikistan",
                ShorterForm = "Tajikistan",
                ChineseName = "塔吉克斯坦共和国",
                ChineseShorterForm = "塔吉克斯坦",
                ChineseAlias = "塔吉克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 塔吉克斯坦（The Republic of Tajikistan，亚洲，TJ，TJK，762），塔吉克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_tajikesitan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tajikesitan";
    }
}