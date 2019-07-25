using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// PapuaNewGuinea Regions
    /// </summary>
    public static class PapuaNewGuineaRegions
    {

        #region Gets regions

        /// <summary>
        /// Chimbu
        /// </summary>
        public static EnumValues Chimbu => EnumValues.Chimbu;

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// East New Britain
        /// </summary>
        public static EnumValues EastNewBritain => EnumValues.EastNewBritain;

        /// <summary>
        /// Eastern Highlands
        /// </summary>
        public static EnumValues EasternHighlands => EnumValues.EasternHighlands;

        /// <summary>
        /// Enga
        /// </summary>
        public static EnumValues Enga => EnumValues.Enga;

        /// <summary>
        /// East Sepik
        /// </summary>
        public static EnumValues EastSepik => EnumValues.EastSepik;

        /// <summary>
        /// Gulf
        /// </summary>
        public static EnumValues Gulf => EnumValues.Gulf;

        /// <summary>
        /// Hela
        /// </summary>
        public static EnumValues Hela => EnumValues.Hela;

        /// <summary>
        /// Jiwaka
        /// </summary>
        public static EnumValues Jiwaka => EnumValues.Jiwaka;

        /// <summary>
        /// Milne Bay
        /// </summary>
        public static EnumValues MilneBay => EnumValues.MilneBay;

        /// <summary>
        /// Morobe
        /// </summary>
        public static EnumValues Morobe => EnumValues.Morobe;

        /// <summary>
        /// Madang
        /// </summary>
        public static EnumValues Madang => EnumValues.Madang;

        /// <summary>
        /// Manus
        /// </summary>
        public static EnumValues Manus => EnumValues.Manus;

        /// <summary>
        /// Port Moresby
        /// </summary>
        public static EnumValues PortMoresby => EnumValues.PortMoresby;

        /// <summary>
        /// New Ireland
        /// </summary>
        public static EnumValues NewIreland => EnumValues.NewIreland;

        /// <summary>
        /// Oro
        /// </summary>
        public static EnumValues Oro => EnumValues.Oro;

        /// <summary>
        /// Bougainville
        /// </summary>
        public static EnumValues Bougainville => EnumValues.Bougainville;

        /// <summary>
        /// Sandaun
        /// </summary>
        public static EnumValues Sandaun => EnumValues.Sandaun;

        /// <summary>
        /// Southern Highlands
        /// </summary>
        public static EnumValues SouthernHighlands => EnumValues.SouthernHighlands;

        /// <summary>
        /// West New Britain
        /// </summary>
        public static EnumValues WestNewBritain => EnumValues.WestNewBritain;

        /// <summary>
        /// Western Highlands
        /// </summary>
        public static EnumValues WesternHighlands => EnumValues.WesternHighlands;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        #endregion

        /// <summary>
        /// Enum values for PapuaNewGuinea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Chimbu
            /// </summary>
            [AliasInShort("CPK")]
            Chimbu,

            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CPM")]
            Central,

            /// <summary>
            /// East New Britain
            /// </summary>
            [AliasInShort("EBK")]
            EastNewBritain,

            /// <summary>
            /// Eastern Highlands
            /// </summary>
            [AliasInShort("EHG")]
            EasternHighlands,

            /// <summary>
            /// Enga
            /// </summary>
            [AliasInShort("EPW")]
            Enga,

            /// <summary>
            /// East Sepik
            /// </summary>
            [AliasInShort("ESW")]
            EastSepik,

            /// <summary>
            /// Gulf
            /// </summary>
            [AliasInShort("GPK")]
            Gulf,

            /// <summary>
            /// Hela
            /// </summary>
            [AliasInShort("HLA")]
            Hela,

            /// <summary>
            /// Imbabura
            /// </summary>
            [AliasInShort("JWK")]
            Jiwaka,

            /// <summary>
            /// Milne Bay
            /// </summary>
            [AliasInShort("MBA")]
            MilneBay,

            /// <summary>
            /// Morobe
            /// </summary>
            [AliasInShort("MPL")]
            Morobe,

            /// <summary>
            /// Madang
            /// </summary>
            [AliasInShort("MPM")]
            Madang,

            /// <summary>
            /// Manus
            /// </summary>
            [AliasInShort("MRL")]
            Manus,

            /// <summary>
            /// Port Moresby
            /// </summary>
            [AliasInShort("NCD")]
            PortMoresby,

            /// <summary>
            /// New Ireland
            /// </summary>
            [AliasInShort("NIK")]
            NewIreland,

            /// <summary>
            /// Oro
            /// </summary>
            [AliasInShort("NPP")]
            Oro,

            /// <summary>
            /// Bougainville
            /// </summary>
            [AliasInShort("NSB")]
            Bougainville,

            /// <summary>
            /// Sandaun
            /// </summary>
            [AliasInShort("SAN")]
            Sandaun,

            /// <summary>
            /// Southern Highlands
            /// </summary>
            [AliasInShort("SHM")]
            SouthernHighlands,

            /// <summary>
            /// West New Britain
            /// </summary>
            [AliasInShort("WBK")]
            WestNewBritain,

            /// <summary>
            /// Western Highlands
            /// </summary>
            [AliasInShort("WHM")]
            WesternHighlands,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("WPD")]
            Western,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="PapuaNewGuineaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="PapuaNewGuineaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"PG-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.PapuaNewGuinea;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.PG;
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