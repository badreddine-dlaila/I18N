namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 瓦利斯和富图纳群岛（Wallis and Futuna Islands，大洋洲，WF，WLF，876） <br />
    /// Cosmos i18n code: i18n_country_walisi
    /// </summary>
    public static class WallisAndFutuna
    {
        private static readonly CountryInfo _country;

        static WallisAndFutuna()
        {
            _country = new CountryInfo
            {
                Country = Country.WallisAndFutuna,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "876",
                Alpha2Code = "WF",
                Alpha3Code = "WLF",
                Name = "Wallis and Futuna Islands",
                ChineseName = "瓦利斯和富图纳群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 瓦利斯和富图纳群岛（Wallis and Futuna Islands，大洋洲，WF，WLF，876） <br />
        /// Cosmos i18n code: i18n_country_walisi
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_walisi";
    }
}