namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 瓜德罗普（Guadeloupe，北美洲，GP，GLP，312） <br />
    /// Cosmos i18n code: i18n_country_guadeluopu
    /// </summary>
    public static class Guadeloupe
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guadeloupe()
        {
            _country = new CountryInfo
            {
                Country = Country.Guadeloupe,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "312",
                Alpha2Code = "GP",
                Alpha3Code = "GLP",
                Name = "Guadeloupe",
                ChineseName = "瓜德罗普",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 瓜德罗普（Guadeloupe，北美洲，GP，GLP，312） <br />
        /// Cosmos i18n code: i18n_country_guadeluopu
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guadeluopu";
    }
}