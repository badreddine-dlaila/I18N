// ReSharper disable once CheckNamespace

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 南斯拉夫（Yugoslavia，欧洲，YU，YUG，38），南斯拉夫联盟共和国 <br />
    /// Cosmos i18n code: i18n_country_nlm_1992
    /// </summary>
    public static class Yugoslavia1992 {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Yugoslavia1992() {
            _country = new CountryInfo {
                Country = Country.Yugoslavia1992,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Yugoslavia1992,
                UNCode = "038",
                Alpha2Code = "YU",
                Alpha3Code = "YUG",
                Name = "The Federal Republic of Yugoslavia",
                ShorterForm = "Yugoslavia",
                ChineseName = "南斯拉夫联盟共和国",
                ChineseShorterForm = "南斯拉夫",
                ChineseAlias = "南联盟",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                HistoricalCountry = true,
            };
        }

        /// <summary>
        /// 南斯拉夫（Yugoslavia，欧洲，YU，YUG，38），南斯拉夫联盟共和国 <br />
        /// Cosmos i18n code: i18n_country_nlm_1992
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nlm_1992";
    }
}