namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 基里巴斯（The Republic of Kiribati，大洋洲，KI，KIR，296），基里巴斯共和国 <br />
    /// Cosmos i18n code: i18n_country_jilibasi
    /// </summary>
    public static class Kiribati {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kiribati() {
            _country = new CountryInfo {
                Country = Country.Kiribati,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Kiribati,
                UNCode = "296",
                Alpha2Code = "KI",
                Alpha3Code = "KIR",
                Name = "The Republic of Kiribati",
                ShorterForm = "Kiribati",
                ChineseName = "基里巴斯共和国",
                ChineseShorterForm = "基里巴斯",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 基里巴斯（The Republic of Kiribati，大洋洲，KI，KIR，296），基里巴斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jilibasi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jilibasi";
    }
}