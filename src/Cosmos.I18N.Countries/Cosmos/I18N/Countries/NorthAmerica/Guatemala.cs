namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 危地马拉（The Republic of Guatemala，北美洲，GT，GTM，320），危地马拉共和国 <br />
    /// Cosmos i18n code: i18n_country_weidimala
    /// </summary>
    public static class Guatemala {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guatemala() {
            _country = new CountryInfo {
                Country = Country.Guatemala,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Guatemala,
                UNCode = "320",
                Alpha2Code = "GT",
                Alpha3Code = "GTM",
                Name = "The Republic of Guatemala",
                ShorterForm = "Guatemala",
                ChineseName = "危地马拉共和国",
                ChineseShorterForm = "危地马拉",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 危地马拉（The Republic of Guatemala，北美洲，GT，GTM，320），危地马拉共和国 <br />
        /// Cosmos i18n code: i18n_country_weidimala
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_weidimala";
    }
}