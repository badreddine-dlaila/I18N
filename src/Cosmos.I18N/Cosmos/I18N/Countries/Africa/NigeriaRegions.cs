using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Nigeria Regions
    /// </summary>
    public static class NigeriaRegions
    {

        #region Gets regions

        /// <summary>
        /// Abia
        /// </summary>
        public static EnumValues Abia => EnumValues.Abia;

        /// <summary>
        /// Adamawa
        /// </summary>
        public static EnumValues Adamawa => EnumValues.Adamawa;

        /// <summary>
        /// Akwa Ibom
        /// </summary>
        public static EnumValues AkwaIbom => EnumValues.AkwaIbom;

        /// <summary>
        /// Anambra
        /// </summary>
        public static EnumValues Anambra => EnumValues.Anambra;

        /// <summary>
        /// Bauchi
        /// </summary>
        public static EnumValues Bauchi => EnumValues.Bauchi;

        /// <summary>
        /// Benue
        /// </summary>
        public static EnumValues Benue => EnumValues.Benue;

        /// <summary>
        /// Borno
        /// </summary>
        public static EnumValues Borno => EnumValues.Borno;

        /// <summary>
        /// Bayelsa
        /// </summary>
        public static EnumValues Bayelsa => EnumValues.Bayelsa;

        /// <summary>
        /// Cross River
        /// </summary>
        public static EnumValues CrossRiver => EnumValues.CrossRiver;

        /// <summary>
        /// Delta
        /// </summary>
        public static EnumValues Delta => EnumValues.Delta;

        /// <summary>
        /// Ebonyi
        /// </summary>
        public static EnumValues Ebonyi => EnumValues.Ebonyi;

        /// <summary>
        /// Edo
        /// </summary>
        public static EnumValues Edo => EnumValues.Edo;

        /// <summary>
        /// Ekiti
        /// </summary>
        public static EnumValues Ekiti => EnumValues.Ekiti;

        /// <summary>
        /// Enugu
        /// </summary>
        public static EnumValues Enugu => EnumValues.Enugu;

        /// <summary>
        /// Federal Capital Territory
        /// </summary>
        public static EnumValues FederalCapitalTerritory => EnumValues.FederalCapitalTerritory;

        /// <summary>
        /// Gombe 
        /// </summary>
        public static EnumValues Gombe => EnumValues.Gombe;

        /// <summary>
        /// Imo
        /// </summary>
        public static EnumValues Imo => EnumValues.Imo;

        /// <summary>
        /// Jigawa 
        /// </summary>
        public static EnumValues Jigawa => EnumValues.Jigawa;

        /// <summary>
        /// Kaduna
        /// </summary>
        public static EnumValues Kaduna => EnumValues.Kaduna;

        /// <summary>
        /// Kebbi
        /// </summary>
        public static EnumValues Kebbi => EnumValues.Kebbi;

        /// <summary>
        /// Kano
        /// </summary>
        public static EnumValues Kano => EnumValues.Kano;

        /// <summary>
        /// Kogi 
        /// </summary>
        public static EnumValues Kogi => EnumValues.Kogi;

        /// <summary>
        /// Katsina
        /// </summary>
        public static EnumValues Katsina => EnumValues.Katsina;

        /// <summary>
        /// Kwara 
        /// </summary>
        public static EnumValues Kwara => EnumValues.Kwara;

        /// <summary>
        /// Lagos
        /// </summary>
        public static EnumValues Lagos => EnumValues.Lagos;

        /// <summary>
        /// Nasarawa
        /// </summary>
        public static EnumValues Nasarawa => EnumValues.Nasarawa;

        /// <summary>
        /// Niger 
        /// </summary>
        public static EnumValues Niger => EnumValues.Niger;

        /// <summary>
        /// Ogun
        /// </summary>
        public static EnumValues Ogun => EnumValues.Ogun;

        /// <summary>
        /// Ondo 
        /// </summary>
        public static EnumValues Ondo => EnumValues.Ondo;

        /// <summary>
        /// Osun 
        /// </summary>
        public static EnumValues Osun => EnumValues.Osun;

        /// <summary>
        /// Oyo
        /// </summary>
        public static EnumValues Oyo => EnumValues.Oyo;

        /// <summary>
        /// Plateau 
        /// </summary>
        public static EnumValues Plateau => EnumValues.Plateau;

        /// <summary>
        /// Rivers
        /// </summary>
        public static EnumValues Rivers => EnumValues.Rivers;

        /// <summary>
        /// Sokoto
        /// </summary>
        public static EnumValues Sokoto => EnumValues.Sokoto;

        /// <summary>
        /// Taraba
        /// </summary>
        public static EnumValues Taraba => EnumValues.Taraba;

        /// <summary>
        /// Yobe
        /// </summary>
        public static EnumValues Yobe => EnumValues.Yobe;

        /// <summary>
        /// Zamfara
        /// </summary>
        public static EnumValues Zamfara => EnumValues.Zamfara;

        #endregion

        /// <summary>
        /// Enum values for Nigeria regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Abia
            /// </summary>
            [AliasInShort("AB")]
            Abia,

            /// <summary>
            /// Adamawa
            /// </summary>
            [AliasInShort("AD")]
            Adamawa,

            /// <summary>
            /// Akwa Ibom
            /// </summary>
            [AliasInShort("AK")]
            AkwaIbom,

            /// <summary>
            /// Anambra
            /// </summary>
            [AliasInShort("AN")]
            Anambra,

            /// <summary>
            /// Bauchi
            /// </summary>
            [AliasInShort("BA")]
            Bauchi,

            /// <summary>
            /// Benue
            /// </summary>
            [AliasInShort("BE")]
            Benue,

            /// <summary>
            /// Borno
            /// </summary>
            [AliasInShort("BO")]
            Borno,

            /// <summary>
            /// Bayelsa
            /// </summary>
            [AliasInShort("BY")]
            Bayelsa,

            /// <summary>
            /// Cross River
            /// </summary>
            [AliasInShort("CR")]
            CrossRiver,

            /// <summary>
            /// Delta
            /// </summary>
            [AliasInShort("DE")]
            Delta,

            /// <summary>
            /// Ebonyi
            /// </summary>
            [AliasInShort("EB")]
            Ebonyi,

            /// <summary>
            /// Edo
            /// </summary>
            [AliasInShort("ED")]
            Edo,

            /// <summary>
            /// Ekiti
            /// </summary>
            [AliasInShort("EK")]
            Ekiti,

            /// <summary>
            /// Enugu
            /// </summary>
            [AliasInShort("EN")]
            Enugu,

            /// <summary>
            /// Federal Capital Territory
            /// </summary>
            [AliasInShort("FC")]
            FederalCapitalTerritory,

            /// <summary>
            /// Gombe
            /// </summary>
            [AliasInShort("GO")]
            Gombe,

            /// <summary>
            /// Imo
            /// </summary>
            [AliasInShort("IM")]
            Imo,

            /// <summary>
            /// Jigawa
            /// </summary>
            [AliasInShort("JI")]
            Jigawa,

            /// <summary>
            /// Kaduna
            /// </summary>
            [AliasInShort("KD")]
            Kaduna,

            /// <summary>
            /// Kebbi
            /// </summary>
            [AliasInShort("KE")]
            Kebbi,

            /// <summary>
            /// Kano
            /// </summary>
            [AliasInShort("KN")]
            Kano,

            /// <summary>
            /// Kogi
            /// </summary>
            [AliasInShort("KO")]
            Kogi,

            /// <summary>
            /// Katsina
            /// </summary>
            [AliasInShort("KT")]
            Katsina,

            /// <summary>
            /// Kwara
            /// </summary>
            [AliasInShort("KW")]
            Kwara,

            /// <summary>
            /// Lagos
            /// </summary>
            [AliasInShort("LA")]
            Lagos,

            /// <summary>
            /// Nasarawa
            /// </summary>
            [AliasInShort("NA")]
            Nasarawa,

            /// <summary>
            /// Niger
            /// </summary>
            [AliasInShort("NI")]
            Niger,

            /// <summary>
            /// Ogun
            /// </summary>
            [AliasInShort("OG")]
            Ogun,

            /// <summary>
            /// Ondo
            /// </summary>
            [AliasInShort("ON")]
            Ondo,

            /// <summary>
            /// Osun
            /// </summary>
            [AliasInShort("OS")]
            Osun,

            /// <summary>
            /// Oyo
            /// </summary>
            [AliasInShort("OY")]
            Oyo,

            /// <summary>
            /// Plateau
            /// </summary>
            [AliasInShort("PL")]
            Plateau,

            /// <summary>
            /// Rivers
            /// </summary>
            [AliasInShort("RI")]
            Rivers,

            /// <summary>
            /// Sokoto
            /// </summary>
            [AliasInShort("SO")]
            Sokoto,

            /// <summary>
            /// Taraba
            /// </summary>
            [AliasInShort("TA")]
            Taraba,

            /// <summary>
            /// Yobe
            /// </summary>
            [AliasInShort("YO")]
            Yobe,

            /// <summary>
            /// Zamfara
            /// </summary>
            [AliasInShort("ZA")]
            Zamfara,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NigeriaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NigeriaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"NG-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Nigeria;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.NG;
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