namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 东帝汶（Democratic Republic of Timor-Leste，亚洲，TL，TLS，626），东帝汶民主共和国 <br />
    /// Cosmos i18n code: i18n_country_dongdiwen
    /// </summary>
    public static class EastTimor
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static EastTimor()
        {
            _country = new CountryInfo
            {
                Country = Country.EastTimor,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.EastTimor,
                UNCode = "626",
                Alpha2Code = "TL",
                Alpha3Code = "TLS",
                Name = "Democratic Republic of Timor-Leste",
                ShorterForm = "East Timor",
                ChineseName = "东帝汶民主共和国",
                ChineseShorterForm = "东帝汶",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 东帝汶（Democratic Republic of Timor-Leste，亚洲，TL，TLS，626），东帝汶民主共和国 <br />
        /// Cosmos i18n code: i18n_country_dongdiwen
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_dongdiwen";
    }
}