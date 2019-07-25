namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_aishaniya
    /// </summary>
    public static class Estonia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Estonia()
        {
            _country = new CountryInfo
            {
                Country = Country.Estonia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Estonia,
                UNCode = "233",
                Alpha2Code = "EE",
                Alpha3Code = "EST",
                Name = "Republic of Estonia",
                ShorterForm = "Ecuador",
                ChineseName = "爱沙尼亚共和国",
                ChineseShorterForm = "爱沙尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aishaniya
        /// </summary>
        public static CountryInfo Instance => _country;
        
        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aishaniya";

    }
}