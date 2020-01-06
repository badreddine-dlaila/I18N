namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
    /// 又名 阿拉伯联合大公国 <br />
    /// Cosmos i18n code: i18n_country_alianqiu
    /// </summary>
    public static class UnitedArabEmirates {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static UnitedArabEmirates() {
            _country = new CountryInfo {
                Country = Country.UnitedArabEmirates,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.UnitedArabEmirates,
                UNCode = "784",
                Alpha2Code = "AE",
                Alpha3Code = "ARE",
                Name = "United Arab Emirates",
                ChineseName = "阿拉伯联合酋长国",
                ChineseShorterForm = "阿联酋",
                ChineseAlias = "阿拉伯联合大公国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
        /// 又名 阿拉伯联合大公国 <br />
        /// Cosmos i18n code: i18n_country_alianqiu
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_alianqiu";
    }
}