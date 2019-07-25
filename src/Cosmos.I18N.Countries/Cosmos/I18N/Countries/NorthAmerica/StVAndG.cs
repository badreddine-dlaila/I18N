namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 圣文森特和格林纳丁斯（Saint Vincent and the Grenadines，北美洲，VC，VCT，670） <br />
    /// Cosmos i18n code: i18n_country_shengwensenteglnds
    /// </summary>
    public static class StVAndG
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static StVAndG()
        {
            _country = new CountryInfo
            {
                Country = Country.StVAndG,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.StVAndG,
                UNCode = "670",
                Alpha2Code = "VC",
                Alpha3Code = "VCT",
                Name = "Saint Vincent and the Grenadines",
                ChineseName = "圣文森特和格林纳丁斯",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣文森特和格林纳丁斯（Saint Vincent and the Grenadines，北美洲，VC，VCT，670） <br />
        /// Cosmos i18n code: i18n_country_shengwensenteglnds
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengwensenteglnds";
    }
}