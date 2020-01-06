namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 马耳他（Republic of Malta，欧洲，MT，MLT，470），马耳他共和国 <br />
    /// Cosmos i18n code: i18n_country_maerta
    /// </summary>
    public static class Malta {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Malta() {
            _country = new CountryInfo {
                Country = Country.Malta,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Malta,
                UNCode = "470",
                Alpha2Code = "MT",
                Alpha3Code = "MLT",
                Name = "Republic of Malta",
                ShorterForm = "Malta",
                ChineseName = "马耳他共和国",
                ChineseShorterForm = "马耳他",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马耳他（Republic of Malta，欧洲，MT，MLT，470），马耳他共和国 <br />
        /// Cosmos i18n code: i18n_country_maerta
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maerta";
    }
}