namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
    /// Cosmos i18n code: i18n_country_danmai
    /// </summary>
    public static class Denmark
    {
        private static readonly CountryInfo _country;

        static Denmark()
        {
            _country = new CountryInfo
            {
                Country = Country.Denmark,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Denmark,
                UNCode = "208",
                Alpha2Code = "DK",
                Alpha3Code = "DNK",
                Name = "The Kingdom of Denmark",
                ShorterForm = "Denmark",
                ChineseName = "丹麦王国",
                ChineseShorterForm = "丹麦",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
        /// Cosmos i18n code: i18n_country_danmai
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_danmai";
    }
}