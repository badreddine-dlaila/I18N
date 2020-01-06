using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Yemen regions
    /// </summary>
    public static class YemenRegions {

        #region Gets regions

        /// <summary>
        /// Abyan
        /// </summary>
        public static EnumValues Abyan => EnumValues.Abyan;

        /// <summary>
        /// 'Adan
        /// </summary>
        public static EnumValues Adan => EnumValues.Adan;

        /// <summary>
        /// Amran
        /// </summary>
        public static EnumValues Amran => EnumValues.Amran;

        /// <summary>
        /// Al Bayda
        /// </summary>
        public static EnumValues AlBayda => EnumValues.AlBayda;

        /// <summary>
        /// Dhale
        /// </summary>
        public static EnumValues Dhale => EnumValues.Dhale;

        /// <summary>
        /// Dhamar
        /// </summary>
        public static EnumValues Dhamar => EnumValues.Dhamar;

        /// <summary>
        /// Hadramaut
        /// </summary>
        public static EnumValues Hadramaut => EnumValues.Hadramaut;

        /// <summary>
        /// Hajjah
        /// </summary>
        public static EnumValues Hajjah => EnumValues.Hajjah;

        /// <summary>
        /// Al Hudaydah
        /// </summary>
        public static EnumValues AlHudaydah => EnumValues.AlHudaydah;

        /// <summary>
        /// Ibb
        /// </summary>
        public static EnumValues Ibb => EnumValues.Ibb;

        /// <summary>
        /// Al Jawf
        /// </summary>
        public static EnumValues AlJawf => EnumValues.AlJawf;

        /// <summary>
        /// Lahij
        /// </summary>
        public static EnumValues Lahij => EnumValues.Lahij;

        /// <summary>
        /// Ma'rib
        /// </summary>
        public static EnumValues MaRib => EnumValues.MaRib;

        /// <summary>
        /// Al Mahrah
        /// </summary>
        public static EnumValues AlMahrah => EnumValues.AlMahrah;

        /// <summary>
        /// Al Mahwit
        /// </summary>
        public static EnumValues AlMahwit => EnumValues.AlMahwit;

        /// <summary>
        /// Raymah
        /// </summary>
        public static EnumValues Raymah => EnumValues.Raymah;


        /// <summary>
        /// Amanat Al Asimah
        /// </summary>
        public static EnumValues AmanatAlAsimah => EnumValues.AmanatAlAsimah;

        /// <summary>
        /// Sa'dah
        /// </summary>
        public static EnumValues SaDah => EnumValues.SaDah;

        /// <summary>
        /// Shabwah
        /// </summary>
        public static EnumValues Shabwah => EnumValues.Shabwah;

        /// <summary>
        /// Sana'a
        /// </summary>
        public static EnumValues SanaA => EnumValues.SanaA;

        /// <summary>
        /// Arkhabil Suqutra
        /// </summary>
        public static EnumValues ArkhabilSuqutra => EnumValues.ArkhabilSuqutra;

        /// <summary>
        /// Taiz
        /// </summary>
        public static EnumValues Taiz => EnumValues.Taiz;

        #endregion

        /// <summary>
        /// Enum values for Yemen regions
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Abyan
            /// </summary>
            [AliasInShort("AB")]
            Abyan,

            /// <summary>
            /// 'Adan
            /// </summary>
            [AliasInShort("AD")]
            Adan,

            /// <summary>
            /// Amran
            /// </summary>
            [AliasInShort("AM")]
            Amran,

            /// <summary>
            /// Al Bayda
            /// </summary>
            [AliasInShort("BA")]
            AlBayda,

            /// <summary>
            /// Dhale
            /// </summary>
            [AliasInShort("DA")]
            Dhale,

            /// <summary>
            /// Dhamar
            /// </summary>
            [AliasInShort("DH")]
            Dhamar,

            /// <summary>
            /// Hadramaut
            /// </summary>
            [AliasInShort("HD")]
            Hadramaut,

            /// <summary>
            /// Hajjah
            /// </summary>
            [AliasInShort("HJ")]
            Hajjah,

            /// <summary>
            /// Al Hudaydah
            /// </summary>
            [AliasInShort("HU")]
            AlHudaydah,

            /// <summary>
            /// Ibb
            /// </summary>
            [AliasInShort("IB")]
            Ibb,

            /// <summary>
            /// Al Jawf
            /// </summary>
            [AliasInShort("JA")]
            AlJawf,

            /// <summary>
            /// Lahij
            /// </summary>
            [AliasInShort("LA")]
            Lahij,

            /// <summary>
            /// Ma'rib
            /// </summary>
            [AliasInShort("MA")]
            MaRib,

            /// <summary>
            /// Al Mahrah
            /// </summary>
            [AliasInShort("MR")]
            AlMahrah,

            /// <summary>
            /// Al Mahwit
            /// </summary>
            [AliasInShort("MW")]
            AlMahwit,

            /// <summary>
            /// Raymah
            /// </summary>
            [AliasInShort("RA")]
            Raymah,

            /// <summary>
            /// Amanat Al Asimah
            /// </summary>
            [AliasInShort("SA")]
            AmanatAlAsimah,

            /// <summary>
            /// Sa'dah
            /// </summary>
            [AliasInShort("SD")]
            SaDah,

            /// <summary>
            /// Shabwah
            /// </summary>
            [AliasInShort("SH")]
            Shabwah,

            /// <summary>
            /// Sana'a
            /// </summary>
            [AliasInShort("SN")]
            SanaA,

            /// <summary>
            /// Arkhabil Suqutra
            /// </summary>
            [AliasInShort("SU")]
            ArkhabilSuqutra,

            /// <summary>
            /// Taiz
            /// </summary>
            [AliasInShort("TA")]
            Taiz,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="YemenRegions.EnumValues"/> to region code likes 'AD'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="YemenRegions.EnumValues"/> to full region code likes 'YE-AD'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"YE-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Yemen;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.YE;
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