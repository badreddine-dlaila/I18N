namespace Cosmos.I18N.Countries {
    /// <summary>
    /// Country info
    /// </summary>
    public class CountryInfo : ICountryInfo {
        /// <summary>
        /// Country
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Country Country { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public CountryType CountryType { get; internal set; }

        /// <summary>
        /// Belongs to country
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Country BeongsToCountry { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string UNCode { get; internal set; }

        /// <inheritdoc />
        public string Alpha2Code { get; internal set; }

        /// <inheritdoc />
        public string Alpha3Code { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Name { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ShorterForm { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Alias { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseName { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseShorterForm { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseAlias { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChineseAlias2 { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Continent Continent { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string I18NIdentityCode { get; internal set; }

        /// <inheritdoc />
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public bool CommonwealthOfNations { get; internal set; }

        /// <inheritdoc />
        public bool HistoricalCountry { get; internal set; } = false;
        
        // /// <inheritdoc />
        // public HistoricalMetadata HistoricalMetadata { get; internal set; }
    }
}