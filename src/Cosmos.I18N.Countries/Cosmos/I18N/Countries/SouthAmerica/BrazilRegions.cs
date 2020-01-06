using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// Brazil Regions
    /// </summary>
    public static class BrazilRegions {

        #region Gets regions

        /// <summary>
        /// Acre
        /// </summary>
        public static EnumValues Acre => EnumValues.Acre;

        /// <summary>
        /// Alagoas
        /// </summary>
        public static EnumValues Alagoas => EnumValues.Alagoas;

        /// <summary>
        /// Amazonas
        /// </summary>
        public static EnumValues Amazonas => EnumValues.Amazonas;

        /// <summary>
        /// Amapá
        /// </summary>
        public static EnumValues Amapá => EnumValues.Amapá;

        /// <summary>
        /// Bahia
        /// </summary>
        public static EnumValues Bahia => EnumValues.Bahia;

        /// <summary>
        /// Ceará
        /// </summary>
        public static EnumValues Ceará => EnumValues.Ceará;

        /// <summary>
        /// Distrito Federal
        /// </summary>
        public static EnumValues DistritoFederal => EnumValues.DistritoFederal;

        /// <summary>
        /// Espírito Santo
        /// </summary>
        public static EnumValues EspíritoSanto => EnumValues.EspíritoSanto;

        /// <summary>
        /// Goiás
        /// </summary>
        public static EnumValues Goiás => EnumValues.Goiás;

        /// <summary>
        /// Maranhão
        /// </summary>
        public static EnumValues Maranhão => EnumValues.Maranhão;

        /// <summary>
        /// Minas Gerais
        /// </summary>
        public static EnumValues MinasGerais => EnumValues.MinasGerais;

        /// <summary>
        /// Mato Grosso do Sul
        /// </summary>
        public static EnumValues MatoGrossoDoSul => EnumValues.MatoGrossoDoSul;

        /// <summary>
        /// Mato Grosso
        /// </summary>
        public static EnumValues MatoGrosso => EnumValues.MatoGrosso;

        /// <summary>
        /// Pará
        /// </summary>
        public static EnumValues Pará => EnumValues.Pará;

        /// <summary>
        /// Paraíba
        /// </summary>
        public static EnumValues Paraíba => EnumValues.Paraíba;

        /// <summary>
        /// Pernambuco
        /// </summary>
        public static EnumValues Pernambuco => EnumValues.Pernambuco;

        /// <summary>
        /// Piauí
        /// </summary>
        public static EnumValues Piauí => EnumValues.Piauí;

        /// <summary>
        /// Paraná
        /// </summary>
        public static EnumValues Paraná => EnumValues.Paraná;

        /// <summary>
        /// Rio de Janeiro
        /// </summary>
        public static EnumValues RioDeJaneiro => EnumValues.RioDeJaneiro;

        /// <summary>
        /// Rio Grande do Norte
        /// </summary>
        public static EnumValues RioGrandeDoNorte => EnumValues.RioGrandeDoNorte;

        /// <summary>
        /// Rondônia
        /// </summary>
        public static EnumValues Rondônia => EnumValues.Rondônia;

        /// <summary>
        /// Roraima
        /// </summary>
        public static EnumValues Roraima => EnumValues.Roraima;

        /// <summary>
        /// Rio Grande do Sul
        /// </summary>
        public static EnumValues RioGrandeDoSul => EnumValues.RioGrandeDoSul;

        /// <summary>
        /// Santa Catarina
        /// </summary>
        public static EnumValues SantaCatarina => EnumValues.SantaCatarina;

        /// <summary>
        /// Sergipe
        /// </summary>
        public static EnumValues Sergipe => EnumValues.Sergipe;

        /// <summary>
        /// São Paulo
        /// </summary>
        public static EnumValues SãoPaulo => EnumValues.SãoPaulo;

        /// <summary>
        /// Tocantins
        /// </summary>
        public static EnumValues Tocantins => EnumValues.Tocantins;

        #endregion

        /// <summary>
        /// Enum values for Brazil regions
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Acre
            /// </summary>
            [AliasInShort("AC")]
            Acre,

            /// <summary>
            /// Alagoas
            /// </summary>
            [AliasInShort("AL")]
            Alagoas,

            /// <summary>
            /// Amazonas
            /// </summary>
            [AliasInShort("AM")]
            Amazonas,

            /// <summary>
            /// Amapá
            /// </summary>
            [AliasInShort("AP")]
            Amapá,

            /// <summary>
            /// Bahia
            /// </summary>
            [AliasInShort("BA")]
            Bahia,

            /// <summary>
            /// Ceará
            /// </summary>
            [AliasInShort("CE")]
            Ceará,

            /// <summary>
            /// Distrito Federal
            /// </summary>
            [AliasInShort("DF")]
            DistritoFederal,

            /// <summary>
            /// Espírito Santo
            /// </summary>
            [AliasInShort("ES")]
            EspíritoSanto,

            /// <summary>
            /// Goiás
            /// </summary>
            [AliasInShort("GO")]
            Goiás,

            /// <summary>
            /// Maranhão
            /// </summary>
            [AliasInShort("MA")]
            Maranhão,

            /// <summary>
            /// Minas Gerais
            /// </summary>
            [AliasInShort("MG")]
            MinasGerais,

            /// <summary>
            /// Mato Grosso do Sul
            /// </summary>
            [AliasInShort("MS")]
            MatoGrossoDoSul,

            /// <summary>
            /// Mato Grosso
            /// </summary>
            [AliasInShort("MT")]
            MatoGrosso,

            /// <summary>
            /// Pará
            /// </summary>
            [AliasInShort("PA")]
            Pará,

            /// <summary>
            /// Paraíba
            /// </summary>
            [AliasInShort("PB")]
            Paraíba,

            /// <summary>
            /// Pernambuco
            /// </summary>
            [AliasInShort("PE")]
            Pernambuco,

            /// <summary>
            /// Piauí
            /// </summary>
            [AliasInShort("PI")]
            Piauí,

            /// <summary>
            /// Paraná
            /// </summary>
            [AliasInShort("PR")]
            Paraná,

            /// <summary>
            /// Rio de Janeiro
            /// </summary>
            [AliasInShort("RJ")]
            RioDeJaneiro,

            /// <summary>
            /// Rio Grande do Norte
            /// </summary>
            [AliasInShort("RN")]
            RioGrandeDoNorte,

            /// <summary>
            /// Rondônia
            /// </summary>
            [AliasInShort("RO")]
            Rondônia,

            /// <summary>
            /// Roraima
            /// </summary>
            [AliasInShort("RR")]
            Roraima,

            /// <summary>
            /// Rio Grande do Sul
            /// </summary>
            [AliasInShort("RS")]
            RioGrandeDoSul,

            /// <summary>
            /// Santa Catarina
            /// </summary>
            [AliasInShort("SC")]
            SantaCatarina,

            /// <summary>
            /// Sergipe
            /// </summary>
            [AliasInShort("SE")]
            Sergipe,

            /// <summary>
            /// São Paulo
            /// </summary>
            [AliasInShort("SP")]
            SãoPaulo,

            /// <summary>
            /// Tocantins
            /// </summary>
            [AliasInShort("TO")]
            Tocantins,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BrazilRegions.EnumValues"/> to region code likes 'ACT', 'NT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BrazilRegions.EnumValues"/> to full region code likes 'AU-ACT', 'AU-NT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BR-{values.ToRegionCode()}";
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