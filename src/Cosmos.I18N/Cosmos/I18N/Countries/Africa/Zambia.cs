namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_zanbiya
    /// </summary>
    public static class Zambia
    {
        private static readonly CountryInfo _country;

        static Zambia()
        {
            _country = new CountryInfo
            {
                Country = Country.Zambia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Zambia,
                UNCode = "894",
                Alpha2Code = "ZM",
                Alpha3Code = "ZMB",
                Name = "The Republic of Zambia",
                ShorterForm = "Zambia",
                ChineseName = "赞比亚共和国",
                ChineseShorterForm = "赞比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_zanbiya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_zanbiya";
    }
}