using System;

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
        /// <param name="source"></param>
        /// <param name="other"></param>
        /// <param name="level"></param>
        /// <param name="customMergeProvider"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITranslatePackage Merge(
            ITranslatePackage source,
            ITranslatePackage other,
            MergeLevel level = MergeLevel.Level_1,
            Func<ITranslatePackage, ITranslatePackage, ITranslatePackage> customMergeProvider = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (other == null)
                throw new ArgumentNullException(nameof(other));

            var ret = source;

            switch (level)
            {
                case MergeLevel.Level_1:
                    MergeInLevel1(source, other);
                    break;

                case MergeLevel.Level_2:
                    MergeInLevel2(source, other);
                    break;

                case MergeLevel.Custom:
                    if (customMergeProvider == null)
                        throw new ArgumentNullException(nameof(customMergeProvider));
                    ret = customMergeProvider(source, other);
                    break;
            }

            return ret;
        }

        private static void MergeInLevel1(ITranslatePackage left, ITranslatePackage right)
        {
            //todo merge level 1
        }

        private static void MergeInLevel2(ITranslatePackage left, ITranslatePackage right)
        {
            //todo merge level 2
        }
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