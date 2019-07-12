namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 梵蒂冈（Vatican City State，欧洲，VA，VAT，336），梵蒂冈城国 <br />
    /// Cosmos i18n code: i18n_country_fandigang
    /// </summary>
    public static class HolySee
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static HolySee()
        {
            _country = new CountryInfo
            {
                Country = Country.Iraq,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Iraq,
                UNCode = "336",
                Alpha2Code = "VA",
                Alpha3Code = "VAT",
                Name = "Vatican City State",
                ShorterForm = "Holy See",
                ChineseName = "梵蒂冈城国",
                ChineseShorterForm = "梵蒂冈",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 梵蒂冈（Vatican City State，欧洲，VA，VAT，336），梵蒂冈城国 <br />
        /// Cosmos i18n code: i18n_country_fandigang
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_fandigang";
    }
}