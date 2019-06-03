namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 爱尔兰（Republic of Ireland，欧洲，IE，IRL，372），爱尔兰共和国 <br />
    /// Cosmos i18n code: i18n_country_aierlan
    /// </summary>
    public static class Ireland
    {
        private static readonly CountryInfo _country;

        static Ireland()
        {
            _country = new CountryInfo
            {
                Country = Country.Ireland,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Ireland,
                UNCode = "372",
                Alpha2Code = "IE",
                Alpha3Code = "IRL",
                Name = "Republic of Ireland",
                ShorterForm = "Ireland",
                ChineseName = "爱尔兰共和国",
                ChineseShorterForm = "爱尔兰",
                Continent = Continent.Europe,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 爱尔兰（Republic of Ireland，欧洲，IE，IRL，372），爱尔兰共和国 <br />
        /// Cosmos i18n code: i18n_country_aierlan
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_aierlan";
    }
}