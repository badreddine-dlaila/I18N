using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Syrian Regions
    /// </summary>
    public static class SyrianRegions {

        #region Gets regions

        /// <summary>
        /// Damascus
        /// </summary>
        public static EnumValues Damascus => EnumValues.Damascus;

        /// <summary>
        /// Daraa
        /// </summary>
        public static EnumValues Daraa => EnumValues.Daraa;

        /// <summary>
        /// Deir ez-Zor
        /// </summary>
        public static EnumValues DeirEzZor => EnumValues.DeirEzZor;

        /// <summary>
        /// Al-Hasakah
        /// </summary>
        public static EnumValues AlHasakah => EnumValues.AlHasakah;

        /// <summary>
        /// Homs
        /// </summary>
        public static EnumValues Homs => EnumValues.Homs;

        /// <summary>
        /// Aleppo
        /// </summary>
        public static EnumValues Aleppo => EnumValues.Aleppo;

        /// <summary>
        /// Hama
        /// </summary>
        public static EnumValues Hama => EnumValues.Hama;

        /// <summary>
        /// Idlib  
        /// </summary>
        public static EnumValues Idlib => EnumValues.Idlib;

        /// <summary>
        /// Latakia
        /// </summary>
        public static EnumValues Latakia => EnumValues.Latakia;

        /// <summary>
        /// Quneitra
        /// </summary>
        public static EnumValues Quneitra => EnumValues.Quneitra;

        /// <summary>
        /// Ar-Raqqah
        /// </summary>
        public static EnumValues ArRaqqah => EnumValues.ArRaqqah;

        /// <summary>
        /// Rif Dimashq
        /// </summary>
        public static EnumValues RifDimashq => EnumValues.RifDimashq;

        /// <summary>
        /// As-Suwayda
        /// </summary>
        public static EnumValues AsSuwayda => EnumValues.AsSuwayda;

        /// <summary>
        /// Tartus
        /// </summary>
        public static EnumValues Tartus => EnumValues.Tartus;

        #endregion

        /// <summary>
        /// Enum values for Syrian regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Damascus
            /// </summary>
            [AliasInShort("DI")]
            Damascus,

            /// <summary>
            /// Daraa
            /// </summary>
            [AliasInShort("DR")]
            Daraa,

            /// <summary>
            /// Deir ez-Zor
            /// </summary>
            [AliasInShort("DY")]
            DeirEzZor,

            /// <summary>
            /// Al-Hasakah
            /// </summary>
            [AliasInShort("HA")]
            AlHasakah,

            /// <summary>
            /// Homs
            /// </summary>
            [AliasInShort("HI")]
            Homs,

            /// <summary>
            /// Aleppo
            /// </summary>
            [AliasInShort("HL")]
            Aleppo,

            /// <summary>
            /// Hama
            /// </summary>
            [AliasInShort("HM")]
            Hama,

            /// <summary>
            /// Idlib
            /// </summary>
            [AliasInShort("ID")]
            Idlib,

            /// <summary>
            /// Latakia
            /// </summary>
            [AliasInShort("LA")]
            Latakia,

            /// <summary>
            /// Quneitra
            /// </summary>
            [AliasInShort("QU")]
            Quneitra,

            /// <summary>
            /// Ar-Raqqah
            /// </summary>
            [AliasInShort("RA")]
            ArRaqqah,

            /// <summary>
            /// Rif Dimashq
            /// </summary>
            [AliasInShort("RD")]
            RifDimashq,

            /// <summary>
            /// As-Suwayda
            /// </summary>
            [AliasInShort("SU")]
            AsSuwayda,

            /// <summary>
            /// Tartus
            /// </summary>
            [AliasInShort("TA")]
            Tartus,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SyrianRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SyrianRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"SY-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Syrian;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.SY;
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