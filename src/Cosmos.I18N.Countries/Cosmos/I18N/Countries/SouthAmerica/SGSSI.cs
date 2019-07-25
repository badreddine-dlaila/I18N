namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 南乔治亚岛和南桑威奇群岛（South Georgia and The South Sandwich Islands，南美洲，GS，SGS，239） <br />
    /// Cosmos i18n code: i18n_country_nanqiaozhiya
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class SGSSI
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SGSSI()
        {
            _country = new CountryInfo
            {
                Country = Country.SGSSI,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "239",
                Alpha2Code = "GS",
                Alpha3Code = "SGS",
                Name = "South Georgia and The South Sandwich Islands",
                ShorterForm = "SGSSI",
                ChineseName = "南乔治亚岛和南桑威奇群岛",
                ChineseShorterForm = "厄瓜多尔",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 南乔治亚岛和南桑威奇群岛（South Georgia and The South Sandwich Islands，南美洲，GS，SGS，239） <br />
        /// Cosmos i18n code: i18n_country_nanqiaozhiya
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nanqiaozhiya";
    }
}