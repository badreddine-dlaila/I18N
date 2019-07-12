using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Egypt Regions
    /// </summary>
    public static class EgyptRegions
    {

        #region Gets regions

        /// <summary>
        /// Alexandria
        /// </summary>
        public static EnumValues Alexandria => EnumValues.Alexandria;

        /// <summary>
        /// Aswan
        /// </summary>
        public static EnumValues Aswan => EnumValues.Aswan;

        /// <summary>
        /// Asyut
        /// </summary>
        public static EnumValues Asyut => EnumValues.Asyut;

        /// <summary>
        /// Red Sea
        /// </summary>
        public static EnumValues RedSea => EnumValues.RedSea;

        /// <summary>
        /// Beheira
        /// </summary>
        public static EnumValues Beheira => EnumValues.Beheira;

        /// <summary>
        /// Beni Suef
        /// </summary>
        public static EnumValues BeniSuef => EnumValues.BeniSuef;

        /// <summary>
        /// Cairo
        /// </summary>
        public static EnumValues Cairo => EnumValues.Cairo;

        /// <summary>
        /// Dakahlia
        /// </summary>
        public static EnumValues Dakahlia => EnumValues.Dakahlia;

        /// <summary>
        /// Damietta
        /// </summary>
        public static EnumValues Damietta => EnumValues.Damietta;

        /// <summary>
        /// Faiyum
        /// </summary>
        public static EnumValues Faiyum => EnumValues.Faiyum;

        /// <summary>
        /// Gharbia
        /// </summary>
        public static EnumValues Gharbia => EnumValues.Gharbia;

        /// <summary>
        /// Giza
        /// </summary>
        public static EnumValues Giza => EnumValues.Giza;

        /// <summary>
        /// Ismailia
        /// </summary>
        public static EnumValues Ismailia => EnumValues.Ismailia;

        /// <summary>
        /// South Sinai
        /// </summary>
        public static EnumValues SouthSinai => EnumValues.SouthSinai;

        /// <summary>
        /// Qalyubia
        /// </summary>
        public static EnumValues Qalyubia => EnumValues.Qalyubia;

        /// <summary>
        /// Kafr el-Sheikh
        /// </summary>
        public static EnumValues KafrElSheikh => EnumValues.KafrElSheikh;

        /// <summary>
        /// Qena
        /// </summary>
        public static EnumValues Qena => EnumValues.Qena;

        /// <summary>
        /// Luxor
        /// </summary>
        public static EnumValues Luxor => EnumValues.Luxor;

        /// <summary>
        /// Minya
        /// </summary>
        public static EnumValues Minya => EnumValues.Minya;

        /// <summary>
        /// Monufia
        /// </summary>
        public static EnumValues Monufia => EnumValues.Monufia;

        /// <summary>
        /// Matrouh
        /// </summary>
        public static EnumValues Matrouh => EnumValues.Matrouh;

        /// <summary>
        /// Port Said
        /// </summary>
        public static EnumValues PortSaid => EnumValues.PortSaid;

        /// <summary>
        /// Sohag
        /// </summary>
        public static EnumValues Sohag => EnumValues.Sohag;

        /// <summary>
        /// Al Sharqia
        /// </summary>
        public static EnumValues AlSharqia => EnumValues.AlSharqia;

        /// <summary>
        /// North Sinai
        /// </summary>
        public static EnumValues NorthSinai => EnumValues.NorthSinai;

        /// <summary>
        /// Suez
        /// </summary>
        public static EnumValues Suez => EnumValues.Suez;

        /// <summary>
        /// New Valley
        /// </summary>
        public static EnumValues NewValley => EnumValues.NewValley;

        #endregion

        /// <summary>
        /// Enum values for Egypt regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Alexandria
            /// </summary>
            [AliasInShort("ALX")]
            Alexandria,

            /// <summary>
            /// Aswan
            /// </summary>
            [AliasInShort("ASN")]
            Aswan,

            /// <summary>
            /// Asyut
            /// </summary>
            [AliasInShort("AST")]
            Asyut,

            /// <summary>
            /// Red Sea
            /// </summary>
            [AliasInShort("BA")]
            RedSea,

            /// <summary>
            /// Beheira
            /// </summary>
            [AliasInShort("BH")]
            Beheira,

            /// <summary>
            /// Beni Suef
            /// </summary>
            [AliasInShort("BNS")]
            BeniSuef,

            /// <summary>
            /// Cairo
            /// </summary>
            [AliasInShort("C")]
            Cairo,

            /// <summary>
            /// Dakahlia
            /// </summary>
            [AliasInShort("DK")]
            Dakahlia,

            /// <summary>
            /// Damietta
            /// </summary>
            [AliasInShort("DT")]
            Damietta,

            /// <summary>
            /// Faiyum
            /// </summary>
            [AliasInShort("FYM")]
            Faiyum,

            /// <summary>
            /// Gharbia
            /// </summary>
            [AliasInShort("GH")]
            Gharbia,

            /// <summary>
            /// Giza
            /// </summary>
            [AliasInShort("GZ")]
            Giza,

            /// <summary>
            /// Ismailia
            /// </summary>
            [AliasInShort("IS")]
            Ismailia,

            /// <summary>
            /// South Sinai
            /// </summary>
            [AliasInShort("JS")]
            SouthSinai,

            /// <summary>
            /// Qalyubia
            /// </summary>
            [AliasInShort("KB")]
            Qalyubia,

            /// <summary>
            /// Kafr el-Sheikh
            /// </summary>
            [AliasInShort("KFS")]
            KafrElSheikh,

            /// <summary>
            /// Qena
            /// </summary>
            [AliasInShort("KN")]
            Qena,

            /// <summary>
            /// Luxor
            /// </summary>
            [AliasInShort("LX")]
            Luxor,

            /// <summary>
            /// Minya
            /// </summary>
            [AliasInShort("MN")]
            Minya,

            /// <summary>
            /// Monufia
            /// </summary>
            [AliasInShort("MNF")]
            Monufia,

            /// <summary>
            /// Matrouh
            /// </summary>
            [AliasInShort("MT")]
            Matrouh,

            /// <summary>
            /// Port Said
            /// </summary>
            [AliasInShort("PTS")]
            PortSaid,

            /// <summary>
            /// Sohag
            /// </summary>
            [AliasInShort("SHG")]
            Sohag,

            /// <summary>
            /// Al Sharqia
            /// </summary>
            [AliasInShort("SHR")]
            AlSharqia,

            /// <summary>
            /// North Sinai
            /// </summary>
            [AliasInShort("SIN")]
            NorthSinai,

            /// <summary>
            /// Suez
            /// </summary>
            [AliasInShort("SUZ")]
            Suez,

            /// <summary>
            /// New Valley
            /// </summary>
            [AliasInShort("WAD")]
            NewValley,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EgyptRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EgyptRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"EG-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Egypt;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.EG;
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