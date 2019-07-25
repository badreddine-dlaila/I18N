namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 哈萨克斯坦（ The Republic of Kazakhstan，亚洲，KZ，KAZ，398），哈萨克斯坦共和国 <br />
    /// Cosmos i18n code: i18n_country_hasakesitan
    /// </summary>
    public static class Kazakhstan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kazakhstan()
        {
            _country = new CountryInfo
            {
                Country = Country.Kazakhstan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Kazakhstan,
                UNCode = "398",
                Alpha2Code = "KZ",
                Alpha3Code = "KAZ",
                Name = " The Republic of Kazakhstan",
                ShorterForm = "Kazakhstan",
                ChineseName = "哈萨克斯坦共和国",
                ChineseShorterForm = "哈萨克斯坦",
                ChineseAlias = "哈萨克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 哈萨克斯坦（ The Republic of Kazakhstan，亚洲，KZ，KAZ，398），哈萨克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_hasakesitan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hasakesitan";
    }
}