namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
    /// Cosmos i18n code: i18n_country_yingguo
    /// </summary>
    public static class UnitedKingdom
    {
        private static readonly CountryInfo _country;

        static UnitedKingdom()
        {
            _country = new CountryInfo
            {
                Country = Country.UnitedKingdom,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "826",
                Alpha2Code = "GB",
                Alpha3Code = "GBR",
                Name = "United Kingdom of Great Britain and Northern Ireland",
                ShorterForm = "United Kingdom",
                ChineseName = "大不列颠及北爱尔兰联合王国",
                ChineseShorterForm = "英国",
                Continent = Continent.Europe,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
        /// Cosmos i18n code: i18n_country_yingguo
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_yingguo";
    }
}