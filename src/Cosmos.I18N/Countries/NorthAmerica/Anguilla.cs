namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
    /// Cosmos i18n code: i18n_country_anguila
    /// </summary>
    public static class Anguilla
    {
        private static readonly CountryInfo _country;

        static Anguilla()
        {
            _country = new CountryInfo
            {
                Country = Country.Anguilla,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "660",
                Alpha2Code = "AI",
                Alpha3Code = "AIA",
                Name = "Anguilla",
                ChineseName = "安圭拉",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
        /// Cosmos i18n code: i18n_country_anguila
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_anguila";
    }
}