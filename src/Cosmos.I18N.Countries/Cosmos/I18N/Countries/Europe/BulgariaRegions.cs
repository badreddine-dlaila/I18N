using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// Bulgaria regions
    /// </summary>
    public static class BulgariaRegions {

        #region Gets region

        /// <summary>
        /// Blagoevgrad
        /// </summary>
        public static EnumValues Blagoevgrad => EnumValues.Blagoevgrad;

        /// <summary>
        /// Burgas
        /// </summary>
        public static EnumValues Burgas => EnumValues.Burgas;

        /// <summary>
        /// Varna
        /// </summary>
        public static EnumValues Varna => EnumValues.Varna;

        /// <summary>
        /// Veliko Tarnovo
        /// </summary>
        public static EnumValues VelikoTarnovo => EnumValues.VelikoTarnovo;

        /// <summary>
        /// Vidin
        /// </summary>
        public static EnumValues Vidin => EnumValues.Vidin;

        /// <summary>
        /// Vratsa
        /// </summary>
        public static EnumValues Vratsa => EnumValues.Vratsa;

        /// <summary>
        /// Gabrovo
        /// </summary>
        public static EnumValues Gabrovo => EnumValues.Gabrovo;

        /// <summary>
        /// Dobrich
        /// </summary>
        public static EnumValues Dobrich => EnumValues.Dobrich;

        /// <summary>
        /// Kardzhali
        /// </summary>
        public static EnumValues Kardzhali => EnumValues.Kardzhali;

        /// <summary>
        /// Kyustendil
        /// </summary>
        public static EnumValues Kyustendil => EnumValues.Kyustendil;

        /// <summary>
        /// Lovech
        /// </summary>
        public static EnumValues Lovech => EnumValues.Lovech;

        /// <summary>
        /// Montana
        /// </summary>
        public static EnumValues Montana => EnumValues.Montana;

        /// <summary>
        /// Pazardzhik
        /// </summary>
        public static EnumValues Pazardzhik => EnumValues.Pazardzhik;

        /// <summary>
        /// Pernik
        /// </summary>
        public static EnumValues Pernik => EnumValues.Pernik;

        /// <summary>
        /// Pleven
        /// </summary>
        public static EnumValues Pleven => EnumValues.Pleven;

        /// <summary>
        /// Plovdiv
        /// </summary>
        public static EnumValues Plovdiv => EnumValues.Plovdiv;

        /// <summary>
        /// Razgrad
        /// </summary>
        public static EnumValues Razgrad => EnumValues.Razgrad;

        /// <summary>
        /// Ruse
        /// </summary>
        public static EnumValues Ruse => EnumValues.Ruse;

        /// <summary>
        /// Silistra
        /// </summary>
        public static EnumValues Silistra => EnumValues.Silistra;

        /// <summary>
        /// Sliven
        /// </summary>
        public static EnumValues Sliven => EnumValues.Sliven;

        /// <summary>
        /// Smolyan
        /// </summary>
        public static EnumValues Smolyan => EnumValues.Smolyan;

        /// <summary>
        /// Sofia
        /// </summary>
        public static EnumValues Sofia => EnumValues.Sofia;

        /// <summary>
        /// Sofia District
        /// </summary>
        public static EnumValues SofiaDistrict => EnumValues.SofiaDistrict;

        /// <summary>
        /// Stara Zagora
        /// </summary>
        public static EnumValues StaraZagora => EnumValues.StaraZagora;

        /// <summary>
        /// Targovishte
        /// </summary>
        public static EnumValues Targovishte => EnumValues.Targovishte;

        /// <summary>
        /// Haskovo
        /// </summary>
        public static EnumValues Haskovo => EnumValues.Haskovo;

        /// <summary>
        /// Shumen
        /// </summary>
        public static EnumValues Shumen => EnumValues.Shumen;

        /// <summary>
        /// Yambol
        /// </summary>
        public static EnumValues Yambol => EnumValues.Yambol;

        #endregion

        /// <summary>
        /// Enum values for Bulgaria regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Blagoevgrad
            /// </summary>
            [AliasInShort("01")]
            Blagoevgrad,

            /// <summary>
            /// Burgas
            /// </summary>
            [AliasInShort("02")]
            Burgas,

            /// <summary>
            /// Varna
            /// </summary>
            [AliasInShort("03")]
            Varna,

            /// <summary>
            /// Veliko Tarnovo
            /// </summary>
            [AliasInShort("04")]
            VelikoTarnovo,

            /// <summary>
            /// Vidin
            /// </summary>
            [AliasInShort("05")]
            Vidin,

            /// <summary>
            /// Vratsa
            /// </summary>
            [AliasInShort("06")]
            Vratsa,

            /// <summary>
            /// Gabrovo
            /// </summary>
            [AliasInShort("07")]
            Gabrovo,

            /// <summary>
            /// Dobrich
            /// </summary>
            [AliasInShort("08")]
            Dobrich,

            /// <summary>
            /// Kardzhali
            /// </summary>
            [AliasInShort("09")]
            Kardzhali,

            /// <summary>
            /// Kyustendil
            /// </summary>
            [AliasInShort("10")]
            Kyustendil,

            /// <summary>
            /// Lovech
            /// </summary>
            [AliasInShort("11")]
            Lovech,

            /// <summary>
            /// Montana
            /// </summary>
            [AliasInShort("12")]
            Montana,

            /// <summary>
            /// Pazardzhik
            /// </summary>
            [AliasInShort("13")]
            Pazardzhik,

            /// <summary>
            /// Pernik
            /// </summary>
            [AliasInShort("14")]
            Pernik,

            /// <summary>
            /// Pleven
            /// </summary>
            [AliasInShort("15")]
            Pleven,

            /// <summary>
            /// Plovdiv
            /// </summary>
            [AliasInShort("16")]
            Plovdiv,

            /// <summary>
            /// Razgrad
            /// </summary>
            [AliasInShort("17")]
            Razgrad,

            /// <summary>
            /// Ruse
            /// </summary>
            [AliasInShort("18")]
            Ruse,

            /// <summary>
            /// Silistra
            /// </summary>
            [AliasInShort("19")]
            Silistra,

            /// <summary>
            /// Sliven
            /// </summary>
            [AliasInShort("20")]
            Sliven,

            /// <summary>
            /// Smolyan
            /// </summary>
            [AliasInShort("21")]
            Smolyan,

            /// <summary>
            /// Sofia
            /// </summary>
            [AliasInShort("22")]
            Sofia,

            /// <summary>
            /// Sofia District
            /// </summary>
            [AliasInShort("23")]
            SofiaDistrict,

            /// <summary>
            /// Stara Zagora
            /// </summary>
            [AliasInShort("24")]
            StaraZagora,

            /// <summary>
            /// Targovishte
            /// </summary>
            [AliasInShort("25")]
            Targovishte,

            /// <summary>
            /// Haskovo
            /// </summary>
            [AliasInShort("26")]
            Haskovo,

            /// <summary>
            /// Shumen
            /// </summary>
            [AliasInShort("27")]
            Shumen,

            /// <summary>
            /// Yambol
            /// </summary>
            [AliasInShort("28")]
            Yambol,


            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BulgariaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BulgariaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BG-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Bulgaria;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.BG;
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