namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 西班牙（The Kingdom of Spain，南美洲，ES，ESP，724），西班牙王国 <br />
    /// Cosmos i18n code: i18n_country_xibanya
    /// </summary>
    public static class Spain
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Spain()
        {
            _country = new CountryInfo
            {
                Country = Country.Spain,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Spain,
                UNCode = "724",
                Alpha2Code = "ES",
                Alpha3Code = "ESP",
                Name = "The Kingdom of Spain",
                ShorterForm = "Spain",
                ChineseName = "西班牙王国",
                ChineseShorterForm = "西班牙",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 西班牙（The Kingdom of Spain，南美洲，ES，ESP，724），西班牙王国 <br />
        /// Cosmos i18n code: i18n_country_xibanya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xibanya";
    }
}