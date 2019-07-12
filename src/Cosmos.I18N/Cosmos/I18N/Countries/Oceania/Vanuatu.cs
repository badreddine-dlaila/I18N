namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 瓦努阿图（The Republic of Vanuatu，大洋洲，VU，VUT，548），瓦努阿图共和国 <br />
    /// Cosmos i18n code: i18n_country_wanuatu
    /// </summary>
    public static class Vanuatu
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Vanuatu()
        {
            _country = new CountryInfo
            {
                Country = Country.Vanuatu,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Vanuatu,
                UNCode = "548",
                Alpha2Code = "VU",
                Alpha3Code = "VUT",
                Name = "The Republic of Vanuatu",
                ShorterForm = "Vanuatu",
                ChineseName = "瓦努阿图共和国",
                ChineseShorterForm = "瓦努阿图",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 瓦努阿图（The Republic of Vanuatu，大洋洲，VU，VUT，548），瓦努阿图共和国 <br />
        /// Cosmos i18n code: i18n_country_wanuatu
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wanuatu";
    }
}