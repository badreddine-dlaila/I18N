namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
    /// Cosmos i18n code: i18n_country_asaibaijiang
    /// </summary>
    public static class Azerbaijan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Azerbaijan() {
            _country = new CountryInfo {
                Country = Country.Azerbaijan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Azerbaijan,
                UNCode = "031",
                Alpha2Code = "AZ",
                Alpha3Code = "AZE",
                Name = "The Republic of Azerbaijan",
                ShorterForm = "Azerbaijan",
                ChineseName = "阿塞拜疆共和国",
                ChineseShorterForm = "阿塞拜疆",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
        /// Cosmos i18n code: i18n_country_asaibaijiang
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_asaibaijiang";
    }
}