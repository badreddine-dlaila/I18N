namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 马达加斯加（The Republic of Madagascar，非洲，MG，MDG，450），马达加斯加共和国 <br />
    /// Cosmos i18n code: i18n_country_madajiasijia
    /// </summary>
    public static class Madagascar
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Madagascar()
        {
            _country = new CountryInfo
            {
                Country = Country.Madagascar,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Madagascar,
                UNCode = "450",
                Alpha2Code = "MG",
                Alpha3Code = "MDG",
                Name = "The Republic of Madagascar",
                ShorterForm = "Madagascar",
                ChineseName = "马达加斯加共和国",
                ChineseShorterForm = "马达加斯加",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马达加斯加（The Republic of Madagascar，非洲，MG，MDG，450），马达加斯加共和国 <br />
        /// Cosmos i18n code: i18n_country_madajiasijia
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_madajiasijia";
    }
}