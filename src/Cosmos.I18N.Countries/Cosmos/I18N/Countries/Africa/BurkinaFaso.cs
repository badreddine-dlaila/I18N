namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
    /// Cosmos i18n code: i18n_country_bujinafaso
    /// </summary>
    public static class BurkinaFaso {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static BurkinaFaso() {
            _country = new CountryInfo {
                Country = Country.BurkinaFaso,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.BurkinaFaso,
                UNCode = "854",
                Alpha2Code = "BF",
                Alpha3Code = "BFA",
                Name = "Burkina Faso",
                ChineseName = "布基纳法索",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
        /// Cosmos i18n code: i18n_country_bujinafaso
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bujinafaso";
    }
}