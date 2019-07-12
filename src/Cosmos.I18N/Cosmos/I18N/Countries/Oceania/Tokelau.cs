namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 托克劳群岛（Tokelau，大洋洲，TK，TKL，772） <br />
    /// Cosmos i18n code: i18n_country_tuokelao
    /// </summary>
    public static class Tokelau
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tokelau()
        {
            _country = new CountryInfo
            {
                Country = Country.Tokelau,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.NewZealand,
                UNCode = "772",
                Alpha2Code = "TK",
                Alpha3Code = "TKL",
                Name = "Tokelau",
                ChineseName = "托克劳群岛",
                ChineseShorterForm = "泰国",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 托克劳群岛（Tokelau，大洋洲，TK，TKL，772） <br />
        /// Cosmos i18n code: i18n_country_tuokelao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tuokelao";
    }
}