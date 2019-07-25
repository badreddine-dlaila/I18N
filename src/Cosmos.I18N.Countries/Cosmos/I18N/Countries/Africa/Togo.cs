namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 多哥（French Southern Territories，非洲，TG，TGO，768），多哥共和国 <br />
    /// Cosmos i18n code: i18n_country_duoge
    /// </summary>
    public static class Togo
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Togo()
        {
            _country = new CountryInfo
            {
                Country = Country.Togo,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Togo,
                UNCode = "768",
                Alpha2Code = "TG",
                Alpha3Code = "AGO",
                Name = "The Republic of Togo",
                ShorterForm = "Togo",
                ChineseName = "多哥共和国",
                ChineseShorterForm = "多哥",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 多哥（French Southern Territories，非洲，TG，TGO，768），多哥共和国 <br />
        /// Cosmos i18n code: i18n_country_duoge
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_duoge";
    }
}