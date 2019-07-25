namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
    /// Cosmos i18n code: i18n_country_bahama
    /// </summary>
    public static class Bahamas
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bahamas()
        {
            _country = new CountryInfo
            {
                Country = Country.Bahamas,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Bahamas,
                UNCode = "044",
                Alpha2Code = "BS",
                Alpha3Code = "BHS",
                Name = "Commonwealth of the Bahamas",
                ShorterForm = "Bahamas",
                ChineseName = "巴哈马国",
                ChineseShorterForm = "巴哈马",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
        /// Cosmos i18n code: i18n_country_bahama
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bahama";
    }
}