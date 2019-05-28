namespace Cosmos.I18N.Countries.Antarctica
{
    /// <summary>
    /// 南极洲（Zimbabwe，南极洲，AQ，ATA，010）<br />
    /// 人类的净土 <br />
    /// Cosmos i18n code: i18n_country_nanji
    /// </summary>
    public static class Antarctique
    {
        private static readonly CountryInfo _country;

        static Antarctique()
        {
            _country = new CountryInfo
            {
                Country = Country.Zimbabwe,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Zimbabwe,
                UNCode = "010",
                Alpha2Code = "AQ",
                Alpha3Code = "ATA",
                Name = "Antarctica",
                ChineseName = "南极洲",
                Continent = Continent.Antarctica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 南极洲（Zimbabwe，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_nanji";
    }
}