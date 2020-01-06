using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Botswana regions
    /// </summary>
    public static class BotswanaRegions {

        #region Gets region

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Chobe
        /// </summary>
        public static EnumValues Chobe => EnumValues.Chobe;

        /// <summary>
        /// Francistown
        /// </summary>
        public static EnumValues Francistown => EnumValues.Francistown;

        /// <summary>
        /// Gaborone
        /// </summary>
        public static EnumValues Gaborone => EnumValues.Gaborone;

        /// <summary>
        /// Ghanzi
        /// </summary>
        public static EnumValues Ghanzi => EnumValues.Ghanzi;

        /// <summary>
        /// Jwaneng
        /// </summary>
        public static EnumValues Jwaneng => EnumValues.Jwaneng;

        /// <summary>
        /// Kgalagadi
        /// </summary>
        public static EnumValues Kgalagadi => EnumValues.Kgalagadi;

        /// <summary>
        /// Kgatleng
        /// </summary>
        public static EnumValues Kgatleng => EnumValues.Kgatleng;

        /// <summary>
        /// Kweneng
        /// </summary>
        public static EnumValues Kweneng => EnumValues.Kweneng;

        /// <summary>
        /// Lobatse
        /// </summary>
        public static EnumValues Lobatse => EnumValues.Lobatse;

        /// <summary>
        ///  North East
        /// </summary>
        public static EnumValues NorthEast => EnumValues.NorthEast;

        /// <summary>
        /// North West
        /// </summary>
        public static EnumValues NorthWest => EnumValues.NorthWest;

        /// <summary>
        /// South East
        /// </summary>
        public static EnumValues SouthEast => EnumValues.SouthEast;

        /// <summary>
        /// Southern
        /// </summary>
        public static EnumValues Southern => EnumValues.Southern;


        /// <summary>
        /// Selibe Phikwe
        /// </summary>
        public static EnumValues SelibePhikwe => EnumValues.SelibePhikwe;


        /// <summary>
        ///  Sowa Town
        /// </summary>
        public static EnumValues SowaTown => EnumValues.SowaTown;

        #endregion

        /// <summary>
        /// Enum values for Botswana regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CE")]
            Central,

            /// <summary>
            /// Chobe
            /// </summary>
            [AliasInShort("CH")]
            Chobe,

            /// <summary>
            /// Francistown
            /// </summary>
            [AliasInShort("FR")]
            Francistown,

            /// <summary>
            /// Gaborone
            /// </summary>
            [AliasInShort("GA")]
            Gaborone,

            /// <summary>
            /// Ghanzi
            /// </summary>
            [AliasInShort("GH")]
            Ghanzi,

            /// <summary>
            /// Jwaneng
            /// </summary>
            [AliasInShort("JW")]
            Jwaneng,

            /// <summary>
            /// Kgalagadi
            /// </summary>
            [AliasInShort("KG")]
            Kgalagadi,

            /// <summary>
            /// Kgatleng
            /// </summary>
            [AliasInShort("KL")]
            Kgatleng,

            /// <summary>
            /// Kweneng
            /// </summary>
            [AliasInShort("KW")]
            Kweneng,

            /// <summary>
            /// Lobatse
            /// </summary>
            [AliasInShort("LO")]
            Lobatse,

            /// <summary>
            ///  North East
            /// </summary>
            [AliasInShort("NE")]
            NorthEast,

            /// <summary>
            /// North West
            /// </summary>
            [AliasInShort("NW")]
            NorthWest,

            /// <summary>
            /// South East
            /// </summary>
            [AliasInShort("SE")]
            SouthEast,

            /// <summary>
            /// Southern
            /// </summary>
            [AliasInShort("SO")]
            Southern,


            /// <summary>
            /// Selibe Phikwe
            /// </summary>
            [AliasInShort("SP")]
            SelibePhikwe,


            /// <summary>
            ///  Sowa Town
            /// </summary>
            [AliasInShort("ST")]
            SowaTown,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BotswanaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BotswanaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BW-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Botswana;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.BW;
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