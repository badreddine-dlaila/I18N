using System.Collections.Generic;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Translate resource merge ops
    /// </summary>
    public interface ITranslateResourceMergeOps
    {
        /// <summary>
        /// Expose library of translation resource
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValuePair<int, string>> ExposeLibrary();
        
        /// <summary>
        /// Merge translate resource
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <param name="resourceTargetValue"></param>
        void Merge(string resourceKey, string resourceTargetValue);
        
        /// <summary>
        /// Merge translate resource
        /// </summary>
        /// <param name="hashOfResourceKey"></param>
        /// <param name="resourceTargetValue"></param>
        void Merge(int hashOfResourceKey, string resourceTargetValue);

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <returns></returns>
        bool Contains(string resourceKey);

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="hashOfResourceKey"></param>
        /// <returns></returns>
        bool Contains(int hashOfResourceKey);
    }
}