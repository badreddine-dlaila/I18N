namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 新加坡（Republic of Singapore，亚洲，SG，SGP，702），新加坡共和国 <br />
    /// Cosmos i18n code: i18n_country_xinjiapo
    /// </summary>
    public static class Singapore
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Singapore()
        {
            _country = new CountryInfo
            {
                Country = Country.Singapore,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Singapore,
                UNCode = "702",
                Alpha2Code = "SG",
                Alpha3Code = "SGP",
                Name = "Republic of Singapore",
                ShorterForm = "Singapore",
                ChineseName = "新加坡共和国",
                ChineseShorterForm = "新加坡",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 新加坡（Republic of Singapore，亚洲，SG，SGP，702），新加坡共和国 <br />
        /// Cosmos i18n code: i18n_country_xinjiapo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xinjiapo";
    }
}