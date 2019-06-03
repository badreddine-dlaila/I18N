namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 立陶宛（The Republic of Lithuania，欧洲，LT，LTU，440），立陶宛共和国 <br />
    /// Cosmos i18n code: i18n_country_litaowan
    /// </summary>
    public static class Lithuania
    {
        private static readonly CountryInfo _country;

        static Lithuania()
        {
            _country = new CountryInfo
            {
                Country = Country.Lithuania,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Lithuania,
                UNCode = "440",
                Alpha2Code = "LT",
                Alpha3Code = "LTU",
                Name = "The Republic of Lithuania",
                ShorterForm = "Lithuania",
                ChineseName = "立陶宛共和国",
                ChineseShorterForm = "立陶宛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 立陶宛（The Republic of Lithuania，欧洲，LT，LTU，440），立陶宛共和国 <br />
        /// Cosmos i18n code: i18n_country_litaowan
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_litaowan";
    }
}