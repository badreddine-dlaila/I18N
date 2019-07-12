namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 瑙鲁（The Republic of Nauru，大洋洲，NR，NRU，520），瑙鲁共和国 <br />
    /// Cosmos i18n code: i18n_country_manu
    /// </summary>
    public static class Nauru
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Nauru()
        {
            _country = new CountryInfo
            {
                Country = Country.Nauru,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Nauru,
                UNCode = "520",
                Alpha2Code = "NR",
                Alpha3Code = "NRU",
                Name = "The Republic of Nauru",
                ShorterForm = "Nauru",
                ChineseName = "瑙鲁共和国",
                ChineseShorterForm = "瑙鲁",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 瑙鲁（The Republic of Nauru，大洋洲，NR，NRU，520），瑙鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_manu
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_manu";
    }
}