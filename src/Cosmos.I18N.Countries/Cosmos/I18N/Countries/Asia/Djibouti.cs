namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 吉布提（The Republic of Djibouti，亚洲，BI，BDI，108），吉布提共和国 <br />
    /// Cosmos i18n code: i18n_country_balin
    /// </summary>
    public static class Djibouti
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Djibouti()
        {
            _country = new CountryInfo
            {
                Country = Country.Djibouti,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Djibouti,
                UNCode = "262",
                Alpha2Code = "DJBI",
                Alpha3Code = "DJI",
                Name = "The Republic of Djibouti",
                ShorterForm = "Djibouti",
                ChineseName = "吉布提共和国",
                ChineseShorterForm = "吉布提",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 吉布提（The Republic of Djibouti，亚洲，BI，BDI，108），吉布提共和国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_balin";
    }
}