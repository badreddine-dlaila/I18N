using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Mauritius Regions
    /// </summary>
    public static class MauritiusRegions
    {

        #region Gets regions

        /// <summary>
        /// Agaléga
        /// </summary>
        public static EnumValues Agaléga => EnumValues.Agaléga;

        /// <summary>
        /// Rivière Noire
        /// </summary>
        public static EnumValues RivièreNoire => EnumValues.RivièreNoire;

        /// <summary>
        /// Beau-Bassin Rose-Hill
        /// </summary>
        public static EnumValues BeauBassinRoseHill => EnumValues.BeauBassinRoseHill;

        /// <summary>
        /// Cargados Carajos
        /// </summary>
        public static EnumValues CargadosCarajos => EnumValues.CargadosCarajos;

        /// <summary>
        /// Curepipe
        /// </summary>
        public static EnumValues Curepipe => EnumValues.Curepipe;

        /// <summary>
        /// Flacq
        /// </summary>
        public static EnumValues Flacq => EnumValues.Flacq;

        /// <summary>
        /// Grand Port
        /// </summary>
        public static EnumValues GrandPort => EnumValues.GrandPort;

        /// <summary>
        /// Moka
        /// </summary>
        public static EnumValues Moka => EnumValues.Moka;

        /// <summary>
        /// Pamplemousses
        /// </summary>
        public static EnumValues Pamplemousses => EnumValues.Pamplemousses;

        /// <summary>
        /// Port Louis District
        /// </summary>
        public static EnumValues PortLouisDistrict => EnumValues.PortLouisDistrict;

        /// <summary>
        /// Port Louis
        /// </summary>
        public static EnumValues PortLouis => EnumValues.PortLouis;

        /// <summary>
        /// Al Muthanna
        /// </summary>
        public static EnumValues AlMuthanna => EnumValues.AlMuthanna;

        /// <summary>
        /// Plaines Wilhems
        /// </summary>
        public static EnumValues PlainesWilhems => EnumValues.PlainesWilhems;

        /// <summary>
        /// Quatre Bornes
        /// </summary>
        public static EnumValues QuatrBornes => EnumValues.QuatrBornes;

        /// <summary>
        /// Rodrigues
        /// </summary>
        public static EnumValues Rodrigues => EnumValues.Rodrigues;

        /// <summary>
        /// Rivière du Rempart
        /// </summary>
        public static EnumValues RivièreDuRempart => EnumValues.RivièreDuRempart;

        /// <summary>
        /// Savanne
        /// </summary>
        public static EnumValues Savanne => EnumValues.Savanne;

        /// <summary>
        /// Vacoas-Phoenix
        /// </summary>
        public static EnumValues VacoasPhoenix => EnumValues.VacoasPhoenix;

        #endregion

        /// <summary>
        /// Enum values for Mauritius regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Agaléga
            /// </summary>
            [AliasInShort("AG")]
            Agaléga,

            /// <summary>
            /// Rivière Noire
            /// </summary>
            [AliasInShort("BL")]
            RivièreNoire,

            /// <summary>
            /// Beau-Bassin Rose-Hill
            /// </summary>
            [AliasInShort("BR")]
            BeauBassinRoseHill,

            /// <summary>
            /// Cargados Carajos
            /// </summary>
            [AliasInShort("CC")]
            CargadosCarajos,

            /// <summary>
            /// Curepipe
            /// </summary>
            [AliasInShort("CU")]
            Curepipe,

            /// <summary>
            /// Flacq
            /// </summary>
            [AliasInShort("FL")]
            Flacq,

            /// <summary>
            /// Grand Port
            /// </summary>
            [AliasInShort("GP")]
            GrandPort,

            /// <summary>
            /// Moka
            /// </summary>
            [AliasInShort("MO")]
            Moka,

            /// <summary>
            /// Pamplemousses
            /// </summary>
            [AliasInShort("PA")]
            Pamplemousses,

            /// <summary>
            /// Port Louis District
            /// </summary>
            [AliasInShort("PL")]
            PortLouisDistrict,

            /// <summary>
            /// Port Louis
            /// </summary>
            [AliasInShort("PU")]
            PortLouis,

            /// <summary>
            /// Al Muthanna
            /// </summary>
            [AliasInShort("MU")]
            AlMuthanna,

            /// <summary>
            /// Plaines Wilhems
            /// </summary>
            [AliasInShort("PW")]
            PlainesWilhems,

            /// <summary>
            /// Quatre Bornes
            /// </summary>
            [AliasInShort("QB")]
            QuatrBornes,

            /// <summary>
            /// Rodrigues
            /// </summary>
            [AliasInShort("RO")]
            Rodrigues,

            /// <summary>
            /// Rivière du Rempart
            /// </summary>
            [AliasInShort("RR")]
            RivièreDuRempart,

            /// <summary>
            /// Savanne
            /// </summary>
            [AliasInShort("SA")]
            Savanne,

            /// <summary>
            /// Vacoas-Phoenix
            /// </summary>
            [AliasInShort("VP")]
            VacoasPhoenix,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MauritiusRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MauritiusRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"MU-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Mauritius;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.MU;
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