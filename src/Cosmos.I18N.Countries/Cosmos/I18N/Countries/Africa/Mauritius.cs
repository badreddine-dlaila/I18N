namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 毛里求斯（The Republic of Mauritius，非洲，MU，MUS，480），毛里求斯共和国 <br />
    /// Cosmos i18n code: i18n_country_maoliqiusi
    /// </summary>
    public static class Mauritius {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mauritius() {
            _country = new CountryInfo {
                Country = Country.Mauritius,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Mauritius,
                UNCode = "480",
                Alpha2Code = "MU",
                Alpha3Code = "MUS",
                Name = "The Republic of Mauritius",
                ShorterForm = "Mauritius",
                ChineseName = "毛里求斯共和国",
                ChineseShorterForm = "毛里求斯",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 毛里求斯（The Republic of Mauritius，非洲，MU，MUS，480），毛里求斯共和国 <br />
        /// Cosmos i18n code: i18n_country_maoliqiusi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maoliqiusi";
    }
}