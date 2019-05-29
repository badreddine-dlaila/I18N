namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
    /// Cosmos i18n code: i18n_country_eguaduoer
    /// </summary>
    public static class Ecuador
    {
        private static readonly CountryInfo _country;

        static Ecuador()
        {
            _country = new CountryInfo
            {
                Country = Country.Ecuador,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Ecuador,
                UNCode = "218",
                Alpha2Code = "EC",
                Alpha3Code = "ECU",
                Name = "The Republic of Ecuador",
                ShorterForm = "Ecuador",
                ChineseName = "厄瓜多尔共和国",
                ChineseShorterForm = "厄瓜多尔",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
        /// Cosmos i18n code: i18n_country_eguaduoer
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_eguaduoer";
    }
}