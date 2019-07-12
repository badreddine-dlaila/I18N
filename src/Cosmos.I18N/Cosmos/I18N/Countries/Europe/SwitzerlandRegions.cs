using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Switzerland regions
    /// </summary>
    public static class SwitzerlandRegions
    {
           #region Gets regions

        /// <summary>
        /// Canton of Zürich
        /// </summary>
        public static EnumValues CantonOfZürich => EnumValues.CantonOfZürich;

        /// <summary>
        /// Canton of Bern
        /// </summary>
        public static EnumValues CantonOfBern => EnumValues.CantonOfBern;

        /// <summary>
        /// Canton of Lucerne
        /// </summary>
        public static EnumValues CantonOfLucerne => EnumValues.CantonOfLucerne;

        /// <summary>
        /// Canton of Uri
        /// </summary>
        public static EnumValues CantonOfUri => EnumValues.CantonOfUri;

        /// <summary>
        /// Canton of Schwyz
        /// </summary>
        public static EnumValues CantonOfSchwyz => EnumValues.CantonOfSchwyz;

        /// <summary>
        /// Canton of Obwalden
        /// </summary>
        public static EnumValues CantonOfObwalden => EnumValues.CantonOfObwalden;

        /// <summary>
        /// Canton of Nidwalden
        /// </summary>
        public static EnumValues CantonOfNidwalden => EnumValues.CantonOfNidwalden;

        /// <summary>
        /// Canton of Glarus, GL
        /// </summary>
        public static EnumValues CantonOfGlarus => EnumValues.CantonOfGlarus;

        /// <summary>
        /// Canton of Zug => EnumValues. ZG
        /// </summary>
        public static EnumValues CantonOfZug => EnumValues.CantonOfZug;

        /// <summary>
        /// Canton of Fribourg => EnumValues. FR
        /// </summary>
        public static EnumValues CantonOfFribourg => EnumValues.CantonOfFribourg;

        /// <summary>
        /// Canton of Solothurn => EnumValues. SO
        /// </summary>
        public static EnumValues CantonOfSolothurn => EnumValues.CantonOfSolothurn;

        /// <summary>
        /// Canton of Basel-City => EnumValues. BS
        /// </summary>
        public static EnumValues CantonOfBaselCity => EnumValues.CantonOfBaselCity;

        /// <summary>
        /// Canton of Basel-Country => EnumValues. BL
        /// </summary>
        public static EnumValues CantonOfBaselCountry => EnumValues.CantonOfBaselCountry;

        /// <summary>
        /// Canton of Schaffhausen => EnumValues. SH
        /// </summary>
        public static EnumValues CantonOfSchaffhausen => EnumValues.CantonOfSchaffhausen;

        /// <summary>
        /// Canton of Appenzell Outer Rhodes => EnumValues. AR
        /// </summary>
        public static EnumValues CantonOfAppenzellOuterRhodes => EnumValues.CantonOfAppenzellOuterRhodes;

        /// <summary>
        /// Canton of Appenzell Inner-Rhodes => EnumValues. AI
        /// </summary>
        public static EnumValues CantonOfAppenzellInnerRhodes => EnumValues.CantonOfAppenzellInnerRhodes;

        /// <summary>
        /// Canton of St. Gallen => EnumValues. SG
        /// </summary>
        public static EnumValues CantonOfStGallen => EnumValues.CantonOfStGallen;

        /// <summary>
        /// Canton of Grisons => EnumValues. GR
        /// </summary>
        public static EnumValues CantonOfGrisons => EnumValues.CantonOfGrisons;

        /// <summary>
        /// Canton of Aargau => EnumValues. AG
        /// </summary>
        public static EnumValues CantonOfAargau => EnumValues.CantonOfAargau;

        /// <summary>
        /// Canton of Thurgau => EnumValues. TG
        /// </summary>
        public static EnumValues CantonOfThurgau => EnumValues.CantonOfThurgau;

        /// <summary>
        /// Canton of Ticino => EnumValues. TI
        /// </summary>
        public static EnumValues CantonOfTicino => EnumValues.CantonOfTicino;

        /// <summary>
        /// Canton of Vaud => EnumValues. VD
        /// </summary>
        public static EnumValues CantonOfVaud => EnumValues.CantonOfVaud;

        /// <summary>
        /// Canton of Valais => EnumValues. VS
        /// </summary>
        public static EnumValues CantonOfValais => EnumValues.CantonOfValais;

        /// <summary>
        /// Canton of Neuchâtel => EnumValues. NE
        /// </summary>
        public static EnumValues CantonOfNeuchâtel => EnumValues.CantonOfNeuchâtel;

        /// <summary>
        /// Canton of Geneva => EnumValues. GE
        /// </summary>
        public static EnumValues CantonOfGeneva => EnumValues.CantonOfGeneva;

        /// <summary>
        /// Canton of Jura => EnumValues. JU
        /// </summary>
        public static EnumValues CantonOfJura => EnumValues.CantonOfJura;
        
        #endregion

        /// <summary>
        /// Enum values for Switzerland regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Canton of Zürich
            /// </summary>
            [AliasInShort("ZH")]
            CantonOfZürich,
            
            /// <summary>
            /// Canton of Bern
            /// </summary>
            [AliasInShort("BE")]
            CantonOfBern,
            
            /// <summary>
            /// Massana
            /// </summary>
            [AliasInShort("LO")]
            CantonOfLucerne,
            
            /// <summary>
            /// Canton of Uri
            /// </summary>
            [AliasInShort("UR")]
            CantonOfUri,
            
            /// <summary>
            /// Canton of Schwyz
            /// </summary>
            [AliasInShort("SZ")]
            CantonOfSchwyz,
            
            /// <summary>
            /// Canton of Obwalden
            /// </summary>
            [AliasInShort("OW")]
            CantonOfObwalden,
            
            /// <summary>
            /// Canton of Nidwalden
            /// </summary>
            [AliasInShort("NW")]
            CantonOfNidwalden,
            
            /// <summary>
            /// Canton of Glarus, GL
            /// </summary>
            [AliasInShort("GL")]
            CantonOfGlarus,
            
            /// <summary>
            /// Canton of Zug, ZG
            /// </summary>
            [AliasInShort("ZG")]
            CantonOfZug,
            
            /// <summary>
            /// Canton of Fribourg, FR
            /// </summary>
            [AliasInShort("FR")]
            CantonOfFribourg,
            
            /// <summary>
            /// Canton of Solothurn, SO
            /// </summary>
            [AliasInShort("SO")]
            CantonOfSolothurn,
            
            /// <summary>
            /// Canton of Basel-City, BS
            /// </summary>
            [AliasInShort("BS")]
            CantonOfBaselCity,
            
            /// <summary>
            /// Canton of Basel-Country, BL
            /// </summary>
            [AliasInShort("BL")]
            CantonOfBaselCountry,
            
            /// <summary>
            /// Canton of Schaffhausen, SH
            /// </summary>
            [AliasInShort("SH")]
            CantonOfSchaffhausen,
            
            /// <summary>
            /// Canton of Appenzell Outer Rhodes, AR
            /// </summary>
            [AliasInShort("AR")]
            CantonOfAppenzellOuterRhodes,
            
            /// <summary>
            /// Canton of Appenzell Inner-Rhodes, AI
            /// </summary>
            [AliasInShort("AI")]
            CantonOfAppenzellInnerRhodes,
            
            /// <summary>
            /// Canton of St. Gallen, SG
            /// </summary>
            [AliasInShort("SG")]
            CantonOfStGallen,
            
            /// <summary>
            /// Canton of Grisons, GR
            /// </summary>
            [AliasInShort("GR")]
            CantonOfGrisons,
            
            /// <summary>
            /// Canton of Aargau, AG
            /// </summary>
            [AliasInShort("AG")]
            CantonOfAargau,
            
            /// <summary>
            /// Canton of Thurgau, TG
            /// </summary>
            [AliasInShort("TG")]
            CantonOfThurgau,
            
            /// <summary>
            /// Canton of Ticino, TI
            /// </summary>
            [AliasInShort("TI")]
            CantonOfTicino,
            
            /// <summary>
            /// Canton of Vaud, VD
            /// </summary>
            [AliasInShort("VD")]
            CantonOfVaud,
            
            /// <summary>
            /// Canton of Valais, VS
            /// </summary>
            [AliasInShort("VS")]
            CantonOfValais,
            
            /// <summary>
            /// Canton of Neuchâtel, NE
            /// </summary>
            [AliasInShort("NE")]
            CantonOfNeuchâtel,
            
            /// <summary>
            /// Canton of Geneva, GE
            /// </summary>
            [AliasInShort("GE")]
            CantonOfGeneva,
            
            /// <summary>
            /// Canton of Jura, JU
            /// </summary>
            [AliasInShort("JU")]
            CantonOfJura,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SwitzerlandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SwitzerlandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CH-{values.ToRegionCode()}";
        }
        
        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Switzerland;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CH;
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