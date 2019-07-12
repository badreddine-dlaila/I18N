namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
    /// Cosmos i18n code: i18n_country_kukequndao
    /// </summary>
    public static class CookIslands
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CookIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.CookIslands,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.CookIslands,
                UNCode = "184",
                Alpha2Code = "CK",
                Alpha3Code = "COK",
                Name = "The Cook Islands",
                ShorterForm = "Cook Islands",
                ChineseName = "库克群岛",
                ChineseShorterForm = "瑞士",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
        /// Cosmos i18n code: i18n_country_kukequndao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kukequndao";
    }
}