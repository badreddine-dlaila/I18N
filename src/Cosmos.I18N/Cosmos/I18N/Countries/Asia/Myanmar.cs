namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 缅甸（The Republic of the Union of Myanmar，亚洲，MM，MMR，104），缅甸联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_miandian
    /// </summary>
    public static class Myanmar
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Myanmar()
        {
            _country = new CountryInfo
            {
                Country = Country.Myanmar,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Myanmar,
                UNCode = "104",
                Alpha2Code = "MM",
                Alpha3Code = "MMR",
                Name = "The Republic of the Union of Myanmar",
                ShorterForm = "Myanmar",
                ChineseName = "缅甸联邦共和国",
                ChineseShorterForm = "缅甸",
                Continent = Continent.Asia ,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 缅甸（The Republic of the Union of Myanmar，亚洲，MM，MMR，104），缅甸联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_miandian
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_miandian";
    }
}