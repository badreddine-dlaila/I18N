namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 直布罗陀（Gibraltar，欧洲，GI，GIB，292） <br />
    /// Cosmos i18n code: i18n_country_zhibuluotuo
    /// </summary>
    public static class Gibraltar
    {
        private static readonly CountryInfo _country;

        static Gibraltar()
        {
            _country = new CountryInfo
            {
                Country = Country.Gibraltar,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "292",
                Alpha2Code = "GI",
                Alpha3Code = "GIB",
                Name = "Gibraltar",
                ChineseName = "直布罗陀",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 直布罗陀（Gibraltar，欧洲，GI，GIB，292） <br />
        /// Cosmos i18n code: i18n_country_zhibuluotuo
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_zhibuluotuo";
    }
}