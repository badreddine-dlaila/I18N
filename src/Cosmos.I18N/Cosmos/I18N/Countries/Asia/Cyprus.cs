namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
    /// Cosmos i18n code: i18n_country_saipulusi
    /// </summary>
    public static class Cyprus
    {
        private static readonly CountryInfo _country;

        static Cyprus()
        {
            _country = new CountryInfo
            {
                Country = Country.Cyprus,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Cyprus,
                UNCode = "196",
                Alpha2Code = "CY",
                Alpha3Code = "CYP",
                Name = "The Republic of Cyprus",
                ShorterForm = "Cyprus",
                ChineseName = "塞浦路斯共和国",
                ChineseShorterForm = "塞浦路斯",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
        /// Cosmos i18n code: i18n_country_saipulusi
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_saipulusi";
    }
}