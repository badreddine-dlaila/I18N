namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 朝鲜（Democratic People's Republic of Korea，亚洲，KP，PRK，408），朝鲜民主主义人民共和国 <br />
    /// Cosmos i18n code: i18n_country_chaoxian
    /// </summary>
    public static class NorthKorea
    {
        private static readonly CountryInfo _country;

        static NorthKorea()
        {
            _country = new CountryInfo
            {
                Country = Country.NorthKorea,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.NorthKorea,
                UNCode = "408",
                Alpha2Code = "KP",
                Alpha3Code = "PRK",
                Name = "Democratic People's Republic of Korea",
                ShorterForm = "North Korea",
                ChineseName = "朝鲜民主主义人民共和国",
                ChineseShorterForm = "朝鲜",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 朝鲜（Democratic People's Republic of Korea，亚洲，KP，PRK，408），朝鲜民主主义人民共和国 <br />
        /// Cosmos i18n code: i18n_country_chaoxian
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_chaoxian";
    }
}