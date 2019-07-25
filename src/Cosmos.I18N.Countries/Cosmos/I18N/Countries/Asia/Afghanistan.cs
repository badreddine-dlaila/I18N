namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
    /// Cosmos i18n code: i18n_country_afuhan
    /// </summary>
    public static class Afghanistan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Afghanistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Afghanistan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Afghanistan,
                UNCode = "004",
                Alpha2Code = "AF",
                Alpha3Code = "AFG",
                Name = "Afghanistan",
                ChineseName = "阿富汗伊斯兰国",
                ChineseShorterForm = "阿富汗",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
        /// Cosmos i18n code: i18n_country_afuhan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_afuhan";
    }
}