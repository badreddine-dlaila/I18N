namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 吉尔吉斯斯坦（The Kyrgyz Republic/Kyrgyzstan，亚洲，KG，KGZ，417），吉尔吉斯共和国 <br />
    /// Cosmos i18n code: i18n_country_jierjisi
    /// </summary>
    public static class Kyrgyzstan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kyrgyzstan()
        {
            _country = new CountryInfo
            {
                Country = Country.Kyrgyzstan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Kyrgyzstan,
                UNCode = "417",
                Alpha2Code = "KG",
                Alpha3Code = "KGZ",
                Name = "The Kyrgyz Republic",
                ShorterForm = "Kyrgyzstan",
                ChineseName = "吉尔吉斯共和国",
                ChineseShorterForm = "吉尔吉斯斯坦",
                ChineseAlias = "吉尔吉斯",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 吉尔吉斯斯坦（The Kyrgyz Republic/Kyrgyzstan，亚洲，KG，KGZ，417），吉尔吉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jierjisi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jierjisi";
    }
}