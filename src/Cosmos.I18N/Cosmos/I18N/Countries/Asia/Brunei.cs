namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
    /// Cosmos i18n code: i18n_country_wenlai
    /// </summary>
    public static class Brunei
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Brunei()
        {
            _country = new CountryInfo
            {
                Country = Country.Brunei,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Brunei,
                UNCode = "096",
                Alpha2Code = "BN",
                Alpha3Code = "BRN",
                Name = "Negara Brunei Darussalam",
                ShorterForm = "Brunei",
                ChineseName = "文莱达鲁萨兰国",
                ChineseShorterForm = "文莱",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
        /// Cosmos i18n code: i18n_country_wenlai
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wenlai";
    }
}