namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 根西岛（Bailiwick of Guernsey，欧洲，GG，GGY，831） <br />
    /// Cosmos i18n code: i18n_country_genxidao
    /// </summary>
    public static class Guernsey
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guernsey()
        {
            _country = new CountryInfo
            {
                Country = Country.Guernsey,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "831",
                Alpha2Code = "GG",
                Alpha3Code = "GGY",
                Name = "Bailiwick of Guernsey",
                ShorterForm = "Guernsey",
                ChineseName = "根西岛",
                ChineseAlias = "格恩西岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 根西岛（Bailiwick of Guernsey，欧洲，GG，GGY，831） <br />
        /// Cosmos i18n code: i18n_country_genxidao
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_genxidao";
    }
}