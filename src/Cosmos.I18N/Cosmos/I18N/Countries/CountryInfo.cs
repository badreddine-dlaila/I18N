namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Country info
    /// </summary>
    public class CountryInfo
    {
        /// <summary>
        /// Country
        /// </summary>
        public Country Country { get; internal set; }

        /// <summary>
        /// Country type
        /// </summary>
        public CountryType CountryType { get; internal set; }

        /// <summary>
        /// Belongs to country
        /// </summary>
        public Country BeongsToCountry { get; internal set; }

        /// <summary>
        /// UnCode
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string UNCode { get; internal set; }

        /// <summary>
        /// Alpha2 code
        /// </summary>
        public string Alpha2Code { get; internal set; }

        /// <summary>
        /// Alpha3 code
        /// </summary>
        public string Alpha3Code { get; internal set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Shorter form
        /// </summary>
        public string ShorterForm { get; internal set; }

        /// <summary>
        /// Alias
        /// </summary>
        public string Alias { get; internal set; }

        /// <summary>
        /// Chinese name
        /// </summary>
        public string ChineseName { get; internal set; }

        /// <summary>
        /// Chinese shorter form
        /// </summary>
        public string ChineseShorterForm { get; internal set; }

        /// <summary>
        /// Chinese alias
        /// </summary>
        public string ChineseAlias { get; internal set; }

        /// <summary>
        /// Chinese alias 2
        /// </summary>
        public string ChineseAlias2 { get; internal set; }

        /// <summary>
        /// Continent
        /// </summary>
        public Continent Continent { get; internal set; }

        /// <summary>
        /// I18n Identity code
        /// </summary>
        public string I18NIdentityCode { get; internal set; }

        /// <summary>
        /// Commonwealth of nations
        /// </summary>
        public bool CommonwealthOfNations { get; internal set; }
    }
}