namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 科摩罗（Union of Comoros，非洲，KM，COM，174），科摩罗联盟 <br />
    /// Cosmos i18n code: i18n_country_kemoluo
    /// </summary>
    public static class Comoros
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Comoros()
        {
            _country = new CountryInfo
            {
                Country = Country.Comoros,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Comoros,
                UNCode = "174",
                Alpha2Code = "KM",
                Alpha3Code = "COM",
                Name = "Union of Comoros",
                ShorterForm = "Comoros",
                ChineseName = "科摩罗联盟",
                ChineseShorterForm = "科摩罗",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 科摩罗（Union of Comoros，非洲，KM，COM，174），科摩罗联盟 <br />
        /// Cosmos i18n code: i18n_country_kemoluo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kemoluo";
    }
}