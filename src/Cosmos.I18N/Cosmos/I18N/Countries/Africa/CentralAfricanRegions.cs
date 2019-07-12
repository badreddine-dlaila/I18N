using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Central African Regions
    /// </summary>
    public static class CentralAfricanRegions
    {

        #region Gets regions

        /// <summary>
        /// Ouham
        /// </summary>
        public static EnumValues Ouham => EnumValues.Ouham;

        /// <summary>
        /// Bamingui-Bangoran
        /// </summary>
        public static EnumValues BaminguiBangoran => EnumValues.BaminguiBangoran;

        /// <summary>
        /// Bangui
        /// </summary>
        public static EnumValues Bangui => EnumValues.Bangui;

        /// <summary>
        /// Basse-Kotto
        /// </summary>
        public static EnumValues BasseKotto => EnumValues.BasseKotto;

        /// <summary>
        /// Haute-Kotto
        /// </summary>
        public static EnumValues HauteKotto => EnumValues.HauteKotto;

        /// <summary>
        /// Haut-Mbomou
        /// </summary>
        public static EnumValues HautMbomou => EnumValues.HautMbomou;

        /// <summary>
        /// Mambéré-Kadéï
        /// </summary>
        public static EnumValues MambéréKadéï => EnumValues.MambéréKadéï;

        /// <summary>
        ///  Nana-Grébizi
        /// </summary>
        public static EnumValues NanaGrébizi => EnumValues.NanaGrébizi;


        /// <summary>
        /// Kémo
        /// </summary>
        public static EnumValues Kémo => EnumValues.Kémo;

        /// <summary>
        /// Lobaye
        /// </summary>
        public static EnumValues Lobaye => EnumValues.Lobaye;

        /// <summary>
        /// Mbomou
        /// </summary>
        public static EnumValues Mbomou => EnumValues.Mbomou;

        /// <summary>
        /// Ombella-M’Poko
        /// </summary>
        public static EnumValues OmbellaMPoko => EnumValues.OmbellaMPoko;

        /// <summary>
        /// Nana-Mambéré
        /// </summary>
        public static EnumValues NanaMambéré => EnumValues.NanaMambéré;

        /// <summary>
        /// Ouham-Pendé
        /// </summary>
        public static EnumValues OuhamPendé => EnumValues.OuhamPendé;

        /// <summary>
        /// Sangha-Mbaéré
        /// </summary>
        public static EnumValues SanghaMbaéré => EnumValues.SanghaMbaéré;

        /// <summary>
        /// Ouaka
        /// </summary>
        public static EnumValues Ouaka => EnumValues.Ouaka;

        /// <summary>
        /// Vakaga
        /// </summary>
        public static EnumValues Vakaga => EnumValues.Vakaga;

        #endregion

        /// <summary>
        /// Enum values for Central African regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ouham
            /// </summary>
            [AliasInShort("AC")]
            Ouham,

            /// <summary>
            /// Bamingui-Bangoran
            /// </summary>
            [AliasInShort("BB")]
            BaminguiBangoran,

            /// <summary>
            /// Bangui
            /// </summary>
            [AliasInShort("BGF")]
            Bangui,

            /// <summary>
            /// Basse-Kotto
            /// </summary>
            [AliasInShort("BK")]
            BasseKotto,

            /// <summary>
            /// Haute-Kotto
            /// </summary>
            [AliasInShort("HK")]
            HauteKotto,

            /// <summary>
            /// Haut-Mbomou
            /// </summary>
            [AliasInShort("HM")]
            HautMbomou,

            /// <summary>
            /// Mambéré-Kadéï
            /// </summary>
            [AliasInShort("HS")]
            MambéréKadéï,

            /// <summary>
            ///  Nana-Grébizi
            /// </summary>
            [AliasInShort("KB")]
            NanaGrébizi,

            /// <summary>
            /// Kémo
            /// </summary>
            [AliasInShort("KG")]
            Kémo,

            /// <summary>
            /// Lobaye
            /// </summary>
            [AliasInShort("LB")]
            Lobaye,

            /// <summary>
            /// Mbomou
            /// </summary>
            [AliasInShort("MB")]
            Mbomou,

            /// <summary>
            /// Ombella-M’Poko
            /// </summary>
            [AliasInShort("MP")]
            OmbellaMPoko,

            /// <summary>
            /// Nana-Mambéré
            /// </summary>
            [AliasInShort("NM")]
            NanaMambéré,

            /// <summary>
            /// Ouham-Pendé
            /// </summary>
            [AliasInShort("OP")]
            OuhamPendé,

            /// <summary>
            /// Sangha-Mbaéré
            /// </summary>
            [AliasInShort("SE")]
            SanghaMbaéré,

            /// <summary>
            /// Ouaka
            /// </summary>
            [AliasInShort("UK")]
            Ouaka,

            /// <summary>
            /// Vakaga
            /// </summary>
            [AliasInShort("VK")]
            Vakaga,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CentralAfricanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CentralAfricanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CF-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.CentralAfrican;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CF;
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