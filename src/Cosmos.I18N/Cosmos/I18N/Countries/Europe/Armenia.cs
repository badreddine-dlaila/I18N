namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 亚美尼亚（Armenia，欧洲，AM，ARM，051），亚美尼亚共和国<br />
    /// Cosmos i18n code: i18n_country_yameiniya
    /// </summary>
    public static class Armenia
    {
        private static readonly CountryInfo _country;

        static Armenia()
        {
            _country = new CountryInfo
            {
                Country = Country.Armenia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Armenia,
                UNCode = "051",
                Alpha2Code = "AM",
                Alpha3Code = "ARM",
                Name = "The Republic of Armenia",
                ChineseName = "亚美尼亚共和国",
                ChineseShorterForm = "亚美尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 亚美尼亚（Armenia，欧洲，AM，ARM，051），亚美尼亚共和国<br />
        /// Cosmos i18n code: i18n_country_yameiniya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_yameiniya";
    }
}