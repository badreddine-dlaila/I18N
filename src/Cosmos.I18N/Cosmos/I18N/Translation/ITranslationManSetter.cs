using System.Collections.Generic;

namespace Cosmos.I18N.Translation {
    /// <summary>
    /// Translation manager setter
    /// </summary>
    public interface ITranslationManSetter {
        /// <summary>
        /// Register translation package
        /// </summary>
        /// <param name="translatePackage"></param>
        void RegisterPackage(ITranslatePackage translatePackage);

        /// <summary>
        /// Register translation packages
        /// </summary>
        /// <param name="translatePackages"></param>
        void RegisterPackages(IEnumerable<ITranslatePackage> translatePackages);

        /// <summary>
        /// Register translation resource
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="translateResource"></param>
        void RegisterResource(string packageKey, ITranslateResource translateResource);

        /// <summary>
        /// Register translation resources
        /// </summary>
        /// <param name="packageKey"></param>
        /// <param name="translateResources"></param>
        void RegisterResources(string packageKey, IEnumerable<ITranslateResource> translateResources);
    }
}