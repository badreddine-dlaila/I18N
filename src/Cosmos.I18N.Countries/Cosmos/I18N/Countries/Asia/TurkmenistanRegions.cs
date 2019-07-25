using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Turkmenistan Regions
    /// </summary>
    public static class TurkmenistanRegions
    {

        #region Gets regions

        /// <summary>
        /// Ahal
        /// </summary>
        public static EnumValues Ahal => EnumValues.Ahal;

        /// <summary>
        /// Balkan
        /// </summary>
        public static EnumValues Balkan => EnumValues.Balkan;

        /// <summary>
        /// Daşoguz
        /// </summary>
        public static EnumValues Daşoguz => EnumValues.Daşoguz;

        /// <summary>
        /// Lebap
        /// </summary>
        public static EnumValues Lebap => EnumValues.Lebap;

        /// <summary>
        /// Mary
        /// </summary>
        public static EnumValues Mary => EnumValues.Mary;

        /// <summary>
        /// Aşgabat
        /// </summary>
        public static EnumValues Aşgabat => EnumValues.Aşgabat;

        #endregion

        /// <summary>
        /// Enum values for Turkmenistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ahal
            /// </summary>
            [AliasInShort("A")]
            Ahal,

            /// <summary>
            /// Balkan
            /// </summary>
            [AliasInShort("B")]
            Balkan,

            /// <summary>
            /// Daşoguz
            /// </summary>
            [AliasInShort("D")]
            Daşoguz,

            /// <summary>
            /// Lebap
            /// </summary>
            [AliasInShort("L")]
            Lebap,

            /// <summary>
            /// Mary
            /// </summary>
            [AliasInShort("M")]
            Mary,

            /// <summary>
            /// Aşgabat
            /// </summary>
            [AliasInShort("S")]
            Aşgabat,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TurkmenistanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TurkmenistanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Turkmenistan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TM;
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