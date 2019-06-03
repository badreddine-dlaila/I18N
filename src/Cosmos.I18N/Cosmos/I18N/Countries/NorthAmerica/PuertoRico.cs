namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 波多黎各（The Commonwealth of Puerto Rico，北美洲，PR，PRI，630），波多黎各自治邦 <br />
    /// Cosmos i18n code: i18n_country_boduolige
    /// </summary>
    public static class PuertoRico
    {
        private static readonly CountryInfo _country;

        static PuertoRico()
        {
            _country = new CountryInfo
            {
                Country = Country.PuertoRico,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedStates,
                UNCode = "630",
                Alpha2Code = "PR",
                Alpha3Code = "PRI",
                Name = "The Commonwealth of Puerto Rico",
                ShorterForm = "Puerto Rico",
                ChineseName = "波多黎各自治邦",
                ChineseShorterForm = "波多黎各",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 波多黎各（The Commonwealth of Puerto Rico，北美洲，PR，PRI，630），波多黎各自治邦 <br />
        /// Cosmos i18n code: i18n_country_boduolige
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_boduolige";
    }
}