namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 圣多美和普林西比（The Democratic Republic of Sao Tome and Principe，非洲，ST，STP，678），圣多美和普林西比民主共和国 <br />
    /// Cosmos i18n code: i18n_country_shengduomeiplxb
    /// </summary>
    public static class SaoTomeAndPrincipe
    {
        private static readonly CountryInfo _country;

        static SaoTomeAndPrincipe()
        {
            _country = new CountryInfo
            {
                Country = Country.SaoTomeAndPrincipe,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SaoTomeAndPrincipe,
                UNCode = "678",
                Alpha2Code = "ST",
                Alpha3Code = "STP",
                Name = "The Democratic Republic of Sao Tome and Principe",
                ShorterForm = "Sao Tome and Principe",
                ChineseName = "圣多美和普林西比民主共和国",
                ChineseShorterForm = "圣多美和普林西比",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣多美和普林西比（The Democratic Republic of Sao Tome and Principe，非洲，ST，STP，678），圣多美和普林西比民主共和国 <br />
        /// Cosmos i18n code: i18n_country_shengduomeiplxb
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_shengduomeiplxb";
    }
}