namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 意大利（The Republic of Italy，欧洲，IT，ITA，380），意大利共和国 <br />
    /// Cosmos i18n code: i18n_country_yidali
    /// </summary>
    public static class Italy {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Italy() {
            _country = new CountryInfo {
                Country = Country.Italy,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Italy,
                UNCode = "380",
                Alpha2Code = "IT",
                Alpha3Code = "ITA",
                Name = "The Republic of Italy",
                ShorterForm = "Italy",
                ChineseName = "意大利共和国",
                ChineseShorterForm = "意大利",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 意大利（The Republic of Italy，欧洲，IT，ITA，380），意大利共和国 <br />
        /// Cosmos i18n code: i18n_country_yidali
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yidali";
    }
}