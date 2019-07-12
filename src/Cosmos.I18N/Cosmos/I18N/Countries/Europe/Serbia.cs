namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 塞尔维亚（The Republic of Serbia，欧洲，RS，SRB，688），塞尔维亚共和国 <br />
    /// Cosmos i18n code: i18n_country_saierweiya
    /// </summary>
    public static class Serbia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Serbia()
        {
            _country = new CountryInfo
            {
                Country = Country.Serbia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Serbia,
                UNCode = "688",
                Alpha2Code = "RS",
                Alpha3Code = "SRB",
                Name = "The Republic of Serbia",
                ShorterForm = "Serbia",
                ChineseName = "塞尔维亚共和国",
                ChineseShorterForm = "塞尔维亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 塞尔维亚（The Republic of Serbia，欧洲，RS，SRB，688），塞尔维亚共和国 <br />
        /// Cosmos i18n code: i18n_country_saierweiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saierweiya";
    }
}