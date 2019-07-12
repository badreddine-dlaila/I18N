namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
    /// Cosmos i18n code: i18n_country_baieluosi
    /// </summary>
    public static class Belarus
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Belarus()
        {
            _country = new CountryInfo
            {
                Country = Country.Belarus,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Belarus,
                UNCode = "112",
                Alpha2Code = "BY",
                Alpha3Code = "BLR",
                Name = "Republic of Belarus",
                ShorterForm = "Belarus",
                ChineseName = "白俄罗斯共和国",
                ChineseShorterForm = "白俄罗斯",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
        /// Cosmos i18n code: i18n_country_baieluosi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_baieluosi";
    }
}