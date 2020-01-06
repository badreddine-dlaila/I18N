using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// Greenland Regions
    /// </summary>
    public static class GreenlandRegions {

        #region Gets regions

        /// <summary>
        /// Kujalleq
        /// </summary>
        public static EnumValues Kujalleq => EnumValues.Kujalleq;

        /// <summary>
        /// Qaasuitsup
        /// </summary>
        public static EnumValues Qaasuitsup => EnumValues.Qaasuitsup;

        /// <summary>
        /// Qeqqata
        /// </summary>
        public static EnumValues Qeqqata => EnumValues.Qeqqata;

        /// <summary>
        /// Sermersooq
        /// </summary>
        public static EnumValues Sermersooq => EnumValues.Sermersooq;

        #endregion

        /// <summary>
        /// Enum values for Greenland regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Kujalleq
            /// </summary>
            [AliasInShort("KU")]
            Kujalleq,

            /// <summary>
            /// Qaasuitsup
            /// </summary>
            [AliasInShort("QA")]
            Qaasuitsup,

            /// <summary>
            /// Qeqqata
            /// </summary>
            [AliasInShort("QE")]
            Qeqqata,

            /// <summary>
            /// Sermersooq
            /// </summary>
            [AliasInShort("SM")]
            Sermersooq,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GreenlandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GreenlandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"GL-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Greenland;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.GL;
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes() {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}