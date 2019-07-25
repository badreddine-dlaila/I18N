using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Ukraine Regions
    /// </summary>
    public static class UkraineRegions
    {

        #region Gets regions

        /// <summary>
        /// Vinnychchyna
        /// </summary>
        public static EnumValues Vinnychchyna => EnumValues.Vinnychchyna;

        /// <summary>
        /// Volyn
        /// </summary>
        public static EnumValues Volyn => EnumValues.Volyn;

        /// <summary>
        /// Luhanshchyna
        /// </summary>
        public static EnumValues Luhanshchyna => EnumValues.Luhanshchyna;

        /// <summary>
        /// Dnipropetrovshchyna
        /// </summary>
        public static EnumValues Dnipropetrovshchyna => EnumValues.Dnipropetrovshchyna;

        /// <summary>
        /// Baghdad
        /// </summary>
        public static EnumValues Donechchyna => EnumValues.Donechchyna;

        /// <summary>
        /// Zhytomyrshchyna
        /// </summary>
        public static EnumValues Zhytomyrshchyna => EnumValues.Zhytomyrshchyna;

        /// <summary>
        /// Zakarpattia
        /// </summary>
        public static EnumValues Zakarpattia => EnumValues.Zakarpattia;

        /// <summary>
        /// Zaporizhzhya
        /// </summary>
        public static EnumValues Zaporizhzhya => EnumValues.Zaporizhzhya;

        /// <summary>
        /// Prykarpattia
        /// </summary>
        public static EnumValues Prykarpattia => EnumValues.Prykarpattia;

        /// <summary>
        /// Kiev
        /// </summary>
        public static EnumValues Kiev => EnumValues.Kiev;

        /// <summary>
        /// Kyivshchyna
        /// </summary>
        public static EnumValues Kyivshchyna => EnumValues.Kyivshchyna;

        /// <summary>
        /// Kirovohradschyna
        /// </summary>
        public static EnumValues Kirovohradschyna => EnumValues.Kirovohradschyna;

        /// <summary>
        /// Sevastopol
        /// </summary>
        public static EnumValues Sevastopol => EnumValues.Sevastopol;

        /// <summary>
        /// Crimea
        /// </summary>
        public static EnumValues Crimea => EnumValues.Crimea;

        /// <summary>
        /// Lvivshchyna
        /// </summary>
        public static EnumValues Lvivshchyna => EnumValues.Lvivshchyna;

        /// <summary>
        /// Mykolayivschyna
        /// </summary>
        public static EnumValues Mykolayivschyna => EnumValues.Mykolayivschyna;

        /// <summary>
        /// Odeshchyna
        /// </summary>
        public static EnumValues Odeshchyna => EnumValues.Odeshchyna;

        /// <summary>
        /// Poltavshchyna
        /// </summary>
        public static EnumValues Poltavshchyna => EnumValues.Poltavshchyna;

        /// <summary>
        /// Rivnenshchyna
        /// </summary>
        public static EnumValues Rivnenshchyna => EnumValues.Rivnenshchyna;

        /// <summary>
        /// Sumshchyna
        /// </summary>
        public static EnumValues Sumshchyna => EnumValues.Sumshchyna;

        /// <summary>
        /// Ternopilshchyna
        /// </summary>
        public static EnumValues Ternopilshchyna => EnumValues.Ternopilshchyna;

        /// <summary>
        /// Kharkivshchyna
        /// </summary>
        public static EnumValues Kharkivshchyna => EnumValues.Kharkivshchyna;

        /// <summary>
        /// Khersonshchyna
        /// </summary>
        public static EnumValues Khersonshchyna => EnumValues.Khersonshchyna;

        /// <summary>
        /// Khmelnychchyna
        /// </summary>
        public static EnumValues Khmelnychchyna => EnumValues.Khmelnychchyna;

        /// <summary>
        /// Cherkashchyna
        /// </summary>
        public static EnumValues Cherkashchyna => EnumValues.Cherkashchyna;

        /// <summary>
        /// Chernihivshchyna
        /// </summary>
        public static EnumValues Chernihivshchyna => EnumValues.Chernihivshchyna;

        /// <summary>
        /// Chernivtsi Oblast
        /// </summary>
        public static EnumValues ChernivtsiOblast => EnumValues.ChernivtsiOblast;

        #endregion

        /// <summary>
        /// Enum values for Ukraine regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Vinnychchyna
            /// </summary>
            [AliasInShort("05")]
            Vinnychchyna,

            /// <summary>
            /// Volyn
            /// </summary>
            [AliasInShort("07")]
            Volyn,

            /// <summary>
            /// Luhanshchyna
            /// </summary>
            [AliasInShort("09")]
            Luhanshchyna,

            /// <summary>
            /// Dnipropetrovshchyna
            /// </summary>
            [AliasInShort("12")]
            Dnipropetrovshchyna,

            /// <summary>
            /// Donechchyna
            /// </summary>
            [AliasInShort("14")]
            Donechchyna,

            /// <summary>
            /// Zhytomyrshchyna
            /// </summary>
            [AliasInShort("18")]
            Zhytomyrshchyna,

            /// <summary>
            /// Zakarpattia
            /// </summary>
            [AliasInShort("21")]
            Zakarpattia,

            /// <summary>
            /// Zaporizhzhya
            /// </summary>
            [AliasInShort("23")]
            Zaporizhzhya,

            /// <summary>
            /// Prykarpattia
            /// </summary>
            [AliasInShort("26")]
            Prykarpattia,

            /// <summary>
            /// Kiev
            /// </summary>
            [AliasInShort("30")]
            Kiev,

            /// <summary>
            /// Kyivshchyna
            /// </summary>
            [AliasInShort("32")]
            Kyivshchyna,

            /// <summary>
            /// Kirovohradschyna
            /// </summary>
            [AliasInShort("35")]
            Kirovohradschyna,

            /// <summary>
            /// Sevastopol
            /// </summary>
            [AliasInShort("40")]
            Sevastopol,

            /// <summary>
            /// Crimea
            /// </summary>
            [AliasInShort("43")]
            Crimea,

            /// <summary>
            /// Lvivshchyna
            /// </summary>
            [AliasInShort("46")]
            Lvivshchyna,

            /// <summary>
            /// Mykolayivschyna
            /// </summary>
            [AliasInShort("48")]
            Mykolayivschyna,

            /// <summary>
            /// Odeshchyna
            /// </summary>
            [AliasInShort("51")]
            Odeshchyna,

            /// <summary>
            /// Poltavshchyna
            /// </summary>
            [AliasInShort("53")]
            Poltavshchyna,

            /// <summary>
            /// Rivnenshchyna
            /// </summary>
            [AliasInShort("56")]
            Rivnenshchyna,

            /// <summary>
            /// Sumshchyna
            /// </summary>
            [AliasInShort("59")]
            Sumshchyna,

            /// <summary>
            /// Ternopilshchyna
            /// </summary>
            [AliasInShort("61")]
            Ternopilshchyna,

            /// <summary>
            /// Kharkivshchyna
            /// </summary>
            [AliasInShort("63")]
            Kharkivshchyna,

            /// <summary>
            /// Khersonshchyna
            /// </summary>
            [AliasInShort("65")]
            Khersonshchyna,

            /// <summary>
            /// Khmelnychchyna
            /// </summary>
            [AliasInShort("68")]
            Khmelnychchyna,

            /// <summary>
            /// Cherkashchyna
            /// </summary>
            [AliasInShort("71")]
            Cherkashchyna,

            /// <summary>
            /// Chernihivshchyna
            /// </summary>
            [AliasInShort("74")]
            Chernihivshchyna,

            /// <summary>
            /// Chernivtsi Oblast
            /// </summary>
            [AliasInShort("77")]
            ChernivtsiOblast,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="UkraineRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UkraineRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"UA-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Ukraine;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.UA;
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