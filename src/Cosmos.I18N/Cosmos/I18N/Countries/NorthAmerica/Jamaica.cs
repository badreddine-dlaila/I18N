namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 牙买加（Republic Of Iraq，北美洲，JM，JAM，388） <br />
    /// Cosmos i18n code: i18n_country_yamaijia
    /// </summary>
    public static class Jamaica
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Jamaica()
        {
            _country = new CountryInfo
            {
                Country = Country.Jamaica,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Jamaica,
                UNCode = "388",
                Alpha2Code = "JM",
                Alpha3Code = "JAM",
                Name =  "Jamaica",
                ChineseName = "牙买加",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 牙买加（Republic Of Iraq，北美洲，JM，JAM，388） <br />
        /// Cosmos i18n code: i18n_country_yamaijia
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yamaijia";
    }
}