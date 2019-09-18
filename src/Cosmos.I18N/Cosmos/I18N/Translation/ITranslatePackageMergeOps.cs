using System;
using System.Collections.Generic;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Translate package merge ops
    /// </summary>
    public interface ITranslatePackageMergeOps
    {
        /// <summary>
        /// Expose translate resource
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValuePair<LanguageTag, ITranslateResource>> ExposeResource();

        /// <summary>
        /// Merge
        /// </summary>
        /// <param name="other"></param>
        /// <param name="sourceMergeFunc"></param>
        void Merge(ITranslateResource other,
            Func<ITranslateResourceMergeOps, (bool, ITranslateResource)> sourceMergeFunc);
    }
}