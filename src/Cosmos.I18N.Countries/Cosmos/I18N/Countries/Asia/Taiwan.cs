namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 台湾（Taiwan, China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
    /// 台湾，中华人民共和国的一部分 <br />
    /// Taiwan, a part of China <br />
    /// Cosmos i18n code: i18n_country_cnhtaiwan
    /// </summary>
    public static class Taiwan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Taiwan() {
            _country = new CountryInfo {
                Country = Country.Taiwan,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.China,
                UNCode = "158",
                Alpha2Code = "TW",
                Alpha3Code = "TWN",
                Name = "Taiwan, China",
                ShorterForm = "Taiwan",
                ChineseName = "中华人民共和国台湾省",
                ChineseShorterForm = "台湾",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 台湾（Taiwan, China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
        /// 台湾，中华人民共和国的一部分 <br />
        /// Taiwan, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhtaiwan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_cnhtaiwan";
    }
}