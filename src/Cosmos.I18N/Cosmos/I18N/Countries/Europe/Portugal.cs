namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 葡萄牙（The Portuguese Republic，欧洲，PT，PRT，620），葡萄牙共和国 <br />
    /// Cosmos i18n code: i18n_country_putapya
    /// </summary>
    public static class Portugal
    {
        private static readonly CountryInfo _country;

        static Portugal()
        {
            _country = new CountryInfo
            {
                Country = Country.Portugal,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Portugal,
                UNCode = "620",
                Alpha2Code = "PT",
                Alpha3Code = "PRT",
                Name = "The Portuguese Republic",
                ShorterForm = "Portugal",
                ChineseName = "葡萄牙共和国",
                ChineseShorterForm = "葡萄牙",
                Continent = Continent.Europe ,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 葡萄牙（The Portuguese Republic，欧洲，PT，PRT，620），葡萄牙共和国 <br />
        /// Cosmos i18n code: i18n_country_putapya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_putapya";
    }
}