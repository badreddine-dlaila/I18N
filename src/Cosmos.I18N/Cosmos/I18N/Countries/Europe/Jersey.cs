namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 泽西（Bailiwick of Jersey，欧洲，JE，JEY，832），泽西岛 <br />
    /// Cosmos i18n code: i18n_country_zexi
    /// </summary>
    public static class Jersey
    {
        private static readonly CountryInfo _country;

        static Jersey()
        {
            _country = new CountryInfo
            {
                Country = Country.Jersey,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "832",
                Alpha2Code = "JE",
                Alpha3Code = "JEY",
                Name = "Bailiwick of Jersey",
                ShorterForm = "Jersey",
                ChineseName = "泽西岛",
                ChineseShorterForm = "泽西",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 泽西（Bailiwick of Jersey，欧洲，JE，JEY，832），泽西岛 <br />
        /// Cosmos i18n code: i18n_country_zexi
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_zexi";
    }
}