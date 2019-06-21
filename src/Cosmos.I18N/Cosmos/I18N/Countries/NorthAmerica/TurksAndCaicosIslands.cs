namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 特克斯和凯科斯群岛（The Turks and Caicos Islands，北美洲，TC，TCA，796） <br />
    /// Cosmos i18n code: i18n_country_tekesikks
    /// </summary>
    public static class TurksAndCaicosIslands
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static TurksAndCaicosIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.TurksAndCaicosIslands,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.TurksAndCaicosIslands,
                UNCode = "796",
                Alpha2Code = "TC",
                Alpha3Code = "TCA",
                Name = "The Turks and Caicos Islands",
                ChineseName = "特克斯和凯科斯群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 特克斯和凯科斯群岛（The Turks and Caicos Islands，北美洲，TC，TCA，796） <br />
        /// Cosmos i18n code: i18n_country_tekesikks
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tekesikks";
    }
}