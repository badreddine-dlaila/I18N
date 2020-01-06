namespace Cosmos.I18N.Countries {
    /// <summary>
    /// Country info
    /// </summary>
    public class CountryInfo {
        /// <summary>
        /// Country
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Country Country { get; internal set; }

        /// <summary>
        /// Country type
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public CountryType CountryType { get; internal set; }

        /// <summary>
        /// Belongs to country
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Country BeongsToCountry { get; internal set; }

        /// <summary>
        /// UnCode
        /// </summary>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
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
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Name { get; internal set; }

        /// <summary>
        /// Shorter form
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ShorterForm { get; internal set; }

        /// <summary>
        /// Alias
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Alias { get; internal set; }

        /// <summary>
        /// Chinese name
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseName { get; internal set; }

        /// <summary>
        /// Chinese shorter form
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseShorterForm { get; internal set; }

        /// <summary>
        /// Chinese alias
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseAlias { get; internal set; }

        /// <summary>
        /// Chinese alias 2
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseAlias2 { get; internal set; }

        /// <summary>
        /// Continent
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Continent Continent { get; internal set; }

        /// <summary>
        /// I18n Identity code
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string I18NIdentityCode { get; internal set; }

        /// <summary>
        /// Commonwealth of nations
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public bool CommonwealthOfNations { get; internal set; }
    }
}