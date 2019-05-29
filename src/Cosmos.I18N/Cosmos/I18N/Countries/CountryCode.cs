// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming

using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// 国家和地区编号
    /// Country And Regions Code (ISO 3166-1 ALPHA-2)
    /// https://www.nationsonline.org/oneworld/country_code_list.htm
    /// </summary>
    public enum CountryCode
    {
        /// <summary>
        /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
        /// Cosmos i18n code: i18n_country_andaoer
        /// </summary>
        [I18NIdentityCode(Europe.Andorra.I18N_IDENTITY_CODE)]
        AD,

        /// <summary>
        /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
        /// 又名 阿拉伯联合大公国 <br />
        /// Cosmos i18n code: i18n_country_alianqiu
        /// </summary>
        [I18NIdentityCode(Asia.UnitedArabEmirates.I18N_IDENTITY_CODE)]
        AE,

        /// <summary>
        /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
        /// Cosmos i18n code: i18n_country_afuhan
        /// </summary>
        [I18NIdentityCode(Asia.Afghanistan.I18N_IDENTITY_CODE)]
        AF,

        /// <summary>
        /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
        /// Cosmos i18n code: i18n_country_andaguababuda
        /// </summary>
        [I18NIdentityCode(NorthAmerica.AntiguaAndBarbuda.I18N_IDENTITY_CODE)]
        AG,

        /// <summary>
        /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
        /// Cosmos i18n code: i18n_country_anguila
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Anguilla.I18N_IDENTITY_CODE)]
        AI,

        /// <summary>
        /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aerbaniya
        /// </summary>
        [I18NIdentityCode(Europe.Albania.I18N_IDENTITY_CODE)]
        AL,

        /// <summary>
        /// 亚美尼亚（Armenia，欧洲，AM，ARM，051），亚美尼亚共和国<br />
        /// Cosmos i18n code: i18n_country_yameiniya
        /// </summary>
        [I18NIdentityCode(Europe.Armenia.I18N_IDENTITY_CODE)]
        AM,

        /// <summary>
        /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
        /// Cosmos i18n code: i18n_country_angela
        /// </summary>
        [I18NIdentityCode(Africa.Angola.I18N_IDENTITY_CODE)]
        AO,

        /// <summary>
        /// 南极洲（Zimbabwe，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji
        /// </summary>
        [I18NIdentityCode(Antarctica.Antarctique.I18N_IDENTITY_CODE)]
        AQ,

        /// <summary>
        /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
        /// Cosmos i18n code: i18n_country_agenting
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Argentina.I18N_IDENTITY_CODE)]
        AR,

        /// <summary>
        /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
        /// 美属萨摩亚领地<br />
        /// Cosmos i18n code: i18n_country_ussamoya
        /// </summary>
        [I18NIdentityCode(Oceania.AmericanSamoa.I18N_IDENTITY_CODE)]
        AS,

        /// <summary>
        /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
        /// Cosmos i18n code: i18n_country_aodili
        /// </summary>
        [I18NIdentityCode(Europe.Austria.I18N_IDENTITY_CODE)]
        AT,

        /// <summary>
        /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
        /// Cosmos i18n code: i18n_country_aodaliya
        /// </summary>
        [I18NIdentityCode(Oceania.Australia.I18N_IDENTITY_CODE)]
        AU,

        /// <summary>
        /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
        /// Cosmos i18n code: i18n_country_aluba
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Aruba.I18N_IDENTITY_CODE)]
        AW,

        /// <summary>
        /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
        /// Cosmos i18n code: i18n_country_aolanqundao
        /// </summary>
        [I18NIdentityCode(Europe.AlandIslands.I18N_IDENTITY_CODE)]
        AX,

        /// <summary>
        /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
        /// Cosmos i18n code: i18n_country_asaibaijiang
        /// </summary>
        [I18NIdentityCode(Asia.Azerbaijan.I18N_IDENTITY_CODE)]
        AZ,

        /// <summary>
        /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
        /// Cosmos i18n code: i18n_country_bohei
        /// </summary>
        [I18NIdentityCode(Europe.BosniaAndHerzegovina.I18N_IDENTITY_CODE)]
        BA,

        /// <summary>
        /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
        /// Cosmos i18n code: i18n_country_babaduosi
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Barbados.I18N_IDENTITY_CODE)]
        BB,

        /// <summary>
        /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
        /// Cosmos i18n code: i18n_country_mengjiala
        /// </summary>
        [I18NIdentityCode(Asia.Bangladesh.I18N_IDENTITY_CODE)]
        BD,

        /// <summary>
        /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
        /// Cosmos i18n code: i18n_country_bilishi
        /// </summary>
        [I18NIdentityCode(Europe.Belgium.I18N_IDENTITY_CODE)]
        BE,

        /// <summary>
        /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
        /// Cosmos i18n code: i18n_country_bujinafaso
        /// </summary>
        [I18NIdentityCode(Africa.BurkinaFaso.I18N_IDENTITY_CODE)]
        BF,

        /// <summary>
        /// 保加利亚（The Republic of Bulgaria，欧洲，BG，BRN，096），保加利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_baojialiya
        /// </summary>
        [I18NIdentityCode(Europe.Bulgaria.I18N_IDENTITY_CODE)]
        BG,

        /// <summary>
        /// 巴林（The Kingdom of Bahrain ，非洲，BH，BHR，048），巴林王国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Asia.Bahrain.I18N_IDENTITY_CODE)]
        BH,

        /// <summary>
        /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Africa.Burundi.I18N_IDENTITY_CODE)]
        BI,

        /// <summary>
        /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
        /// Cosmos i18n code: i18n_country_beining
        /// </summary>
        [I18NIdentityCode(Africa.Benin.I18N_IDENTITY_CODE)]
        BJ,

        /// <summary>
        /// 圣巴托洛缪岛（Collectivitéde Saint-Barthélemy，北美洲，BL，BLM，652），法兰西共和国圣巴托洛缪行政区 <br />
        /// Cosmos i18n code: i18n_country_shengbatuo
        /// </summary>
        [I18NIdentityCode(NorthAmerica.SaintBarts.I18N_IDENTITY_CODE)]
        BL,

        /// <summary>
        /// 百慕大（The Bermuda Islands，北美洲，BI，BDI，108），百慕大群岛 <br />
        /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
        /// Cosmos i18n code: i18n_country_baimuda
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Bermuda.I18N_IDENTITY_CODE)]
        BM,

        /// <summary>
        /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
        /// Cosmos i18n code: i18n_country_wenlai
        /// </summary>
        [I18NIdentityCode(Asia.Brunei.I18N_IDENTITY_CODE)]
        BN,

        /// <summary>
        /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Bolivia.I18N_IDENTITY_CODE)]
        BO,

        /// <summary>
        /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
        /// Cosmos i18n code: i18n_country_boneihe
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Bonaire.I18N_IDENTITY_CODE)]
        BQ,

        /// <summary>
        /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_baxi
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Brazil.I18N_IDENTITY_CODE)]
        BR,

        /// <summary>
        /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
        /// Cosmos i18n code: i18n_country_bahama
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Bahamas.I18N_IDENTITY_CODE)]
        BS,

        /// <summary>
        /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
        /// Cosmos i18n code: i18n_country_budan
        /// </summary>
        [I18NIdentityCode(Asia.Bhutan.I18N_IDENTITY_CODE)]
        BT,

        /// <summary>
        /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
        /// Cosmos i18n code: i18n_country_buweidao
        /// </summary>
        [I18NIdentityCode(Europe.BouvetIsland.I18N_IDENTITY_CODE)]
        BV,

        /// <summary>
        /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
        /// Cosmos i18n code: i18n_country_boziwana
        /// </summary>
        [I18NIdentityCode(Africa.Botswana.I18N_IDENTITY_CODE)]
        BW,

        /// <summary>
        /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
        /// Cosmos i18n code: i18n_country_baieluosi
        /// </summary>
        [I18NIdentityCode(Europe.Belarus.I18N_IDENTITY_CODE)]
        BY,

        /// <summary>
        /// 伯利兹（Belize，北美洲，BZ，BLZ，084） <br />
        /// Cosmos i18n code: i18n_country_bolizi
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Belize.I18N_IDENTITY_CODE)]
        BZ,

        /// <summary>
        /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
        /// Cosmos i18n code: i18n_country_jianada
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Canada.I18N_IDENTITY_CODE)]
        CA,

        /// <summary>
        /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
        /// Cosmos i18n code: i18n_country_kekesi
        /// </summary>
        [I18NIdentityCode(Asia.CocosIslands.I18N_IDENTITY_CODE)]
        CC,

        /// <summary>
        /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguojin
        /// </summary>
        [I18NIdentityCode(Africa.CongoKinshasa.I18N_IDENTITY_CODE)]
        CD,

        /// <summary>
        /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
        /// Cosmos i18n code: i18n_country_zhongfei
        /// </summary>
        [I18NIdentityCode(Africa.CentralAfrican.I18N_IDENTITY_CODE)]
        CF,

        /// <summary>
        /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguobu
        /// </summary>
        [I18NIdentityCode(Africa.CongoBrazzaville.I18N_IDENTITY_CODE)]
        CG,

        /// <summary>
        /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
        /// Cosmos i18n code: i18n_country_ruishi
        /// </summary>
        [I18NIdentityCode(Europe.Switzerland.I18N_IDENTITY_CODE)]
        CH,

        /// <summary>
        /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_ketediwa
        /// </summary>
        [I18NIdentityCode(Africa.CotedIvoire.I18N_IDENTITY_CODE)]
        CI,

        /// <summary>
        /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
        /// Cosmos i18n code: i18n_country_kukequndao
        /// </summary>
        [I18NIdentityCode(Oceania.CookIslands.I18N_IDENTITY_CODE)]
        CK,

        /// <summary>
        /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
        /// Cosmos i18n code: i18n_country_zhili
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Chile.I18N_IDENTITY_CODE)]
        CL,

        /// <summary>
        /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
        /// Cosmos i18n code: i18n_country_kamailong
        /// </summary>
        [I18NIdentityCode(Africa.Cameroun.I18N_IDENTITY_CODE)]
        CM,

        /// <summary>
        /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
        /// Cosmos i18n code: i18n_country_china
        /// </summary>
        [I18NIdentityCode(Asia.China.I18N_IDENTITY_CODE)]
        CN,

        /// <summary>
        /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gelunbiya
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Colombia.I18N_IDENTITY_CODE)]
        CO,

        /// <summary>
        /// 哥斯达黎加（The Republic of Costa Rica，南美洲，CR，CRI，188），哥斯达黎加共和国 <br />
        /// Cosmos i18n code: i18n_country_gesidalijia
        /// </summary>
        [I18NIdentityCode(NorthAmerica.CostaRica.I18N_IDENTITY_CODE)]
        CR,

        /// <summary>
        /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
        /// Cosmos i18n code: i18n_country_guba
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Cuba.I18N_IDENTITY_CODE)]
        CU,

        /// <summary>
        /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
        /// Cosmos i18n code: i18n_country_fodejiao
        /// </summary>
        [I18NIdentityCode(Africa.CapeVerde.I18N_IDENTITY_CODE)]
        CV,

        /// <summary>
        /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
        /// Cosmos i18n code: i18n_country_kusuola
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Curaçao.I18N_IDENTITY_CODE)]
        CW,

        /// <summary>
        /// 圣诞岛（Christmas Island，亚洲，CX，CXR，162） <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Asia.ChristmasIsland.I18N_IDENTITY_CODE)]
        CX,

        /// <summary>
        /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
        /// Cosmos i18n code: i18n_country_saipulusi
        /// </summary>
        [I18NIdentityCode(Asia.Cyprus.I18N_IDENTITY_CODE)]
        CY,

        /// <summary>
        /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
        /// Cosmos i18n code: i18n_country_jieke
        /// </summary>
        [I18NIdentityCode(Europe.Czechia.I18N_IDENTITY_CODE)]
        CZ,

        /// <summary>
        /// 德国（TThe Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_deguo
        /// </summary>
        [I18NIdentityCode(Europe.Germany.I18N_IDENTITY_CODE)]
        DE,

        /// <summary>
        /// 吉布提（The Republic of Djibouti，非洲，BI，BDI，108），吉布提共和国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        [I18NIdentityCode(Asia.Djibouti.I18N_IDENTITY_CODE)]
        DJ,

        /// <summary>
        /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
        /// Cosmos i18n code: i18n_country_danmai
        /// </summary>
        [I18NIdentityCode(Europe.Denmark.I18N_IDENTITY_CODE)]
        DK,

        /// <summary>
        /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
        /// Cosmos i18n code: i18n_country_duominike
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Dominica.I18N_IDENTITY_CODE)]
        DM,

        /// <summary>
        /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
        /// Cosmos i18n code: i18n_country_duominijia
        /// </summary>
        [I18NIdentityCode(NorthAmerica.Dominican.I18N_IDENTITY_CODE)]
        DO,

        /// <summary>
        /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
        /// Cosmos i18n code: i18n_country_aerjiliya
        /// </summary>
        [I18NIdentityCode(Africa.Algeria.I18N_IDENTITY_CODE)]
        DZ,

        /// <summary>
        /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
        /// Cosmos i18n code: i18n_country_eguaduoer
        /// </summary>
        [I18NIdentityCode(SouthAmerica.Ecuador.I18N_IDENTITY_CODE)]
        EC,

        /// <summary>
        /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aishaniya
        /// </summary>
        [I18NIdentityCode(Europe.Estonia.I18N_IDENTITY_CODE)]
        EE,

        /// <summary>
        /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
        /// Cosmos i18n code: i18n_country_aiji
        /// </summary>
        [I18NIdentityCode(Africa.Egypt.I18N_IDENTITY_CODE)]
        EG,

        /// <summary>
        /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
        /// Cosmos i18n code: i18n_country_xisahala
        /// </summary>
        [I18NIdentityCode(Africa.WesternSahara.I18N_IDENTITY_CODE)]
        EH,

        /// <summary>
        /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
        /// Cosmos i18n code: i18n_country_aliteliya
        /// </summary>
        [I18NIdentityCode(Africa.Eritrea.I18N_IDENTITY_CODE)]
        ER,

        /// <summary>
        /// 西班牙（The Kingdom of Spain，南美洲，ES，ESP，724），西班牙王国 <br />
        /// Cosmos i18n code: i18n_country_xibanya
        /// </summary>
        [I18NIdentityCode(Europe.Spain.I18N_IDENTITY_CODE)]
        ES,

        /// <summary>
        /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_aisaiebiya
        /// </summary>
        [I18NIdentityCode(Africa.Ethiopia.I18N_IDENTITY_CODE)]
        ET,

        /// <summary>
        /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
        /// Cosmos i18n code: i18n_country_fenlan
        /// </summary>
        [I18NIdentityCode(Europe.Finland.I18N_IDENTITY_CODE)]
        FI,

        /// <summary>
        /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
        /// Cosmos i18n code: i18n_country_feiji
        /// </summary>
        [I18NIdentityCode(Oceania.Fiji.I18N_IDENTITY_CODE)]
        FJ,

        /// <summary>
        /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
        /// Cosmos i18n code: i18n_country_fukelan
        /// </summary>
        [I18NIdentityCode(SouthAmerica.FalklandIslands.I18N_IDENTITY_CODE)]
        FK,

        /// <summary>
        /// Micronesia (Federated States of)
        /// </summary>
        [Alpha2Code("FM")]
        [Alpha3Code("FSM")]
        [CountryOrRegionName("Micronesia (Federated States of)")]
        [UNCode("583")]
        FM,

        /// <summary>
        /// Faroe Islands
        /// </summary>
        [Alpha2Code("FO")]
        [Alpha3Code("FRO")]
        [CountryOrRegionName("Faroe Islands")]
        [UNCode("234")]
        FO,

        /// <summary>
        /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
        /// Cosmos i18n code: i18n_country_faguo
        /// </summary>
        [I18NIdentityCode(Europe.France.I18N_IDENTITY_CODE)]
        FR,

        /// <summary>
        /// Gabon
        /// </summary>
        [Alpha2Code("GA")]
        [Alpha3Code("GAB")]
        [CountryOrRegionName("Gabon")]
        [UNCode("266")]
        GA,

        /// <summary>
        /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
        /// Cosmos i18n code: i18n_country_yingguo
        /// </summary>
        [I18NIdentityCode(Europe.UnitedKingdom.I18N_IDENTITY_CODE)]
        GB,

        /// <summary>
        /// Grenada
        /// </summary>
        [Alpha2Code("GD")]
        [Alpha3Code("GRD")]
        [CountryOrRegionName("Grenada")]
        [UNCode("308")]
        GD,

        /// <summary>
        /// Georgia
        /// </summary>
        [Alpha2Code("GE")]
        [Alpha3Code("GEO")]
        [CountryOrRegionName("Georgia")]
        [UNCode("268")]
        GE,

        /// <summary>
        /// French Guiana
        /// </summary>
        [Alpha2Code("GF")]
        [Alpha3Code("GUF")]
        [CountryOrRegionName("French Guiana")]
        [UNCode("254")]
        GF,

        /// <summary>
        /// Guernsey
        /// </summary>
        [Alpha2Code("GG")]
        [Alpha3Code("GGY")]
        [CountryOrRegionName("Guernsey")]
        [UNCode("831")]
        GG,

        /// <summary>
        /// Ghana
        /// </summary>
        [Alpha2Code("GH")]
        [Alpha3Code("GHA")]
        [CountryOrRegionName("Ghana")]
        [UNCode("288")]
        GH,

        /// <summary>
        /// Gibraltar
        /// </summary>
        [Alpha2Code("GI")]
        [Alpha3Code("GIB")]
        [CountryOrRegionName("Gibraltar")]
        [UNCode("292")]
        GI,

        /// <summary>
        /// Greenland
        /// </summary>
        [Alpha2Code("GL")]
        [Alpha3Code("GRL")]
        [CountryOrRegionName("Greenland")]
        [UNCode("304")]
        GL,

        /// <summary>
        /// Gambia
        /// </summary>
        [Alpha2Code("GM")]
        [Alpha3Code("GMB")]
        [CountryOrRegionName("Gambia")]
        [UNCode("270")]
        GM,

        /// <summary>
        /// Guinea
        /// </summary>
        [Alpha2Code("GN")]
        [Alpha3Code("GIN")]
        [CountryOrRegionName("Guinea")]
        [UNCode("324")]
        GN,

        /// <summary>
        /// Guadeloupe
        /// </summary>
        [Alpha2Code("GP")]
        [Alpha3Code("GLP")]
        [CountryOrRegionName("Guadeloupe")]
        [UNCode("312")]
        GP,

        /// <summary>
        /// Equatorial Guinea
        /// </summary>
        [Alpha2Code("GQ")]
        [Alpha3Code("GNQ")]
        [CountryOrRegionName("Equatorial Guinea")]
        [UNCode("226")]
        GQ,

        /// <summary>
        /// Greece
        /// </summary>
        [Alpha2Code("GR")]
        [Alpha3Code("GRC")]
        [CountryOrRegionName("Greece")]
        [UNCode("300")]
        GR,

        /// <summary>
        /// South Georgia and the South Sandwich Islands
        /// </summary>
        [Alpha2Code("GS")]
        [Alpha3Code("SGS")]
        [CountryOrRegionName("South Georgia and the South Sandwich Islands")]
        [UNCode("239")]
        GS,

        /// <summary>
        /// Guatemala
        /// </summary>
        [Alpha2Code("GT")]
        [Alpha3Code("GTM")]
        [CountryOrRegionName("Guatemala")]
        [UNCode("320")]
        GT,

        /// <summary>
        /// Guam
        /// </summary>
        [Alpha2Code("GU")]
        [Alpha3Code("GUM")]
        [CountryOrRegionName("Guam")]
        [UNCode("316")]
        GU,

        /// <summary>
        /// Guinea-Bissau
        /// </summary>
        [Alpha2Code("GW")]
        [Alpha3Code("GNB")]
        [CountryOrRegionName("Guinea-Bissau")]
        [UNCode("624")]
        GW,

        /// <summary>
        /// Guyana
        /// </summary>
        [Alpha2Code("GY")]
        [Alpha3Code("GUY")]
        [CountryOrRegionName("Guyana")]
        [UNCode("328")]
        GY,

        /// <summary>
        /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
        /// 香港，中华人民共和国的一部分 <br />
        /// Hong Kong, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhxianggang
        /// </summary>
        [I18NIdentityCode(Asia.HongKong.I18N_IDENTITY_CODE)]
        HK,

        /// <summary>
        /// Heard Island and McDonald Islands
        /// </summary>
        [Alpha2Code("HM")]
        [Alpha3Code("HMD")]
        [CountryOrRegionName("Heard Island and McDonald Islands")]
        [UNCode("334")]
        HM,

        /// <summary>
        /// Honduras
        /// </summary>
        [Alpha2Code("HN")]
        [Alpha3Code("HND")]
        [CountryOrRegionName("Honduras")]
        [UNCode("340")]
        HN,

        /// <summary>
        /// Croatia
        /// </summary>
        [Alpha2Code("HR")]
        [Alpha3Code("HRV")]
        [CountryOrRegionName("Croatia")]
        [UNCode("191")]
        HR,

        /// <summary>
        /// Haiti
        /// </summary>
        [Alpha2Code("HT")]
        [Alpha3Code("HTI")]
        [CountryOrRegionName("Haiti")]
        [UNCode("332")]
        HT,

        /// <summary>
        /// Hungary
        /// </summary>
        [Alpha2Code("HU")]
        [Alpha3Code("HUN")]
        [CountryOrRegionName("Hungary")]
        [UNCode("348")]
        HU,

        /// <summary>
        /// Indonesia
        /// </summary>
        [Alpha2Code("ID")]
        [Alpha3Code("IDN")]
        [CountryOrRegionName("Indonesia")]
        [UNCode("360")]
        ID,

        /// <summary>
        /// Ireland
        /// </summary>
        [Alpha2Code("IE")]
        [Alpha3Code("IRL")]
        [CountryOrRegionName("Ireland")]
        [UNCode("372")]
        IE,

        /// <summary>
        /// Israel
        /// </summary>
        [Alpha2Code("IL")]
        [Alpha3Code("ISR")]
        [CountryOrRegionName("Israel")]
        [UNCode("376")]
        IL,

        /// <summary>
        /// Isle of Man
        /// </summary>
        [Alpha2Code("IM")]
        [Alpha3Code("IMN")]
        [CountryOrRegionName("Isle of Man")]
        [UNCode("833")]
        IM,

        /// <summary>
        /// India
        /// </summary>
        [Alpha2Code("IN")]
        [Alpha3Code("IND")]
        [CountryOrRegionName("India")]
        [UNCode("356")]
        IN,

        /// <summary>
        /// British Indian Ocean Territory
        /// </summary>
        [Alpha2Code("IO")]
        [Alpha3Code("IOT")]
        [CountryOrRegionName("British Indian Ocean Territory")]
        [UNCode("086")]
        IO,

        /// <summary>
        /// Iraq
        /// </summary>
        [Alpha2Code("IQ")]
        [Alpha3Code("IRQ")]
        [CountryOrRegionName("Iraq")]
        [UNCode("368")]
        IQ,

        /// <summary>
        /// Iran (Islamic Republic of)
        /// </summary>
        [Alpha2Code("IR")]
        [Alpha3Code("IRN")]
        [CountryOrRegionName("Iran (Islamic Republic of)")]
        [UNCode("364")]
        IR,

        /// <summary>
        /// Iceland
        /// </summary>
        [Alpha2Code("IS")]
        [Alpha3Code("ISL")]
        [CountryOrRegionName("Iceland")]
        [UNCode("352")]
        IS,

        /// <summary>
        /// Italy
        /// </summary>
        [Alpha2Code("IT")]
        [Alpha3Code("ITA")]
        [CountryOrRegionName("Italy")]
        [UNCode("380")]
        IT,

        /// <summary>
        /// Jersey
        /// </summary>
        [Alpha2Code("JE")]
        [Alpha3Code("JEY")]
        [CountryOrRegionName("Jersey")]
        [UNCode("832")]
        JE,

        /// <summary>
        /// Jamaica
        /// </summary>
        [Alpha2Code("JM")]
        [Alpha3Code("JAM")]
        [CountryOrRegionName("Jamaica")]
        [UNCode("388")]
        JM,

        /// <summary>
        /// Jordan
        /// </summary>
        [Alpha2Code("JO")]
        [Alpha3Code("JOR")]
        [CountryOrRegionName("Jordan")]
        [UNCode("400")]
        JO,
        
        /// <summary>
        /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
        /// Cosmos i18n code: i18n_country_riben
        /// </summary>
        [I18NIdentityCode(Asia.Japan.I18N_IDENTITY_CODE)]
        JP,

        /// <summary>
        /// Kenya
        /// </summary>
        [Alpha2Code("KE")]
        [Alpha3Code("KEN")]
        [CountryOrRegionName("Kenya")]
        [UNCode("404")]
        KE,

        /// <summary>
        /// Kyrgyzstan
        /// </summary>
        [Alpha2Code("KG")]
        [Alpha3Code("KGZ")]
        [CountryOrRegionName("Kyrgyzstan")]
        [UNCode("417")]
        KG,

        /// <summary>
        /// Cambodia
        /// </summary>
        [Alpha2Code("KH")]
        [Alpha3Code("KHM")]
        [CountryOrRegionName("Cambodia")]
        [UNCode("116")]
        KH,

        /// <summary>
        /// Kiribati
        /// </summary>
        [Alpha2Code("KI")]
        [Alpha3Code("KIR")]
        [CountryOrRegionName("Kiribati")]
        [UNCode("296")]
        KI,

        /// <summary>
        /// Comoros
        /// </summary>
        [Alpha2Code("KM")]
        [Alpha3Code("COM")]
        [CountryOrRegionName("Comoros")]
        [UNCode("174")]
        KM,

        /// <summary>
        /// Saint Kitts and Nevis
        /// </summary>
        [Alpha2Code("KN")]
        [Alpha3Code("KNA")]
        [CountryOrRegionName("Saint Kitts and Nevis")]
        [UNCode("659")]
        KN,

        /// <summary>
        /// North Korea
        /// </summary>
        [Alpha2Code("KP")]
        [Alpha3Code("PRK")]
        [CountryOrRegionName("North Korea")]
        [UNCode("408")]
        KP,

        /// <summary>
        /// South Korea
        /// </summary>
        [Alpha2Code("KR")]
        [Alpha3Code("KOR")]
        [CountryOrRegionName("South Korea")]
        [UNCode("410")]
        KR,

        /// <summary>
        /// Kuwait
        /// </summary>
        [Alpha2Code("KW")]
        [Alpha3Code("KWT")]
        [CountryOrRegionName("Kuwait")]
        [UNCode("414")]
        KW,

        /// <summary>
        /// Cayman Islands
        /// </summary>
        [Alpha2Code("KY")]
        [Alpha3Code("CYM")]
        [CountryOrRegionName("Cayman Islands")]
        [UNCode("136")]
        KY,

        /// <summary>
        /// Kazakhstan
        /// </summary>
        [Alpha2Code("KZ")]
        [Alpha3Code("KAZ")]
        [CountryOrRegionName("Kazakhstan")]
        [UNCode("398")]
        KZ,

        /// <summary>
        /// Laos
        /// </summary>
        [Alpha2Code("LA")]
        [Alpha3Code("LAO")]
        [CountryOrRegionName("Lao PDR")]
        [UNCode("418")]
        LA,

        /// <summary>
        /// Lebanon
        /// </summary>
        [Alpha2Code("LB")]
        [Alpha3Code("LBN")]
        [CountryOrRegionName("Lebanon")]
        [UNCode("422")]
        LB,

        /// <summary>
        /// Saint Lucia
        /// </summary>
        [Alpha2Code("LC")]
        [Alpha3Code("LCA")]
        [CountryOrRegionName("Saint Lucia")]
        [UNCode("662")]
        LC,

        /// <summary>
        /// Liechtenstein
        /// </summary>
        [Alpha2Code("LI")]
        [Alpha3Code("LIE")]
        [CountryOrRegionName("Liechtenstein")]
        [UNCode("438")]
        LI,

        /// <summary>
        /// Sri Lanka
        /// </summary>
        [Alpha2Code("LK")]
        [Alpha3Code("LKA")]
        [CountryOrRegionName("Sri Lanka")]
        [UNCode("144")]
        LK,

        /// <summary>
        /// Liberia
        /// </summary>
        [Alpha2Code("LR")]
        [Alpha3Code("LBR")]
        [CountryOrRegionName("Liberia")]
        [UNCode("430")]
        LR,

        /// <summary>
        /// Lesotho
        /// </summary>
        [Alpha2Code("LS")]
        [Alpha3Code("LSO")]
        [CountryOrRegionName("Lesotho")]
        [UNCode("426")]
        LS,

        /// <summary>
        /// Lithuania
        /// </summary>
        [Alpha2Code("LT")]
        [Alpha3Code("LTU")]
        [CountryOrRegionName("Lithuania")]
        [UNCode("440")]
        LT,

        /// <summary>
        /// Luxembourg
        /// </summary>
        [Alpha2Code("LU")]
        [Alpha3Code("LUX")]
        [CountryOrRegionName("Luxembourg")]
        [UNCode("442")]
        LU,

        /// <summary>
        /// Latvia
        /// </summary>
        [Alpha2Code("LV")]
        [Alpha3Code("LVA")]
        [CountryOrRegionName("Latvia")]
        [UNCode("428")]
        LV,

        /// <summary>
        /// Libya
        /// </summary>
        [Alpha2Code("LY")]
        [Alpha3Code("LBY")]
        [CountryOrRegionName("Libya")]
        [UNCode("434")]
        LY,

        /// <summary>
        /// Morocco
        /// </summary>
        [Alpha2Code("MA")]
        [Alpha3Code("MAR")]
        [CountryOrRegionName("Morocco")]
        [UNCode("504")]
        MA,

        /// <summary>
        /// Monaco
        /// </summary>
        [Alpha2Code("MC")]
        [Alpha3Code("MCO")]
        [CountryOrRegionName("Monaco")]
        [UNCode("492")]
        MC,

        /// <summary>
        /// Moldova (Republic of)
        /// </summary>
        [Alpha2Code("MD")]
        [Alpha3Code("MDA")]
        [CountryOrRegionName("Moldova (Republic of)")]
        [UNCode("498")]
        MD,

        /// <summary>
        /// Montenegro
        /// </summary>
        [Alpha2Code("ME")]
        [Alpha3Code("MNE")]
        [CountryOrRegionName("Montenegro")]
        [UNCode("499")]
        ME,

        /// <summary>
        /// Saint Martin (French part)
        /// </summary>
        [Alpha2Code("MF")]
        [Alpha3Code("MAF")]
        [CountryOrRegionName("Saint Martin (French part)")]
        [UNCode("663")]
        MF,

        /// <summary>
        /// Madagascar
        /// </summary>
        [Alpha2Code("MG")]
        [Alpha3Code("MDG")]
        [CountryOrRegionName("Madagascar")]
        [UNCode("450")]
        MG,

        /// <summary>
        /// Marshall Islands
        /// </summary>
        [Alpha2Code("MH")]
        [Alpha3Code("MHL")]
        [CountryOrRegionName("Marshall Islands")]
        [UNCode("584")]
        MH,

        /// <summary>
        /// Macedonia (the former Yugoslav Republic of)
        /// </summary>
        [Alpha2Code("MK")]
        [Alpha3Code("MKD")]
        [CountryOrRegionName("Macedonia (the former Yugoslav Republic of)")]
        [UNCode("807")]
        MK,

        /// <summary>
        /// Mali
        /// </summary>
        [Alpha2Code("ML")]
        [Alpha3Code("MLI")]
        [CountryOrRegionName("Mali")]
        [UNCode("466")]
        ML,

        /// <summary>
        /// Myanmar
        /// </summary>
        [Alpha2Code("MM")]
        [Alpha3Code("MMR")]
        [CountryOrRegionName("Myanmar")]
        [UNCode("104")]
        MM,

        /// <summary>
        /// Mongolia
        /// </summary>
        [Alpha2Code("MN")]
        [Alpha3Code("MNG")]
        [CountryOrRegionName("Mongolia")]
        [UNCode("496")]
        MN,

        /// <summary>
        /// 澳门（Macao, SAR China，亚洲，HK，HKG，344），中华人民共和国澳门特别行政区 <br />
        /// 澳门，中华人民共和国的一部分 <br />
        /// Macao, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhaomen
        /// </summary>
        [I18NIdentityCode(Asia.Macao.I18N_IDENTITY_CODE)]
        MO,

        /// <summary>
        /// Northern Mariana Islands
        /// </summary>
        [Alpha2Code("MP")]
        [Alpha3Code("MNP")]
        [CountryOrRegionName("Northern Mariana Islands")]
        [UNCode("580")]
        MP,

        /// <summary>
        /// Martinique
        /// </summary>
        [Alpha2Code("MQ")]
        [Alpha3Code("MTQ")]
        [CountryOrRegionName("Martinique")]
        [UNCode("474")]
        MQ,

        /// <summary>
        /// Mauritania
        /// </summary>
        [Alpha2Code("MR")]
        [Alpha3Code("MRT")]
        [CountryOrRegionName("Mauritania")]
        [UNCode("478")]
        MR,

        /// <summary>
        /// Montserrat
        /// </summary>
        [Alpha2Code("MS")]
        [Alpha3Code("MSR")]
        [CountryOrRegionName("Montserrat")]
        [UNCode("500")]
        MS,

        /// <summary>
        /// Malta
        /// </summary>
        [Alpha2Code("MT")]
        [Alpha3Code("MLT")]
        [CountryOrRegionName("Malta")]
        [UNCode("470")]
        MT,

        /// <summary>
        /// Mauritius
        /// </summary>
        [Alpha2Code("MU")]
        [Alpha3Code("MUS")]
        [CountryOrRegionName("Mauritius")]
        [UNCode("480")]
        MU,

        /// <summary>
        /// Maldives
        /// </summary>
        [Alpha2Code("MV")]
        [Alpha3Code("MDV")]
        [CountryOrRegionName("Maldives")]
        [UNCode("462")]
        MV,

        /// <summary>
        /// Malawi
        /// </summary>
        [Alpha2Code("MW")]
        [Alpha3Code("MWI")]
        [CountryOrRegionName("Malawi")]
        [UNCode("454")]
        MW,

        /// <summary>
        /// Mexico
        /// </summary>
        [Alpha2Code("MX")]
        [Alpha3Code("MEX")]
        [CountryOrRegionName("Mexico")]
        [UNCode("484")]
        MX,

        /// <summary>
        /// Malaysia
        /// </summary>
        [Alpha3Code("MYS")]
        [CountryOrRegionName("Malaysia")]
        [UNCode("458")]
        MY,

        /// <summary>
        /// Mozambique
        /// </summary>
        [Alpha2Code("MZ")]
        [Alpha3Code("MOZ")]
        [CountryOrRegionName("Mozambique")]
        [UNCode("508")]
        MZ,

        /// <summary>
        /// Namibia
        /// </summary>
        [Alpha2Code("NA")]
        [Alpha3Code("NAM")]
        [CountryOrRegionName("Namibia")]
        [UNCode("516")]
        NA,

        /// <summary>
        /// New Caledonia
        /// </summary>
        [Alpha2Code("NC")]
        [Alpha3Code("NCL")]
        [CountryOrRegionName("New Caledonia")]
        [UNCode("540")]
        NC,

        /// <summary>
        /// Niger
        /// </summary>
        [Alpha2Code("NE")]
        [Alpha3Code("NER")]
        [CountryOrRegionName("Niger")]
        [UNCode("562")]
        NE,

        /// <summary>
        /// Norfolk Island
        /// </summary>
        [Alpha2Code("NF")]
        [Alpha3Code("NFK")]
        [CountryOrRegionName("Norfolk Island")]
        [UNCode("574")]
        NF,

        /// <summary>
        /// Nigeria
        /// </summary>
        [Alpha2Code("NG")]
        [Alpha3Code("NGA")]
        [CountryOrRegionName("Niger")]
        [UNCode("566")]
        NG,

        /// <summary>
        /// Nicaragua
        /// </summary>
        [Alpha2Code("NI")]
        [Alpha3Code("NIC")]
        [CountryOrRegionName("Nicaragua")]
        [UNCode("558")]
        NI,

        /// <summary>
        /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
        /// Cosmos i18n code: i18n_country_helan
        /// </summary>
        [I18NIdentityCode(Europe.Netherlands.I18N_IDENTITY_CODE)]
        NL,

        /// <summary>
        /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
        /// Cosmos i18n code: i18n_country_nuowei
        /// </summary>
        [I18NIdentityCode(Europe.Norway.I18N_IDENTITY_CODE)]
        NO,

        /// <summary>
        /// Nepal
        /// </summary>
        [Alpha2Code("NP")]
        [Alpha3Code("NPL")]
        [CountryOrRegionName("Nepal")]
        [UNCode("524")]
        NP,

        /// <summary>
        /// Nauru
        /// </summary>
        [Alpha2Code("NR")]
        [Alpha3Code("NRU")]
        [CountryOrRegionName("Nauru")]
        [UNCode("520")]
        NR,

        /// <summary>
        /// Niue
        /// </summary>
        [Alpha2Code("NU")]
        [Alpha3Code("NIU")]
        [CountryOrRegionName("Niue")]
        [UNCode("570")]
        NU,

        /// <summary>
        /// New Zealand
        /// </summary>
        [Alpha2Code("NZ")]
        [Alpha3Code("NZL")]
        [CountryOrRegionName("New Zealand")]
        [UNCode("554")]
        NZ,

        /// <summary>
        /// Oman
        /// </summary>
        [Alpha2Code("OM")]
        [Alpha3Code("OMN")]
        [CountryOrRegionName("Oman")]
        [UNCode("512")]
        OM,

        /// <summary>
        /// Panama
        /// </summary>
        [Alpha2Code("PA")]
        [Alpha3Code("PAN")]
        [CountryOrRegionName("Panama")]
        [UNCode("591")]
        PA,

        /// <summary>
        /// Peru
        /// </summary>
        [Alpha2Code("PE")]
        [Alpha3Code("PER")]
        [CountryOrRegionName("Peru")]
        [UNCode("604")]
        PE,

        /// <summary>
        /// French Polynesia
        /// </summary>
        [Alpha2Code("PF")]
        [Alpha3Code("PYF")]
        [CountryOrRegionName("French Polynesia")]
        [UNCode("258")]
        PF,

        /// <summary>
        /// Papua New Guinea
        /// </summary>
        [Alpha2Code("PG")]
        [Alpha3Code("PNG")]
        [CountryOrRegionName("Papua New Guinea")]
        [UNCode("598")]
        PG,

        /// <summary>
        /// Philippines
        /// </summary>
        [Alpha2Code("PH")]
        [Alpha3Code("PHL")]
        [CountryOrRegionName("Philippines")]
        [UNCode("608")]
        PH,

        /// <summary>
        /// Pakistan
        /// </summary>
        [Alpha2Code("PK")]
        [Alpha3Code("PAK")]
        [CountryOrRegionName("Pakistan")]
        [UNCode("586")]
        PK,

        /// <summary>
        /// Poland
        /// </summary>
        [Alpha2Code("PL")]
        [Alpha3Code("POL")]
        [CountryOrRegionName("Poland")]
        [UNCode("616")]
        PL,

        /// <summary>
        /// Saint Pierre and Miquelon
        /// </summary>
        [Alpha2Code("PM")]
        [Alpha3Code("SPM")]
        [CountryOrRegionName("Saint Pierre and Miquelon")]
        [UNCode("666")]
        PM,

        /// <summary>
        /// Pitcairn
        /// </summary>
        [Alpha2Code("PN")]
        [Alpha3Code("PCN")]
        [CountryOrRegionName("Pitcairn")]
        [UNCode("612")]
        PN,

        /// <summary>
        /// Puerto Rico
        /// </summary>
        [Alpha2Code("PR")]
        [Alpha3Code("PRI")]
        [CountryOrRegionName("Puerto Rico")]
        [UNCode("630")]
        PR,

        /// <summary>
        /// Palestine, State of
        /// </summary>
        [Alpha2Code("PS")]
        [Alpha3Code("PSE")]
        [CountryOrRegionName("Palestine, State of")]
        [UNCode("275")]
        PS,

        /// <summary>
        /// Portugal
        /// </summary>
        [Alpha2Code("PT")]
        [Alpha3Code("PRT")]
        [CountryOrRegionName("Portugal")]
        [UNCode("620")]
        PT,

        /// <summary>
        /// Palau
        /// </summary>
        [Alpha2Code("PW")]
        [Alpha3Code("PLW")]
        [CountryOrRegionName("Palau")]
        [UNCode("585")]
        PW,

        /// <summary>
        /// Paraguay
        /// </summary>
        [Alpha2Code("PY")]
        [Alpha3Code("PRY")]
        [CountryOrRegionName("Paraguay")]
        [UNCode("600")]
        PY,

        /// <summary>
        /// Qatar
        /// </summary>
        [Alpha2Code("QA")]
        [Alpha3Code("QAT")]
        [CountryOrRegionName("Qatar")]
        [UNCode("634")]
        QA,

        /// <summary>
        /// Réunion
        /// </summary>
        [Alpha2Code("RE")]
        [Alpha3Code("REU")]
        [CountryOrRegionName("Réunion")]
        [UNCode("638")]
        RE,

        /// <summary>
        /// Romania
        /// </summary>
        [Alpha2Code("RO")]
        [Alpha3Code("ROU")]
        [CountryOrRegionName("Romania")]
        [UNCode("642")]
        RO,

        /// <summary>
        /// Serbia
        /// </summary>
        [Alpha2Code("RS")]
        [Alpha3Code("SRB")]
        [CountryOrRegionName("Serbia")]
        [UNCode("688")]
        RS,

        /// <summary>
        /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
        /// Cosmos i18n code: i18n_country_eluosi
        /// </summary>
        [I18NIdentityCode(Europe.Russia.I18N_IDENTITY_CODE)]
        RU,

        /// <summary>
        /// Rwanda
        /// </summary>
        [Alpha2Code("RW")]
        [Alpha3Code("RWA")]
        [CountryOrRegionName("Rwanda")]
        [UNCode("646")]
        RW,

        /// <summary>
        /// Saudi Arabia
        /// </summary>
        [Alpha2Code("SA")]
        [Alpha3Code("SAU")]
        [CountryOrRegionName("Saudi Arabia")]
        [UNCode("682")]
        SA,

        /// <summary>
        /// Solomon Islands
        /// </summary>
        [Alpha2Code("SB")]
        [Alpha3Code("SLB")]
        [CountryOrRegionName("Solomon Islands")]
        [UNCode("090")]
        SB,

        /// <summary>
        /// Seychelles
        /// </summary>
        [Alpha2Code("SC")]
        [Alpha3Code("SYC")]
        [CountryOrRegionName("Seychelles")]
        [UNCode("690")]
        SC,

        /// <summary>
        /// Sudan
        /// </summary>
        [Alpha2Code("SD")]
        [Alpha3Code("SDN")]
        [CountryOrRegionName("Sudan")]
        [UNCode("736")]
        SD,

        /// <summary>
        /// Sweden
        /// </summary>
        [Alpha2Code("SE")]
        [Alpha3Code("SWE")]
        [CountryOrRegionName("Sweden")]
        [UNCode("752")]
        SE,

        /// <summary>
        /// Singapore
        /// </summary>
        [Alpha2Code("SG")]
        [Alpha3Code("SGP")]
        [CountryOrRegionName("Singapore")]
        [UNCode("702")]
        SG,

        /// <summary>
        /// Saint Helena, Ascension and Tristan da Cunha
        /// </summary>
        [Alpha2Code("SH")]
        [Alpha3Code("SHN")]
        [CountryOrRegionName("Saint Helena, Ascension and Tristan da Cunha")]
        [UNCode("654")]
        SH,

        /// <summary>
        /// Slovenia
        /// </summary>
        [Alpha2Code("SI")]
        [Alpha3Code("SVN")]
        [CountryOrRegionName("Slovenia")]
        [UNCode("705")]
        SI,

        /// <summary>
        /// Svalbard and Jan Mayen
        /// </summary>
        [Alpha2Code("SJ")]
        [Alpha3Code("SJM")]
        [CountryOrRegionName("Svalbard and Jan Mayen")]
        [UNCode("744")]
        SJ,

        /// <summary>
        /// Slovakia
        /// </summary>
        [Alpha2Code("SK")]
        [Alpha3Code("SVK")]
        [CountryOrRegionName("Slovakia")]
        [UNCode("703")]
        SK,

        /// <summary>
        /// Sierra Leone
        /// </summary>
        [Alpha2Code("SL")]
        [Alpha3Code("SLE")]
        [CountryOrRegionName("Sierra Leone")]
        [UNCode("694")]
        SL,

        /// <summary>
        /// San Marino
        /// </summary>
        [Alpha2Code("SM")]
        [Alpha3Code("SMR")]
        [CountryOrRegionName("San Marino")]
        [UNCode("674")]
        SM,

        /// <summary>
        /// Senegal
        /// </summary>
        [Alpha2Code("SN")]
        [Alpha3Code("SEN")]
        [CountryOrRegionName("Senegal")]
        [UNCode("686")]
        SN,

        /// <summary>
        /// Somalia
        /// </summary>
        [Alpha2Code("SO")]
        [Alpha3Code("SOM")]
        [CountryOrRegionName("Somalia")]
        [UNCode("706")]
        SO,

        /// <summary>
        /// Suriname
        /// </summary>
        [Alpha2Code("SR")]
        [Alpha3Code("SUR")]
        [CountryOrRegionName("Suriname")]
        [UNCode("740")]
        SR,

        /// <summary>
        /// South Sudan
        /// </summary>
        [Alpha2Code("SS")]
        [Alpha3Code("SSD")]
        [CountryOrRegionName("South Sudan")]
        [UNCode("728")]
        SS,

        /// <summary>
        /// Sao Tome and Principe
        /// </summary>
        [Alpha2Code("ST")]
        [Alpha3Code("STP")]
        [CountryOrRegionName("Sao Tome and Principe")]
        [UNCode("678")]
        ST,

        /// <summary>
        /// El Salvador
        /// </summary>
        [Alpha2Code("SV")]
        [Alpha3Code("SLV")]
        [CountryOrRegionName("El Salvador")]
        [UNCode("222")]
        SV,

        /// <summary>
        /// Sint Maarten (Dutch part)
        /// </summary>
        [Alpha2Code("SX")]
        [Alpha3Code("SXM")]
        [CountryOrRegionName("Sint Maarten (Dutch part)")]
        [UNCode("534")]
        SX,

        /// <summary>
        /// Syrian Arab Republic
        /// </summary>
        [Alpha2Code("SY")]
        [Alpha3Code("SYR")]
        [CountryOrRegionName("Syrian Arab Republic")]
        [UNCode("760")]
        SY,

        /// <summary>
        /// Swaziland
        /// </summary>
        [Alpha2Code("SZ")]
        [Alpha3Code("SWZ")]
        [CountryOrRegionName("Swaziland")]
        [UNCode("748")]
        SZ,

        /// <summary>
        /// Turks and Caicos Islands
        /// </summary>
        [Alpha2Code("TC")]
        [Alpha3Code("TCA")]
        [CountryOrRegionName("Turks and Caicos Islands")]
        [UNCode("796")]
        TC,

        /// <summary>
        /// Chad
        /// </summary>
        [Alpha2Code("TD")]
        [Alpha3Code("TCD")]
        [CountryOrRegionName("Chad")]
        [UNCode("148")]
        TD,

        /// <summary>
        /// French Southern Territories
        /// </summary>
        [Alpha2Code("TF")]
        [Alpha3Code("ATF")]
        [CountryOrRegionName("French Southern Territories")]
        [UNCode("260")]
        TF,

        /// <summary>
        /// Togo
        /// </summary>
        [Alpha2Code("TG")]
        [Alpha3Code("TGO")]
        [CountryOrRegionName("Togo")]
        [UNCode("768")]
        TG,

        /// <summary>
        /// Thailand
        /// </summary>
        [Alpha2Code("TH")]
        [Alpha3Code("THA")]
        [CountryOrRegionName("Thailand")]
        [UNCode("764")]
        TH,

        /// <summary>
        /// Tajikistan
        /// </summary>
        [Alpha2Code("TJ")]
        [Alpha3Code("TJK")]
        [CountryOrRegionName("Tajikistan")]
        [UNCode("762")]
        TJ,

        /// <summary>
        /// Tokelau
        /// </summary>
        [Alpha2Code("TK")]
        [Alpha3Code("TKL")]
        [CountryOrRegionName("Tokelau")]
        [UNCode("772")]
        TK,

        /// <summary>
        /// East Timor
        /// </summary>
        [Alpha2Code("TL")]
        [Alpha3Code("TLS")]
        [CountryOrRegionName("East Timor")]
        [UNCode("626")]
        TL,

        /// <summary>
        /// Turkmenistan
        /// </summary>
        [Alpha2Code("TM")]
        [Alpha3Code("TKM")]
        [CountryOrRegionName("Turkmenistan")]
        [UNCode("795")]
        TM,

        /// <summary>
        /// Tunisia
        /// </summary>
        [Alpha2Code("TN")]
        [Alpha3Code("TUN")]
        [CountryOrRegionName("Tunisia")]
        [UNCode("788")]
        TN,

        /// <summary>
        /// Tonga
        /// </summary>
        [Alpha2Code("TO")]
        [Alpha3Code("TON")]
        [CountryOrRegionName("Tonga")]
        [UNCode("776")]
        TO,

        /// <summary>
        /// Turkey
        /// </summary>
        [Alpha2Code("TR")]
        [Alpha3Code("TUR")]
        [CountryOrRegionName("Turkey")]
        [UNCode("792")]
        TR,

        /// <summary>
        /// Trinidad and Tobago
        /// </summary>
        [Alpha2Code("TT")]
        [Alpha3Code("TTO")]
        [CountryOrRegionName("Trinidad and Tobago")]
        [UNCode("780")]
        TT,

        /// <summary>
        /// Tuvalu
        /// </summary>
        [Alpha2Code("TV")]
        [Alpha3Code("TUV")]
        [CountryOrRegionName("Tuvalu")]
        [UNCode("798")]
        TV,

        /// <summary>
        /// 台湾（Macao, SAR China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
        /// 台湾，中华人民共和国的一部分 <br />
        /// Taiwan, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhtaiwan
        /// </summary>
        [I18NIdentityCode(Asia.Taiwan.I18N_IDENTITY_CODE)]
        TW,

        /// <summary>
        /// Tanzania, United Republic of
        /// </summary>
        [Alpha2Code("TZ")]
        [Alpha3Code("TZA")]
        [CountryOrRegionName("Tanzania, United Republic of")]
        [UNCode("834")]
        TZ,

        /// <summary>
        /// Ukraine
        /// </summary>
        [Alpha2Code("UA")]
        [Alpha3Code("UKR")]
        [CountryOrRegionName("Ukraine")]
        [UNCode("804")]
        UA,

        /// <summary>
        /// Uganda
        /// </summary>
        [Alpha2Code("UG")]
        [Alpha3Code("UGA")]
        [CountryOrRegionName("Uganda")]
        [UNCode("800")]
        UG,

        /// <summary>
        /// United States Minor Outlying Islands
        /// </summary>
        [Alpha2Code("UM")]
        [Alpha3Code("UMI")]
        [CountryOrRegionName("United States Minor Outlying Islands")]
        [UNCode("581")]
        UM,

        /// <summary>
        /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
        /// Cosmos i18n code: i18n_country_meiguo
        /// </summary>
        [I18NIdentityCode(NorthAmerica.UnitedStates.I18N_IDENTITY_CODE)]
        US,

        /// <summary>
        /// Uruguay
        /// </summary>
        [Alpha2Code("UY")]
        [Alpha3Code("URY")]
        [CountryOrRegionName("Uruguay")]
        [UNCode("858")]
        UY,

        /// <summary>
        /// Uzbekistan
        /// </summary>
        [Alpha2Code("UZ")]
        [Alpha3Code("UZB")]
        [CountryOrRegionName("Uzbekistan")]
        [UNCode("860")]
        UZ,

        /// <summary>
        /// Vatican City Holy See
        /// </summary>
        [Alpha2Code("VA")]
        [Alpha3Code("VAT")]
        [CountryOrRegionName("Holy See (Vatican City State)")]
        [UNCode("336")]
        VA,

        /// <summary>
        /// Saint Vincent and the Grenadines
        /// </summary>
        [Alpha2Code("VC")]
        [Alpha3Code("VCT")]
        [CountryOrRegionName("Saint Vincent and the Grenadines")]
        [UNCode("670")]
        VC,

        /// <summary>
        /// Venezuela (Bolivarian Republic of)
        /// </summary>
        [Alpha2Code("VE")]
        [Alpha3Code("VEN")]
        [CountryOrRegionName("Venezuela (Bolivarian Republic)")]
        [UNCode("862")]
        VE,

        /// <summary>
        /// Virgin Islands (British)
        /// </summary>
        [Alpha2Code("VG")]
        [Alpha3Code("VGB")]
        [CountryOrRegionName("Virgin Islands (British)")]
        [UNCode("092")]
        VG,

        /// <summary>
        /// Virgin Islands (U.S.)
        /// </summary>
        [Alpha2Code("VI")]
        [Alpha3Code("VIR")]
        [CountryOrRegionName("Virgin Islands (U.S.)")]
        [UNCode("850")]
        VI,

        /// <summary>
        /// Viet Nam
        /// </summary>
        [Alpha2Code("VN")]
        [Alpha3Code("VNM")]
        [CountryOrRegionName("Viet Nam")]
        [UNCode("704")]
        VN,

        /// <summary>
        /// Vanuatu
        /// </summary>
        [Alpha2Code("VU")]
        [Alpha3Code("VUT")]
        [CountryOrRegionName("Vanuatu")]
        [UNCode("548")]
        VU,

        /// <summary>
        /// Wallis and Futuna
        /// </summary>
        [Alpha2Code("WF")]
        [Alpha3Code("WLF")]
        [CountryOrRegionName("Wallis and Futuna")]
        [UNCode("876")]
        WF,

        /// <summary>
        /// Samoa
        /// </summary>
        [Alpha2Code("WS")]
        [Alpha3Code("WSM")]
        [CountryOrRegionName("Samoa")]
        [UNCode("882")]
        WS,

        /// <summary>
        /// Kosovo
        /// </summary>
        [Alpha2Code("XK")]
        [Alpha3Code("XKX")]
        [CountryOrRegionName("Kosovo")]
        [UNCode("838")]
        XK,

        /// <summary>
        /// Yemen
        /// </summary>
        [Alpha2Code("YE")]
        [Alpha3Code("YEM")]
        [CountryOrRegionName("Yemen")]
        [UNCode("887")]
        YE,

        /// <summary>
        /// 马奥霍（Territorial Collectivity of Mayotte ，非洲，AF，AFG，004），马约特岛 <br />
        /// Cosmos i18n code: i18n_country_mayuete
        /// </summary>
        [I18NIdentityCode(Africa.Mayotte.I18N_IDENTITY_CODE)]
        YT,

        /// <summary>
        /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
        /// Cosmos i18n code: i18n_country_nanfei
        /// </summary>
        [I18NIdentityCode(Africa.SouthAfrica.I18N_IDENTITY_CODE)]
        ZA,

        /// <summary>
        /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_zanbiya
        /// </summary>
        [I18NIdentityCode(Africa.Zambia.I18N_IDENTITY_CODE)]
        ZM,

        /// <summary>
        /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
        /// Cosmos i18n code: i18n_country_jinbabuwei
        /// </summary>
        [I18NIdentityCode(Africa.Zimbabwe.I18N_IDENTITY_CODE)]
        ZW,
    }
}