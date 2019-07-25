namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 冰岛（The Republic of Iceland，欧洲，IS，ISL，352），冰岛共和国 <br />
    /// Cosmos i18n code: i18n_country_bingdao
    /// </summary>
    public static class Iceland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Iceland()
        {
            _country = new CountryInfo
            {
                Country = Country.Iceland,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Iceland,
                UNCode = "352",
                Alpha2Code = "IS",
                Alpha3Code = "ISL",
                Name = "The Republic of Iceland",
                ShorterForm = "Iceland",
                ChineseName = "冰岛共和国",
                ChineseShorterForm = "冰岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 冰岛（The Republic of Iceland，欧洲，IS，ISL，352），冰岛共和国 <br />
        /// Cosmos i18n code: i18n_country_bingdao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bingdao";
    }
}