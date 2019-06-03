namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 密克罗尼西亚（The Federated States of Micronesia，大洋洲，FM，FSM，583） ，密克罗尼西亚联邦<br />
    /// Cosmos i18n code: i18n_country_mikeluonixiya
    /// </summary>
    public static class Micronesia
    {
        private static readonly CountryInfo _country;

        static Micronesia()
        {
            _country = new CountryInfo
            {
                Country = Country.Micronesia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Micronesia,
                UNCode = "583",
                Alpha2Code = "FM",
                Alpha3Code = "FSM",
                Name = "The Federated States of Micronesia",
                ShorterForm="Micronesia",
                ChineseName = "密克罗尼西亚联邦",
                ChineseShorterForm="密联邦",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 密克罗尼西亚（The Federated States of Micronesia，大洋洲，FM，FSM，583） ，密克罗尼西亚联邦<br />
        /// Cosmos i18n code: i18n_country_mikeluonixiya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_mikeluonixiya";
    }
}