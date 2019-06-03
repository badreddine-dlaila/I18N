namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 关岛（The Territory of Guam，大洋洲，GU，GUM，316） <br />
    /// Cosmos i18n code: i18n_country_guandao
    /// </summary>
    public static class Guam
    {
        private static readonly CountryInfo _country;

        static Guam()
        {
            _country = new CountryInfo
            {
                Country = Country.Guam,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedStates,
                UNCode = "316",
                Alpha2Code = "GU",
                Alpha3Code = "GUM",
                Name = "The Territory of Guam",
                ShorterForm = "Ecuador",
                ChineseName = "关岛",
                ChineseAlias = "自由天堂",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 关岛（The Territory of Guam，大洋洲，GU，GUM，316） <br />
        /// Cosmos i18n code: i18n_country_guandao
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_guandao";
    }
}