namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 马奥霍（Territorial Collectivity of Mayotte ，非洲，AF，AFG，004），马约特岛 <br />
    /// Cosmos i18n code: i18n_country_mayuete
    /// </summary>
    public static class Mayotte
    {
        private static readonly CountryInfo _country;

        static Mayotte()
        {
            _country = new CountryInfo
            {
                Country = Country.Mayotte,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Mayotte,
                UNCode = "175",
                Alpha2Code = "YT",
                Alpha3Code = "MYT",
                Name = "Territorial Collectivity of Mayotte",
                ShorterForm = "Mahore",
                ChineseName = "马约特岛",
                ChineseShorterForm = "马奥霍",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马奥霍（Territorial Collectivity of Mayotte，非洲，AF，AFG，004），马约特岛 <br />
        /// Cosmos i18n code: i18n_country_mayuete
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_mayuete";
    }
}