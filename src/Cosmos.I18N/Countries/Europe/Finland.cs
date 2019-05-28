namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
    /// Cosmos i18n code: i18n_country_fenlan
    /// </summary>
    public static class Finland
    {
        private static readonly CountryInfo _country;

        static Finland()
        {
            _country = new CountryInfo
            {
                Country = Country.Finland,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Finland,
                UNCode = "246",
                Alpha2Code = "FI",
                Alpha3Code = "FIN",
                Name = "The Republic of Finland",
                ShorterForm = "Finland",
                ChineseName = "芬兰共和国",
                ChineseShorterForm = "芬兰",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
        /// Cosmos i18n code: i18n_country_fenlan
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_fenlan";
    }
}