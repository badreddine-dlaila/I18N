using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// France Regions
    /// </summary>
    public static class FranceRegions {

        #region Gets regions

        /// <summary>
        /// Département et région d'outre-mer Mayotte
        /// </summary>
        public static EnumValues Mayotte => EnumValues.Mayotte;

        /// <summary>
        /// Département et région d'outre-mer Martinique
        /// </summary>
        public static EnumValues Martinique => EnumValues.Martinique;

        /// <summary>
        /// Département et région d'outre-mer Guadeloupe
        /// </summary>
        public static EnumValues Guadeloupe => EnumValues.Guadeloupe;

        /// <summary>
        /// Département et région d'outre-mer Guyane
        /// </summary>
        public static EnumValues Guiana => EnumValues.Guiana;

        /// <summary>
        /// Département et région d'outre-mer La Réunion
        /// </summary>
        public static EnumValues Réunion => EnumValues.Réunion;

        /// <summary>
        /// Saint Martin French Part
        /// </summary>
        public static EnumValues SaintMartin => EnumValues.SaintMartin;

        /// <summary>
        /// French Southern Territories
        /// </summary>
        public static EnumValues SouthernTerritories => EnumValues.SouthernTerritories;

        /// <summary>
        /// SaintBarts
        /// </summary>
        public static EnumValues SaintBarts => EnumValues.SaintBarts;

        /// <summary>
        /// Département Bas-Rhin
        /// </summary>
        public static EnumValues DépartementBasRhin => EnumValues.DépartementBasRhin;

        /// <summary>
        /// Département Haut-Rhin
        /// </summary>
        public static EnumValues DépartementHautRhin => EnumValues.DépartementHautRhin;

        /// <summary>
        /// Dordogne
        /// </summary>
        public static EnumValues Dordogne => EnumValues.Dordogne;

        /// <summary>
        /// Gironde
        /// </summary>
        public static EnumValues Gironde => EnumValues.Gironde;

        /// <summary>
        /// Landes
        /// </summary>
        public static EnumValues Landes => EnumValues.Landes;

        /// <summary>
        /// Lot-et-Garonne
        /// </summary>
        public static EnumValues LotEtGaronne => EnumValues.LotEtGaronne;

        /// <summary>
        /// Pyrénées-Atlantiques
        /// </summary>
        public static EnumValues PyrénéesAtlantiques => EnumValues.PyrénéesAtlantiques;

        /// <summary>
        /// Cantal
        /// </summary>
        public static EnumValues Cantal => EnumValues.Cantal;

        /// <summary>
        /// Haute-Loire
        /// </summary>
        public static EnumValues HauteLoire => EnumValues.HauteLoire;

        /// <summary>
        /// Puy-de-Dôme
        /// </summary>
        public static EnumValues PuyDeDôme => EnumValues.PuyDeDôme;

        /// <summary>
        /// Allier 
        /// </summary>
        public static EnumValues Allier => EnumValues.Allier;

        /// <summary>
        /// Côte-d’Or
        /// </summary>
        public static EnumValues CôtedOr => EnumValues.CôtedOr;

        /// <summary>
        /// Nièvre 
        /// </summary>
        public static EnumValues Nièvre => EnumValues.Nièvre;

        /// <summary>
        /// Saône-et-Loire
        /// </summary>
        public static EnumValues SaôneEtLoire => EnumValues.SaôneEtLoire;

        /// <summary>
        /// Yonne 
        /// </summary>
        public static EnumValues Yonne => EnumValues.Yonne;

        /// <summary>
        /// Côtes-d’Armor 
        /// </summary>
        public static EnumValues CôtesdArmor => EnumValues.CôtesdArmor;

        /// <summary>
        /// Finistère 
        /// </summary>
        public static EnumValues Finistère => EnumValues.Finistère;

        /// <summary>
        /// Ille-et-Vilaine
        /// </summary>
        public static EnumValues IlleEtVilaine => EnumValues.IlleEtVilaine;

        /// <summary>
        /// Morbihan 
        /// </summary>
        public static EnumValues Morbihan => EnumValues.Morbihan;

        /// <summary>
        /// Cher
        /// </summary>
        public static EnumValues Cher => EnumValues.Cher;

        /// <summary>
        /// Eure-et-Loir 
        /// </summary>
        public static EnumValues EureEtLoir => EnumValues.EureEtLoir;

        /// <summary>
        /// Indre 
        /// </summary>
        public static EnumValues Indre => EnumValues.Indre;

        /// <summary>
        /// Indre-et-Loire
        /// </summary>
        public static EnumValues IndreEtLoire => EnumValues.IndreEtLoire;

        /// <summary>
        /// Loir-et-Cher 
        /// </summary>
        public static EnumValues LoirEtCher => EnumValues.LoirEtCher;

        /// <summary>
        /// Loiret 
        /// </summary>
        public static EnumValues Loiret => EnumValues.Loiret;

        /// <summary>
        /// Aube
        /// </summary>
        public static EnumValues Aube => EnumValues.Aube;

        /// <summary>
        /// Marne 
        /// </summary>
        public static EnumValues Marne => EnumValues.Marne;

        /// <summary>
        /// Haute-Marne 
        /// </summary>
        public static EnumValues HauteMarne => EnumValues.HauteMarne;

        /// <summary>
        /// Ardennes
        /// </summary>
        public static EnumValues Ardennes => EnumValues.Ardennes;

        /// <summary>
        /// Corse-du-Sud
        /// </summary>
        public static EnumValues CorseDuSud => EnumValues.CorseDuSud;

        /// <summary>
        /// Haute-Corse
        /// </summary>
        public static EnumValues HauteCorse => EnumValues.HauteCorse;

        /// <summary>
        /// Doubs
        /// </summary>
        public static EnumValues Doubs => EnumValues.Doubs;


        /// <summary>
        /// Jura
        /// </summary>
        public static EnumValues Jura => EnumValues.Jura;

        /// <summary>
        /// Haute-Saône
        /// </summary>
        public static EnumValues HauteSaône => EnumValues.HauteSaône;

        /// <summary>
        /// Territoire de Belfort
        /// </summary>
        public static EnumValues TerritoireDeBelfort => EnumValues.TerritoireDeBelfort;

        /// <summary>
        /// Paris
        /// </summary>
        public static EnumValues Paris => EnumValues.Paris;

        /// <summary>
        /// Seine-et-Marne
        /// </summary>
        public static EnumValues SeineEtMarne => EnumValues.SeineEtMarne;

        /// <summary>
        /// Yvelines
        /// </summary>
        public static EnumValues Yvelines => EnumValues.Yvelines;

        /// <summary>
        /// Essonne
        /// </summary>
        public static EnumValues Essonne => EnumValues.Essonne;

        /// <summary>
        /// Hauts-de-Seine
        /// </summary>
        public static EnumValues HautsDeSeine => EnumValues.HautsDeSeine;

        /// <summary>
        /// Seine-Saint-Denis
        /// </summary>
        public static EnumValues SeineSaintDenis => EnumValues.SeineSaintDenis;

        /// <summary>
        /// Val-de-Marne
        /// </summary>
        public static EnumValues ValDeMarne => EnumValues.ValDeMarne;

        /// <summary>
        /// Val-d’Oise
        /// </summary>
        public static EnumValues ValdOise => EnumValues.ValdOise;

        /// <summary>
        /// Aude
        /// </summary>
        public static EnumValues Aude => EnumValues.Aude;

        /// <summary>
        /// Gard
        /// </summary>
        public static EnumValues Gard => EnumValues.Gard;

        /// <summary>
        /// Hérault
        /// </summary>
        public static EnumValues Hérault => EnumValues.Hérault;

        /// <summary>
        /// Lozère
        /// </summary>
        public static EnumValues Lozère => EnumValues.Lozère;

        /// <summary>
        /// Pyrénées-Orientales
        /// </summary>
        public static EnumValues PyrénéesOrientales => EnumValues.PyrénéesOrientales;

        /// <summary>
        /// Corrèze
        /// </summary>
        public static EnumValues Corrèze => EnumValues.Corrèze;

        /// <summary>
        /// Creuse
        /// </summary>
        public static EnumValues Creuse => EnumValues.Creuse;

        /// <summary>
        /// Haute-Vienne
        /// </summary>
        public static EnumValues HauteVienne => EnumValues.HauteVienne;

        /// <summary>
        /// Meurthe-et-Moselle
        /// </summary>
        public static EnumValues MeurtheEtMoselle => EnumValues.MeurtheEtMoselle;

        /// <summary>
        /// Meuse
        /// </summary>
        public static EnumValues Meuse => EnumValues.Meuse;

        /// <summary>
        /// Département Moselle
        /// </summary>
        public static EnumValues DépartementMoselle => EnumValues.DépartementMoselle;

        /// <summary>
        /// Vosges
        /// </summary>
        public static EnumValues Vosges => EnumValues.Vosges;

        /// <summary>
        /// Aveyron
        /// </summary>
        public static EnumValues Aveyron => EnumValues.Aveyron;

        /// <summary>
        /// Haute-Garonne
        /// </summary>
        public static EnumValues HauteGaronne => EnumValues.HauteGaronne;

        /// <summary>
        /// Gers
        /// </summary>
        public static EnumValues Gers => EnumValues.Gers;

        /// <summary>
        /// Lot
        /// </summary>
        public static EnumValues Lot => EnumValues.Lot;

        /// <summary>
        /// Hautes-Pyrénées
        /// </summary>
        public static EnumValues HautesPyrénées => EnumValues.HautesPyrénées;

        /// <summary>
        /// Tarn
        /// </summary>
        public static EnumValues Tarn => EnumValues.Tarn;

        /// <summary>
        /// Tarn-et-Garonne
        /// </summary>
        public static EnumValues TarnEtGaronne => EnumValues.TarnEtGaronne;

        /// <summary>
        /// Ariège
        /// </summary>
        public static EnumValues Ariège => EnumValues.Ariège;

        /// <summary>
        /// Nord
        /// </summary>
        public static EnumValues Nord => EnumValues.Nord;

        /// <summary>
        /// Pas-de-Calais
        /// </summary>
        public static EnumValues PasDeCalais => EnumValues.PasDeCalais;

        /// <summary>
        /// Calvados
        /// </summary>
        public static EnumValues Calvados => EnumValues.Calvados;

        /// <summary>
        /// Manche
        /// </summary>
        public static EnumValues Manche => EnumValues.Manche;

        /// <summary>
        /// Orne
        /// </summary>
        public static EnumValues Orne => EnumValues.Orne;

        /// <summary>
        /// Eure
        /// </summary>
        public static EnumValues Eure => EnumValues.Eure;

        /// <summary>
        /// Seine-Maritime
        /// </summary>
        public static EnumValues SeineMaritime => EnumValues.SeineMaritime;

        /// <summary>
        /// Loire-Atlantique
        /// </summary>
        public static EnumValues LoireAtlantique => EnumValues.LoireAtlantique;

        /// <summary>
        /// Maine-et-Loire
        /// </summary>
        public static EnumValues MaineEtLoire => EnumValues.MaineEtLoire;

        /// <summary>
        /// Mayenne
        /// </summary>
        public static EnumValues Mayenne => EnumValues.Mayenne;

        /// <summary>
        /// Sarthe
        /// </summary>
        public static EnumValues Sarthe => EnumValues.Sarthe;

        /// <summary>
        /// Vendée
        /// </summary>
        public static EnumValues Vendée => EnumValues.Vendée;

        /// <summary>
        /// Oise
        /// </summary>
        public static EnumValues Oise => EnumValues.Oise;

        /// <summary>
        /// Somme
        /// </summary>
        public static EnumValues Somme => EnumValues.Somme;

        /// <summary>
        /// Aisne
        /// </summary>
        public static EnumValues Aisne => EnumValues.Aisne;

        /// <summary>
        /// Charente
        /// </summary>
        public static EnumValues Charente => EnumValues.Charente;

        /// <summary>
        /// Charente-Maritime
        /// </summary>
        public static EnumValues CharenteMaritime => EnumValues.CharenteMaritime;

        /// <summary>
        /// Deux-Sèvres
        /// </summary>
        public static EnumValues DeuxSèvres => EnumValues.DeuxSèvres;

        /// <summary>
        /// Vienne
        /// </summary>
        public static EnumValues Vienne => EnumValues.Vienne;

        /// <summary>
        /// Bouches-du-Rhône
        /// </summary>
        public static EnumValues BouchesDuRhône => EnumValues.BouchesDuRhône;

        /// <summary>
        /// Var
        /// </summary>
        public static EnumValues Var => EnumValues.Var;

        /// <summary>
        /// Vaucluse
        /// </summary>
        public static EnumValues Vaucluse => EnumValues.Vaucluse;

        /// <summary>
        /// Alpes-de-Haute-Provence
        /// </summary>
        public static EnumValues AlpesDeHauteProvence => EnumValues.AlpesDeHauteProvence;

        /// <summary>
        /// Hautes-Alpes
        /// </summary>
        public static EnumValues HautesAlpes => EnumValues.HautesAlpes;

        /// <summary>
        /// Alpes-Maritimes
        /// </summary>
        public static EnumValues AlpesMaritimes => EnumValues.AlpesMaritimes;

        /// <summary>
        /// Drôme
        /// </summary>
        public static EnumValues Drôme => EnumValues.Drôme;

        /// <summary>
        /// Isère
        /// </summary>
        public static EnumValues Isère => EnumValues.Isère;

        /// <summary>
        /// Loire
        /// </summary>
        public static EnumValues Loire => EnumValues.Loire;

        /// <summary>
        /// Rhône
        /// </summary>
        public static EnumValues Rhône => EnumValues.Rhône;

        /// <summary>
        /// Savoie
        /// </summary>
        public static EnumValues Savoie => EnumValues.Savoie;

        /// <summary>
        /// Haute-Savoie
        /// </summary>
        public static EnumValues HauteSavoie => EnumValues.HauteSavoie;

        /// <summary>
        /// Ain
        /// </summary>
        public static EnumValues Ain => EnumValues.Ain;

        /// <summary>
        /// Ardèche
        /// </summary>
        public static EnumValues Ardèche => EnumValues.Ardèche;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special {
            /// <summary>
            /// Mayotte
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Mayotte => Country.Mayotte;

            /// <summary>
            /// Mayotte
            /// </summary>
            public static CountryCode MayotteCode => CountryCode.YT;

            /// <summary>
            /// Martinique
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Martinique => Country.Martinique;

            /// <summary>
            /// Martinique
            /// </summary>
            public static CountryCode MartiniqueCode => CountryCode.MQ;

            /// <summary>
            /// Guadeloupe
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Guadeloupe => Country.Guadeloupe;

            /// <summary>
            /// Guadeloupe
            /// </summary>
            public static CountryCode GuadeloupeCode => CountryCode.GP;

            /// <summary>
            /// Guiana
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Guiana => Country.Guiana;

            /// <summary>
            /// Guiana
            /// </summary>
            public static CountryCode GuianaCode => CountryCode.GF;

            /// <summary>
            /// Réunion
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Réunion => Country.Réunion;

            /// <summary>
            /// Réunion
            /// </summary>
            public static CountryCode RéunionCode => CountryCode.RE;

            /// <summary>
            /// SaintMartinFrenchPart
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country SaintMartin => Country.SaintMartinFrenchPart;

            /// <summary>
            /// SaintMartinFrenchPart
            /// </summary>
            public static CountryCode SaintMartinCode => CountryCode.MF;
        }

        /// <summary>
        /// Enum values for France regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Département et région d'outre-mer Mayotte
            /// </summary>
            [AliasInShort("YT")]
            [RegionFlag("overseas")]
            Mayotte,

            /// <summary>
            /// Département et région d'outre-mer Martinique
            /// </summary>
            [AliasInShort("MQ")]
            [RegionFlag("overseas")]
            Martinique,

            /// <summary>
            /// Département et région d'outre-mer Guadeloupe
            /// </summary>
            [AliasInShort("GP")]
            [RegionFlag("overseas")]
            Guadeloupe,

            /// <summary>
            /// Département et région d'outre-mer Guyane
            /// </summary>
            [AliasInShort("GF")]
            [RegionFlag("overseas")]
            Guiana,

            /// <summary>
            /// Département et région d'outre-mer La Réunion
            /// </summary>
            [AliasInShort("RE")]
            [RegionFlag("overseas")]
            Réunion,

            /// <summary>
            /// Saint Martin French Part
            /// </summary>
            [AliasInShort("MF")]
            [RegionFlag("overseas")]
            SaintMartin,

            /// <summary>
            /// French Southern Territories
            /// </summary>
            [AliasInShort("TF")]
            [RegionFlag("overseas")]
            SouthernTerritories,

            /// <summary>
            /// SaintBarts
            /// </summary>
            [AliasInShort("BL")]
            [RegionFlag("overseas")]
            SaintBarts,

            /// <summary>
            /// Département Bas-Rhin
            /// </summary>
            [AliasInShort("67")]
            [RegionFlag("main")]
            DépartementBasRhin,

            /// <summary>
            /// Département Haut-Rhin
            /// </summary>
            [AliasInShort("68")]
            [RegionFlag("main")]
            DépartementHautRhin,

            /// <summary>
            /// Dordogne
            /// </summary>
            [AliasInShort("24")]
            [RegionFlag("main")]
            Dordogne,

            /// <summary>
            /// Gironde
            /// </summary>
            [AliasInShort("33")]
            [RegionFlag("main")]
            Gironde,

            /// <summary>
            /// Landes
            /// </summary>
            [AliasInShort("40")]
            [RegionFlag("main")]
            Landes,

            /// <summary>
            /// Lot-et-Garonne
            /// </summary>
            [AliasInShort("47")]
            [RegionFlag("main")]
            LotEtGaronne,

            /// <summary>
            /// Pyrénées-Atlantiques
            /// </summary>
            [AliasInShort("64")]
            [RegionFlag("main")]
            PyrénéesAtlantiques,

            /// <summary>
            /// Cantal
            /// </summary>
            [AliasInShort("15")]
            [RegionFlag("main")]
            Cantal,

            /// <summary>
            /// Haute-Loire
            /// </summary>
            [AliasInShort("43")]
            [RegionFlag("main")]
            HauteLoire,

            /// <summary>
            /// Puy-de-Dôme
            /// </summary>
            [AliasInShort("63")]
            [RegionFlag("main")]
            PuyDeDôme,

            /// <summary>
            /// Allier
            /// </summary>
            [AliasInShort("03")]
            [RegionFlag("main")]
            Allier,

            /// <summary>
            /// Côte-d’Or
            /// </summary>
            [AliasInShort("21")]
            [RegionFlag("main")]
            CôtedOr,

            /// <summary>
            /// Nièvre
            /// </summary>
            [AliasInShort("58")]
            [RegionFlag("main")]
            [RegionFlag("main")]
            Nièvre,

            /// <summary>
            /// Saône-et-Loire
            /// </summary>
            [AliasInShort("71")]
            [RegionFlag("main")]
            SaôneEtLoire,

            /// <summary>
            /// Yonne
            /// </summary>
            [AliasInShort("89")]
            [RegionFlag("main")]
            Yonne,

            /// <summary>
            /// Côtes-d’Armor
            /// </summary>
            [AliasInShort("22")]
            [RegionFlag("main")]
            CôtesdArmor,

            /// <summary>
            /// Finistère
            /// </summary>
            [AliasInShort("29")]
            [RegionFlag("main")]
            Finistère,

            /// <summary>
            /// Ille-et-Vilaine
            /// </summary>
            [AliasInShort("35")]
            [RegionFlag("main")]
            IlleEtVilaine,

            /// <summary>
            /// Morbihan
            /// </summary>
            [AliasInShort("56")]
            [RegionFlag("main")]
            Morbihan,

            /// <summary>
            /// Cher
            /// </summary>
            [AliasInShort("18")]
            [RegionFlag("main")]
            Cher,

            /// <summary>
            /// Eure-et-Loir
            /// </summary>
            [AliasInShort("28")]
            [RegionFlag("main")]
            EureEtLoir,

            /// <summary>
            /// Indre
            /// </summary>
            [AliasInShort("36")]
            [RegionFlag("main")]
            Indre,

            /// <summary>
            /// Indre-et-Loire
            /// </summary>
            [AliasInShort("37")]
            [RegionFlag("main")]
            IndreEtLoire,

            /// <summary>
            /// Loir-et-Cher
            /// </summary>
            [AliasInShort("41")]
            [RegionFlag("main")]
            LoirEtCher,

            /// <summary>
            /// Loiret
            /// </summary>
            [AliasInShort("45")]
            [RegionFlag("main")]
            Loiret,

            /// <summary>
            /// Aube
            /// </summary>
            [AliasInShort("10")]
            [RegionFlag("main")]
            Aube,

            /// <summary>
            /// Marne
            /// </summary>
            [AliasInShort("51")]
            [RegionFlag("main")]
            Marne,

            /// <summary>
            /// Haute-Marne
            /// </summary>
            [AliasInShort("52")]
            [RegionFlag("main")]
            HauteMarne,

            /// <summary>
            /// Ardennes
            /// </summary>
            [AliasInShort("08")]
            [RegionFlag("main")]
            Ardennes,

            /// <summary>
            /// Corse-du-Sud
            /// </summary>
            [AliasInShort("2A")]
            [RegionFlag("main")]
            CorseDuSud,

            /// <summary>
            /// Haute-Corse
            /// </summary>
            [AliasInShort("2B")]
            [RegionFlag("main")]
            HauteCorse,

            /// <summary>
            /// Doubs
            /// </summary>
            [AliasInShort("25")]
            [RegionFlag("main")]
            Doubs,


            /// <summary>
            /// Jura
            /// </summary>
            [AliasInShort("39")]
            [RegionFlag("main")]
            Jura,

            /// <summary>
            /// Haute-Saône
            /// </summary>
            [AliasInShort("70")]
            [RegionFlag("main")]
            HauteSaône,

            /// <summary>
            /// Territoire de Belfort
            /// </summary>
            [AliasInShort("90")]
            [RegionFlag("main")]
            TerritoireDeBelfort,

            /// <summary>
            /// Paris
            /// </summary>
            [AliasInShort("75")]
            [RegionFlag("main")]
            Paris,

            /// <summary>
            /// Seine-et-Marne
            /// </summary>
            [AliasInShort("77")]
            [RegionFlag("main")]
            SeineEtMarne,

            /// <summary>
            /// Yvelines
            /// </summary>
            [AliasInShort("78")]
            [RegionFlag("main")]
            Yvelines,

            /// <summary>
            /// Essonne
            /// </summary>
            [AliasInShort("91")]
            [RegionFlag("main")]
            Essonne,

            /// <summary>
            /// Hauts-de-Seine
            /// </summary>
            [AliasInShort("92")]
            [RegionFlag("main")]
            HautsDeSeine,

            /// <summary>
            /// Seine-Saint-Denis
            /// </summary>
            [AliasInShort("93")]
            [RegionFlag("main")]
            SeineSaintDenis,

            /// <summary>
            /// Val-de-Marne
            /// </summary>
            [AliasInShort("94")]
            [RegionFlag("main")]
            ValDeMarne,

            /// <summary>
            /// Val-d’Oise
            /// </summary>
            [AliasInShort("95")]
            [RegionFlag("main")]
            ValdOise,

            /// <summary>
            /// Aude
            /// </summary>
            [AliasInShort("11")]
            [RegionFlag("main")]
            Aude,

            /// <summary>
            /// Gard
            /// </summary>
            [AliasInShort("30")]
            [RegionFlag("main")]
            Gard,

            /// <summary>
            /// Hérault
            /// </summary>
            [AliasInShort("34")]
            [RegionFlag("main")]
            Hérault,

            /// <summary>
            /// Lozère
            /// </summary>
            [AliasInShort("48")]
            [RegionFlag("main")]
            Lozère,

            /// <summary>
            /// Pyrénées-Orientales
            /// </summary>
            [AliasInShort("66")]
            [RegionFlag("main")]
            PyrénéesOrientales,

            /// <summary>
            /// Corrèze
            /// </summary>
            [AliasInShort("19")]
            [RegionFlag("main")]
            Corrèze,

            /// <summary>
            /// Creuse
            /// </summary>
            [AliasInShort("23")]
            [RegionFlag("main")]
            Creuse,

            /// <summary>
            /// Haute-Vienne
            /// </summary>
            [AliasInShort("87")]
            [RegionFlag("main")]
            HauteVienne,

            /// <summary>
            /// Meurthe-et-Moselle
            /// </summary>
            [AliasInShort("54")]
            [RegionFlag("main")]
            MeurtheEtMoselle,

            /// <summary>
            /// Meuse
            /// </summary>
            [AliasInShort("55")]
            [RegionFlag("main")]
            Meuse,

            /// <summary>
            /// Département Moselle
            /// </summary>
            [AliasInShort("57")]
            [RegionFlag("main")]
            DépartementMoselle,

            /// <summary>
            /// Vosges
            /// </summary>
            [AliasInShort("88")]
            [RegionFlag("main")]
            Vosges,

            /// <summary>
            /// Aveyron
            /// </summary>
            [AliasInShort("12")]
            [RegionFlag("main")]
            Aveyron,

            /// <summary>
            /// Haute-Garonne
            /// </summary>
            [AliasInShort("31")]
            [RegionFlag("main")]
            HauteGaronne,

            /// <summary>
            /// Gers
            /// </summary>
            [AliasInShort("32")]
            [RegionFlag("main")]
            Gers,

            /// <summary>
            /// Lot
            /// </summary>
            [AliasInShort("46")]
            [RegionFlag("main")]
            Lot,

            /// <summary>
            /// Hautes-Pyrénées
            /// </summary>
            [AliasInShort("65")]
            [RegionFlag("main")]
            HautesPyrénées,

            /// <summary>
            /// Tarn
            /// </summary>
            [AliasInShort("81")]
            [RegionFlag("main")]
            Tarn,

            /// <summary>
            /// Tarn-et-Garonne
            /// </summary>
            [AliasInShort("82")]
            [RegionFlag("main")]
            TarnEtGaronne,

            /// <summary>
            /// Ariège
            /// </summary>
            [AliasInShort("09")]
            [RegionFlag("main")]
            Ariège,

            /// <summary>
            /// Nord
            /// </summary>
            [AliasInShort("59")]
            [RegionFlag("main")]
            Nord,

            /// <summary>
            /// Pas-de-Calais
            /// </summary>
            [AliasInShort("62")]
            [RegionFlag("main")]
            PasDeCalais,

            /// <summary>
            /// Calvados
            /// </summary>
            [AliasInShort("14")]
            [RegionFlag("main")]
            Calvados,

            /// <summary>
            /// Manche
            /// </summary>
            [AliasInShort("50")]
            [RegionFlag("main")]
            Manche,

            /// <summary>
            /// Orne
            /// </summary>
            [AliasInShort("61")]
            [RegionFlag("main")]
            Orne,

            /// <summary>
            /// Eure
            /// </summary>
            [AliasInShort("27")]
            [RegionFlag("main")]
            Eure,

            /// <summary>
            /// Seine-Maritime
            /// </summary>
            [AliasInShort("76")]
            [RegionFlag("main")]
            SeineMaritime,

            /// <summary>
            /// Loire-Atlantique
            /// </summary>
            [AliasInShort("44")]
            [RegionFlag("main")]
            LoireAtlantique,

            /// <summary>
            /// Maine-et-Loire
            /// </summary>
            [AliasInShort("49")]
            [RegionFlag("main")]
            MaineEtLoire,

            /// <summary>
            /// Mayenne
            /// </summary>
            [AliasInShort("53")]
            [RegionFlag("main")]
            Mayenne,

            /// <summary>
            /// Sarthe
            /// </summary>
            [AliasInShort("72")]
            [RegionFlag("main")]
            Sarthe,

            /// <summary>
            /// Vendée
            /// </summary>
            [AliasInShort("85")]
            [RegionFlag("main")]
            Vendée,

            /// <summary>
            /// Oise
            /// </summary>
            [AliasInShort("60")]
            [RegionFlag("main")]
            Oise,

            /// <summary>
            /// Somme
            /// </summary>
            [AliasInShort("80")]
            [RegionFlag("main")]
            Somme,

            /// <summary>
            /// Aisne
            /// </summary>
            [AliasInShort("02")]
            [RegionFlag("main")]
            Aisne,

            /// <summary>
            /// Charente
            /// </summary>
            [AliasInShort("16")]
            [RegionFlag("main")]
            Charente,

            /// <summary>
            /// Charente-Maritime
            /// </summary>
            [AliasInShort("17")]
            [RegionFlag("main")]
            CharenteMaritime,

            /// <summary>
            /// Deux-Sèvres
            /// </summary>
            [AliasInShort("79")]
            [RegionFlag("main")]
            DeuxSèvres,

            /// <summary>
            /// Vienne
            /// </summary>
            [AliasInShort("86")]
            [RegionFlag("main")]
            Vienne,

            /// <summary>
            /// Bouches-du-Rhône
            /// </summary>
            [AliasInShort("13")]
            [RegionFlag("main")]
            BouchesDuRhône,

            /// <summary>
            /// Var
            /// </summary>
            [AliasInShort("83")]
            [RegionFlag("main")]
            Var,

            /// <summary>
            /// Vaucluse
            /// </summary>
            [AliasInShort("84")]
            [RegionFlag("main")]
            Vaucluse,

            /// <summary>
            /// Alpes-de-Haute-Provence
            /// </summary>
            [AliasInShort("04")]
            [RegionFlag("main")]
            AlpesDeHauteProvence,

            /// <summary>
            /// Hautes-Alpes
            /// </summary>
            [AliasInShort("05")]
            [RegionFlag("main")]
            HautesAlpes,

            /// <summary>
            /// Alpes-Maritimes
            /// </summary>
            [AliasInShort("06")]
            [RegionFlag("main")]
            AlpesMaritimes,

            /// <summary>
            /// Drôme
            /// </summary>
            [AliasInShort("26")]
            [RegionFlag("main")]
            Drôme,

            /// <summary>
            /// Isère
            /// </summary>
            [AliasInShort("38")]
            [RegionFlag("main")]
            Isère,

            /// <summary>
            /// Loire
            /// </summary>
            [AliasInShort("42")]
            [RegionFlag("main")]
            Loire,

            /// <summary>
            /// Rhône
            /// </summary>
            [AliasInShort("69")]
            [RegionFlag("main")]
            Rhône,

            /// <summary>
            /// Savoie
            /// </summary>
            [AliasInShort("73")]
            [RegionFlag("main")]
            Savoie,

            /// <summary>
            /// Haute-Savoie
            /// </summary>
            [AliasInShort("74")]
            [RegionFlag("main")]
            HauteSavoie,

            /// <summary>
            /// Ain
            /// </summary>
            [AliasInShort("01")]
            [RegionFlag("main")]
            Ain,

            /// <summary>
            /// Ardèche
            /// </summary>
            [AliasInShort("07")]
            [RegionFlag("main")]
            Ardèche,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="FranceRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="FranceRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"FR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            switch (value) {
                case EnumValues.Mayotte:
                    return Country.Mayotte;
                case EnumValues.Martinique:
                    return Country.Martinique;
                case EnumValues.Guadeloupe:
                    return Country.Guadeloupe;
                case EnumValues.Guiana:
                    return Country.Guiana;
                case EnumValues.Réunion:
                    return Country.Réunion;
                case EnumValues.SaintMartin:
                    return Country.SaintMartinFrenchPart;
                case EnumValues.SouthernTerritories:
                    return Country.FrenchSouthernTerritories;
                case EnumValues.SaintBarts:
                    return Country.SaintBarts;
                default:
                    return Country.France;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            switch (value) {
                case EnumValues.Mayotte:
                    return CountryCode.YT;
                case EnumValues.Martinique:
                    return CountryCode.MQ;
                case EnumValues.Guadeloupe:
                    return CountryCode.GP;
                case EnumValues.Guiana:
                    return CountryCode.GF;
                case EnumValues.Réunion:
                    return CountryCode.RE;
                case EnumValues.SaintMartin:
                    return CountryCode.MF;
                case EnumValues.SouthernTerritories:
                    return CountryCode.TF;
                case EnumValues.SaintBarts:
                    return CountryCode.BL;
                default:
                    return CountryCode.FR;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of France
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country) {
            switch (country) {
                case Country.Mayotte:
                    return EnumValues.Mayotte;
                case Country.Martinique:
                    return EnumValues.Martinique;
                case Country.Guadeloupe:
                    return EnumValues.Guadeloupe;
                case Country.Guiana:
                    return EnumValues.Guiana;
                case Country.Réunion:
                    return EnumValues.Réunion;
                case Country.SaintMartinFrenchPart:
                    return EnumValues.SaintMartin;
                case Country.FrenchSouthernTerritories:
                    return EnumValues.SouthernTerritories;
                case Country.SaintBarts:
                    return EnumValues.SaintBarts;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of France
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code) {
            switch (code) {
                case CountryCode.YT:
                    return EnumValues.Mayotte;
                case CountryCode.MQ:
                    return EnumValues.Martinique;
                case CountryCode.GP:
                    return EnumValues.Guadeloupe;
                case CountryCode.GF:
                    return EnumValues.Guiana;
                case CountryCode.RE:
                    return EnumValues.Réunion;
                case CountryCode.MF:
                    return EnumValues.SaintMartin;
                case CountryCode.TF:
                    return EnumValues.SouthernTerritories;
                case CountryCode.BL:
                    return EnumValues.SaintBarts;
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
        public static IEnumerable<string> GetAllRegonCodes() {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得本土地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes() {
            foreach (var member in Filter("mainland"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得海外地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes() {
            foreach (var member in Filter("overseas"))
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}