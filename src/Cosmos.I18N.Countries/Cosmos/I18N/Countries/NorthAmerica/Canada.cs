namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
    /// Cosmos i18n code: i18n_country_jianada
    /// </summary>
    public static class Canada {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Canada() {
            _country = new CountryInfo {
                Country = Country.Canada,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Canada,
                UNCode = "124",
                Alpha2Code = "CA",
                Alpha3Code = "CAN",
                Name = "Canada",
                ChineseName = "加拿大",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
        /// Cosmos i18n code: i18n_country_jianada
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jianada";
    }
}