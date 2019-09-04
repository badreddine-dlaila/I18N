using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core.Extensions;

namespace Cosmos.I18N.Languages
{
    /// <summary>
    /// Fallback Experimenter for LanguageTag
    /// </summary>
    public class FallbackExperimenter
    {
        private readonly FallbackItemList _items = new FallbackItemList();
        private readonly Dictionary<int, List<FallbackItem>> _cachedResults = new Dictionary<int, List<FallbackItem>>();
        private readonly object _cacheLockObj = new object();

        private static readonly List<MatchLevel> _matchLevels = new List<MatchLevel>
        {
            MatchLevel.ExactMatch,
            MatchLevel.DefaultRegion,
            MatchLevel.ScriptMatch,
            MatchLevel.LanguageMatch
        };

        private int MinPriorityOfItems => _items.Min(m => m.Priority);

        /// <summary>
        /// Has cached result
        /// </summary>
        /// <param name="langTag"></param>
        /// <returns></returns>
        public bool HasCachedResult(string langTag)
        {
            if (langTag.IsNullOrWhiteSpace())
                return false;
            var lowerCacheLanguageTag = langTag.Trim().ToLowerInvariant();
            return _cachedResults.ContainsKey(lowerCacheLanguageTag.GetHashCode());
        }

        /// <summary>
        /// Has cached result
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public bool HashCachedResult(LanguageTag languageTag)
        {
            if (languageTag == null)
                return false;
            return _cachedResults.ContainsKey(languageTag.GetHashCode());
        }

        #region Set

        /// <summary>
        /// Register language tag
        /// </summary>
        /// <param name="languageTag"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void RegisterTag(LanguageTag languageTag)
        {
            if (languageTag == null)
                throw new ArgumentNullException(nameof(languageTag));

            var hashcode = languageTag.GetHashCode();

            // ReSharper disable once InconsistentlySynchronizedField
            if (_items.Any(x => x.HashCodeCached == hashcode))
                return;

            lock (_cacheLockObj)
            {
                if (_items.Any(x => x.HashCodeCached == hashcode))
                    return;

                //this will update all item's priority
                _items.Add(new FallbackItem(languageTag));
            }
        }

        #endregion

        #region Get

        /// <summary>
        /// Get suitable tags
        /// </summary>
        /// <param name="languageTag"></param>
        /// <returns></returns>
        public IEnumerable<LanguageTag> GetSuitableTags(LanguageTag languageTag)
        {
            if (_cachedResults.TryGetValue(languageTag.GetHashCode(), out var results))
                return results.Select(s => s.Value);

            if (!_items.Any())
                return Enumerable.Empty<LanguageTag>();

            results = new List<FallbackItem>();

            var orderedItems = _items.OrderByDescending(o => o.Priority).ToList();
            var skipHashCodes = new List<int>();

            //step.1 filter all results by this order:  ExactMatch, DefaultRegion, ScriptMatch and LanguageMatch
            foreach (var level in _matchLevels)
                results.AddRange(Filter(orderedItems, languageTag, level, skipHashCodes));

            //step.2 add all results which priority less than the min of the result that got from step.1
            results.AddRange(Filter(orderedItems, results.Min(m => m.Priority), skipHashCodes));

            //step.3 add default language tag (in this case, the most less priority) if need.
            AddMostLessPriorityIfNeed(results, skipHashCodes);

            //step.4 clear skipped hashcode cache
            skipHashCodes.Clear();

            return Remember(languageTag, results);
        }

        private IEnumerable<FallbackItem> Filter(List<FallbackItem> orderedItems, LanguageTag languageTag, MatchLevel matchLevel, List<int> skipHashCodes)
        {
            foreach (var item in orderedItems)
            {
                if (skipHashCodes.Contains(item.HashCodeCached))
                    continue;
                var score = LanguageTagMatcher.Match(languageTag, item.Value, matchLevel);

                if (score > 0)
                {
                    skipHashCodes.Add(item.HashCodeCached);
                    yield return item;
                }
            }
        }

        private IEnumerable<FallbackItem> Filter(List<FallbackItem> orderedItems, int priority, List<int> skipHashCodes)
        {
            foreach (var item in orderedItems)
            {
                if (item.Priority >= priority)
                    continue;

                if (skipHashCodes.Contains(item.HashCodeCached))
                    continue;

                skipHashCodes.Add(item.HashCodeCached);
                yield return item;
            }
        }

        private void AddMostLessPriorityIfNeed(List<FallbackItem> results, List<int> skipHashCodes)
        {
            var minPriority = results.Min(m => m.Priority);
            if (minPriority != MinPriorityOfItems)
            {
                var minItem = _items.FirstOrDefault(x => x.Priority == minPriority);
                if (minItem != null && !skipHashCodes.Contains(minItem.HashCodeCached))
                {
                    skipHashCodes.Add(minItem.HashCodeCached);
                    results.Add(minItem);
                }
            }
        }

        private IEnumerable<LanguageTag> Remember(LanguageTag left, List<FallbackItem> filteredItems)
        {
            lock (_cacheLockObj)
            {
                var hashcode = left.GetHashCode();
                if (_cachedResults.ContainsKey(hashcode))
                    _cachedResults[hashcode] = filteredItems;
                else
                    _cachedResults.Add(hashcode, filteredItems);
            }

            return filteredItems.Select(s => s.Value);
        }

        #endregion

        /// <summary>
        /// Fallback item for fallback experimenter
        /// </summary>
        private class FallbackItem
        {
            /// <summary>
            /// Create a new instance for <see cref="FallbackItem"/>
            /// </summary>
            /// <param name="languageTag"></param>
            public FallbackItem(LanguageTag languageTag)
            {
                Value = languageTag ?? throw new ArgumentNullException(nameof(languageTag));
                HashCodeCached = Value.GetHashCode();
                FullLevel = GetFullLevel(Value);
            }

            /// <summary>
            /// Value
            /// </summary>
            public LanguageTag Value { get; }

            /// <inheritdoc />
            public override int GetHashCode() => Value.GetHashCode();

            /// <inheritdoc />
            public override bool Equals(object obj) => obj is LanguageTag rhs && Value.Equals(rhs);

            /// <summary>
            /// Cached hashcode
            /// </summary>
            internal int HashCodeCached { get; }

            /// <summary>
            /// Priority
            /// </summary>
            public int Priority { get; set; }

            /// <summary>
            /// Full level
            /// </summary>
            public int FullLevel { get; }

            /// <summary>
            /// 获得 LanguageTag 的完整度级别，该级别用于 Add 方法对同语言标记做优先级自动优化排列时的参考
            /// 级别从 0 到 4，数字越小，优先级越高
            /// LanguageTag 完整性越高，优先级越高——优先命中高优先级的，最低的 Language only 作为兜底候选项
            /// l        0
            /// l-r      1
            /// l-s      2
            /// l-s-r    3
            /// l-s-r-p  4
            /// </summary>
            /// <param name="languageTag"></param>
            /// <returns></returns>
            private static int GetFullLevel(LanguageTag languageTag)
            {
                if (languageTag == null)
                    return -1;

                if (!languageTag.Language.IsSet())
                    return -1;

                if (languageTag.Language.IsSet() && languageTag.Script.IsSet() && languageTag.Region.IsSet() && languageTag.PrivateUse.IsSet())
                    return 4;

                if (languageTag.Language.IsSet() && languageTag.Script.IsSet() && languageTag.Region.IsSet())
                    return 3;

                if (languageTag.Language.IsSet() && languageTag.Script.IsSet())
                    return 2;

                if (languageTag.Language.IsSet() && languageTag.Region.IsSet())
                    return 1;

                return 0;
            }
        }

        /// <summary>
        /// Fallback item list for fallback experimenter
        /// </summary>
        private class FallbackItemList : List<FallbackItem>
        {
            /// <summary>
            /// Add and fix priority<br />
            /// THIS WILL UPDATE ALL ITEM'S PRIORITY
            /// </summary>
            /// <param name="item"></param>
            public new void Add(FallbackItem item)
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item));

                if (Contains(item))
                    return;

                //note
                //检测出相同 Language 的 tag，根据 Language - region - script - privateUse 的顺序将新的 language tag 插入到合适的位置
                //然后修正相同 language 的优先级
                //修正优先级大于该 language tag 的所有 tag 的优先级（集体 +1）

                //step.1 get all same [Language] tag from items
                var sameLanguageItems = this.Where(x => x.Value.Language == item.Value.Language).ToList();

                if (!sameLanguageItems.Any())
                {
                    //there's no same [Language] in list
                    var max = this.Max(m => m.Priority);
                    item.Priority = max + 1;
                    base.Add(item);
                    return;
                }

                //step.2 update same-language-items' priority
                var minPriority = sameLanguageItems.Min(x => x.Priority);
                var maxPriority = sameLanguageItems.Max(x => x.Priority);
                sameLanguageItems.Add(item);

                foreach (var nicePtr in sameLanguageItems.OrderByDescending(o => o.FullLevel))
                    nicePtr.Priority = minPriority++;

                //step.3 update all item which priority greater than maxPriority
                foreach (var nicePtr in this)
                {
                    if (nicePtr.Priority <= maxPriority)
                        continue;
                    nicePtr.Priority++;
                }

                base.Add(item);
            }
        }
    }
}