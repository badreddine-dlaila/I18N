using System;
using System.Collections.Generic;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Default implementation of translate package
    /// </summary>
    public partial class TranslatePackage : ITranslatePackageMergeOps
    {

        #region Internal Merge Opts

        /// <summary>
        /// Expose translate resource
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValuePair<LanguageTag, ITranslateResource>> ITranslatePackageMergeOps.ExposeResource() => _resources;

        /// <summary>
        /// Merge
        /// </summary>
        /// <param name="other"></param>
        /// <param name="sourceMergeFunc"></param>
        void ITranslatePackageMergeOps.Merge(ITranslateResource other,
            Func<ITranslateResourceMergeOps, (bool, ITranslateResource)> sourceMergeFunc)
        {
            if (other == null)
                return;

            if (sourceMergeFunc == null)
                return;

            var languageTag = other.Binding;

            if (languageTag == null)
                return;

            if (_resources.TryGetValue(languageTag, out var sourceResource))
            {
                if (sourceResource is ITranslateResourceMergeOps sourceMergeOps)
                {
                    (bool updateFallbackExperimenter, ITranslateResource returnedResource) mergedResult = sourceMergeFunc(sourceMergeOps);

                    if (mergedResult.returnedResource == null)
                    {
                        throw new InvalidOperationException("The translate resource returned from merge provider cannot be null.");
                    }

                    if (mergedResult.updateFallbackExperimenter)
                    {
                        TryRegisterLanguageTagOnceAgain(languageTag);
                    }
                }
                else
                {
                    throw new InvalidOperationException($"Translate resource for '{languageTag}' cannot be converted to an implementance of {nameof(ITranslateResourceMergeOps)}.");
                }
            }
            else
            {
                (bool updateFallbackExperimenter, ITranslateResource returnedResource) mergedResult = sourceMergeFunc(null);

                if (mergedResult.returnedResource == null)
                {
                    throw new InvalidOperationException("The translate resource returned from merge provider cannot be null.");
                }

                if (!mergedResult.returnedResource.Binding.Equals((ILanguageTag) languageTag))
                {
                    throw new InvalidOperationException("Different language teg between the given resource 'Other' and the returned one from merge provider.");
                }

                AddResourceCore(mergedResult.returnedResource);
            }
        }

        #endregion

    }
}