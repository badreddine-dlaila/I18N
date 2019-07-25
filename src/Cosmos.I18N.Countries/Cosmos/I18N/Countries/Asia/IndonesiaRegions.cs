using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Indonesia Regions
    /// </summary>
    public static class IndonesiaRegions
    {

        #region Gets regions

        /// <summary>
        /// Java
        /// </summary>
        public static EnumValues Java => EnumValues.Java;

        /// <summary>
        /// Kalimantan
        /// </summary>
        public static EnumValues Kalimantan => EnumValues.Kalimantan;

        /// <summary>
        /// Maluku Islands
        /// </summary>
        public static EnumValues MalukuIslands => EnumValues.MalukuIslands;

        /// <summary>
        /// Lesser Sunda Islands
        /// </summary>
        public static EnumValues LesserSundaIslands => EnumValues.LesserSundaIslands;

        /// <summary>
        /// Papua Islands
        /// </summary>
        public static EnumValues PapuaIslands => EnumValues.PapuaIslands;

        /// <summary>
        /// Sulawesi
        /// </summary>
        public static EnumValues Sulawesi => EnumValues.Sulawesi;

        /// <summary>
        /// Sumatra
        /// </summary>
        public static EnumValues Sumatra => EnumValues.Sumatra;

        #endregion

        /// <summary>
        /// Enum values for Indonesia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Java
            /// </summary>
            [AliasInShort("JW")]
            Java,

            /// <summary>
            /// Kalimantan
            /// </summary>
            [AliasInShort("KA")]
            Kalimantan,

            /// <summary>
            /// Maluku Islands
            /// </summary>
            [AliasInShort("ML")]
            MalukuIslands,

            /// <summary>
            /// Lesser Sunda Islands
            /// </summary>
            [AliasInShort("MU")]
            LesserSundaIslands,

            /// <summary>
            /// Papua Islands
            /// </summary>
            [AliasInShort("PP")]
            PapuaIslands,

            /// <summary>
            /// Sulawesi
            /// </summary>
            [AliasInShort("SL")]
            Sulawesi,

            /// <summary>
            /// Sumatra
            /// </summary>
            [AliasInShort("SM")]
            Sumatra,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IndonesiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IndonesiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"ID-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Indonesia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.ID;
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