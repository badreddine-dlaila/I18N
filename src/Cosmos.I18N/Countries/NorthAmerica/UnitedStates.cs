namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
    /// Cosmos i18n code: i18n_country_meiguo
    /// </summary>
    public static class UnitedStates
    {
        private static readonly CountryInfo _country;

        static UnitedStates()
        {
            _country = new CountryInfo
            {
                Country = Country.UnitedStates,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.UnitedStates,
                UNCode = "840",
                Alpha2Code = "US",
                Alpha3Code = "USA",
                Name = "United States of America",
                ShorterForm = "United States",
                ChineseName = "美利坚合众国",
                ChineseShorterForm = "美国",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
        /// Cosmos i18n code: i18n_country_meiguo
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_meiguo";
    }
}