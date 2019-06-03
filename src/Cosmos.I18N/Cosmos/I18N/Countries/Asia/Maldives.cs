namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 马尔代夫（The Republic of Maldives，亚洲，MV，MDV，462），马尔代夫共和国 <br />
    /// Cosmos i18n code: i18n_country_maerdaifu
    /// </summary>
    public static class Maldives
    {
        private static readonly CountryInfo _country;

        static Maldives()
        {
            _country = new CountryInfo
            {
                Country = Country.Maldives,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Maldives,
                UNCode = "462",
                Alpha2Code = "MV",
                Alpha3Code = "MDV",
                Name = "The Republic of Maldives",
                ShorterForm = "Maldives",
                ChineseName = "马尔代夫共和国",
                ChineseShorterForm = "马尔代夫",
                ChineseAlias = "马尔代夫群岛",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马尔代夫（The Republic of Maldives，亚洲，MV，MDV，462），马尔代夫共和国 <br />
        /// Cosmos i18n code: i18n_country_maerdaifu
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_maerdaifu";
    }
}