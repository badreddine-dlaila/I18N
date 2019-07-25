namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 索马里（The Federal Republic of Somalia，非洲，SO，SOM，706），索马里联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_suomali
    /// </summary>
    public static class Somalia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Somalia()
        {
            _country = new CountryInfo
            {
                Country = Country.Somalia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Somalia,
                UNCode = "706",
                Alpha2Code = "SO",
                Alpha3Code = "SOM",
                Name = "The Federal Republic of Somalia",
                ShorterForm = "Somalia",
                ChineseName = "索马里联邦共和国",
                ChineseShorterForm = "索马里",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 索马里（The Federal Republic of Somalia，非洲，SO，SOM，706），索马里联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_suomali
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_suomali";
    }
}