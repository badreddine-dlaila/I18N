using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Chad Regions
    /// </summary>
    public static class ChadRegions
    {

        #region Gets regions

        /// <summary>
        /// Batha
        /// </summary>
        public static EnumValues Batha => EnumValues.Batha;

        /// <summary>
        /// Bahr el Gazel
        /// </summary>
        public static EnumValues BahrElGazel => EnumValues.BahrElGazel;

        /// <summary>
        /// Borkou
        /// </summary>
        public static EnumValues Borkou => EnumValues.Borkou;

        /// <summary>
        /// Chari-Baguirmi
        /// </summary>
        public static EnumValues ChariBaguirmi => EnumValues.ChariBaguirmi;

        /// <summary>
        /// Ennedi-Est
        /// </summary>
        public static EnumValues EnnediEst => EnumValues.EnnediEst;

        /// <summary>
        /// Ennedi-Ouest
        /// </summary>
        public static EnumValues EnnediOuest => EnumValues.EnnediOuest;

        /// <summary>
        /// Guéra
        /// </summary>
        public static EnumValues Guéra => EnumValues.Guéra;

        /// <summary>
        /// Hadjer-Lamis
        /// </summary>
        public static EnumValues HadjerLamis => EnumValues.HadjerLamis;

        /// <summary>
        /// Kanem
        /// </summary>
        public static EnumValues Kanem => EnumValues.Kanem;

        /// <summary>
        /// Lac
        /// </summary>
        public static EnumValues Lac => EnumValues.Lac;

        /// <summary>
        /// Logone Occidental
        /// </summary>
        public static EnumValues LogoneOccidental => EnumValues.LogoneOccidental;

        /// <summary>
        /// Logone Oriental
        /// </summary>
        public static EnumValues LogoneOriental => EnumValues.LogoneOriental;

        /// <summary>
        /// Mandoul
        /// </summary>
        public static EnumValues Mandoul => EnumValues.Mandoul;

        /// <summary>
        /// Moyen-Chari
        /// </summary>
        public static EnumValues MoyenChari => EnumValues.MoyenChari;

        /// <summary>
        /// Mayo-Kebbi Est
        /// </summary>
        public static EnumValues MayoKebbiEst => EnumValues.MayoKebbiEst;

        /// <summary>
        /// Mayo-Kebbi Ouest
        /// </summary>
        public static EnumValues MayoKebbiOuest => EnumValues.MayoKebbiOuest;

        /// <summary>
        /// N’Djamena
        /// </summary>
        public static EnumValues NDjamena => EnumValues.NDjamena;

        /// <summary>
        /// Ouaddaï
        /// </summary>
        public static EnumValues Ouaddaï => EnumValues.Ouaddaï;

        /// <summary>
        /// Salamat
        /// </summary>
        public static EnumValues Salamat => EnumValues.Salamat;

        /// <summary>
        /// Sila
        /// </summary>
        public static EnumValues Sila => EnumValues.Sila;

        /// <summary>
        /// Tandjilé
        /// </summary>
        public static EnumValues Tandjilé => EnumValues.Tandjilé;

        /// <summary>
        /// Tibesti
        /// </summary>
        public static EnumValues Tibesti => EnumValues.Tibesti;


        /// <summary>
        /// Wadi Fira
        /// </summary>
        public static EnumValues WadiFira => EnumValues.WadiFira;

        #endregion

        /// <summary>
        /// Enum values for Chad regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Batha
            /// </summary>
            [AliasInShort("BA")]
            Batha,

            /// <summary>
            /// Bahr el Gazel
            /// </summary>
            [AliasInShort("BG")]
            BahrElGazel,

            /// <summary>
            /// Borkou
            /// </summary>
            [AliasInShort("BO")]
            Borkou,

            /// <summary>
            /// Chari-Baguirmi
            /// </summary>
            [AliasInShort("CB")]
            ChariBaguirmi,

            /// <summary>
            /// Ennedi-Est
            /// </summary>
            [AliasInShort("EE")]
            EnnediEst,

            /// <summary>
            /// Ennedi-Ouest
            /// </summary>
            [AliasInShort("EO")]
            EnnediOuest,

            /// <summary>
            /// Guéra
            /// </summary>
            [AliasInShort("GR")]
            Guéra,

            /// <summary>
            ///  Hadjer-Lamis
            /// </summary>
            [AliasInShort("HL")]
            HadjerLamis,

            /// <summary>
            /// Kanem
            /// </summary>
            [AliasInShort("KA")]
            Kanem,

            /// <summary>
            /// Lac
            /// </summary>
            [AliasInShort("LC")]
            Lac,

            /// <summary>
            /// Logone Occidental
            /// </summary>
            [AliasInShort("LO")]
            LogoneOccidental,

            /// <summary>
            /// Logone Oriental
            /// </summary>
            [AliasInShort("LR")]
            LogoneOriental,

            /// <summary>
            /// Mandoul
            /// </summary>
            [AliasInShort("MA")]
            Mandoul,

            /// <summary>
            /// Moyen-Chari
            /// </summary>
            [AliasInShort("MC")]
            MoyenChari,

            /// <summary>
            /// Mayo-Kebbi Est
            /// </summary>
            [AliasInShort("ME")]
            MayoKebbiEst,

            /// <summary>
            /// Mayo-Kebbi Ouest
            /// </summary>
            [AliasInShort("MO")]
            MayoKebbiOuest,

            /// <summary>
            /// N’Djamena
            /// </summary>
            [AliasInShort("ND")]
            NDjamena,

            /// <summary>
            /// Ouaddaï
            /// </summary>
            [AliasInShort("OD")]
            Ouaddaï,

            /// <summary>
            /// Salamat
            /// </summary>
            [AliasInShort("SA")]
            Salamat,

            /// <summary>
            /// Sila
            /// </summary>
            [AliasInShort("SI")]
            Sila,

            /// <summary>
            /// Tandjilé
            /// </summary>
            [AliasInShort("TA")]
            Tandjilé,

            /// <summary>
            /// Tibesti
            /// </summary>
            [AliasInShort("TI")]
            Tibesti,

            /// <summary>
            /// Wadi Fira
            /// </summary>
            [AliasInShort("WF")]
            WadiFira,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ChadRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ChadRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TD-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Chad;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TD;
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