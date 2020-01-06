namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
    /// Cosmos i18n code: i18n_country_aodili
    /// </summary>
    public static class Austria {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Austria() {
            _country = new CountryInfo {
                Country = Country.Austria,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Austria,
                UNCode = "040",
                Alpha2Code = "AT",
                Alpha3Code = "AUT",
                Name = "The Republic of Austria",
                ShorterForm = "Austria",
                ChineseName = "奥地利共和国",
                ChineseShorterForm = "奥地利",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
        /// Cosmos i18n code: i18n_country_aodili
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aodili";
    }
}