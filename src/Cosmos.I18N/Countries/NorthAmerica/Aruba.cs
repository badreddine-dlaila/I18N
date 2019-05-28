namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
    /// Cosmos i18n code: i18n_country_aluba
    /// </summary>
    public static class Aruba
    {
        private static readonly CountryInfo _country;

        static Aruba()
        {
            _country = new CountryInfo
            {
                Country = Country.Aruba,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Netherlands,
                UNCode = "533",
                Alpha2Code = "AW",
                Alpha3Code = "ABW",
                Name = "Aruba",
                ChineseName = "阿鲁巴（荷兰海外属地） ",
                ChineseShorterForm = "阿鲁巴 ",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
        /// Cosmos i18n code: i18n_country_aluba
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_aluba";
    }
}