namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 马提尼克岛（Martinique，北美洲，MQ，MTQ，474），法国的海外大区 <br />
    /// Cosmos i18n code: i18n_country_matinike
    /// </summary>
    public static class Martinique
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Martinique()
        {
            _country = new CountryInfo
            {
                Country = Country.Martinique,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "474",
                Alpha2Code = "MQ",
                Alpha3Code = "MTQ",
                Name = "Martinique",
                ChineseName = "马提尼克岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马提尼克岛（Martinique，北美洲，MQ，MTQ，474），法国的海外大区 <br />
        /// Cosmos i18n code: i18n_country_matinike
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_matinike";
    }
}