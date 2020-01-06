namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 沙特（Kingdom of Saudi Arabia，亚洲，SA，SAU，682），沙特阿拉伯王国 <br />
    /// Cosmos i18n code: i18n_country_shate
    /// </summary>
    public static class SaudiArabia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaudiArabia() {
            _country = new CountryInfo {
                Country = Country.SaudiArabia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SaudiArabia,
                UNCode = "682",
                Alpha2Code = "SA",
                Alpha3Code = "SAU",
                Name = "Kingdom of Saudi Arabia",
                ShorterForm = "Saudi Arabia",
                ChineseName = "沙特阿拉伯王国",
                ChineseShorterForm = "沙特",
                ChineseAlias = "沙特阿拉伯",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 沙特（Kingdom of Saudi Arabia，亚洲，SA，SAU，682），沙特阿拉伯王国 <br />
        /// Cosmos i18n code: i18n_country_shate
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shate";
    }
}