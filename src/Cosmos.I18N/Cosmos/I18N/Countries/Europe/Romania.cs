namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 罗马尼亚（Romania，欧洲，RO，ROU，642） <br />
    /// Cosmos i18n code: i18n_country_luomaniya
    /// </summary>
    public static class Romania
    {
        private static readonly CountryInfo _country;

        static Romania()
        {
            _country = new CountryInfo
            {
                Country = Country.Romania,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Romania,
                UNCode = "642",
                Alpha2Code = "RO",
                Alpha3Code = "ROU",
                Name = "Romania",
                ChineseName = "罗马尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 罗马尼亚（Romania，欧洲，RO，ROU，642） <br />
        /// Cosmos i18n code: i18n_country_luomaniya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_luomaniya";
    }
}