namespace Cosmos.I18N.Adapters {
    /// <summary>
    /// File adapter interface
    /// </summary>
    public interface IFileAdapter : IAdapterProcess {
        /// <summary>
        /// Gets path
        /// </summary>
        string Path { get; }
    }
}