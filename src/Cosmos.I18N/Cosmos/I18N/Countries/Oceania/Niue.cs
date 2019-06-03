namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 纽埃（Niue，大洋洲，NU，NIU，570） <br />
    /// Cosmos i18n code: i18n_country_niuai
    /// </summary>
    public static class Niue
    {
        private static readonly CountryInfo _country;

        static Niue()
        {
            _country = new CountryInfo
            {
                Country = Country.Niue,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Niue,
                UNCode = "570",
                Alpha2Code = "NU",
                Alpha3Code = "NIU",
                Name = "Niue",
                ChineseName = "纽埃",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 纽埃（Niue，大洋洲，NU，NIU，570） <br />
        /// Cosmos i18n code: i18n_country_niuai
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_niuai";
    }
}