namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 巴布亚新几内亚（The Independent State of Papua New Guinea，大洋洲，PG，PNG，598），巴布亚新几内亚独立国 <br />
    /// Cosmos i18n code: i18n_country_baxin
    /// </summary>
    public static class PapuaNewGuinea
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static PapuaNewGuinea()
        {
            _country = new CountryInfo
            {
                Country = Country.PapuaNewGuinea,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.PapuaNewGuinea,
                UNCode = "598",
                Alpha2Code = "PG",
                Alpha3Code = "PNG",
                Name = "The Independent State of Papua New Guinea",
                ShorterForm = "Papua New Guinea",
                ChineseName = "巴布亚新几内亚独立国",
                ChineseShorterForm = "巴布亚新几内亚",
                ChineseAlias = "巴新",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴布亚新几内亚（The Independent State of Papua New Guinea，大洋洲，PG，PNG，598），巴布亚新几内亚独立国 <br />
        /// Cosmos i18n code: i18n_country_baxin
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_baxin";
    }
}