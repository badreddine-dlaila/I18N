namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 百慕大（The Bermuda Islands，北美洲，BI，BDI，108），百慕大群岛 <br />
    /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
    /// Cosmos i18n code: i18n_country_baimuda
    /// </summary>
    public class Bermuda
    {
        private static readonly CountryInfo _country;

        static Bermuda()
        {
            _country = new CountryInfo
            {
                Country = Country.Bermuda,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.UnitedKingdom,
                UNCode = "060",
                Alpha2Code = "BM",
                Alpha3Code = "BMU",
                Name = "The Bermuda Islands",
                ShorterForm = "Bermuda",
                ChineseName = "百慕大群岛",
                ChineseShorterForm = "百慕大",
                ChineseAlias = "旧称萨默斯岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 百慕大（The Bermuda Islands，北美洲，BI，BDI，108），百慕大群岛 <br />
        /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
        /// Cosmos i18n code: i18n_country_baimuda
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_baimuda";
    }
}