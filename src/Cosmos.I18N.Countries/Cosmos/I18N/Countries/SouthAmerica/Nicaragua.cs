namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 尼加拉瓜（The Republic of Nicaragua，南美洲，NI，NIC，558），尼加拉瓜共和国 <br />
    /// Cosmos i18n code: i18n_country_nijialagua
    /// </summary>
    public static class Nicaragua {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Nicaragua() {
            _country = new CountryInfo {
                Country = Country.Nicaragua,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Nicaragua,
                UNCode = "558",
                Alpha2Code = "NI",
                Alpha3Code = "NIC",
                Name = "The Republic of Nicaragua",
                ShorterForm = "Nicaragua",
                ChineseName = "尼加拉瓜共和国",
                ChineseShorterForm = "尼加拉瓜",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 尼加拉瓜（The Republic of Nicaragua，南美洲，NI，NIC，558），尼加拉瓜共和国 <br />
        /// Cosmos i18n code: i18n_country_nijialagua
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nijialagua";
    }
}