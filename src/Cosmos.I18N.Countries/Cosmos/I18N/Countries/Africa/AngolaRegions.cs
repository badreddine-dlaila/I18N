using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Angola regions
    /// </summary>
    public static class AngolaRegions {

        #region Gets region

        /// <summary>
        /// Bengo
        /// </summary>
        public static EnumValues Bengo => EnumValues.Bengo;

        /// <summary>
        /// Benguela
        /// </summary>
        public static EnumValues Benguela => EnumValues.Benguela;

        /// <summary>
        /// Bié
        /// </summary>
        public static EnumValues Bié => EnumValues.Bié;

        /// <summary>
        /// Cabinda
        /// </summary>
        public static EnumValues Cabinda => EnumValues.Cabinda;

        /// <summary>
        /// Cuando Cubango
        /// </summary>
        public static EnumValues CuandoCubango => EnumValues.CuandoCubango;

        /// <summary>
        /// Cunene
        /// </summary>
        public static EnumValues Cunene => EnumValues.Cunene;

        /// <summary>
        /// Cuanza Norte
        /// </summary>
        public static EnumValues CuanzaNorte => EnumValues.CuanzaNorte;

        /// <summary>
        /// Cuanza Sul    
        /// </summary>
        public static EnumValues CuanzaSul => EnumValues.CuanzaSul;

        /// <summary>
        /// Huambo
        /// </summary>
        public static EnumValues Huambo => EnumValues.Huambo;

        /// <summary>
        /// Huíla
        /// </summary>
        public static EnumValues Huíla => EnumValues.Huíla;

        /// <summary>
        /// Lunda Norte
        /// </summary>
        public static EnumValues LundaNorte => EnumValues.LundaNorte;

        /// <summary>
        /// Lunda Sul
        /// </summary>
        public static EnumValues LundaSul => EnumValues.LundaSul;

        /// <summary>
        /// Luanda
        /// </summary>
        public static EnumValues Luanda => EnumValues.Luanda;

        /// <summary>
        /// Malanje
        /// </summary>
        public static EnumValues Malanje => EnumValues.Malanje;

        /// <summary>
        /// Moxico
        /// </summary>
        public static EnumValues Moxico => EnumValues.Moxico;

        /// <summary>
        /// Namibe
        /// </summary>
        public static EnumValues Namibe => EnumValues.Namibe;

        /// <summary>
        /// Uíge
        /// </summary>
        public static EnumValues Uíge => EnumValues.Uíge;

        /// <summary>
        /// Zaire
        /// </summary>
        public static EnumValues Zaire => EnumValues.Zaire;

        #endregion

        /// <summary>
        /// Enum values for Angola regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bengo
            /// </summary>
            [AliasInShort("BGO")]
            Bengo,

            /// <summary>
            /// Benguela
            /// </summary>
            [AliasInShort("BGU")]
            Benguela,

            /// <summary>
            /// Bié
            /// </summary>
            [AliasInShort("BIE")]
            Bié,

            /// <summary>
            /// Cabinda
            /// </summary>
            [AliasInShort("CAB")]
            Cabinda,

            /// <summary>
            /// Cuando Cubango
            /// </summary>
            [AliasInShort("CCU")]
            CuandoCubango,

            /// <summary>
            /// Cunene
            /// </summary>
            [AliasInShort("CNN")]
            Cunene,

            /// <summary>
            /// Cuanza Norte
            /// </summary>
            [AliasInShort("CNO")]
            CuanzaNorte,

            /// <summary>
            /// Cuanza Sul    
            /// </summary>
            [AliasInShort("CUS")]
            CuanzaSul,

            /// <summary>
            /// Huambo
            /// </summary>
            [AliasInShort("HUA")]
            Huambo,

            /// <summary>
            /// Huíla
            /// </summary>
            [AliasInShort("HUI")]
            Huíla,

            /// <summary>
            /// Lunda Norte
            /// </summary>
            [AliasInShort("LNO")]
            LundaNorte,

            /// <summary>
            /// Lunda Sul
            /// </summary>
            [AliasInShort("LSU")]
            LundaSul,

            /// <summary>
            /// Luanda
            /// </summary>
            [AliasInShort("LUA")]
            Luanda,

            /// <summary>
            /// Malanje
            /// </summary>
            [AliasInShort("MAL")]
            Malanje,

            /// <summary>
            /// Moxico
            /// </summary>
            [AliasInShort("MOX")]
            Moxico,

            /// <summary>
            /// Namibe
            /// </summary>
            [AliasInShort("NAM")]
            Namibe,

            /// <summary>
            /// Uíge
            /// </summary>
            [AliasInShort("UIG")]
            Uíge,

            /// <summary>
            /// Zaire
            /// </summary>
            [AliasInShort("ZAI")]
            Zaire,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AngolaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AngolaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"AO-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Angola;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.AO;
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