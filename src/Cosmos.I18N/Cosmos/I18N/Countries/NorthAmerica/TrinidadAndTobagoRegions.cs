using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// TrinidadAndTobago Regions
    /// </summary>
    public static class TrinidadAndTobagoRegions
    {

        #region Gets regions

        /// <summary>
        /// Arima
        /// </summary>
        public static EnumValues Arima => EnumValues.Arima;

        /// <summary>
        /// Chaguanas
        /// </summary>
        public static EnumValues Chaguanas => EnumValues.Chaguanas;

        /// <summary>
        /// Couva-Tabaquite-Talparo
        /// </summary>
        public static EnumValues CouvaTabaquiteTalparo => EnumValues.CouvaTabaquiteTalparo;

        /// <summary>
        /// Diego Martin
        /// </summary>
        public static EnumValues DiegoMartin => EnumValues.DiegoMartin;

        /// <summary>
        /// Mayaro-Rio Claro
        /// </summary>
        public static EnumValues MayaroRioClaro => EnumValues.MayaroRioClaro;

        /// <summary>
        /// Penal-Debe
        /// </summary>
        public static EnumValues PenalDebe => EnumValues.PenalDebe;

        /// <summary>
        /// Port of Spain
        /// </summary>
        public static EnumValues PortOfSpain => EnumValues.PortOfSpain;

        /// <summary>
        /// Princes Town
        /// </summary>
        public static EnumValues PrincesTown => EnumValues.PrincesTown;

        /// <summary>
        /// Point Fortin
        /// </summary>
        public static EnumValues PointFortin => EnumValues.PointFortin;

        /// <summary>
        /// San Fernando
        /// </summary>
        public static EnumValues SanFernando => EnumValues.SanFernando;

        /// <summary>
        /// Sangre Grande
        /// </summary>
        public static EnumValues SangreGrande => EnumValues.SangreGrande;

        /// <summary>
        /// Siparia
        /// </summary>
        public static EnumValues Siparia => EnumValues.Siparia;

        /// <summary>
        /// San Juan-Laventille
        /// </summary>
        public static EnumValues SanJuanLaventille => EnumValues.SanJuanLaventille;

        /// <summary>
        /// Tobago
        /// </summary>
        public static EnumValues Tobago => EnumValues.Tobago;

        /// <summary>
        /// Tunapuna-Piarco
        /// </summary>
        public static EnumValues TunapunaPiarco => EnumValues.TunapunaPiarco;

        #endregion

        /// <summary>
        /// Enum values for TrinidadAndTobago regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Arima
            /// </summary>
            [AliasInShort("ARI")]
            Arima,

            /// <summary>
            /// Chaguanas
            /// </summary>
            [AliasInShort("CHA")]
            Chaguanas,

            /// <summary>
            /// Couva-Tabaquite-Talparo
            /// </summary>
            [AliasInShort("CTT")]
            CouvaTabaquiteTalparo,

            /// <summary>
            /// Diego Martin
            /// </summary>
            [AliasInShort("DMN")]
            DiegoMartin,

            /// <summary>
            /// Mayaro-Rio Claro
            /// </summary>
            [AliasInShort("MRC")]
            MayaroRioClaro,

            /// <summary>
            /// Penal-Debe
            /// </summary>
            [AliasInShort("PED")]
            PenalDebe,

            /// <summary>
            /// Port of Spain
            /// </summary>
            [AliasInShort("POS")]
            PortOfSpain,

            /// <summary>
            /// Princes Town
            /// </summary>
            [AliasInShort("PRT")]
            PrincesTown,

            /// <summary>
            /// Point Fortin
            /// </summary>
            [AliasInShort("PTF")]
            PointFortin,

            /// <summary>
            /// San Fernando
            /// </summary>
            [AliasInShort("SFO")]
            SanFernando,

            /// <summary>
            /// Sangre Grande
            /// </summary>
            [AliasInShort("SGE")]
            SangreGrande,

            /// <summary>
            /// Siparia
            /// </summary>
            [AliasInShort("SIP")]
            Siparia,

            /// <summary>
            /// San Juan-Laventille
            /// </summary>
            [AliasInShort("SJL")]
            SanJuanLaventille,

            /// <summary>
            /// Tobago
            /// </summary>
            [AliasInShort("TOB")]
            Tobago,

            /// <summary>
            /// Tunapuna-Piarco
            /// </summary>
            [AliasInShort("TUP")]
            TunapunaPiarco,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TrinidadAndTobagoRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TrinidadAndTobagoRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TT-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.TrinidadAndTobago;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TT;
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