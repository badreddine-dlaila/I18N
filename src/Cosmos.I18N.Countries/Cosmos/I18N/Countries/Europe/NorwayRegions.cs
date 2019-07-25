using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Norway Regions
    /// </summary>
    public static class NorwayRegions
    {

        #region Gets regions

        /// <summary>
        /// The Svalbard archipelago
        /// </summary>
        public static EnumValues SvalbardAndJanMayen => EnumValues.SvalbardAndJanMayen;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// Sint Maarten Dutch Part
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country SvalbardAndJanMayen => Country.SvalbardAndJanMayen;

            /// <summary>
            /// Sint Maarten Dutch Part
            /// </summary>
            public static CountryCode SvalbardAndJanMayenCode => CountryCode.SJ;
        }

        /// <summary>
        /// Enum values for United Kingdom regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// The Svalbard archipelago
            /// </summary>
            [AliasInShort("SJ")]
            [RegionFlag("overseas")]
            SvalbardAndJanMayen,

            /// <summary>
            /// 未知
            /// </summary>
            [IgnoreRegionAttribute]
            [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NetherlandsRegions.EnumValues"/> to region code likes 'ENG', 'ALD', 'GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NetherlandsRegions.EnumValues"/> to full region code likes 'GB-ENG', 'GB-ALD', 'GB-GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"NO-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Norway;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.NO;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.SintMaartenDutchPart:
                    return EnumValues.SvalbardAndJanMayen;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.SJ:
                    return EnumValues.SvalbardAndJanMayen;
                default:
                    return EnumValues.Unknown;
            }
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) =>
            InternalEnumMembersCache.Where(x => x.Attributes.GetAll<RegionFlagAttribute>().Any(attr => attr.Flag == flag));

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes()
        {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// Get overseas region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes()
        {
            foreach (var member in Filter("overseas"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// Get main region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes()
        {
            foreach (var member in Filter("main"))
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}