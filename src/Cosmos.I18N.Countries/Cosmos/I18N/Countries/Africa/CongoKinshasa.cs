namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
    /// Cosmos i18n code: i18n_country_gangguojin
    /// </summary>
    public static class CongoKinshasa {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CongoKinshasa() {
            _country = new CountryInfo {
                Country = Country.CongoKinshasa,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.CongoKinshasa,
                UNCode = "140",
                Alpha2Code = "CD",
                Alpha3Code = "CAF",
                Name = "The Democratic Republic of the Congo",
                ShorterForm = "Congo (Kinshasa)",
                ChineseName = "刚果民主共和国",
                ChineseShorterForm = "刚果（金）",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguojin
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gangguojin";
    }
}