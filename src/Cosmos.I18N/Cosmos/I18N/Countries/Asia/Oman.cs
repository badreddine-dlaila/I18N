namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 阿曼（Sultanate of Oman，亚洲，OM，OMN，512），阿曼苏丹国 <br />
    /// Cosmos i18n code: i18n_country_aman
    /// </summary>
    public static class Oman
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Oman()
        {
            _country = new CountryInfo
            {
                Country = Country.Oman,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Oman,
                UNCode = "512",
                Alpha2Code = "OM",
                Alpha3Code = "OMN",
                Name = "Sultanate of Oman",
                ShorterForm = "Oman",
                ChineseName = "阿曼苏丹国",
                ChineseShorterForm = "阿曼",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿曼（Sultanate of Oman，亚洲，OM，OMN，512），阿曼苏丹国 <br />
        /// Cosmos i18n code: i18n_country_aman
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aman";
    }
}