using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Germany Regions
    /// </summary>
    public static class GermanyRegions
    {

        #region Gets regions

        /// <summary>
        /// Baden-Württemberg
        /// </summary>
        public static EnumValues BadenWürttemberg => EnumValues.BadenWürttemberg;

        /// <summary>
        /// Bayern, Bavaria
        /// </summary>
        public static EnumValues Bayern => EnumValues.Bayern;

        /// <summary>
        /// Berlin
        /// </summary>
        public static EnumValues Berlin => EnumValues.Berlin;

        /// <summary>
        /// Brandenburg
        /// </summary>
        public static EnumValues Brandenburg => EnumValues.Brandenburg;

        /// <summary>
        /// Bremen
        /// </summary>
        public static EnumValues Bremen => EnumValues.Bremen;

        /// <summary>
        /// Hamburg
        /// </summary>
        public static EnumValues Hamburg => EnumValues.Hamburg;

        /// <summary>
        /// Hessen, Hesse
        /// </summary>
        public static EnumValues Hessen => EnumValues.Hessen;

        /// <summary>
        /// Mecklenburg-Vorpommern
        /// </summary>
        public static EnumValues MecklenburgVorpommern => EnumValues.MecklenburgVorpommern;

        /// <summary>
        /// Niedersachsen, Lower Saxony
        /// </summary>
        public static EnumValues Niedersachsen => EnumValues.Niedersachsen;

        /// <summary>
        /// Nordrhein-Westfalen, North Rhine-Westphalia
        /// </summary>
        public static EnumValues NordrheinWestfalen => EnumValues.NordrheinWestfalen;

        /// <summary>
        /// Rheinland-Pfalz, Rhineland-Palatinate
        /// </summary>
        public static EnumValues RheinlandPfalz => EnumValues.RheinlandPfalz;

        /// <summary>
        /// Saarland
        /// </summary>
        public static EnumValues Saarland => EnumValues.Saarland;

        /// <summary>
        /// Sachsen, Saxony
        /// </summary>
        public static EnumValues Sachsen => EnumValues.Sachsen;

        /// <summary>
        /// Sachsen-Anhalt
        /// </summary>
        public static EnumValues SachsenAnhalt => EnumValues.SachsenAnhalt;

        /// <summary>
        /// Schleswig-Holstein
        /// </summary>
        public static EnumValues SchleswigHolstein => EnumValues.SchleswigHolstein;

        /// <summary>
        /// Thüringen
        /// </summary>
        public static EnumValues Thüringen => EnumValues.Thüringen;

        #endregion

        /// <summary>
        /// Enum values for Germany regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Baden-Württemberg
            /// </summary>
            [AliasInShort("BW")]
            BadenWürttemberg,

            /// <summary>
            /// Bayern, Bavaria
            /// </summary>
            [AliasInShort("BY")]
            Bayern,

            /// <summary>
            /// Berlin
            /// </summary>
            [AliasInShort("BE")]
            Berlin,

            /// <summary>
            /// Brandenburg
            /// </summary>
            [AliasInShort("BB")]
            Brandenburg,

            /// <summary>
            /// Bremen
            /// </summary>
            [AliasInShort("HB")]
            Bremen,

            /// <summary>
            /// Hamburg
            /// </summary>
            [AliasInShort("HH")]
            Hamburg,

            /// <summary>
            /// Hessen, Hesse
            /// </summary>
            [AliasInShort("HE")]
            Hessen,

            /// <summary>
            /// Mecklenburg-Vorpommern
            /// </summary>
            [AliasInShort("MV")]
            MecklenburgVorpommern,

            /// <summary>
            /// Niedersachsen, Lower Saxony
            /// </summary>
            [AliasInShort("NI")]
            Niedersachsen,

            /// <summary>
            /// Nordrhein-Westfalen, North Rhine-Westphalia
            /// </summary>
            [AliasInShort("NW")]
            NordrheinWestfalen,

            /// <summary>
            /// Rheinland-Pfalz, Rhineland-Palatinate
            /// </summary>
            [AliasInShort("RP")]
            RheinlandPfalz,

            /// <summary>
            /// Saarland
            /// </summary>
            [AliasInShort("SL")]
            Saarland,

            /// <summary>
            /// Sachsen, Saxony
            /// </summary>
            [AliasInShort("SN")]
            Sachsen,

            /// <summary>
            /// Sachsen-Anhalt
            /// </summary>
            [AliasInShort("ST")]
            SachsenAnhalt,

            /// <summary>
            /// Schleswig-Holstein
            /// </summary>
            [AliasInShort("SH")]
            SchleswigHolstein,

            /// <summary>
            /// Thüringen
            /// </summary>
            [AliasInShort("TH")]
            Thüringen,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GermanyRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GermanyRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"DE-{values.ToRegionCode()}";
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