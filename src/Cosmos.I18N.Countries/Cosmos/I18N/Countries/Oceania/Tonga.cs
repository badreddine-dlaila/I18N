namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 汤加（The Kingdom of Tonga，大洋洲，TO，TN，776），汤加王国 <br />
    /// Cosmos i18n code: i18n_country_tangjia
    /// </summary>
    public static class Tonga
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tonga()
        {
            _country = new CountryInfo
            {
                Country = Country.Tonga,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Tonga,
                UNCode = "776",
                Alpha2Code = "TO",
                Alpha3Code = "TON",
                Name = "The Kingdom of Tonga",
                ShorterForm = "Tonga",
                ChineseName = "汤加王国",
                ChineseShorterForm = "汤加",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 汤加（The Kingdom of Tonga，大洋洲，TO，TN，776），汤加王国 <br />
        /// Cosmos i18n code: i18n_country_tangjia
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tangjia";
    }
}