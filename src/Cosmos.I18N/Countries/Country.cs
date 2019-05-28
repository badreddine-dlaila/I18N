using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries
{
    public enum Country
    {
        /// <summary>
        /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
        /// Cosmos i18n code: i18n_country_andaoer
        /// </summary>
        [I18NIdentityCode(Europe.Andorra.I18N_IDENTITY_CODE)]
        Andorra,

        /// <summary>
        /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
        /// 又名 阿拉伯联合大公国 <br />
        /// Cosmos i18n code: i18n_country_alianqiu
        /// </summary>
        [I18NIdentityCode(Asia.UnitedArabEmirates.I18N_IDENTITY_CODE)]
        UnitedArabEmirates,

        /// <summary>
        /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
        /// Cosmos i18n code: i18n_country_afuhan
        /// </summary>
        [I18NIdentityCode(Asia.Afghanistan.I18N_IDENTITY_CODE)]
        Afghanistan,

        /// <summary>
        /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
        /// Cosmos i18n code: i18n_country_andaguababuda
        /// </summary>
        [I18NIdentityCode(NorthAmerica.AntiguaAndBarbuda.I18N_IDENTITY_CODE)]
        AntiguaAndBarbuda,

        /// <summary>
        /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
        /// Cosmos i18n code: i18n_country_anguila
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Anguilla.I18N_IDENTITY_CODE)]
        Anguilla,

        /// <summary>
        /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aerbaniya
        /// </summary>
        [I18NIdentityCode(Europe.Albania.I18N_IDENTITY_CODE)]
        Albania,

        /// <summary>
        /// 亚美尼亚（Armenia，欧洲，AM，ARM，051），亚美尼亚共和国<br />
        /// Cosmos i18n code: i18n_country_yameiniya
        /// </summary>
        [I18NIdentityCode(Europe.Armenia.I18N_IDENTITY_CODE)]
        Armenia,

        /// <summary>
        /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
        /// Cosmos i18n code: i18n_country_angela
        /// </summary>
        [I18NIdentityCode(Africa.Angola.I18N_IDENTITY_CODE)]
        Angola,

        /// <summary>
        /// 南极洲（Zimbabwe，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji
        /// </summary>
        [I18NIdentityCode(global::Cosmos.I18N.Countries.Antarctica.Antarctique.I18N_IDENTITY_CODE)]
        Antarctica,
      
        /// <summary>
        /// 南极洲（Zimbabwe，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji
        /// </summary>
        [I18NIdentityCode(global::Cosmos.I18N.Countries.Antarctica.Antarctique.I18N_IDENTITY_CODE)]
        Antarctique = Antarctica,
        
        /// <summary>
        /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
        /// Cosmos i18n code: i18n_country_agenting
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Argentina.I18N_IDENTITY_CODE)]
        Argentina,
        
        /// <summary>
        /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
        /// 美属萨摩亚领地<br />
        /// Cosmos i18n code: i18n_country_ussamoya
        /// </summary>
        [I18NIdentityCode(Oceania.AmericanSamoa.I18N_IDENTITY_CODE)]
        AmericanSamoa,
        
        /// <summary>
        /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
        /// Cosmos i18n code: i18n_country_aodili
        /// </summary>
        [I18NIdentityCode(Europe.Austria.I18N_IDENTITY_CODE)]
        Austria,
        
        /// <summary>
        /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
        /// Cosmos i18n code: i18n_country_aodaliya
        /// </summary>
        [I18NIdentityCode(Oceania.Australia.I18N_IDENTITY_CODE)]
        Australia,
        
        /// <summary>
        /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
        /// Cosmos i18n code: i18n_country_aluba
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Aruba.I18N_IDENTITY_CODE)]
        Aruba,
        
        /// <summary>
        /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
        /// Cosmos i18n code: i18n_country_aolanqundao
        /// </summary>
        [I18NIdentityCode(Europe.AlandIslands.I18N_IDENTITY_CODE)]
        AlandIslands,
        
        /// <summary>
        /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
        /// Cosmos i18n code: i18n_country_china
        /// </summary>
        [I18NIdentityCode(Asia.China.I18N_IDENTITY_CODE)]
        China,
        
        /// <summary>
        /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
        /// Cosmos i18n code: i18n_country_fenlan
        /// </summary>
        [I18NIdentityCode(Europe.Finland.I18N_IDENTITY_CODE)]
        Finland,


        /// <summary>
        /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
        /// 香港，中华人民共和国的一部分 <br />
        /// Hong Kong, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhxianggang
        /// </summary>
        [I18NIdentityCode(Asia.HongKong.I18N_IDENTITY_CODE)]
        HongKong,

        /// <summary>
        /// 澳门（Macao, SAR China，亚洲，HK，HKG，344），中华人民共和国澳门特别行政区 <br />
        /// 澳门，中华人民共和国的一部分 <br />
        /// Macao, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhaomen
        /// </summary>
        [I18NIdentityCode(Asia.Macao.I18N_IDENTITY_CODE)]
        Macao,
        
        /// <summary>
        /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
        /// Cosmos i18n code: i18n_country_helan
        /// </summary>
        [I18NIdentityCode(Europe.Netherlands.I18N_IDENTITY_CODE)]
        Netherlands,
        
        /// <summary>
        /// 台湾（Macao, SAR China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
        /// 台湾，中华人民共和国的一部分 <br />
        /// Taiwan, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhtaiwan
        /// </summary>
        [I18NIdentityCode(Asia.Taiwan.I18N_IDENTITY_CODE)]
        Taiwan,

        /// <summary>
        /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
        /// Cosmos i18n code: i18n_country_yingguo
        /// </summary>
        [I18NIdentityCode(Europe.UnitedKingdom.I18N_IDENTITY_CODE)]
        UnitedKingdom,


        /// <summary>
        /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
        /// Cosmos i18n code: i18n_country_meiguo
        /// </summary>
        [I18NIdentityCode(NorthAmerica.UnitedStates.I18N_IDENTITY_CODE)]
        UnitedStates,

        /// <summary>
        /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
        /// Cosmos i18n code: i18n_country_jinbabuwei
        /// </summary>
        [I18NIdentityCode(Africa.Zimbabwe.I18N_IDENTITY_CODE)]
        Zimbabwe,
    }
}