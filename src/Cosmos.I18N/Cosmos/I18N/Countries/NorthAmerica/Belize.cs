namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 伯利兹（Belize，北美洲，BZ，BLZ，084） <br />
    /// Cosmos i18n code: i18n_country_bolizi
    /// </summary>
    public class Belize
    {
        private static readonly CountryInfo _country;

        static Belize()
        {
            _country = new CountryInfo
            {
                Country = Country.Belize,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Belize,
                UNCode = "084",
                Alpha2Code = "BZ",
                Alpha3Code = "BLZ",
                Name = "Belize",
                ChineseName = "伯利兹",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 伯利兹（Belize，北美洲，BZ，BLZ，084） <br />
        /// Cosmos i18n code: i18n_country_bolizi
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_bolizi";
    }
}