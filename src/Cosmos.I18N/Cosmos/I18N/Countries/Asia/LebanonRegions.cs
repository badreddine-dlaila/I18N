using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Lebanon regions
    /// </summary>
    public static class LebanonRegions
    {

        #region Gets regions

        /// <summary>
        /// Akkar
        /// </summary>
        public static EnumValues Akkar => EnumValues.Akkar;

        /// <summary>
        /// North
        /// </summary>
        public static EnumValues North => EnumValues.North;

        /// <summary>
        /// Beirut
        /// </summary>
        public static EnumValues Beirut => EnumValues.Beirut;

        /// <summary>
        /// Baalbek-Hermel
        /// </summary>
        public static EnumValues BaalbekHermel => EnumValues.BaalbekHermel;

        /// <summary>
        /// Beqaa
        /// </summary>
        public static EnumValues Beqaa => EnumValues.Beqaa;

        /// <summary>
        /// South
        /// </summary>
        public static EnumValues South => EnumValues.South;

        /// <summary>
        /// Mount Lebanon
        /// </summary>
        public static EnumValues MountLebanon => EnumValues.MountLebanon;

        /// <summary>
        /// Nabatieh
        /// </summary>
        public static EnumValues Nabatieh => EnumValues.Nabatieh;

        #endregion

        /// <summary>
        /// Enum values for Lebanon regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Akkar
            /// </summary>
            [AliasInShort("AK")]
            Akkar,

            /// <summary>
            /// North
            /// </summary>
            [AliasInShort("AS")]
            North,

            /// <summary>
            /// Beirut
            /// </summary>
            [AliasInShort("BA")]
            Beirut,

            /// <summary>
            /// Baalbek-Hermel
            /// </summary>
            [AliasInShort("BH")]
            BaalbekHermel,

            /// <summary>
            /// Beqaa
            /// </summary>
            [AliasInShort("BI")]
            Beqaa,

            /// <summary>
            /// South
            /// </summary>
            [AliasInShort("JA")]
            South,

            /// <summary>
            /// Mount Lebanon
            /// </summary>
            [AliasInShort("JL")]
            MountLebanon,

            /// <summary>
            /// Nabatieh
            /// </summary>
            [AliasInShort("NA")]
            Nabatieh,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="LebanonRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="LebanonRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"LB-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Lebanon;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.LB;
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