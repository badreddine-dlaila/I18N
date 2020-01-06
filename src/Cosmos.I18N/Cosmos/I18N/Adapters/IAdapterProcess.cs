using System.Threading.Tasks;

namespace Cosmos.I18N.Adapters {
    /// <summary>
    /// Adapter process interface
    /// </summary>
    public interface IAdapterProcess {
        /// <summary>
        /// Process
        /// </summary>
        /// <returns></returns>
        bool Process();

        /// <summary>
        /// Process async
        /// </summary>
        /// <returns></returns>
        Task<bool> ProcessAsync();
    }
}