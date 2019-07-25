using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Bosnia And Herzegovina Regions
    /// </summary>
    public static class BosniaAndHerzegovinaRegions
    {

        #region Gets regions

        /// <summary>
        /// Federation of Bosnia and Herzegovina
        /// </summary>
        public static EnumValues FederationOfBosniaAndHerzegovina => EnumValues.FederationOfBosniaAndHerzegovina;

        /// <summary>
        /// Brčko District
        /// </summary>
        public static EnumValues BrčkoDistrict => EnumValues.BrčkoDistrict;

        /// <summary>
        /// Republika Srpska
        /// </summary>
        public static EnumValues RepublikaSrpskam => EnumValues.RepublikaSrpskam;

        #endregion

        /// <summary>
        /// Enum values for Bosnia And Herzegovina regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Federation of Bosnia and Herzegovina
            /// </summary>
            [AliasInShort("BIH")]
            FederationOfBosniaAndHerzegovina,

            /// <summary>
            /// Brčko District
            /// </summary>
            [AliasInShort("BRC")]
            BrčkoDistrict,

            /// <summary>
            /// Republika Srpska
            /// </summary>
            [AliasInShort("SRP")]
            RepublikaSrpskam,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BosniaAndHerzegovinaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BosniaAndHerzegovinaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BA-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.BosniaAndHerzegovina;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BA;
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