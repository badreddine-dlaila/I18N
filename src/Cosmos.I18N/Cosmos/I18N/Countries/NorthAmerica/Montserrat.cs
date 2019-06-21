namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 蒙特塞拉特（Montserrat，北美洲，MS，MSR，500） <br />
    /// Cosmos i18n code: i18n_country_mengtesailate
    /// </summary>
    public static class Montserrat
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Montserrat()
        {
            _country = new CountryInfo
            {
                Country = Country.Montserrat,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "500",
                Alpha2Code = "MS",
                Alpha3Code = "MSR",
                Name = "Montserrat",
                ChineseName = "蒙特塞拉特",
                ChineseAlias = "蒙瑟拉特岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 蒙特塞拉特（Montserrat，北美洲，MS，MSR，500） <br />
        /// Cosmos i18n code: i18n_country_mengtesailate
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mengtesailate";
    }
}