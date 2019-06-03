namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 尼日尔（The Republic of Niger，非洲，NE，NER，562），尼日尔共和国 <br />
    /// Cosmos i18n code: i18n_country_nirier
    /// </summary>
    public static class Niger
    {
        private static readonly CountryInfo _country;

        static Niger()
        {
            _country = new CountryInfo
            {
                Country = Country.Niger,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Niger,
                UNCode = "562",
                Alpha2Code = "NE",
                Alpha3Code = "NER",
                Name = "The Republic of Niger",
                ShorterForm = "Niger",
                ChineseName = "尼日尔共和国",
                ChineseShorterForm = "尼日尔",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 尼日尔（The Republic of Niger，非洲，NE，NER，562），尼日尔共和国 <br />
        /// Cosmos i18n code: i18n_country_nirier
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_nirier";
    }
}