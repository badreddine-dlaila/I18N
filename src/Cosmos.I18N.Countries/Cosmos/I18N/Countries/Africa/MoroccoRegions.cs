using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Morocco Regions
    /// </summary>
    public static class MoroccoRegions
    {

        #region Gets regions

        /// <summary>
        /// Doukkala-Abda
        /// </summary>
        public static EnumValues DoukkalaAbda => EnumValues.DoukkalaAbda;

        /// <summary>
        /// Marrakesh-Tensift-El Haouz
        /// </summary>
        public static EnumValues MarrakeshTensiftElHaouz => EnumValues.MarrakeshTensiftElHaouz;

        /// <summary>
        /// Tadla-Azilal
        /// </summary>
        public static EnumValues TadlaAzilal => EnumValues.TadlaAzilal;

        /// <summary>
        /// Souss-Massa-Drâa
        /// </summary>
        public static EnumValues SoussMassaDrâa => EnumValues.SoussMassaDrâa;

        /// <summary>
        /// Guelmim-Es Semara
        /// </summary>
        public static EnumValues GuelmimEsSemara => EnumValues.GuelmimEsSemara;

        /// <summary>
        /// Laâyoune-Boujdour-Sakia El Hamra
        /// </summary>
        public static EnumValues LaâyouneBoujdourSakiaElHamra => EnumValues.LaâyouneBoujdourSakiaElHamra;

        /// <summary>
        /// Oued Ed-Dahab-Lagouira
        /// </summary>
        public static EnumValues OuedEdDahabLagouira => EnumValues.OuedEdDahabLagouira;

        /// <summary>
        /// Tangier-Tétouan  
        /// </summary>
        public static EnumValues TangierTétouan => EnumValues.TangierTétouan;

        /// <summary>
        /// Gharb-Chrarda-Béni Hssen
        /// </summary>
        public static EnumValues GharbChrardaBéniHssen => EnumValues.GharbChrardaBéniHssen;

        /// <summary>
        /// Taza-Al Hoceima-Taounate
        /// </summary>
        public static EnumValues TazaAlHoceimaTaounate => EnumValues.TazaAlHoceimaTaounate;

        /// <summary>
        /// Oriental
        /// </summary>
        public static EnumValues Oriental => EnumValues.Oriental;

        /// <summary>
        /// Fès-Boulemane
        /// </summary>
        public static EnumValues FèsBoulemane => EnumValues.FèsBoulemane;

        /// <summary>
        /// Meknès-Tafilalet
        /// </summary>
        public static EnumValues MeknèsTafilalet => EnumValues.MeknèsTafilalet;

        /// <summary>
        /// Rabat-Salé-Zemmour-Zaer
        /// </summary>
        public static EnumValues RabatSaléZemmourZaer => EnumValues.RabatSaléZemmourZaer;

        /// <summary>
        /// Grand Casablanca
        /// </summary>
        public static EnumValues GrandCasablanca => EnumValues.GrandCasablanca;

        /// <summary>
        /// Chaouia-Ouardigha
        /// </summary>
        public static EnumValues ChaouiaOuardigha => EnumValues.ChaouiaOuardigha;

        #endregion

        /// <summary>
        /// Enum values for Morocco regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Doukkala-Abda
            /// </summary>
            [AliasInShort("10")]
            DoukkalaAbda,

            /// <summary>
            /// Marrakesh-Tensift-El Haouz
            /// </summary>
            [AliasInShort("11")]
            MarrakeshTensiftElHaouz,

            /// <summary>
            /// Tadla-Azilal
            /// </summary>
            [AliasInShort("12")]
            TadlaAzilal,

            /// <summary>
            /// Souss-Massa-Drâa
            /// </summary>
            [AliasInShort("13")]
            SoussMassaDrâa,

            /// <summary>
            /// Guelmim-Es Semara
            /// </summary>
            [AliasInShort("14")]
            GuelmimEsSemara,

            /// <summary>
            /// Laâyoune-Boujdour-Sakia El Hamra
            /// </summary>
            [AliasInShort("15")]
            LaâyouneBoujdourSakiaElHamra,

            /// <summary>
            /// Oued Ed-Dahab-Lagouira
            /// </summary>
            [AliasInShort("16")]
            OuedEdDahabLagouira,

            /// <summary>
            /// Tangier-Tétouan
            /// </summary>
            [AliasInShort("01")]
            TangierTétouan,

            /// <summary>
            /// Gharb-Chrarda-Béni Hssen
            /// </summary>
            [AliasInShort("02")]
            GharbChrardaBéniHssen,

            /// <summary>
            /// Taza-Al Hoceima-Taounate
            /// </summary>
            [AliasInShort("03")]
            TazaAlHoceimaTaounate,

            /// <summary>
            /// Oriental
            /// </summary>
            [AliasInShort("04")]
            Oriental,

            /// <summary>
            /// Fès-Boulemane
            /// </summary>
            [AliasInShort("05")]
            FèsBoulemane,

            /// <summary>
            /// Meknès-Tafilalet
            /// </summary>
            [AliasInShort("06")]
            MeknèsTafilalet,

            /// <summary>
            /// Rabat-Salé-Zemmour-Zaer
            /// </summary>
            [AliasInShort("07")]
            RabatSaléZemmourZaer,

            /// <summary>
            /// Grand Casablanca
            /// </summary>
            [AliasInShort("08")]
            GrandCasablanca,

            /// <summary>
            /// Chaouia-Ouardigha
            /// </summary>
            [AliasInShort("09")]
            ChaouiaOuardigha,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MoroccoRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MoroccoRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"MA-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Morocco;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.MA;
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