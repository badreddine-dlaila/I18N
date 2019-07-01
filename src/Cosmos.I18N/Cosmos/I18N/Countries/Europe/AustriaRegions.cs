using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Austria regions
    /// </summary>
    public static class AustriaRegions
    {

        #region Gets regions

        /// <summary>
        /// Burgenland
        /// </summary>
        public static EnumValues Burgenland => EnumValues.Burgenland;

        /// <summary>
        /// Carinthia
        /// </summary>
        public static EnumValues Kärnten => EnumValues.Kärnten;

        /// <summary>
        /// Lower Austria
        /// </summary>
        public static EnumValues Niederösterreich => EnumValues.Niederösterreich;

        /// <summary>
        /// Upper Austria
        /// </summary>
        public static EnumValues Oberösterreich => EnumValues.Oberösterreich;

        /// <summary>
        /// Salzburg
        /// </summary>
        public static EnumValues Salzburg => EnumValues.Salzburg;

        /// <summary>
        /// Styria
        /// </summary>
        public static EnumValues Steiermark => EnumValues.Steiermark;

        /// <summary>
        /// Tyrol
        /// </summary>
        public static EnumValues Tirol => EnumValues.Tirol;

        /// <summary>
        /// Vorarlberg
        /// </summary>
        public static EnumValues Vorarlberg => EnumValues.Vorarlberg;

        /// <summary>
        /// Vienna
        /// </summary>
        public static EnumValues Wien => EnumValues.Wien;

        #endregion

        /// <summary>
        /// Enum values for Austria regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Burgenland
            /// </summary>
            [AliasInShort("AT1")]
            Burgenland,

            /// <summary>
            /// Carinthia
            /// </summary>
            [AliasInShort("AT2")]
            Kärnten,

            /// <summary>
            /// Lower Austria
            /// </summary>
            [AliasInShort("AT3")]
            Niederösterreich,

            /// <summary>
            /// Upper Austria
            /// </summary>
            [AliasInShort("AT4")]
            Oberösterreich,

            /// <summary>
            /// Salzburg
            /// </summary>
            [AliasInShort("AT5")]
            Salzburg,

            /// <summary>
            /// Styria
            /// </summary>
            [AliasInShort("AT6")]
            Steiermark,

            /// <summary>
            /// Tyrol
            /// </summary>
            [AliasInShort("AT7")]
            Tirol,

            /// <summary>
            /// Vorarlberg
            /// </summary>
            [AliasInShort("AT8")]
            Vorarlberg,

            /// <summary>
            /// Vienna
            /// </summary>
            [AliasInShort("AT9")]
            Wien,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AustriaRegions.EnumValues"/> to region code likes 'ACT', 'NT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AustriaRegions.EnumValues"/> to full region code likes 'AU-ACT', 'AU-NT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AT-{values.ToRegionCode()}";
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();
        
        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes()
        {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}