namespace Cosmos.I18N.Countries {
    /// <summary>
    /// Runtime country info for historical counties.
    /// </summary>
    public class RuntimeCountryInfo : ICountryInfo {
        /// <inheritdoc />
        public CountryType CountryType { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once InconsistentNaming
        public string UNCode { get; internal set; }

        /// <inheritdoc />
        public string Alpha2Code { get; internal set; }

        /// <inheritdoc />
        public string Alpha3Code { get; internal set; }

        /// <inheritdoc />
        public string Name { get; internal set; }

        /// <inheritdoc />
        public string ShorterForm { get; internal set; }

        /// <inheritdoc />
        public string Alias { get; internal set; }

        /// <inheritdoc />
        public string ChineseName { get; internal set; }

        /// <inheritdoc />
        public string ChineseShorterForm { get; internal set; }

        /// <inheritdoc />
        public string ChineseAlias { get; internal set; }

        /// <inheritdoc />
        public string ChineseAlias2 { get; internal set; }

        /// <inheritdoc />
        public Continent Continent { get; internal set; }

        /// <inheritdoc />
        public string I18NIdentityCode { get; internal set; }

        /// <inheritdoc />
        public bool CommonwealthOfNations { get; internal set; }

        /// <inheritdoc />
        public bool HistoricalCountry { get; internal set; } = false;
    }
}