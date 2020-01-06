namespace Cosmos.I18N.Adapters {
    /// <summary>
    /// Content adapter interface
    /// </summary>
    /// <typeparam name="TContentFormatting"></typeparam>
    public interface IContentAdapter<out TContentFormatting> : IAdapterProcess {
        /// <summary>
        /// Original content
        /// </summary>
        TContentFormatting OriginalContent { get; }
    }
}