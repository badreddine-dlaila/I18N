namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 美国本土外小岛屿（United States Minor Outlying Islands，北美洲，UM，UMI，581） <br />
    /// Cosmos i18n code: i18n_country_meiguoum
    /// </summary>
    public static class UnitedStatesMinorOutlyingIslands
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static UnitedStatesMinorOutlyingIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.UnitedStatesMinorOutlyingIslands,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedStates,
                UNCode = "581",
                Alpha2Code = "UM",
                Alpha3Code = "UMI",
                Name = "United States Minor Outlying Islands",
                ChineseName = "美国本土外小岛屿",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 美国本土外小岛屿（United States Minor Outlying Islands，北美洲，UM，UMI，581） <br />
        /// Cosmos i18n code: i18n_country_meiguoum
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_meiguoum";
    }
}