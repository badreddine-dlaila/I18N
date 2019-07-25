namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 韩国（Republic Of Korea，亚洲，KR，KOR，410），大韩民国 <br />
    /// Cosmos i18n code: i18n_country_hanguo
    /// </summary>
    public static class SouthKorea
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SouthKorea()
        {
            _country = new CountryInfo
            {
                Country = Country.SouthKorea,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SouthKorea,
                UNCode = "410",
                Alpha2Code = "KR",
                Alpha3Code = "KOR",
                Name = "Republic Of Korea",
                ShorterForm = "South Korea",
                ChineseName = "大韩民国",
                ChineseShorterForm = "韩国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 韩国（Republic Of Korea，亚洲，KR，KOR，410），大韩民国 <br />
        /// Cosmos i18n code: i18n_country_hanguo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hanguo";
    }
}