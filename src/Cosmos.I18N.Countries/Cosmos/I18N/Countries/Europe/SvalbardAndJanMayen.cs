namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 斯瓦尔巴群岛（The Svalbard archipelago，欧洲，SJ，SJM，744） <br />
    /// Cosmos i18n code: i18n_country_siwaerba
    /// </summary>
    public static class SvalbardAndJanMayen
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SvalbardAndJanMayen()
        {
            _country = new CountryInfo
            {
                Country = Country.SvalbardAndJanMayen,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Norway,
                UNCode = "744",
                Alpha2Code = "SJ",
                Alpha3Code = "SJM",
                Name = "The Svalbard archipelago",
                ShorterForm = "Svalbard and Jan Mayen",
                ChineseName = "斯瓦尔巴群岛",
                ChineseAlias = "斯匹次卑尔根",
                ChineseAlias2 = "斯匹次卑尔根",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯瓦尔巴群岛（The Svalbard archipelago，欧洲，SJ，SJM，744） <br />
        /// Cosmos i18n code: i18n_country_siwaerba
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_siwaerba";
    }
}