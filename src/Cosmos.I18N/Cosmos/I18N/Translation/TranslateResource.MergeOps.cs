using System.Collections.Generic;

namespace Cosmos.I18N.Translation {
    /// <summary>
    /// Translate resource
    /// </summary>
    public partial class TranslateResource : ITranslateResourceMergeOps {

        #region Internal Merge Opts

        /// <summary>
        /// Expose library of translation resource
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValuePair<int, string>> ITranslateResourceMergeOps.ExposeLibrary() => _l;

        /// <summary>
        /// Merge translate resource
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <param name="resourceTargetValue"></param>
        void ITranslateResourceMergeOps.Merge(string resourceKey, string resourceTargetValue) {
            if (string.IsNullOrWhiteSpace(resourceKey))
                return;

            var k = Key(resourceKey);

            if (Contains(k))
                return;

            _l.Add(k, resourceTargetValue);
        }


        /// <summary>
        /// Merge translate resource
        /// </summary>
        /// <param name="hashOfResourceKey"></param>
        /// <param name="resourceTargetValue"></param>
        void ITranslateResourceMergeOps.Merge(int hashOfResourceKey, string resourceTargetValue) {
            if (Contains(hashOfResourceKey))
                return;

            _l.Add(hashOfResourceKey, resourceTargetValue);
        }

        #endregion

        #region Contains

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <returns></returns>
        public bool Contains(string resourceKey) => _l.ContainsKey(Key(resourceKey));

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="hashOfResourceKey"></param>
        /// <returns></returns>
        public bool Contains(int hashOfResourceKey) => _l.ContainsKey(hashOfResourceKey);

        #endregion

    }
}