using System.Collections.Generic;

namespace Cosmos.I18N {
    /// <summary>
    /// Lang tag ant maker, a update helper for Language Tag Ant Manager
    /// </summary>
    public static class AntHooks {
        /// <summary>
        /// Make
        /// </summary>
        /// <param name="antResource"></param>
        public static void Insert((AntFrom, string[]) antResource) {
            AntManager.AppendAnt(antResource.Item1, antResource.Item2);
        }

        /// <summary>
        /// Make
        /// </summary>
        /// <param name="antResources"></param>
        public static void Insert(List<(AntFrom, string[])> antResources) {
            if (antResources is null)
                return;

            foreach (var antResource in antResources) {
                Insert(antResource);
            }
        }
    }
}