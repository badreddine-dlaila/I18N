namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_aerbaniya
    /// </summary>
    public static class Albania
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Albania()
        {
            _country = new CountryInfo
            {
                Country = Country.Albania,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Albania,
                UNCode = "008",
                Alpha2Code = "AL",
                Alpha3Code = "ALB",
                Name = "Republic of Albania",
                ShorterForm = "Albania",
                ChineseName = "阿尔巴尼亚共和国",
                ChineseShorterForm = "阿尔巴尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aerbaniya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aerbaniya";
    }
}