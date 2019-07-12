namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
    /// Cosmos i18n code: i18n_country_xisahala
    /// </summary>
    public static class WesternSahara
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static WesternSahara()
        {
            _country = new CountryInfo
            {
                Country = Country.WesternSahara,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.WesternSahara,
                UNCode = "732",
                Alpha2Code = "EH",
                Alpha3Code = "ESH",
                Name = "The Sahrawi Arab Democratic Republic",
                ShorterForm = "Western Sahara",
                ChineseName = "阿拉伯撒哈拉民主共和国",
                ChineseShorterForm = "西撒哈拉",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
        /// Cosmos i18n code: i18n_country_xisahala
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xisahala";
    }
}