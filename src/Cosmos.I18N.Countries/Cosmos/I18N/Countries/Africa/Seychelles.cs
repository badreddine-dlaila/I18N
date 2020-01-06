namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 塞舌尔（Republic of Seychelles，非洲，SC，SYC，690），塞舌尔共和国 <br />
    /// Cosmos i18n code: i18n_country_saisheer
    /// </summary>
    public static class Seychelles {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Seychelles() {
            _country = new CountryInfo {
                Country = Country.Seychelles,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Seychelles,
                UNCode = "690",
                Alpha2Code = "SC",
                Alpha3Code = "SYC",
                Name = "Republic of Seychelles",
                ShorterForm = "Seychelles",
                ChineseName = "塞舌尔共和国",
                ChineseShorterForm = "塞舌尔",
                Continent = Continent.Africa,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 塞舌尔（Republic of Seychelles，非洲，SC，SYC，690），塞舌尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saisheer
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saisheer";
    }
}