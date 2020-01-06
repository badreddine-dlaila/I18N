namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 圭亚那（Cooperative Republic of Guyana，南美洲，GY，GUY，328），圭亚那合作共和国 <br />
    /// Cosmos i18n code: i18n_country_guiyana
    /// </summary>
    public static class Guyana {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guyana() {
            _country = new CountryInfo {
                Country = Country.Guyana,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Guyana,
                UNCode = "328",
                Alpha2Code = "GY",
                Alpha3Code = "GUY",
                Name = "Cooperative Republic of Guyana",
                ShorterForm = "Guyana",
                ChineseName = "圭亚那合作共和国",
                ChineseShorterForm = "圭亚那",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圭亚那（Cooperative Republic of Guyana，南美洲，GY，GUY，328），圭亚那合作共和国 <br />
        /// Cosmos i18n code: i18n_country_guiyana
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guiyana";
    }
}