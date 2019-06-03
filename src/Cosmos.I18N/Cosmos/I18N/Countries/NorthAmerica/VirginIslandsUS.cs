namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 美属维尔京群岛（The United States Virgin Islands，北美洲，VI，VIR，850） <br />
    /// Cosmos i18n code: i18n_country_meishuweierjing
    /// </summary>
    public static class VirginIslandsUS
    {
        private static readonly CountryInfo _country;

        static VirginIslandsUS()
        {
            _country = new CountryInfo
            {
                Country = Country.VirginIslandsUS,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedStates,
                UNCode = "850",
                Alpha2Code = "VI",
                Alpha3Code = "VIR",
                Name = "The United States Virgin Islands",
                ShorterForm = "Virgin Islands (U.S.)",
                ChineseName = "美属维尔京群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 美属维尔京群岛（The United States Virgin Islands，北美洲，VI，VIR，850） <br />
        /// Cosmos i18n code: i18n_country_meishuweierjing
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_meishuweierjing";
    }
}