namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
    /// Cosmos i18n code: i18n_country_faguo
    /// </summary>
    public class France
    {
        private static readonly CountryInfo _country;

        static France()
        {
            _country = new CountryInfo
            {
                Country = Country.France,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.France,
                UNCode = "250",
                Alpha2Code = "FR",
                Alpha3Code = "FRA",
                Name = "French Republic",
                ShorterForm = "France",
                ChineseName = "法兰西共和国",
                ChineseShorterForm = "法国",
                ChineseAlias = "法兰西",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
        /// Cosmos i18n code: i18n_country_faguo
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_faguo";
    }
}