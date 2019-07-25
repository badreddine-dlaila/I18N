using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Iran Regions
    /// </summary>
    public static class IranRegions
    {

        #region Gets regions

        /// <summary>
        /// Khuzestan
        /// </summary>
        public static EnumValues Khuzestan => EnumValues.Khuzestan;

        /// <summary>
        /// Zanjan
        /// </summary>
        public static EnumValues Zanjan => EnumValues.Zanjan;

        /// <summary>
        /// Semnan
        /// </summary>
        public static EnumValues Semnan => EnumValues.Semnan;

        /// <summary>
        /// Sistan and Baluchestan
        /// </summary>
        public static EnumValues SistanAndBaluchestan => EnumValues.SistanAndBaluchestan;

        /// <summary>
        /// Fars
        /// </summary>
        public static EnumValues Fars => EnumValues.Fars;

        /// <summary>
        /// Kerman
        /// </summary>
        public static EnumValues Kerman => EnumValues.Kerman;

        /// <summary>
        /// Kurdistan
        /// </summary>
        public static EnumValues Kurdistan => EnumValues.Kurdistan;

        /// <summary>
        /// Kermanshah
        /// </summary>
        public static EnumValues Kermanshah => EnumValues.Kermanshah;

        /// <summary>
        /// Kohgiluyeh and Boyer-Ahmad
        /// </summary>
        public static EnumValues KohgiluyehAndBoyerAhmad => EnumValues.KohgiluyehAndBoyerAhmad;

        /// <summary>
        /// Gilan
        /// </summary>
        public static EnumValues Gilan => EnumValues.Gilan;

        /// <summary>
        /// Lorestan
        /// </summary>
        public static EnumValues Lorestan => EnumValues.Lorestan;

        /// <summary>
        /// Mazandaran
        /// </summary>
        public static EnumValues Mazandaran => EnumValues.Mazandaran;

        /// <summary>
        /// Markazi
        /// </summary>
        public static EnumValues Markazi => EnumValues.Markazi;

        /// <summary>
        /// Hormozgan
        /// </summary>
        public static EnumValues Hormozgan => EnumValues.Hormozgan;

        /// <summary>
        /// Hamadan
        /// </summary>
        public static EnumValues Hamadan => EnumValues.Hamadan;

        /// <summary>
        /// Yazd
        /// </summary>
        public static EnumValues Yazd => EnumValues.Yazd;

        /// <summary>
        /// Qom
        /// </summary>
        public static EnumValues Qom => EnumValues.Qom;

        /// <summary>
        /// Golestan
        /// </summary>
        public static EnumValues Golestan => EnumValues.Golestan;

        /// <summary>
        /// Qazvin
        /// </summary>
        public static EnumValues Qazvin => EnumValues.Qazvin;

        /// <summary>
        /// South Khorasan
        /// </summary>
        public static EnumValues SouthKhorasan => EnumValues.SouthKhorasan;

        /// <summary>
        /// Razavi Khorasan
        /// </summary>
        public static EnumValues RazaviKhorasan => EnumValues.RazaviKhorasan;

        /// <summary>
        /// North Khorasan
        /// </summary>
        public static EnumValues NorthKhorasan => EnumValues.NorthKhorasan;

        /// <summary>
        /// Alborz
        /// </summary>
        public static EnumValues Alborz => EnumValues.Alborz;

        /// <summary>
        /// East Azerbaijan
        /// </summary>
        public static EnumValues EastAzerbaijan => EnumValues.EastAzerbaijan;

        /// <summary>
        /// West Azarbaijan
        /// </summary>
        public static EnumValues WestAzarbaijan => EnumValues.WestAzarbaijan;

        /// <summary>
        /// Ardabil
        /// </summary>
        public static EnumValues Ardabil => EnumValues.Ardabil;

        /// <summary>
        /// Isfahan
        /// </summary>
        public static EnumValues Isfahan => EnumValues.Isfahan;

        /// <summary>
        /// Ilam
        /// </summary>
        public static EnumValues Ilam => EnumValues.Ilam;

        /// <summary>
        /// Bushehr
        /// </summary>
        public static EnumValues Bushehr => EnumValues.Bushehr;

        /// <summary>
        /// Tehran
        /// </summary>
        public static EnumValues Tehran => EnumValues.Tehran;

        /// <summary>
        /// Chaharmahal and Bakhtiari
        /// </summary>
        public static EnumValues ChaharmahalAndBakhtiari => EnumValues.ChaharmahalAndBakhtiari;

        #endregion

        /// <summary>
        /// Enum values for Iran regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Khuzestan
            /// </summary>
            [AliasInShort("10")]
            Khuzestan,

            /// <summary>
            /// Zanjan
            /// </summary>
            [AliasInShort("11")]
            Zanjan,

            /// <summary>
            /// Semnan
            /// </summary>
            [AliasInShort("12")]
            Semnan,

            /// <summary>
            /// Sistan and Baluchestan
            /// </summary>
            [AliasInShort("13")]
            SistanAndBaluchestan,

            /// <summary>
            /// Fars
            /// </summary>
            [AliasInShort("14")]
            Fars,

            /// <summary>
            /// Kerman
            /// </summary>
            [AliasInShort("15")]
            Kerman,

            /// <summary>
            /// Kurdistan
            /// </summary>
            [AliasInShort("16")]
            Kurdistan,

            /// <summary>
            /// Kermanshah
            /// </summary>
            [AliasInShort("17")]
            Kermanshah,

            /// <summary>
            /// Kohgiluyeh and Boyer-Ahmad
            /// </summary>
            [AliasInShort("18")]
            KohgiluyehAndBoyerAhmad,

            /// <summary>
            /// Gilan
            /// </summary>
            [AliasInShort("19")]
            Gilan,

            /// <summary>
            /// Lorestan
            /// </summary>
            [AliasInShort("20")]
            Lorestan,

            /// <summary>
            /// Mazandaran
            /// </summary>
            [AliasInShort("21")]
            Mazandaran,

            /// <summary>
            /// Markazi
            /// </summary>
            [AliasInShort("22")]
            Markazi,

            /// <summary>
            /// Hormozgan
            /// </summary>
            [AliasInShort("23")]
            Hormozgan,

            /// <summary>
            /// Hamadan
            /// </summary>
            [AliasInShort("24")]
            Hamadan,

            /// <summary>
            /// Yazd
            /// </summary>
            [AliasInShort("25")]
            Yazd,

            /// <summary>
            /// Qom
            /// </summary>
            [AliasInShort("26")]
            Qom,

            /// <summary>
            /// Golestan
            /// </summary>
            [AliasInShort("27")]
            Golestan,

            /// <summary>
            /// Qazvin
            /// </summary>
            [AliasInShort("28")]
            Qazvin,

            /// <summary>
            /// South Khorasan
            /// </summary>
            [AliasInShort("29")]
            SouthKhorasan,

            /// <summary>
            /// Razavi Khorasan
            /// </summary>
            [AliasInShort("30")]
            RazaviKhorasan,

            /// <summary>
            /// North Khorasan
            /// </summary>
            [AliasInShort("31")]
            NorthKhorasan,

            /// <summary>
            /// Alborz
            /// </summary>
            [AliasInShort("32")]
            Alborz,

            /// <summary>
            /// East Azerbaijan
            /// </summary>
            [AliasInShort("01")]
            EastAzerbaijan,

            /// <summary>
            /// West Azarbaijan
            /// </summary>
            [AliasInShort("02")]
            WestAzarbaijan,

            /// <summary>
            /// Ardabil
            /// </summary>
            [AliasInShort("03")]
            Ardabil,

            /// <summary>
            /// Isfahan
            /// </summary>
            [AliasInShort("04")]
            Isfahan,

            /// <summary>
            /// Ilam
            /// </summary>
            [AliasInShort("05")]
            Ilam,

            /// <summary>
            /// Bushehr
            /// </summary>
            [AliasInShort("06")]
            Bushehr,

            /// <summary>
            /// Tehran
            /// </summary>
            [AliasInShort("07")]
            Tehran,

            /// <summary>
            /// Chaharmahal and Bakhtiari
            /// </summary>
            [AliasInShort("08")]
            ChaharmahalAndBakhtiari,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IranRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IranRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"IR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Iran;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.IR;
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