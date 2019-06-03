namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 斯里兰卡（The Democratic Socialist Republic of Sri Lanka，亚洲，LK，LKA，144），斯里兰卡民主社会主义共和国 <br />
    /// Cosmos i18n code: i18n_country_sililanka
    /// </summary>
    public static class SriLanka
    {
        private static readonly CountryInfo _country;

        static SriLanka()
        {
            _country = new CountryInfo
            {
                Country = Country.SriLanka,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SriLanka,
                UNCode = "144",
                Alpha2Code = "LK",
                Alpha3Code = "LKA",
                Name = "The Democratic Socialist Republic of Sri Lanka",
                ShorterForm = "Sri Lanka",
                ChineseName = "斯里兰卡民主社会主义共和国",
                ChineseShorterForm = "斯里兰卡",
                Continent = Continent.Asia,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯里兰卡（The Democratic Socialist Republic of Sri Lanka，亚洲，LK，LKA，144），斯里兰卡民主社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_sililanka
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_sililanka";
    }
}