namespace Cosmos.I18N.Countries {
    /// <summary>
    /// Interface for country info
    /// </summary>
    public interface ICountryInfo {
        /// <summary>
        /// Country type
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        CountryType CountryType { get; }

        /// <summary>
        /// UnCode
        /// </summary>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string UNCode { get; }

        /// <summary>
        /// Alpha2 code
        /// </summary>
        string Alpha2Code { get; }

        /// <summary>
        /// Alpha3 code
        /// </summary>
        string Alpha3Code { get; }

        /// <summary>
        /// Name
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string Name { get; }

        /// <summary>
        /// Shorter form
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ShorterForm { get; }

        /// <summary>
        /// Alias
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string Alias { get; }

        /// <summary>
        /// Chinese name
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseName { get; }

        /// <summary>
        /// Chinese shorter form
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseShorterForm { get; }

        /// <summary>
        /// Chinese alias
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseAlias { get; }

        /// <summary>
        /// Chinese alias 2
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseAlias2 { get; }

        /// <summary>
        /// Continent
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        Continent Continent { get; }

        /// <summary>
        /// I18n Identity code
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string I18NIdentityCode { get; }

        /// <summary>
        /// Commonwealth of nations
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        bool CommonwealthOfNations { get; }

        /// <summary>
        /// Historical country
        /// </summary>
        bool HistoricalCountry { get; }

        // /// <summary>
        // /// Historical metadata
        // /// </summary>
        // HistoricalMetadata HistoricalMetadata { get; }
    }
}