using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Tunisia Regions
    /// </summary>
    public static class TunisiaRegions
    {

        #region Gets regions

        /// <summary>
        /// Tunis
        /// </summary>
        public static EnumValues Tunis => EnumValues.Tunis;

        /// <summary>
        /// Ariana
        /// </summary>
        public static EnumValues Ariana => EnumValues.Ariana;

        /// <summary>
        /// Ben Arous
        /// </summary>
        public static EnumValues BenArous => EnumValues.BenArous;

        /// <summary>
        /// Manouba
        /// </summary>
        public static EnumValues Manouba => EnumValues.Manouba;

        /// <summary>
        /// Nabeul
        /// </summary>
        public static EnumValues Nabeul => EnumValues.Nabeul;

        /// <summary>
        /// Zaghouan
        /// </summary>
        public static EnumValues Zaghouan => EnumValues.Zaghouan;

        /// <summary>
        /// Bizerte
        /// </summary>
        public static EnumValues Bizerte => EnumValues.Bizerte;

        /// <summary>
        /// Béja
        /// </summary>
        public static EnumValues Béja => EnumValues.Béja;

        /// <summary>
        /// Jendouba
        /// </summary>
        public static EnumValues Jendouba => EnumValues.Jendouba;

        /// <summary>
        /// Kef
        /// </summary>
        public static EnumValues Kef => EnumValues.Kef;

        /// <summary>
        /// Siliana
        /// </summary>
        public static EnumValues Siliana => EnumValues.Siliana;

        /// <summary>
        /// Kairouan
        /// </summary>
        public static EnumValues Kairouan => EnumValues.Kairouan;

        /// <summary>
        /// Kasserine
        /// </summary>
        public static EnumValues Kasserine => EnumValues.Kasserine;

        /// <summary>
        /// Sidi Bouzid
        /// </summary>
        public static EnumValues SidiBouzid => EnumValues.SidiBouzid;

        /// <summary>
        /// Sousse
        /// </summary>
        public static EnumValues Sousse => EnumValues.Sousse;

        /// <summary>
        /// Monastir
        /// </summary>
        public static EnumValues Monastir => EnumValues.Monastir;

        /// <summary>
        /// Mahdia
        /// </summary>
        public static EnumValues Mahdia => EnumValues.Mahdia;

        /// <summary>
        /// Sfax
        /// </summary>
        public static EnumValues Sfax => EnumValues.Sfax;

        /// <summary>
        /// Gafsa
        /// </summary>
        public static EnumValues Gafsa => EnumValues.Gafsa;

        /// <summary>
        /// Tozeur
        /// </summary>
        public static EnumValues Tozeur => EnumValues.Tozeur;

        /// <summary>
        /// Kebili
        /// </summary>
        public static EnumValues Kebili => EnumValues.Kebili;

        /// <summary>
        /// Gabès
        /// </summary>
        public static EnumValues Gabès => EnumValues.Gabès;

        /// <summary>
        /// Medenine
        /// </summary>
        public static EnumValues Medenine => EnumValues.Medenine;

        /// <summary>
        /// Tataouine
        /// </summary>
        public static EnumValues Tataouine => EnumValues.Tataouine;

        #endregion

        /// <summary>
        /// Enum values for Tunisia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Tunis
            /// </summary>
            [AliasInShort("11")]
            Tunis,

            /// <summary>
            /// Ariana
            /// </summary>
            [AliasInShort("12")]
            Ariana,

            /// <summary>
            /// Ben Arous
            /// </summary>
            [AliasInShort("13")]
            BenArous,

            /// <summary>
            /// Manouba
            /// </summary>
            [AliasInShort("14")]
            Manouba,

            /// <summary>
            /// Nabeul
            /// </summary>
            [AliasInShort("21")]
            Nabeul,

            /// <summary>
            /// Zaghouan
            /// </summary>
            [AliasInShort("22")]
            Zaghouan,

            /// <summary>
            /// Bizerte
            /// </summary>
            [AliasInShort("23")]
            Bizerte,

            /// <summary>
            /// Béja
            /// </summary>
            [AliasInShort("31")]
            Béja,

            /// <summary>
            /// Jendouba
            /// </summary>
            [AliasInShort("32")]
            Jendouba,

            /// <summary>
            /// Kef
            /// </summary>
            [AliasInShort("33")]
            Kef,

            /// <summary>
            /// Siliana
            /// </summary>
            [AliasInShort("34")]
            Siliana,

            /// <summary>
            /// Kairouan
            /// </summary>
            [AliasInShort("41")]
            Kairouan,

            /// <summary>
            /// Kasserine
            /// </summary>
            [AliasInShort("42")]
            Kasserine,

            /// <summary>
            /// Sidi Bouzid
            /// </summary>
            [AliasInShort("43")]
            SidiBouzid,

            /// <summary>
            /// Sousse
            /// </summary>
            [AliasInShort("51")]
            Sousse,

            /// <summary>
            /// Monastir
            /// </summary>
            [AliasInShort("52")]
            Monastir,

            /// <summary>
            /// Mahdia
            /// </summary>
            [AliasInShort("53")]
            Mahdia,

            /// <summary>
            /// Sfax
            /// </summary>
            [AliasInShort("61")]
            Sfax,

            /// <summary>
            /// Gafsa
            /// </summary>
            [AliasInShort("71")]
            Gafsa,

            /// <summary>
            /// Tozeur
            /// </summary>
            [AliasInShort("72")]
            Tozeur,

            /// <summary>
            /// Kebili
            /// </summary>
            [AliasInShort("73")]
            Kebili,

            /// <summary>
            /// Gabès
            /// </summary>
            [AliasInShort("81")]
            Gabès,

            /// <summary>
            /// Medenine
            /// </summary>
            [AliasInShort("82")]
            Medenine,

            /// <summary>
            /// Tataouine
            /// </summary>
            [AliasInShort("83")]
            Tataouine,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TunisiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TunisiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TN-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Tunisia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TN;
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