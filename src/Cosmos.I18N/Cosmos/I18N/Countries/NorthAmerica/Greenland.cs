namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 格陵兰岛（Greenland，北美洲，GL，GRL，304） <br />
    /// Cosmos i18n code: i18n_country_gelinlan
    /// </summary>
    public static class Greenland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Greenland()
        {
            _country = new CountryInfo
            {
                Country = Country.Greenland,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Greenland,
                UNCode = "304",
                Alpha2Code = "GL",
                Alpha3Code = "GRL",
                Name = "Greenland",
                ChineseName = "格陵兰岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 格陵兰岛（Greenland，北美洲，GL，GRL，304） <br />
        /// Cosmos i18n code: i18n_country_gelinlan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gelinlan";
    }
}