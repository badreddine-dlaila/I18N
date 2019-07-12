namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 加蓬（The Gabonese Republic，非洲，GA，GAB，266），加蓬共和国 <br />
    /// Cosmos i18n code: i18n_country_eguaduoer
    /// </summary>
    public static class Gabon
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Gabon()
        {
            _country = new CountryInfo
            {
                Country = Country.Gabon,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Gabon,
                UNCode = "266",
                Alpha2Code = "GA",
                Alpha3Code = "GAB",
                Name = "The Gabonese Republic",
                ShorterForm = "Gabon",
                ChineseName = "加蓬共和国",
                ChineseShorterForm = "加蓬",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 加蓬（The Gabonese Republic，非洲，GA，GAB，266），加蓬共和国 <br />
        /// Cosmos i18n code: i18n_country_eguaduoer
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jiapeng";
    }
}