namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 波利尼西亚（French Polynesia，大洋洲，PF，PYF，258），法属波利尼西亚 <br />
    /// Cosmos i18n code: i18n_country_bolinixiya
    /// </summary>
    public static class Polynesia
    {
        private static readonly CountryInfo _country;

        static Polynesia()
        {
            _country = new CountryInfo
            {
                Country = Country.Polynesia,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "258",
                Alpha2Code = "PF",
                Alpha3Code = "PYF",
                Name = "French Polynesia",
                ShorterForm = "Polynesia",
                ChineseName = "法属波利尼西亚",
                ChineseShorterForm = "波利尼西亚",
                ChineseAlias = "塔希提",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 波利尼西亚（French Polynesia，大洋洲，PF，PYF，258），法属波利尼西亚 <br />
        /// Cosmos i18n code: i18n_country_bolinixiya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_bolinixiya";
    }
}