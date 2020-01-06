namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 希腊（The Republic of Greece，欧洲，GR，GRC，300），希腊共和国 <br />
    /// Cosmos i18n code: i18n_country_xila
    /// </summary>
    public static class Greece {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Greece() {
            _country = new CountryInfo {
                Country = Country.Greece,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Greece,
                UNCode = "300",
                Alpha2Code = "GR",
                Alpha3Code = "GRC",
                Name = "The Republic of Greece",
                ShorterForm = "Greece",
                ChineseName = "希腊共和国",
                ChineseShorterForm = "希腊",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 希腊（The Republic of Greece，欧洲，GR，GRC，300），希腊共和国 <br />
        /// Cosmos i18n code: i18n_country_xila
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xila";
    }
}