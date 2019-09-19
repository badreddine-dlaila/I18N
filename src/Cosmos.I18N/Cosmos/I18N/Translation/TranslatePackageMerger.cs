using System;
using System.Linq;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N.Translation
{
    /// <summary>
    /// Translation package merger
    /// </summary>
    public static class TranslatePackageMerger
    {
        /// <summary>
        /// Merge
        /// </summary>
        /// <param name="source">源 Translation Package，将合并到此包内</param>
        /// <param name="other">需要合并的素材 Translation Package，合并后此包将抛弃</param>
        /// <param name="level">合并级别</param>
        /// <param name="customMergeProvider">自定义合并方法提供者程序</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITranslatePackage Merge(
            ITranslatePackage source,
            ITranslatePackage other,
            MergeLevel level = MergeLevel.Level_1,
            Func<ITranslatePackageMergeOps, ITranslatePackageMergeOps, ITranslatePackage> customMergeProvider = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (other == null)
                throw new ArgumentNullException(nameof(other));

            var left = source as ITranslatePackageMergeOps;
            var right = other as ITranslatePackageMergeOps;

            if (left == null)
                throw new ArgumentException($"The source translate package should be an implementation of '{nameof(ITranslatePackageMergeOps)}'");

            if (right == null)
                throw new ArgumentException($"The target translate package should be an implementation of '{nameof(ITranslatePackageMergeOps)}'");

            var ret = source;

            switch (level)
            {
                case MergeLevel.Level_1:
                    MergeInLevel1(left, right);
                    break;

                case MergeLevel.Level_2:
                    MergeInLevel2(left, right);
                    break;

                case MergeLevel.Custom:
                    if (customMergeProvider == null)
                        throw new ArgumentNullException(nameof(customMergeProvider));
                    ret = customMergeProvider(left, right);
                    break;
            }

            return ret;
        }

        /// <summary>
        /// Level 1 merge
        /// (1) left 和 right 不能为空
        /// (2) 获取 right 的 TranslationResource 清单
        /// (3) 检测 right Translation Resource 和 right LanguageTag
        /// (4) 如果 left Translation Resource 包含 right LanguageTag，跳过
        /// (5) 此时 left Translation Resource 不包含 right LanguageTag，将 right Translation Resource 传入 Core Merge 1
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void MergeInLevel1(ITranslatePackageMergeOps left, ITranslatePackageMergeOps right)
        {
            if (left == null || right == null) //(1)
                return;

            var leftResourcesPtr = left.ExposeResource().ToList();

            foreach (var rightResource in right.ExposeResource()) //(2)
            {
                if (rightResource.Key == null || rightResource.Value == null) //(3)
                    continue;

                if (leftResourcesPtr.Any(x => x.Key.Equals((ILanguageTag) rightResource.Key))) //(4)
                    continue;

                left.Merge(rightResource.Value, MergeLevel1CoreFunc(rightResource.Value)); //(5_
            }
        }

        /// <summary>
        /// Level 2 merge
        /// (1) left 和 right 不能为空
        /// (2) 获取 right 的 TranslationResource 清单
        /// (3) 检测 right Translation Resource 和 right LanguageTag
        /// (4) 将 right Translation Resource 传入 Core Merge 2
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void MergeInLevel2(ITranslatePackageMergeOps left, ITranslatePackageMergeOps right)
        {
            if (left == null || right == null) //(1)
                return;

            foreach (var rightResource in right.ExposeResource()) //(2)
            {
                if (rightResource.Key == null || rightResource.Value == null) //(3)
                    continue;

                left.Merge(rightResource.Value, MergeLevel2CoreFunc(rightResource.Value)); //(4)
            }
        }

        /// <summary>
        /// Core Merge 1
        /// 当 resource 为 null 时，表示 TranslatePackage 内不包含该 LanguageTag 的资源，此时直接返回 Other TranslateResource (1)
        /// 当 resource 不为 null，表示 TranslatePackage 内包含该 LanguageTag 的资源，此时直接跳过，并原样返回 resource (2)
        /// </summary>
        /// <param name="otherResource"></param>
        /// <returns></returns>
        private static Func<ITranslateResourceMergeOps, (bool, ITranslateResource)> MergeLevel1CoreFunc(ITranslateResource otherResource) => resource =>
        {
            return resource == null
                ? (true, otherResource) //(1)
                : (false, resource as ITranslateResource); //(2)
        };

        /// <summary>
        /// Core Merge 2
        /// 当 resource 为 null 时，表示 TranslatePackage 内不包含该 LanguageTag 的资源，此时直接返回 Other TranslateResource (1)
        /// 当 resource 不为 null，表示 TranslatePackage 内包含该 LanguageTag 的资源，此时将所有 resource 不包含、但 other 包含的 Translation value 合并进 resource，并返回 resource (2)
        /// 如果 other 不支持合并操作，则跳过 Merge (*)
        /// </summary>
        /// <param name="otherResource"></param>
        /// <returns></returns>
        private static Func<ITranslateResourceMergeOps, (bool, ITranslateResource)> MergeLevel2CoreFunc(ITranslateResource otherResource) => resource =>
        {
            if (resource == null)
            {
                return (true, otherResource); //(1)
            }

            if (otherResource is ITranslateResourceMergeOps otherMergeOps) //(*) 如果 other 不支持合并操作，则跳过 Merge
            {
                foreach (var l in otherMergeOps.ExposeLibrary())
                {
                    resource.Merge(l.Key, l.Value);
                }
            }

            return (false, (ITranslateResource) resource); //(2)
        };

        /// <summary>
        /// Anonymous merge core func
        /// 当 resource 为 null 时，表示 TranslatePackage 内不包含该 LanguageTag 的资源，此时直接返回 Other TranslateResource (1)
        /// 当 resource 不为 null，表示 TranslatePackage 内包含该 LanguageTag 的资源，此时将所有 resource 不包含、但 other 包含的 Translation value 合并进 resource，并返回 resource (2)
        /// 如果 other 不支持合并操作，则跳过 Merge (*)
        /// </summary>
        /// <param name="otherResource"></param>
        /// <returns></returns>
        internal static Func<ITranslateResourceMergeOps, (bool, ITranslateResource)> AnonymousMergeCoreFunc(ITranslateResource otherResource) => MergeLevel2CoreFunc(otherResource);
    }

    /// <summary>
    /// Merge level for translation package
    /// </summary>
    public enum MergeLevel
    {
        /// <summary>
        /// Level 1
        /// <br />
        /// 粗颗粒
        /// </summary>
        // ReSharper disable once InconsistentNaming
        Level_1,

        /// <summary>
        /// Level 2
        /// <br />
        /// 细颗粒
        /// </summary>
        // ReSharper disable once InconsistentNaming
        Level_2,

        /// <summary>
        /// Custom<br />
        /// 自定义
        /// </summary>
        Custom,
    }
}