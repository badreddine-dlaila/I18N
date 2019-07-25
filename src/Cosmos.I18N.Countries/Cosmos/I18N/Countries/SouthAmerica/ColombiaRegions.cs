using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Colombia regions
    /// </summary>
    public static class ColombiaRegions
    {

        #region Gets regions

        /// <summary>
        /// Amazonas
        /// </summary>
        public static EnumValues Amazonas => EnumValues.Amazonas;

        /// <summary>
        /// Antioquia
        /// </summary>
        public static EnumValues Antioquia => EnumValues.Antioquia;

        /// <summary>
        /// Arauca
        /// </summary>
        public static EnumValues Arauca => EnumValues.Arauca;

        /// <summary>
        /// Atlántico
        /// </summary>
        public static EnumValues Atlántico => EnumValues.Atlántico;

        /// <summary>
        /// Bolívar
        /// </summary>
        public static EnumValues Bolívar => EnumValues.Bolívar;

        /// <summary>
        /// Boyacá
        /// </summary>
        public static EnumValues Boyacá => EnumValues.Boyacá;

        /// <summary>
        /// Caldas
        /// </summary>
        public static EnumValues Caldas => EnumValues.Caldas;

        /// <summary>
        /// Caquetá
        /// </summary>
        public static EnumValues Caquetá => EnumValues.Caquetá;

        /// <summary>
        /// Casanare
        /// </summary>
        public static EnumValues Casanare => EnumValues.Casanare;

        /// <summary>
        /// Cauca
        /// </summary>
        public static EnumValues Cauca => EnumValues.Cauca;

        /// <summary>
        /// Cesar
        /// </summary>
        public static EnumValues Cesar => EnumValues.Cesar;

        /// <summary>
        /// Chocó
        /// </summary>
        public static EnumValues Chocó => EnumValues.Chocó;

        /// <summary>
        /// Córdoba, COR
        /// </summary>
        public static EnumValues Córdoba => EnumValues.Córdoba;

        /// <summary>
        /// Cundinamarca
        /// </summary>
        public static EnumValues Cundinamarca => EnumValues.Cundinamarca;

        /// <summary>
        /// Capital District 
        /// </summary>
        public static EnumValues CapitalDistrict => EnumValues.CapitalDistrict;

        /// <summary>
        /// Guainía 
        /// </summary>
        public static EnumValues Guainía => EnumValues.Guainía;

        /// <summary>
        /// Guaviare
        /// </summary>
        public static EnumValues Guaviare => EnumValues.Guaviare;

        /// <summary>
        /// Huila 
        /// </summary>
        public static EnumValues Huila => EnumValues.Huila;

        /// <summary>
        /// La Guajira 
        /// </summary>
        public static EnumValues LaGuajira => EnumValues.LaGuajira;

        /// <summary>
        /// Magdalena 
        /// </summary>
        public static EnumValues Magdalena => EnumValues.Magdalena;

        /// <summary>
        /// Meta 
        /// </summary>
        public static EnumValues Meta => EnumValues.Meta;

        /// <summary>
        /// Nariño 
        /// </summary>
        public static EnumValues Nariño => EnumValues.Nariño;

        /// <summary>
        /// Norte de Santander 
        /// </summary>
        public static EnumValues NorteDeSantander => EnumValues.NorteDeSantander;

        /// <summary>
        /// Putumayo 
        /// </summary>
        public static EnumValues Putumayo => EnumValues.Putumayo;

        /// <summary>
        /// Quindío
        /// </summary>
        public static EnumValues Quindío => EnumValues.Quindío;

        /// <summary>
        /// Risaralda 
        /// </summary>
        public static EnumValues Risaralda => EnumValues.Risaralda;

        /// <summary>
        /// Santander 
        /// </summary>
        public static EnumValues Santander => EnumValues.Santander;

        /// <summary>
        /// San Andrés and Providencia
        /// </summary>
        public static EnumValues SanAndrésAndProvidencia => EnumValues.SanAndrésAndProvidencia;

        /// <summary>
        /// Sucre 
        /// </summary>
        public static EnumValues Sucre => EnumValues.Sucre;

        /// <summary>
        /// Tolima 
        /// </summary>
        public static EnumValues Tolima => EnumValues.Tolima;

        /// <summary>
        /// Valle del Cauca 
        /// </summary>
        public static EnumValues ValleDelCauca => EnumValues.ValleDelCauca;

        /// <summary>
        /// Vaupés 
        /// </summary>
        public static EnumValues Vaupés => EnumValues.Vaupés;

        /// <summary>
        /// Vichada 
        /// </summary>
        public static EnumValues Vichada => EnumValues.Vichada;

        #endregion

        /// <summary>
        /// Enum values for Colombia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Amazonas
            /// </summary>
            [AliasInShort("AMA")]
            Amazonas,

            /// <summary>
            /// Antioquia
            /// </summary>
            [AliasInShort("ANT")]
            Antioquia,

            /// <summary>
            /// Arauca
            /// </summary>
            [AliasInShort("ARA")]
            Arauca,

            /// <summary>
            /// Atlántico
            /// </summary>
            [AliasInShort("ATL")]
            Atlántico,

            /// <summary>
            /// Bolívar
            /// </summary>
            [AliasInShort("BOL")]
            Bolívar,

            /// <summary>
            /// Boyacá
            /// </summary>
            [AliasInShort("BOY")]
            Boyacá,

            /// <summary>
            /// Caldas
            /// </summary>
            [AliasInShort("CAL")]
            Caldas,

            /// <summary>
            /// Caquetá
            /// </summary>
            [AliasInShort("CAQ")]
            Caquetá,

            /// <summary>
            /// Casanare
            /// </summary>
            [AliasInShort("CAS")]
            Casanare,

            /// <summary>
            /// Cauca
            /// </summary>
            [AliasInShort("CAU")]
            Cauca,

            /// <summary>
            /// Cesar
            /// </summary>
            [AliasInShort("CES")]
            Cesar,

            /// <summary>
            /// Chocó
            /// </summary>
            [AliasInShort("CHO")]
            Chocó,

            /// <summary>
            /// Córdoba, COR
            /// </summary>
            [AliasInShort("COR")]
            Córdoba,

            /// <summary>
            /// Cundinamarca, CUN
            /// </summary>
            [AliasInShort("CUN")]
            Cundinamarca,

            /// <summary>
            /// Capital District, DC
            /// </summary>
            [AliasInShort("DC")]
            CapitalDistrict,

            /// <summary>
            /// Guainía, GUA
            /// </summary>
            [AliasInShort("GUA")]
            Guainía,

            /// <summary>
            /// Guaviare, GUV
            /// </summary>
            [AliasInShort("GUV")]
            Guaviare,

            /// <summary>
            /// Huila, HUI
            /// </summary>
            [AliasInShort("HUI")]
            Huila,

            /// <summary>
            /// La Guajira, LAG
            /// </summary>
            [AliasInShort("LAG")]
            LaGuajira,

            /// <summary>
            /// Magdalena, MAG
            /// </summary>
            [AliasInShort("MAG")]
            Magdalena,

            /// <summary>
            /// Meta, MET
            /// </summary>
            [AliasInShort("MET")]
            Meta,

            /// <summary>
            /// Nariño, NAR
            /// </summary>
            [AliasInShort("NAR")]
            Nariño,

            /// <summary>
            /// Norte de Santander, NSA
            /// </summary>
            [AliasInShort("NSA")]
            NorteDeSantander,

            /// <summary>
            /// Putumayo, PUT
            /// </summary>
            [AliasInShort("PUT")]
            Putumayo,

            /// <summary>
            /// Quindío, QUI
            /// </summary>
            [AliasInShort("QUI")]
            Quindío,

            /// <summary>
            /// Risaralda, RIS
            /// </summary>
            [AliasInShort("RIS")]
            Risaralda,

            /// <summary>
            /// Santander, SAN
            /// </summary>
            [AliasInShort("SAN")]
            Santander,

            /// <summary>
            /// San Andrés and Providencia, SAP
            /// </summary>
            [AliasInShort("SAP")]
            SanAndrésAndProvidencia,

            /// <summary>
            /// Sucre, SUC
            /// </summary>
            [AliasInShort("SUC")]
            Sucre,

            /// <summary>
            /// Tolima, TOL
            /// </summary>
            [AliasInShort("TOL")]
            Tolima,

            /// <summary>
            /// Valle del Cauca, VAC
            /// </summary>
            [AliasInShort("VAC")]
            ValleDelCauca,

            /// <summary>
            /// Vaupés, VAU
            /// </summary>
            [AliasInShort("VAU")]
            Vaupés,

            /// <summary>
            /// Vichada, VID
            /// </summary>
            [AliasInShort("VID")]
            Vichada,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ColombiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ColombiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CO-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Colombia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CO;
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