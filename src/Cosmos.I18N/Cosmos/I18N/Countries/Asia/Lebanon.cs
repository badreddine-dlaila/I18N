namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 黎巴嫩（The Republic of Lebanon，亚洲，LB，LBN，422），黎巴嫩共和国 <br />
    /// Cosmos i18n code: i18n_country_libanen
    /// </summary>
    public static class Lebanon
    {
        private static readonly CountryInfo _country;

        static Lebanon()
        {
            _country = new CountryInfo
            {
                Country = Country.Lebanon,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Lebanon,
                UNCode = "422",
                Alpha2Code = "LB",
                Alpha3Code = "LBN",
                Name = "The Republic of Lebanon",
                ShorterForm = "Lebanon",
                ChineseName = "黎巴嫩共和国",
                ChineseShorterForm = "黎巴嫩",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 黎巴嫩（The Republic of Lebanon，亚洲，LB，LBN，422），黎巴嫩共和国 <br />
        /// Cosmos i18n code: i18n_country_libanen
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_libanen";
    }
}