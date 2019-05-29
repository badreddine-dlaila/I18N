using Cosmos.I18N.Core;
using EnumsNET;

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
        /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
        /// Cosmos i18n code: i18n_country_aerjiliya
        /// </summary>
        [I18NIdentityCode(Africa.Algeria.I18N_IDENTITY_CODE)]
        Algeria,

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
        /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
        /// Cosmos i18n code: i18n_country_asaibaijiang
        /// </summary>
        [I18NIdentityCode(Asia.Azerbaijan.I18N_IDENTITY_CODE)]
        Azerbaijan,
        
        /// <summary>
        /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
        /// Cosmos i18n code: i18n_country_bohei
        /// </summary>
        [I18NIdentityCode(Europe.BosniaAndHerzegovina.I18N_IDENTITY_CODE)]
        BosniaAndHerzegovina,
        
        /// <summary>
        /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
        /// Cosmos i18n code: i18n_country_babaduosi
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Barbados.I18N_IDENTITY_CODE)]
        Barbados,

        /// <summary>
        /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
        /// Cosmos i18n code: i18n_country_mengjiala
        /// </summary>
        [I18NIdentityCode(Asia.Bangladesh.I18N_IDENTITY_CODE)]
        Bangladesh,
        
        /// <summary>
        /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
        /// Cosmos i18n code: i18n_country_bilishi
        /// </summary>
        [I18NIdentityCode(Europe.Belgium.I18N_IDENTITY_CODE)]
        Belgium,
        
        /// <summary>
        /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
        /// Cosmos i18n code: i18n_country_bujinafaso
        /// </summary>
        [I18NIdentityCode(Africa.BurkinaFaso.I18N_IDENTITY_CODE)]
        BurkinaFaso,
        
        /// <summary>
        /// 保加利亚（The Republic of Bulgaria，欧洲，BG，BRN，096），保加利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_baojialiya
        /// </summary>
        [I18NIdentityCode(Europe.Bulgaria.I18N_IDENTITY_CODE)]
        Bulgaria,
        
        /// <summary>
        /// 巴林（The Kingdom of Bahrain ，非洲，BH，BHR，048），巴林王国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Asia.Bahrain.I18N_IDENTITY_CODE)]
        Bahrain,
        
        
        /// <summary>
        /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Africa.Burundi.I18N_IDENTITY_CODE)]
        Burundi,
        
        /// <summary>
        /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
        /// Cosmos i18n code: i18n_country_beining
        /// </summary>
        [I18NIdentityCode(Africa.Benin.I18N_IDENTITY_CODE)]
        Benin,
        
        /// <summary>
        /// 百慕大（The Bermuda Islands，北美洲，BI，BDI，108），百慕大群岛 <br />
        /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
        /// Cosmos i18n code: i18n_country_baimuda
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Bermuda.I18N_IDENTITY_CODE)]
        Bermuda,
        
        /// <summary>
        /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
        /// Cosmos i18n code: i18n_country_wenlai
        /// </summary>
        [I18NIdentityCode(Asia.Brunei.I18N_IDENTITY_CODE)]
        Brunei,
        
        /// <summary>
        /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Bolivia.I18N_IDENTITY_CODE)]
        Bolivia,
        
        /// <summary>
        /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
        /// Cosmos i18n code: i18n_country_boneihe
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Bonaire.I18N_IDENTITY_CODE)]
        Bonaire,
        
        /// <summary>
        /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_baxi
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Brazil.I18N_IDENTITY_CODE)]
        Brazil,
        
        /// <summary>
        /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
        /// Cosmos i18n code: i18n_country_bahama
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Bahamas.I18N_IDENTITY_CODE)]
        Bahamas,
        
        /// <summary>
        /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
        /// Cosmos i18n code: i18n_country_budan
        /// </summary>
        [I18NIdentityCode(Asia.Bhutan.I18N_IDENTITY_CODE)]
        Bhutan,
        
        /// <summary>
        /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
        /// Cosmos i18n code: i18n_country_buweidao
        /// </summary>
        [I18NIdentityCode(Europe.BouvetIsland.I18N_IDENTITY_CODE)]
        BouvetIsland,
        
        /// <summary>
        /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
        /// Cosmos i18n code: i18n_country_boziwana
        /// </summary>
        [I18NIdentityCode(Africa.Botswana.I18N_IDENTITY_CODE)]
        Botswana,
        
        /// <summary>
        /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
        /// Cosmos i18n code: i18n_country_baieluosi
        /// </summary>
        [I18NIdentityCode(Europe.Belarus.I18N_IDENTITY_CODE)]
        Belarus,
        
        /// <summary>
        /// 伯利兹（Belize，北美洲，BZ，BLZ，084） <br />
        /// Cosmos i18n code: i18n_country_bolizi
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Belize.I18N_IDENTITY_CODE)]
        Belize,
        
        /// <summary>
        /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
        /// Cosmos i18n code: i18n_country_kamailong
        /// </summary>
        [I18NIdentityCode(Africa.Cameroun.I18N_IDENTITY_CODE)]
        Cameroun,
       
        /// <summary>
        /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
        /// Cosmos i18n code: i18n_country_jianada
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Canada.I18N_IDENTITY_CODE)]
        Canada,
        
        /// <summary>
        /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
        /// Cosmos i18n code: i18n_country_fodejiao
        /// </summary>
        [I18NIdentityCode(Africa.CapeVerde.I18N_IDENTITY_CODE)]
        CapeVerde,
        
        /// <summary>
        /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
        /// Cosmos i18n code: i18n_country_zhongfei
        /// </summary>
        [I18NIdentityCode(Africa.CentralAfrican.I18N_IDENTITY_CODE)]
        CentralAfrican,
        
        /// <summary>
        /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
        /// Cosmos i18n code: i18n_country_china
        /// </summary>
        [I18NIdentityCode(Asia.China.I18N_IDENTITY_CODE)]
        China,
      
        /// <summary>
        /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
        /// Cosmos i18n code: i18n_country_zhili
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Chile.I18N_IDENTITY_CODE)]
        Chile,
        
        /// <summary>
        /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
        /// Cosmos i18n code: i18n_country_kekesi
        /// </summary>
        [I18NIdentityCode(Asia.CocosIslands.I18N_IDENTITY_CODE)]
        CocosIslands,
        
        /// <summary>
        /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gelunbiya
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Colombia.I18N_IDENTITY_CODE)]
        Colombia,
        
        /// <summary>
        /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguobu
        /// </summary>
       [I18NIdentityCode(Africa.CongoBrazzaville.I18N_IDENTITY_CODE)]
        CongoBrazzaville,
        
        /// <summary>
        /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguojin
        /// </summary>
        [I18NIdentityCode(Africa.CongoKinshasa.I18N_IDENTITY_CODE)]
        CongoKinshasa,
        
        /// <summary>
        /// 哥斯达黎加（The Republic of Costa Rica，南美洲，CR，CRI，188），哥斯达黎加共和国 <br />
        /// Cosmos i18n code: i18n_country_gesidalijia
        /// </summary>
        [I18NIdentityCode(NorthAmerica.CostaRica.I18N_IDENTITY_CODE)]
        CostaRica,

        /// <summary>
        /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_ketediwa
        /// </summary>
        [I18NIdentityCode(Africa.CotedIvoire.I18N_IDENTITY_CODE)]
        CotedIvoire,
        
        /// <summary>
        /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
        /// Cosmos i18n code: i18n_country_kukequndao
        /// </summary>
        [I18NIdentityCode(Oceania.CookIslands.I18N_IDENTITY_CODE)]
        CookIslands,
        
        /// <summary>
        /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
        /// Cosmos i18n code: i18n_country_guba
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Cuba.I18N_IDENTITY_CODE)]
        Cuba,
        
        /// <summary>
        /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
        /// Cosmos i18n code: i18n_country_kusuola
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Curaçao.I18N_IDENTITY_CODE)]
        Curaçao,
        
        /// <summary>
        /// 圣诞岛（Christmas Island，亚洲，CX，CXR，162） <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Asia.ChristmasIsland.I18N_IDENTITY_CODE)]
        ChristmasIsland,
        
        /// <summary>
        /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
        /// Cosmos i18n code: i18n_country_saipulusi
        /// </summary>
        [I18NIdentityCode(Asia.Cyprus.I18N_IDENTITY_CODE)]
        Cyprus,
        
        /// <summary>
        /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
        /// Cosmos i18n code: i18n_country_jieke
        /// </summary>
        [I18NIdentityCode(Europe.Czechia.I18N_IDENTITY_CODE)]
        Czechia,
        
        /// <summary>
        /// 吉布提（The Republic of Djibouti，非洲，BI，BDI，108），吉布提共和国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Asia.Djibouti.I18N_IDENTITY_CODE)]
        Djibouti,
        
        /// <summary>
        /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
        /// Cosmos i18n code: i18n_country_danmai
        /// </summary>
        [I18NIdentityCode(Europe.Denmark.I18N_IDENTITY_CODE)]
        Denmark,
        
        /// <summary>
        /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
        /// Cosmos i18n code: i18n_country_duominike
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Dominica.I18N_IDENTITY_CODE)]
        Dominica,
        
        /// <summary>
        /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
        /// Cosmos i18n code: i18n_country_duominijia
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Dominican.I18N_IDENTITY_CODE)]
        Dominican,
        
        /// <summary>
        /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
        /// Cosmos i18n code: i18n_country_eguaduoer
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Ecuador.I18N_IDENTITY_CODE)]
        Ecuador,
        
        /// <summary>
        /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aishaniya
        /// </summary>
        [I18NIdentityCode(Europe.Estonia.I18N_IDENTITY_CODE)]
        Estonia,
        
        /// <summary>
        /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
        /// Cosmos i18n code: i18n_country_aiji
        /// </summary>
        [I18NIdentityCode(Africa.Egypt.I18N_IDENTITY_CODE)]
        Egypt,
        
        /// <summary>
        /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
        /// Cosmos i18n code: i18n_country_aliteliya
        /// </summary>
        [I18NIdentityCode(Africa.Eritrea.I18N_IDENTITY_CODE)]
        Eritrea,
        
        /// <summary>
        /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_aisaiebiya
        /// </summary>
        [I18NIdentityCode(Africa.Ethiopia.I18N_IDENTITY_CODE)]
        Ethiopia,
        
        /// <summary>
        /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
        /// Cosmos i18n code: i18n_country_fenlan
        /// </summary>
        [I18NIdentityCode(Europe.Finland.I18N_IDENTITY_CODE)]
        Finland,
        
        /// <summary>
        /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
        /// Cosmos i18n code: i18n_country_feiji
        /// </summary>
        [I18NIdentityCode(Oceania.Fiji.I18N_IDENTITY_CODE)]
        Fiji,
        
        /// <summary>
        /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
        /// Cosmos i18n code: i18n_country_fukelan
        /// </summary>
        [I18NIdentityCode(SouthAmerica.FalklandIslands.I18N_IDENTITY_CODE)]
        FalklandIslands,
        
        /// <summary>
        /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
        /// Cosmos i18n code: i18n_country_faguo
        /// </summary>
        [I18NIdentityCode(Europe.France.I18N_IDENTITY_CODE)]
        France,
        
        /// <summary>
        /// 德国（TThe Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_deguo
        /// </summary>
        [I18NIdentityCode(Europe.Germany.I18N_IDENTITY_CODE)]
        Germany,
        

        /// <summary>
        /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
        /// 香港，中华人民共和国的一部分 <br />
        /// Hong Kong, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhxianggang
        /// </summary>
        [I18NIdentityCode(Asia.HongKong.I18N_IDENTITY_CODE)]
        HongKong,
        
        /// <summary>
        /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
        /// Cosmos i18n code: i18n_country_riben
        /// </summary>
        [I18NIdentityCode(Asia.Japan.I18N_IDENTITY_CODE)]
        Japan,
        
        Micronesia,

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
        /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
        /// Cosmos i18n code: i18n_country_nuowei
        /// </summary>
        [I18NIdentityCode(Europe.Norway.I18N_IDENTITY_CODE)]
        Norway,
        
        /// <summary>
        /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
        /// Cosmos i18n code: i18n_country_eluosi
        /// </summary>
        [I18NIdentityCode(Europe.Russia.I18N_IDENTITY_CODE)]
        Russia,
        
        /// <summary>
        /// 圣巴托洛缪岛（Collectivitéde Saint-Barthélemy，北美洲，BL，BLM，652），法兰西共和国圣巴托洛缪行政区 <br />
        /// Cosmos i18n code: i18n_country_shengbatuo
        /// </summary>
        [I18NIdentityCode(NorthAmerica.SaintBarts.I18N_IDENTITY_CODE)]
        SaintBarts,
        
        /// <summary>
        /// 西班牙（The Kingdom of Spain，南美洲，ES，ESP，724），西班牙王国 <br />
        /// Cosmos i18n code: i18n_country_xibanya
        /// </summary>
        [I18NIdentityCode(Europe.Spain.I18N_IDENTITY_CODE)]
        Spain,
        
        /// <summary>
        /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
        /// Cosmos i18n code: i18n_country_ruishi
        /// </summary>
        [I18NIdentityCode(Europe.Switzerland.I18N_IDENTITY_CODE)]
        Switzerland,
        
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
        /// 马奥霍（Territorial Collectivity of Mayotte ，非洲，AF，AFG，004），马约特岛 <br />
        /// Cosmos i18n code: i18n_country_mayuete
        /// </summary>
        [I18NIdentityCode(Africa.Mayotte.I18N_IDENTITY_CODE)]
        Mayotte,
        
        /// <summary>
        /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
        /// Cosmos i18n code: i18n_country_nanfei
        /// </summary>
        [I18NIdentityCode(Africa.SouthAfrica.I18N_IDENTITY_CODE)]
        SouthAfrica,
        
        /// <summary>
        /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
        /// Cosmos i18n code: i18n_country_xisahala
        /// </summary>
        [I18NIdentityCode(Africa.WesternSahara.I18N_IDENTITY_CODE)]
        WesternSahara,
        
        /// <summary>
        /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_zanbiya
        /// </summary>
        [I18NIdentityCode(Africa.Zambia.I18N_IDENTITY_CODE)]
        Zambia,

        /// <summary>
        /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
        /// Cosmos i18n code: i18n_country_jinbabuwei
        /// </summary>
        [I18NIdentityCode(Africa.Zimbabwe.I18N_IDENTITY_CODE)]
        Zimbabwe,
    }
}