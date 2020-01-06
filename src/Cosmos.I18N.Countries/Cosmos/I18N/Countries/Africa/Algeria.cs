namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
    /// Cosmos i18n code: i18n_country_aerjiliya
    /// </summary>
    public static class Algeria {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Algeria() {
            _country = new CountryInfo {
                Country = Country.Algeria,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Algeria,
                UNCode = "012",
                Alpha2Code = "DZ",
                Alpha3Code = "DZA",
                Name = "People's Democratic Republic of Algeria",
                ShorterForm = "Algeria",
                ChineseName = "阿尔及利亚民主人民共和国",
                ChineseShorterForm = "阿尔及利亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
        /// Cosmos i18n code: i18n_country_aerjiliya
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aerjiliya";
    }
}