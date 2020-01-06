namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 德国（The Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_deguo
    /// </summary>
    public static class Germany {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Germany() {
            _country = new CountryInfo {
                Country = Country.Germany,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Germany,
                UNCode = "276",
                Alpha2Code = "DE",
                Alpha3Code = "DEU",
                Name = "The Federal Republic of Germany",
                ShorterForm = "Germany",
                ChineseName = "德意志联邦共和国",
                ChineseShorterForm = "德国",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 德国（The Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_deguo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_deguo";
    }
}