namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 赤道几内亚（The Republic of Equatorial Guinea，非洲，GQ，GNQ，226），赤道几内亚共和国 <br />
    /// Cosmos i18n code: i18n_country_chidaojineiya
    /// </summary>
    public static class EquatorialGuinea
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static EquatorialGuinea()
        {
            _country = new CountryInfo
            {
                Country = Country.EquatorialGuinea,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.EquatorialGuinea,
                UNCode = "226",
                Alpha2Code = "GQ",
                Alpha3Code = "GNQ",
                Name = "The Republic of Equatorial Guinea",
                ShorterForm = "Equatorial Guinea",
                ChineseName = "赤道几内亚共和国",
                ChineseShorterForm = "赤道几内亚",
                Alias = "赤几",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 赤道几内亚（The Republic of Equatorial Guinea，非洲，GQ，GNQ，226），赤道几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_chidaojineiya
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_chidaojineiya";
    }
}