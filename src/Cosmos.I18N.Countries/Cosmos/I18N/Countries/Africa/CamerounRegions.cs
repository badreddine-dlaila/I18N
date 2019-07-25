using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Cameroun Regions
    /// </summary>
    public static class CamerounRegions
    {

        #region Gets regions

        /// <summary>
        /// Adamawa
        /// </summary>
        public static EnumValues Adamawa => EnumValues.Adamawa;

        /// <summary>
        /// Centre
        /// </summary>
        public static EnumValues Centre => EnumValues.Centre;

        /// <summary>
        /// Far North
        /// </summary>
        public static EnumValues FarNorth => EnumValues.FarNorth;

        /// <summary>
        /// East
        /// </summary>
        public static EnumValues East => EnumValues.East;

        /// <summary>
        /// Littoral
        /// </summary>
        public static EnumValues Littoral => EnumValues.Littoral;

        /// <summary>
        /// North
        /// </summary>
        public static EnumValues North => EnumValues.North;

        /// <summary>
        /// Northwest
        /// </summary>
        public static EnumValues Northwest => EnumValues.Northwest;

        /// <summary>
        /// West
        /// </summary>
        public static EnumValues West => EnumValues.West;

        /// <summary>
        /// South
        /// </summary>
        public static EnumValues South => EnumValues.South;

        /// <summary>
        /// Southwest
        /// </summary>
        public static EnumValues Southwest => EnumValues.Southwest;

        #endregion

        /// <summary>
        /// Enum values for Cameroun regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Adamawa
            /// </summary>
            [AliasInShort("AD")]
            Adamawa,

            /// <summary>
            /// Centre
            /// </summary>
            [AliasInShort("CE")]
            Centre,

            /// <summary>
            /// Far North
            /// </summary>
            [AliasInShort("EN")]
            FarNorth,

            /// <summary>
            /// East
            /// </summary>
            [AliasInShort("ES")]
            East,

            /// <summary>
            /// Littoral
            /// </summary>
            [AliasInShort("LT")]
            Littoral,

            /// <summary>
            /// North
            /// </summary>
            [AliasInShort("NO")]
            North,

            /// <summary>
            /// Northwest
            /// </summary>
            [AliasInShort("NW")]
            Northwest,

            /// <summary>
            /// West
            /// </summary>
            [AliasInShort("OU")]
            West,

            /// <summary>
            /// South
            /// </summary>
            [AliasInShort("SU")]
            South,

            /// <summary>
            /// Southwest
            /// </summary>
            [AliasInShort("SW")]
            Southwest,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CamerounRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CamerounRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Cameroun;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CM;
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