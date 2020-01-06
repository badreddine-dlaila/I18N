using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Armenia regions
    /// </summary>
    public static class ArmeniaRegions {

        #region Gets region

        /// <summary>
        /// Aragatsotn
        /// </summary>
        public static EnumValues Aragatsotn => EnumValues.Aragatsotn;

        /// <summary>
        /// Ararat
        /// </summary>
        public static EnumValues Ararat => EnumValues.Ararat;

        /// <summary>
        /// Armavir
        /// </summary>
        public static EnumValues Armavir => EnumValues.Armavir;

        /// <summary>
        /// Yerevan
        /// </summary>
        public static EnumValues Yerevan => EnumValues.Yerevan;

        /// <summary>
        /// Gegharkunik
        /// </summary>
        public static EnumValues Gegharkunik => EnumValues.Gegharkunik;

        /// <summary>
        /// Kotayk
        /// </summary>
        public static EnumValues Kotayk => EnumValues.Kotayk;

        /// <summary>
        /// Lori
        /// </summary>
        public static EnumValues Lori => EnumValues.Lori;

        /// <summary>
        /// Shirak
        /// </summary>
        public static EnumValues Shirak => EnumValues.Shirak;

        /// <summary>
        /// Syunik
        /// </summary>
        public static EnumValues Syunik => EnumValues.Syunik;

        /// <summary>
        /// Tavush
        /// </summary>
        public static EnumValues Tavush => EnumValues.Tavush;

        /// <summary>
        /// Vayots Dzor
        /// </summary>
        public static EnumValues VayotsDzor => EnumValues.VayotsDzor;

        #endregion

        /// <summary>
        /// Enum values for Armenia regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Aragatsotn
            /// </summary>
            [AliasInShort("AG")]
            Aragatsotn,

            /// <summary>
            /// Ararat
            /// </summary>
            [AliasInShort("AR")]
            Ararat,

            /// <summary>
            /// Armavir
            /// </summary>
            [AliasInShort("AV")]
            Armavir,

            /// <summary>
            /// Yerevan
            /// </summary>
            [AliasInShort("ER")]
            Yerevan,

            /// <summary>
            /// Gegharkunik
            /// </summary>
            [AliasInShort("GR")]
            Gegharkunik,

            /// <summary>
            /// Kotayk
            /// </summary>
            [AliasInShort("KT")]
            Kotayk,

            /// <summary>
            /// Lori
            /// </summary>
            [AliasInShort("LO")]
            Lori,

            /// <summary>
            /// Shirak
            /// </summary>
            [AliasInShort("SH")]
            Shirak,

            /// <summary>
            /// Syunik
            /// </summary>
            [AliasInShort("SU")]
            Syunik,

            /// <summary>
            /// Tavush
            /// </summary>
            [AliasInShort("TV")]
            Tavush,

            /// <summary>
            /// Vayots Dzor
            /// </summary>
            [AliasInShort("VD")]
            VayotsDzor,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ArmeniaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ArmeniaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"AM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Armenia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.AM;
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