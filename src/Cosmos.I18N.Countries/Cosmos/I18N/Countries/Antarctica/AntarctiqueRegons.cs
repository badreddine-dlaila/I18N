using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Antarctica
{
    /// <summary>
    /// Antarctique regions
    /// </summary>
    public static class AntarctiqueRegons
    {

        #region Gets regions

        /// <summary>
        /// Casey
        /// </summary>
        public static EnumValues Casey => EnumValues.Casey;

        /// <summary>
        /// Davis
        /// </summary>
        public static EnumValues Davis => EnumValues.Davis;

        /// <summary>
        /// DumontDUrville
        /// </summary>
        public static EnumValues DumontDUrville => EnumValues.DumontDUrville;

        /// <summary>
        /// Mawson
        /// </summary>
        public static EnumValues Mawson => EnumValues.Mawson;

        /// <summary>
        /// Palmer
        /// </summary>
        public static EnumValues Palmer => EnumValues.Palmer;

        /// <summary>
        /// Rothera
        /// </summary>
        public static EnumValues Rothera => EnumValues.Rothera;

        /// <summary>
        /// Syowa
        /// </summary>
        public static EnumValues Syowa => EnumValues.Syowa;

        /// <summary>
        /// Troll
        /// </summary>
        public static EnumValues Troll => EnumValues.Troll;

        /// <summary>
        /// Vostok
        /// </summary>
        public static EnumValues Vostok => EnumValues.Vostok;

        #endregion

        /// <summary>
        /// Enum values for Antarctique regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Casey
            /// </summary>
            [AliasInShort("CA")]
            Casey,

            /// <summary>
            /// Davis
            /// </summary>
            [AliasInShort("DA")]
            Davis,

            /// <summary>
            /// DumontDUrville
            /// </summary>
            [AliasInShort("DU")]
            DumontDUrville,

            /// <summary>
            /// Mawson
            /// </summary>
            [AliasInShort("MA")]
            Mawson,

            /// <summary>
            /// Palmer
            /// </summary>
            [AliasInShort("PA")]
            Palmer,

            /// <summary>
            /// Rothera
            /// </summary>
            [AliasInShort("RO")]
            Rothera,

            /// <summary>
            /// Syowa
            /// </summary>
            [AliasInShort("SY")]
            Syowa,

            /// <summary>
            /// Troll
            /// </summary>
            [AliasInShort("TR")]
            Troll,

            /// <summary>
            /// Vostok
            /// </summary>
            [AliasInShort("VO")]
            Vostok,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AntarctiqueRegons.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AntarctiqueRegons.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AQ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Antarctique;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.AQ;
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