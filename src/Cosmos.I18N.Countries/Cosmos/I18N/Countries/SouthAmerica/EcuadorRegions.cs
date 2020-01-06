using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// Ecuador Regions
    /// </summary>
    public static class EcuadorRegions {

        #region Gets regions

        /// <summary>
        /// Azuay
        /// </summary>
        public static EnumValues Azuay => EnumValues.Azuay;

        /// <summary>
        /// Bolívar
        /// </summary>
        public static EnumValues Bolívar => EnumValues.Bolívar;

        /// <summary>
        /// Carchi
        /// </summary>
        public static EnumValues Carchi => EnumValues.Carchi;

        /// <summary>
        /// Orellana
        /// </summary>
        public static EnumValues Orellana => EnumValues.Orellana;

        /// <summary>
        /// Esmeraldas
        /// </summary>
        public static EnumValues Esmeraldas => EnumValues.Esmeraldas;

        /// <summary>
        /// Cañar
        /// </summary>
        public static EnumValues Cañar => EnumValues.Cañar;

        /// <summary>
        /// Guayas
        /// </summary>
        public static EnumValues Guayas => EnumValues.Guayas;

        /// <summary>
        /// Chimborazo
        /// </summary>
        public static EnumValues Chimborazo => EnumValues.Chimborazo;

        /// <summary>
        /// Imbabura
        /// </summary>
        public static EnumValues Imbabura => EnumValues.Imbabura;

        /// <summary>
        /// Loja
        /// </summary>
        public static EnumValues Loja => EnumValues.Loja;

        /// <summary>
        /// Manabí
        /// </summary>
        public static EnumValues Manabí => EnumValues.Manabí;

        /// <summary>
        /// Napo
        /// </summary>
        public static EnumValues Napo => EnumValues.Napo;

        /// <summary>
        /// El Oro
        /// </summary>
        public static EnumValues ElOro => EnumValues.ElOro;

        /// <summary>
        /// Pichincha
        /// </summary>
        public static EnumValues Pichincha => EnumValues.Pichincha;

        /// <summary>
        /// Los Ríos
        /// </summary>
        public static EnumValues LosRíos => EnumValues.LosRíos;

        /// <summary>
        /// Morona-Santiago
        /// </summary>
        public static EnumValues MoronaSantiago => EnumValues.MoronaSantiago;

        /// <summary>
        /// Santo Domingo de los Tsáchilas
        /// </summary>
        public static EnumValues SantoDomingoDeLosTsáchilas => EnumValues.SantoDomingoDeLosTsáchilas;

        /// <summary>
        /// Santa Elena
        /// </summary>
        public static EnumValues SantaElena => EnumValues.SantaElena;

        /// <summary>
        /// Tungurahua
        /// </summary>
        public static EnumValues Tungurahua => EnumValues.Tungurahua;

        /// <summary>
        /// Sucumbíos
        /// </summary>
        public static EnumValues Sucumbíos => EnumValues.Sucumbíos;

        /// <summary>
        /// Galápagos
        /// </summary>
        public static EnumValues Galápagos => EnumValues.Galápagos;

        /// <summary>
        /// Cotopaxi
        /// </summary>
        public static EnumValues Cotopaxi => EnumValues.Cotopaxi;

        /// <summary>
        /// Pastaza
        /// </summary>
        public static EnumValues Pastaza => EnumValues.Pastaza;

        /// <summary>
        /// Zamora-Chinchipe
        /// </summary>
        public static EnumValues ZamoraChinchipe => EnumValues.ZamoraChinchipe;

        #endregion

        /// <summary>
        /// Enum values for Ecuador regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Azuay
            /// </summary>
            [AliasInShort("A")]
            Azuay,

            /// <summary>
            /// Bolívar
            /// </summary>
            [AliasInShort("B")]
            Bolívar,

            /// <summary>
            /// Carchi
            /// </summary>
            [AliasInShort("C")]
            Carchi,

            /// <summary>
            /// Orellana
            /// </summary>
            [AliasInShort("D")]
            Orellana,

            /// <summary>
            /// Esmeraldas
            /// </summary>
            [AliasInShort("E")]
            Esmeraldas,

            /// <summary>
            /// Cañar
            /// </summary>
            [AliasInShort("F")]
            Cañar,

            /// <summary>
            /// Guayas
            /// </summary>
            [AliasInShort("G")]
            Guayas,

            /// <summary>
            /// Chimborazo
            /// </summary>
            [AliasInShort("H")]
            Chimborazo,

            /// <summary>
            /// Imbabura
            /// </summary>
            [AliasInShort("I")]
            Imbabura,

            /// <summary>
            /// Loja
            /// </summary>
            [AliasInShort("L")]
            Loja,

            /// <summary>
            /// Manabí
            /// </summary>
            [AliasInShort("M")]
            Manabí,

            /// <summary>
            /// Napo
            /// </summary>
            [AliasInShort("N")]
            Napo,

            /// <summary>
            /// El Oro
            /// </summary>
            [AliasInShort("O")]
            ElOro,

            /// <summary>
            /// Pichincha
            /// </summary>
            [AliasInShort("P")]
            Pichincha,

            /// <summary>
            /// Los Ríos
            /// </summary>
            [AliasInShort("R")]
            LosRíos,

            /// <summary>
            /// Morona-Santiago
            /// </summary>
            [AliasInShort("S")]
            MoronaSantiago,

            /// <summary>
            /// Santo Domingo de los Tsáchilas
            /// </summary>
            [AliasInShort("SD")]
            SantoDomingoDeLosTsáchilas,

            /// <summary>
            /// Santa Elena
            /// </summary>
            [AliasInShort("SE")]
            SantaElena,

            /// <summary>
            /// Tungurahua
            /// </summary>
            [AliasInShort("T")]
            Tungurahua,

            /// <summary>
            /// Sucumbíos
            /// </summary>
            [AliasInShort("U")]
            Sucumbíos,

            /// <summary>
            /// Galápagos
            /// </summary>
            [AliasInShort("W")]
            Galápagos,

            /// <summary>
            /// Cotopaxi
            /// </summary>
            [AliasInShort("X")]
            Cotopaxi,

            /// <summary>
            /// Pastaza
            /// </summary>
            [AliasInShort("Y")]
            Pastaza,

            /// <summary>
            /// Zamora-Chinchipe
            /// </summary>
            [AliasInShort("Z")]
            ZamoraChinchipe,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EcuadorRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EcuadorRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"EC-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Ecuador;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.EC;
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