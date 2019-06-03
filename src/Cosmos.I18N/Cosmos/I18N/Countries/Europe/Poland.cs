namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 波兰（The Republic Of Poland，欧洲，PL，POL，61），波兰共和国 <br />
    /// Cosmos i18n code: i18n_country_bolan
    /// </summary>
    public static class Poland
    {
        private static readonly CountryInfo _country;

        static Poland()
        {
            _country = new CountryInfo
            {
                Country = Country.Poland,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Poland,
                UNCode = "616",
                Alpha2Code = "PL",
                Alpha3Code = "POL",
                Name = "The Republic Of Poland",
                ShorterForm = "Poland",
                ChineseName = "波兰共和国",
                ChineseShorterForm = "波兰",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 波兰（The Republic Of Poland，欧洲，PL，POL，61），波兰共和国 <br />
        /// Cosmos i18n code: i18n_country_bolan
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_bolan";
    }
}