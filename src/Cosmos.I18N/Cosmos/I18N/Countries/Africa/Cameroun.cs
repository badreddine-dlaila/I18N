namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
    /// Cosmos i18n code: i18n_country_kamailong
    /// </summary>
    public static class Cameroun
    {
        private static readonly CountryInfo _country;

        static Cameroun()
        {
            _country = new CountryInfo
            {
                Country = Country.Cameroun,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Cameroun,
                UNCode = "120",
                Alpha2Code = "CM",
                Alpha3Code = "CRM",
                Name = "Republic of Cameroon",
                ShorterForm = "Cameroun",
                ChineseName = "喀麦隆共和国",
                ChineseShorterForm = "喀麦隆",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
        /// Cosmos i18n code: i18n_country_kamailong
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_kamailong";
    }
}