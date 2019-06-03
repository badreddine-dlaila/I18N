namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 摩洛哥（The Kingdom of Morocco，非洲，MA，MAR，504），摩洛哥王国 <br />
    /// Cosmos i18n code: i18n_country_moluoge
    /// </summary>
    public static class Morocco
    {
        private static readonly CountryInfo _country;

        static Morocco()
        {
            _country = new CountryInfo
            {
                Country = Country.Morocco,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Morocco,
                UNCode = "504",
                Alpha2Code = "MA",
                Alpha3Code = "MAR",
                Name = "The Kingdom of Morocco",
                ShorterForm = "Morocco",
                ChineseName = "摩洛哥王国",
                ChineseShorterForm = "摩洛哥",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 摩洛哥（The Kingdom of Morocco，非洲，MA，MAR，504），摩洛哥王国 <br />
        /// Cosmos i18n code: i18n_country_moluoge
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_moluoge";
    }
}