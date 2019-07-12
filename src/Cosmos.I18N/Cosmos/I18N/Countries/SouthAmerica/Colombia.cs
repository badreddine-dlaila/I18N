namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_gelunbiya
    /// </summary>
    public static class Colombia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Colombia()
        {
            _country = new CountryInfo
            {
                Country = Country.Colombia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Colombia,
                UNCode = "170",
                Alpha2Code = "CO",
                Alpha3Code = "COL",
                Name = "The Republic of Colombia",
                ShorterForm = "Colombia",
                ChineseName = "哥伦比亚共和国",
                ChineseShorterForm = "哥伦比亚",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gelunbiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gelunbiya";
    }
}