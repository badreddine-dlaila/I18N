namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
    /// Cosmos i18n code: i18n_country_gelinnada
    /// </summary>
    public static class Grenada
    {
        private static readonly CountryInfo _country;

        static Grenada()
        {
            _country = new CountryInfo
            {
                Country = Country.Grenada,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Grenada,
                UNCode = "308",
                Alpha2Code = "GD",
                Alpha3Code = "GRD",
                Name = "Grenada",
                ChineseName = "格林纳达",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
        /// Cosmos i18n code: i18n_country_gelinnada
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_gelinnada";
    }
}