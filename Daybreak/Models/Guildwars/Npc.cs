﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Daybreak.Models.Guildwars;

// TODO: Add missing npcs
public sealed class Npc
{
    public static readonly Npc Unknown = new() { Ids = new int[] { 0 }, Name = "Unknown" };
    public static readonly Npc RitualPriest = new() { Ids = new int[] { 94, 2831 }, Name = "Ritual Priest" };
    public static readonly Npc CanthanGuard = new() { Ids = new int[] { 107, 188, 3064, 3096, 3228, 3234, 3235, 3237 }, Name = "Canthan Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Guard" };
    public static readonly Npc ZaishenRepresentative = new() { Ids = new int[] { 111 }, Name = "Zaishen Representative", WikiUrl = "https://wiki.guildwars.com/wiki/Zaishen_Representative" };
    public static readonly Npc CanthanAmbassador = new() { Ids = new int[] { 216 }, Name = "Canthan Ambassador", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Ambassador" };
    public static readonly Npc PriestOfBalthazar = new() { Ids = new int[] { 218 }, Name = "Priest Of Balthazar", WikiUrl = "https://wiki.guildwars.com/wiki/Priest_of_Balthazar" };
    public static readonly Npc Tolkano = new() { Ids = new int[] { 219 }, Name = "Tolkano", WikiUrl = "https://wiki.guildwars.com/wiki/Tolkano" };
    public static readonly Npc XunlaiAgent = new() { Ids = new int[] { 220, 221, 3287 }, Name = "Xunlai Agent", WikiUrl = "https://wiki.guildwars.com/wiki/Xunlai_Agent" };
    public static readonly Npc VabbianCommoner = new() { Ids = new int[] { 224, 5659, 5662, 5661, 5653, 5656, 5657 }, Name = "Vabbian Commoner", WikiUrl = "https://wiki.guildwars.com/wiki/Vabbian_Commoner" };
    public static readonly Npc VabbianArtisan = new() { Ids = new int[] { 1202 }, Name = "Vabbian Artisan", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Vabbians" };
    public static readonly Npc AbaddonsCursed = new() { Ids = new int[] { 1338 }, Name = "Abaddon's Cursed", WikiUrl = "https://wiki.guildwars.com/wiki/Abaddon%27s_Cursed" };
    public static readonly Npc Lynx = new() { Ids = new int[] { 1342, 8029 }, Name = "Lynx", WikiUrl = "https://wiki.guildwars.com/wiki/Lynx" };
    public static readonly Npc Strider = new() { Ids = new int[] { 1343 }, Name = "Strider", WikiUrl = "https://wiki.guildwars.com/wiki/Strider" };
    public static readonly Npc MelandrusStalker = new() { Ids = new int[] { 1345 }, Name = "Melandru's Stalker", WikiUrl = "https://wiki.guildwars.com/wiki/Melandru%27s_Stalker" };
    public static readonly Npc Wolf = new() { Ids = new int[] { 1346 }, Name = "Wolf", WikiUrl = "https://wiki.guildwars.com/wiki/Wolf" };
    public static readonly Npc Warthog = new() { Ids = new int[] { 1347, 1348 }, Name = "Warthog", WikiUrl = "https://wiki.guildwars.com/wiki/Warthog" };
    public static readonly Npc BlackBear = new() { Ids = new int[] { 1349, 1352 }, Name = "Black Bear", WikiUrl = "https://wiki.guildwars.com/wiki/Black_Bear" };
    public static readonly Npc DuneLizard = new() { Ids = new int[] { 1351 }, Name = "Dune Lizard", WikiUrl = "https://wiki.guildwars.com/wiki/Dune_Lizard" };
    public static readonly Npc MossSpider = new() { Ids = new int[] { 1354, 2316 }, Name = "Moss Spider", WikiUrl = "https://wiki.guildwars.com/wiki/Moss_Spider" };
    public static readonly Npc MoaBird = new() { Ids = new int[] { 1393, 1344 }, Name = "Moa Bird", WikiUrl = "https://wiki.guildwars.com/wiki/Moa_Bird" };
    public static readonly Npc PrizeWinningHog = new() { Ids = new int[] { 1399 }, Name = "Prize-Winning Hog", WikiUrl = "https://wiki.guildwars.com/wiki/Prize-Winning_Hog" };
    public static readonly Npc GiantNeedleSpider = new() { Ids = new int[] { 1401 }, Name = "Giant Needle Spider", WikiUrl = "https://wiki.guildwars.com/wiki/Giant_Needle_Spider" };
    public static readonly Npc DeadlyCryptSpider = new() { Ids = new int[] { 1402 }, Name = "Deadly Crypt Spider", WikiUrl = "https://wiki.guildwars.com/wiki/Deadly_Crypt_Spider" };
    public static readonly Npc GiantTreeSpider = new() { Ids = new int[] { 1403 }, Name = "Giant Tree Spider", WikiUrl = "https://wiki.guildwars.com/wiki/Giant_Tree_Spider" };
    public static readonly Npc CarrionDevourer = new() { Ids = new int[] { 1405 }, Name = "Carrion Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Carrion_Devourer" };
    public static readonly Npc SnappingDevourer = new() { Ids = new int[] { 1406 }, Name = "Snapping Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Snapping_Devourer" };
    public static readonly Npc DiseasedDevourer = new() { Ids = new int[] { 1408 }, Name = "Diseased Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Diseased_Devourer" };
    public static readonly Npc LashDevourer = new() { Ids = new int[] { 1409 }, Name = "Lash Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Lash_Devourer" };
    public static readonly Npc IceElemental = new() { Ids = new int[] { 1412 }, Name = "Ice Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Ice_Elemental" };
    public static readonly Npc StoneElemental = new() { Ids = new int[] { 1414 }, Name = "Stone Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Elemental" };
    public static readonly Npc HulkingStoneElemental = new() { Ids = new int[] { 1415 }, Name = "Hulking Stone Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Hulking_Stone_Elemental" };
    public static readonly Npc Gargoyle = new() { Ids = new int[] { 1417 }, Name = "Gargoyle", WikiUrl = "https://wiki.guildwars.com/wiki/Gargoyle" };
    public static readonly Npc ShatterGargoyle = new() { Ids = new int[] { 1418, 2445 }, Name = "Shatter Gargoyle", WikiUrl = "https://wiki.guildwars.com/wiki/Shatter_Gargoyle" };
    public static readonly Npc BanditFirestarter = new() { Ids = new int[] { 1420 }, Name = "Bandit Firestarter", WikiUrl = "https://wiki.guildwars.com/wiki/Bandit_Firestarter" };
    public static readonly Npc BanditRaider = new() { Ids = new int[] { 1421 }, Name = "Bandit Raider", WikiUrl = "https://wiki.guildwars.com/wiki/Bandit_Raider" };
    public static readonly Npc BanditBloodSworn = new() { Ids = new int[] { 1422 }, Name = "Bandit Blood Sworn", WikiUrl = "https://wiki.guildwars.com/wiki/Bandit_Blood_Sworn" };
    public static readonly Npc NightmareNecromancer = new() { Ids = new int[] { 1424 }, Name = "Nightmare Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Nightmare" };
    public static readonly Npc AloeHusk = new() { Ids = new int[] { 1426 }, Name = "Aloe Husk", WikiUrl = "https://wiki.guildwars.com/wiki/Aloe_Husk" };
    public static readonly Npc LargeAloeSeed = new() { Ids = new int[] { 1427 }, Name = "Large Aloe Seed", WikiUrl = "https://wiki.guildwars.com/wiki/Large_Aloe_Seed" };
    public static readonly Npc AloeSeed = new() { Ids = new int[] { 1428 }, Name = "Aloe Seed", WikiUrl = "https://wiki.guildwars.com/wiki/Aloe_Seed" };
    public static readonly Npc Oakheart = new() { Ids = new int[] { 1429, 1733 }, Name = "Oakheart", WikiUrl = "https://wiki.guildwars.com/wiki/Oakheart" };
    public static readonly Npc RiverSkale = new() { Ids = new int[] { 1430 }, Name = "River Skale", WikiUrl = "https://wiki.guildwars.com/wiki/River_Skale" };
    public static readonly Npc SkaleBroodcaller = new() { Ids = new int[] { 1431 }, Name = "Skale Broodcaller", WikiUrl = "https://wiki.guildwars.com/wiki/Skale_Broodcaller" };
    public static readonly Npc RiverSkaleTad = new() { Ids = new int[] { 1432 }, Name = "River Skale Tad", WikiUrl = "https://wiki.guildwars.com/wiki/River_Skale_Tad" };
    public static readonly Npc GrawlInvader = new() { Ids = new int[] { 1436 }, Name = "Grawl Invader", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl_Invader" };
    public static readonly Npc GrawlLongspear = new() { Ids = new int[] { 1437 }, Name = "Grawl Longspear", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl_Longspear" };
    public static readonly Npc GrawlShaman = new() { Ids = new int[] { 1438 }, Name = "Grawl Shaman", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl_Shaman" };
    public static readonly Npc RedEyeTheUnholy = new() { Ids = new int[] { 1448 }, Name = "Red Eye The Unholy", WikiUrl = "https://wiki.guildwars.com/wiki/Red_Eye_the_Unholy" };
    public static readonly Npc JawSmokeskin = new() { Ids = new int[] { 1449 }, Name = "Jaw Smokeskin", WikiUrl = "https://wiki.guildwars.com/wiki/Jaw_Smokeskin" };
    public static readonly Npc BlazeBloodbane = new() { Ids = new int[] { 1450 }, Name = "Blaze Bloodbane", WikiUrl = "https://wiki.guildwars.com/wiki/Blaze_Bloodbane" };
    public static readonly Npc Haversdan = new() { Ids = new int[] { 1455 }, Name = "Haversdan", WikiUrl = "https://wiki.guildwars.com/wiki/Haversdan" };
    public static readonly Npc WarmasterTydus = new() { Ids = new int[] { 1456, 2856, 2097 }, Name = "Warmaster Tydus", WikiUrl = "https://wiki.guildwars.com/wiki/Warmaster_Tydus" };
    public static readonly Npc AscalonNoble = new() { Ids = new int[] { 1461, 2083 }, Name = "Ascalon Noble", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonianGuard = new() { Ids = new int[] { 1464, 2091 }, Name = "Ascalonian Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalonian_Guard" };
    public static readonly Npc AscalonMesmer = new() { Ids = new int[] { 1466, 1644 }, Name = "Ascalon Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonMerchant = new() { Ids = new int[] { 1467, 1480, 2090 }, Name = "Ascalon Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonCrafter = new() { Ids = new int[] { 1468 }, Name = "Ascalon Crafter", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonNecromancer = new() { Ids = new int[] { 1469, 1470 }, Name = "Ascalon Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc RalenaStormbringer = new() { Ids = new int[] { 1471 }, Name = "Ralena Stormbringer", WikiUrl = "https://wiki.guildwars.com/wiki/Ralena_Stormbringer" };
    public static readonly Npc AscalonMonk = new() { Ids = new int[] { 1474 }, Name = "Ascalon Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonBrawler = new() { Ids = new int[] { 1475 }, Name = "Ascalon Brawler", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonGuard = new() { Ids = new int[] { 1477, 7758 }, Name = "Ascalon Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalon_Guard" };
    public static readonly Npc AscalonianFarmer = new() { Ids = new int[] { 1479, 2070 }, Name = "Ascalonian Farmer", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalonian_Farmer" };
    public static readonly Npc AscalonTamer = new() { Ids = new int[] { 1482 }, Name = "Ascalon Tamer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AcademyMonk = new() { Ids = new int[] { 1483, 1484, 6028 }, Name = "Academy Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Academy_Monk" };
    public static readonly Npc AscalonianTownsfolk = new() { Ids = new int[] { 1485, 1487 }, Name = "Ascalonian Townsfolk", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalonian_Townsfolk" };
    public static readonly Npc AscalonianPeasant = new() { Ids = new int[] { 1488, 1490 }, Name = "Ascalonian Peasant", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalonian_Peasant" };
    public static readonly Npc Krytan = new() { Ids = new int[] { 1492, 1960, 1964, 1966, 1967, 1991, 2008, 2009, 2020, 2032, 2049, 2120, 2858, 2867, 2869, 2095 }, Name = "Krytan", WikiUrl = "https://wiki.guildwars.com/wiki/Krytan" };
    public static readonly Npc Gwen = new() { Ids = new int[] { 1493, 1494, 5966, 5970 }, Name = "Gwen", WikiUrl = "https://wiki.guildwars.com/wiki/Gwen" };
    public static readonly Npc FarrahCappo = new() { Ids = new int[] { 1497, 2863, 2138 }, Name = "Farrah Cappo", WikiUrl = "https://wiki.guildwars.com/wiki/Farrah_Cappo" };
    public static readonly Npc Cynn = new() { Ids = new int[] { 1501, 1924, 2128, 2853, 3489, 4565, 4575, 5988, 4585 }, Name = "Cynn", WikiUrl = "https://wiki.guildwars.com/wiki/Cynn" };
    public static readonly Npc Devona = new() { Ids = new int[] { 1502, 1932, 2132, 2854, 3492, 3509, 4569, 4579, 5993, 4589 }, Name = "Devona", WikiUrl = "https://wiki.guildwars.com/wiki/Devona" };
    public static readonly Npc AscalonDuke = new() { Ids = new int[] { 1504, 1511 }, Name = "Ascalon Duke", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc PrinceRurik = new() { Ids = new int[] { 1505 }, Name = "Prince Rurik", WikiUrl = "https://wiki.guildwars.com/wiki/Prince_Rurik" };
    public static readonly Npc LadyAlthea = new() { Ids = new int[] { 1507 }, Name = "Lady Althea", WikiUrl = "https://wiki.guildwars.com/wiki/Lady_Althea" };
    public static readonly Npc NecromancerMunne = new() { Ids = new int[] { 1508 }, Name = "Necromancer Munne", WikiUrl = "https://wiki.guildwars.com/wiki/Necromancer_Munne" };
    public static readonly Npc ElementalistAziure = new() { Ids = new int[] { 1509 }, Name = "Elementalist Aziure", WikiUrl = "https://wiki.guildwars.com/wiki/Elementalist_Aziure" };
    public static readonly Npc AscalonRanger = new() { Ids = new int[] { 1512, 1513, 1481 }, Name = "Ascalon Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalon_Ranger" };
    public static readonly Npc Skullreaver = new() { Ids = new int[] { 1514 }, Name = "Skullreaver", WikiUrl = "https://wiki.guildwars.com/wiki/Skullreaver" };
    public static readonly Npc RestlessCorpse = new() { Ids = new int[] { 1515 }, Name = "Restless Corpse", WikiUrl = "https://wiki.guildwars.com/wiki/Restless_Corpse" };
    public static readonly Npc RagingCadaver = new() { Ids = new int[] { 1517 }, Name = "Raging Cadaver", WikiUrl = "https://wiki.guildwars.com/wiki/Raging_Cadaver" };
    public static readonly Npc Ventari = new() { Ids = new int[] { 1519 }, Name = "Ventari", WikiUrl = "https://wiki.guildwars.com/wiki/Ventari" };
    public static readonly Npc ShiningBladeScout = new() { Ids = new int[] { 1520 }, Name = "Shining Blade Scout", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade_Scout" };
    public static readonly Npc Evennia = new() { Ids = new int[] { 1521, 1530, 2841 }, Name = "Evennia", WikiUrl = "https://wiki.guildwars.com/wiki/Evennia" };
    public static readonly Npc Saidra = new() { Ids = new int[] { 1528 }, Name = "Saidra", WikiUrl = "https://wiki.guildwars.com/wiki/Saidra" };
    public static readonly Npc ShiningBladeMesmer = new() { Ids = new int[] { 1532 }, Name = "Shining Blade Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade_Mesmer" };
    public static readonly Npc ShiningBladeNecromancer = new() { Ids = new int[] { 1533 }, Name = "Shining Blade Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade_Necromancer" };
    public static readonly Npc ShiningBladeElementalist = new() { Ids = new int[] { 1534 }, Name = "Shining Blade Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade_Elementalist" };
    public static readonly Npc GarethQuickblade = new() { Ids = new int[] { 1536 }, Name = "Gareth Quickblade", WikiUrl = "https://wiki.guildwars.com/wiki/Gareth_Quickblade" };
    public static readonly Npc ShiningBladeWarrior = new() { Ids = new int[] { 1538, 1996, 2039 }, Name = "Shining Blade Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade_Warrior" };
    public static readonly Npc AlariDoubleblade = new() { Ids = new int[] { 1539 }, Name = "Alari Doubleblade", WikiUrl = "https://wiki.guildwars.com/wiki/Alari_Doubleblade" };
    public static readonly Npc ShiningBladeRanger = new() { Ids = new int[] { 1541, 2045 }, Name = "Shining Blade Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade_Ranger" };
    public static readonly Npc DwarvenSmith = new() { Ids = new int[] { 1548 }, Name = "Dwarven Smith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dwarves" };
    public static readonly Npc DeldrimorCaster = new() { Ids = new int[] { 1550, 1552, 6214, 2109 }, Name = "Deldrimor Caster" };
    public static readonly Npc DeldrimorWarrior = new() { Ids = new int[] { 1553, 1555, 1556, 2840, 6180, 6215, 6216 }, Name = "Deldrimor Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dwarves" };
    public static readonly Npc DwarvenSoldier = new() { Ids = new int[] { 1554, 1569 }, Name = "Dwarven Soldier", WikiUrl = "https://wiki.guildwars.com/wiki/Dwarven_Soldier" };
    public static readonly Npc DeldrimorRanger = new() { Ids = new int[] { 1557, 1558, 6271 }, Name = "Deldrimor Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dwarves" };
    public static readonly Npc KingJalisIronhammer = new() { Ids = new int[] { 1562, 2839 }, Name = "King Jalis Ironhammer", WikiUrl = "https://wiki.guildwars.com/wiki/King_Jalis_Ironhammer" };
    public static readonly Npc BrechnarIronhammer = new() { Ids = new int[] { 1564 }, Name = "Brechnar Ironhammer", WikiUrl = "https://wiki.guildwars.com/wiki/Brechnar_Ironhammer" };
    public static readonly Npc DwarvenSage = new() { Ids = new int[] { 1565 }, Name = "Dwarven Sage", WikiUrl = "https://wiki.guildwars.com/wiki/Dwarven_Sage" };
    public static readonly Npc DwarvenScout = new() { Ids = new int[] { 1567 }, Name = "Dwarven Scout", WikiUrl = "https://wiki.guildwars.com/wiki/Dwarven_Scout" };
    public static readonly Npc CharrChaot = new() { Ids = new int[] { 1635 }, Name = "Charr Chaot", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Chaot" };
    public static readonly Npc CharrAshenClaw = new() { Ids = new int[] { 1638 }, Name = "Charr Ashen Claw", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Ashen_Claw" };
    public static readonly Npc CharrShaman = new() { Ids = new int[] { 1646, 5711, 4972 }, Name = "Charr Shaman", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Shaman" };
    public static readonly Npc CharrAxeFiend = new() { Ids = new int[] { 1651, 7802 }, Name = "Charr Axe Fiend", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Axe_Fiend" };
    public static readonly Npc CharrBladeStorm = new() { Ids = new int[] { 1653 }, Name = "Charr Blade Storm", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Blade_Storm" };
    public static readonly Npc CharrHunter = new() { Ids = new int[] { 1656 }, Name = "Charr Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Hunter" };
    public static readonly Npc SquawNimblecrest = new() { Ids = new int[] { 1685 }, Name = "Squaw Nimblecrest", WikiUrl = "https://wiki.guildwars.com/wiki/Squaw_Nimblecrest" };
    public static readonly Npc GypsieEttin = new() { Ids = new int[] { 1715 }, Name = "Gypsie Ettin", WikiUrl = "https://wiki.guildwars.com/wiki/Gypsie_Ettin" };
    public static readonly Npc HillGiant = new() { Ids = new int[] { 1724 }, Name = "Hill Giant", WikiUrl = "https://wiki.guildwars.com/wiki/Hill_Giant" };
    public static readonly Npc InfernoImp = new() { Ids = new int[] { 1725 }, Name = "Inferno Imp", WikiUrl = "https://wiki.guildwars.com/wiki/Inferno_Imp" };
    public static readonly Npc FireImp = new() { Ids = new int[] { 1726 }, Name = "Fire Imp", WikiUrl = "https://wiki.guildwars.com/wiki/Fire_Imp" };
    public static readonly Npc BogSkale = new() { Ids = new int[] { 1737 }, Name = "Bog Skale", WikiUrl = "https://wiki.guildwars.com/wiki/Bog_Skale" };
    public static readonly Npc CaromiTenguWild = new() { Ids = new int[] { 1739 }, Name = "Caromi Tengu Wild", WikiUrl = "https://wiki.guildwars.com/wiki/Caromi_Tengu_Wild" };
    public static readonly Npc CaromiTenguBrave = new() { Ids = new int[] { 1741, 1744 }, Name = "Caromi Tengu Brave", WikiUrl = "https://wiki.guildwars.com/wiki/Caromi_Tengu_Brave" };
    public static readonly Npc CaromiTenguScout = new() { Ids = new int[] { 1746 }, Name = "Caromi Tengu Scout", WikiUrl = "https://wiki.guildwars.com/wiki/Caromi_Tengu_Scout" };
    public static readonly Npc TrechSchmoogle = new() { Ids = new int[] { 1754 }, Name = "Trech Schmoogle", WikiUrl = "https://wiki.guildwars.com/wiki/Trech_Schmoogle" };
    public static readonly Npc CootleSizzlehorn = new() { Ids = new int[] { 1756 }, Name = "Cootle Sizzlehorn", WikiUrl = "https://wiki.guildwars.com/wiki/Cootle_Sizzlehorn" };
    public static readonly Npc MinaBrillianthaunch = new() { Ids = new int[] { 1770 }, Name = "Mina Brillianthaunch", WikiUrl = "https://wiki.guildwars.com/wiki/Mina_Brillianthaunch" };
    public static readonly Npc AguoGruffmane = new() { Ids = new int[] { 1771 }, Name = "Aguo Gruffmane", WikiUrl = "https://wiki.guildwars.com/wiki/Aguo_Gruffmane" };
    public static readonly Npc ShegZamnMada = new() { Ids = new int[] { 1775 }, Name = "Sheg Zamn Mada", WikiUrl = "https://wiki.guildwars.com/wiki/Sheg_Zamn_Mada" };
    public static readonly Npc VisionOfGlint = new() { Ids = new int[] { 1779 }, Name = "Vision Of Glint", WikiUrl = "https://wiki.guildwars.com/wiki/Vision_of_Glint" };
    public static readonly Npc GhostlyHero = new() { Ids = new int[] { 1781, 1782 }, Name = "Ghostly Hero", WikiUrl = "https://wiki.guildwars.com/wiki/Ghostly_Hero" };
    public static readonly Npc StormKin = new() { Ids = new int[] { 1785 }, Name = "Storm Kin", WikiUrl = "https://wiki.guildwars.com/wiki/Storm_Kin" };
    public static readonly Npc DuneBurrower = new() { Ids = new int[] { 1786 }, Name = "Dune Burrower", WikiUrl = "https://wiki.guildwars.com/wiki/Dune_Burrower" };
    public static readonly Npc LosaruWindcaster = new() { Ids = new int[] { 1787 }, Name = "Losaru Windcaster", WikiUrl = "https://wiki.guildwars.com/wiki/Losaru_Windcaster" };
    public static readonly Npc LosaruLifeband = new() { Ids = new int[] { 1788 }, Name = "Losaru Lifeband", WikiUrl = "https://wiki.guildwars.com/wiki/Losaru_Lifeband" };
    public static readonly Npc LosaruBladehand = new() { Ids = new int[] { 1789 }, Name = "Losaru Bladehand", WikiUrl = "https://wiki.guildwars.com/wiki/Losaru_Bladehand" };
    public static readonly Npc LosaruBowmaster = new() { Ids = new int[] { 1790 }, Name = "Losaru Bowmaster", WikiUrl = "https://wiki.guildwars.com/wiki/Losaru_Bowmaster" };
    public static readonly Npc SandElemental = new() { Ids = new int[] { 1791 }, Name = "Sand Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Sand_Elemental" };
    public static readonly Npc RockshotDevourer = new() { Ids = new int[] { 1792 }, Name = "Rockshot Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Rockshot_Devourer" };
    public static readonly Npc SandDrake = new() { Ids = new int[] { 1793 }, Name = "Sand Drake", WikiUrl = "https://wiki.guildwars.com/wiki/Sand_Drake" };
    public static readonly Npc DesertGriffon = new() { Ids = new int[] { 1794 }, Name = "Desert Griffon", WikiUrl = "https://wiki.guildwars.com/wiki/Desert_Griffon" };
    public static readonly Npc Hydra = new() { Ids = new int[] { 1796, 2438 }, Name = "Hydra", WikiUrl = "https://wiki.guildwars.com/wiki/Hydra" };
    public static readonly Npc Minotaur = new() { Ids = new int[] { 1797, 2493, 2486 }, Name = "Minotaur", WikiUrl = "https://wiki.guildwars.com/wiki/Minotaur" };
    public static readonly Npc JadeScarab = new() { Ids = new int[] { 1799 }, Name = "Jade Scarab", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Scarab" };
    public static readonly Npc RockEaterScarab = new() { Ids = new int[] { 1800 }, Name = "Rock-Eater Scarab", WikiUrl = "https://wiki.guildwars.com/wiki/Rock-Eater_Scarab" };
    public static readonly Npc SiegeWurm = new() { Ids = new int[] { 1802 }, Name = "Siege Wurm", WikiUrl = "https://wiki.guildwars.com/wiki/Siege_Wurm" };
    public static readonly Npc SandGiant = new() { Ids = new int[] { 1803 }, Name = "Sand Giant", WikiUrl = "https://wiki.guildwars.com/wiki/Sand_Giant" };
    public static readonly Npc MarrowScarab = new() { Ids = new int[] { 1810 }, Name = "Marrow Scarab", WikiUrl = "https://wiki.guildwars.com/wiki/Marrow_Scarab" };
    public static readonly Npc ScarabNestBuilder = new() { Ids = new int[] { 1811 }, Name = "Scarab Nest Builder", WikiUrl = "https://wiki.guildwars.com/wiki/Scarab_Nest_Builder" };
    public static readonly Npc AyassahHess = new() { Ids = new int[] { 1835 }, Name = "Ayassah Hess", WikiUrl = "https://wiki.guildwars.com/wiki/Ayassah_Hess" };
    public static readonly Npc BysshaHisst = new() { Ids = new int[] { 1836 }, Name = "Byssha Hisst", WikiUrl = "https://wiki.guildwars.com/wiki/Byssha_Hisst" };
    public static readonly Npc CyssGresshla = new() { Ids = new int[] { 1837 }, Name = "Cyss Gresshla", WikiUrl = "https://wiki.guildwars.com/wiki/Cyss_Gresshla" };
    public static readonly Npc CustodianKora = new() { Ids = new int[] { 1840 }, Name = "Custodian Kora", WikiUrl = "https://wiki.guildwars.com/wiki/Custodian_Kora" };
    public static readonly Npc GossAleessh = new() { Ids = new int[] { 1841 }, Name = "Goss Aleessh", WikiUrl = "https://wiki.guildwars.com/wiki/Goss_Aleessh" };
    public static readonly Npc HessperSasso = new() { Ids = new int[] { 1842 }, Name = "Hessper Sasso", WikiUrl = "https://wiki.guildwars.com/wiki/Hessper_Sasso" };
    public static readonly Npc IssahSshay = new() { Ids = new int[] { 1843 }, Name = "Issah Sshay", WikiUrl = "https://wiki.guildwars.com/wiki/Issah_Sshay" };
    public static readonly Npc JossoEssher = new() { Ids = new int[] { 1844 }, Name = "Josso Essher", WikiUrl = "https://wiki.guildwars.com/wiki/Josso_Essher" };
    public static readonly Npc CustodianHulgar = new() { Ids = new int[] { 1845 }, Name = "Custodian Hulgar", WikiUrl = "https://wiki.guildwars.com/wiki/Custodian_Hulgar" };
    public static readonly Npc CustodianPhebus = new() { Ids = new int[] { 1846 }, Name = "Custodian Phebus", WikiUrl = "https://wiki.guildwars.com/wiki/Custodian_Phebus" };
    public static readonly Npc FacetOfDarkness = new() { Ids = new int[] { 1848 }, Name = "Facet Of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Facet_of_Darkness" };
    public static readonly Npc TissDanssir = new() { Ids = new int[] { 1853 }, Name = "Tiss Danssir", WikiUrl = "https://wiki.guildwars.com/wiki/Tiss_Danssir" };
    public static readonly Npc UusshVisshta = new() { Ids = new int[] { 1854 }, Name = "Uussh Visshta", WikiUrl = "https://wiki.guildwars.com/wiki/Uussh_Visshta" };
    public static readonly Npc VassaSsiss = new() { Ids = new int[] { 1855 }, Name = "Vassa Ssiss", WikiUrl = "https://wiki.guildwars.com/wiki/Vassa_Ssiss" };
    public static readonly Npc WissperInssani = new() { Ids = new int[] { 1856 }, Name = "Wissper Inssani", WikiUrl = "https://wiki.guildwars.com/wiki/Wissper_Inssani" };
    public static readonly Npc CustodianDellus = new() { Ids = new int[] { 1857 }, Name = "Custodian Dellus", WikiUrl = "https://wiki.guildwars.com/wiki/Custodian_Dellus" };
    public static readonly Npc CustodianJenus = new() { Ids = new int[] { 1858 }, Name = "Custodian Jenus", WikiUrl = "https://wiki.guildwars.com/wiki/Custodian_Jenus" };
    public static readonly Npc ForgottenCursebearer = new() { Ids = new int[] { 1862 }, Name = "Forgotten Cursebearer", WikiUrl = "https://wiki.guildwars.com/wiki/Forgotten_Cursebearer" };
    public static readonly Npc ForgottenArcanist = new() { Ids = new int[] { 1863 }, Name = "Forgotten Arcanist", WikiUrl = "https://wiki.guildwars.com/wiki/Forgotten_Arcanist" };
    public static readonly Npc ForgottenSage = new() { Ids = new int[] { 1864 }, Name = "Forgotten Sage", WikiUrl = "https://wiki.guildwars.com/wiki/Forgotten_Sage" };
    public static readonly Npc EnchantedHammer = new() { Ids = new int[] { 1865 }, Name = "Enchanted Hammer", WikiUrl = "https://wiki.guildwars.com/wiki/Enchanted_Hammer" };
    public static readonly Npc EnchantedSword = new() { Ids = new int[] { 1866, 6869 }, Name = "Enchanted Sword", WikiUrl = "https://wiki.guildwars.com/wiki/Enchanted_Sword" };
    public static readonly Npc EnchantedBow = new() { Ids = new int[] { 1867 }, Name = "Enchanted Bow", WikiUrl = "https://wiki.guildwars.com/wiki/Enchanted_Bow" };
    public static readonly Npc EnemyPriest = new() { Ids = new int[] { 1871 }, Name = "Enemy Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Enemy_Priest" };
    public static readonly Npc ForgottenChampion = new() { Ids = new int[] { 1872 }, Name = "Forgotten Champion", WikiUrl = "https://wiki.guildwars.com/wiki/Forgotten_Champion" };
    public static readonly Npc ForgottenAvenger = new() { Ids = new int[] { 1873 }, Name = "Forgotten Avenger", WikiUrl = "https://wiki.guildwars.com/wiki/Forgotten_Avenger" };
    public static readonly Npc Forgotten = new() { Ids = new int[] { 1874, 5002 }, Name = "Forgotten", WikiUrl = "https://wiki.guildwars.com/wiki/Forgotten" };
    public static readonly Npc Dunham = new() { Ids = new int[] { 1890, 1897, 1904, 1911, 1919, 1920, 2847 }, Name = "Dunham", WikiUrl = "https://wiki.guildwars.com/wiki/Dunham" };
    public static readonly Npc Claude = new() { Ids = new int[] { 1891, 1898, 1905, 1912, 1921, 2848 }, Name = "Claude", WikiUrl = "https://wiki.guildwars.com/wiki/Claude" };
    public static readonly Npc Orion = new() { Ids = new int[] { 1892, 1899, 1906, 1913, 1923, 2849, 1885, 1879, 1875 }, Name = "Orion", WikiUrl = "https://wiki.guildwars.com/wiki/Orion" };
    public static readonly Npc Alesia = new() { Ids = new int[] { 1893, 1900, 1907, 1914, 1925, 2850, 1886, 1880, 1876 }, Name = "Alesia", WikiUrl = "https://wiki.guildwars.com/wiki/Alesia" };
    public static readonly Npc LittleThom = new() { Ids = new int[] { 1894, 1901, 1908, 1916, 1929, 1930, 2844 }, Name = "Little Thom", WikiUrl = "https://wiki.guildwars.com/wiki/Little_Thom" };
    public static readonly Npc Stefan = new() { Ids = new int[] { 1895, 1902, 1909, 1917, 1931, 2845, 1888, 1881, 1877 }, Name = "Stefan", WikiUrl = "https://wiki.guildwars.com/wiki/Stefan" };
    public static readonly Npc Reyna = new() { Ids = new int[] { 1896, 1903, 1910, 1918, 1933, 2846, 1889, 1882, 1878 }, Name = "Reyna", WikiUrl = "https://wiki.guildwars.com/wiki/Reyna" };
    public static readonly Npc Lina = new() { Ids = new int[] { 1915, 1927, 1928, 2851, 5991 }, Name = "Lina", WikiUrl = "https://wiki.guildwars.com/wiki/Lina" };
    public static readonly Npc Eve = new() { Ids = new int[] { 1922, 2873, 3488, 4564, 4574, 5987, 4584 }, Name = "Eve", WikiUrl = "https://wiki.guildwars.com/wiki/Eve" };
    public static readonly Npc Mhenlo = new() { Ids = new int[] { 1926, 2136, 2855, 3121, 4577, 5990, 4587, 1503 }, Name = "Mhenlo", WikiUrl = "https://wiki.guildwars.com/wiki/Mhenlo" };
    public static readonly Npc Aidan = new() { Ids = new int[] { 1934, 2124, 2852, 3493, 4570, 4580, 5994, 4590, 2123 }, Name = "Aidan", WikiUrl = "https://wiki.guildwars.com/wiki/Aidan" };
    public static readonly Npc Olias = new() { Ids = new int[] { 1935, 1938 }, Name = "Olias", WikiUrl = "https://wiki.guildwars.com/wiki/Olias" };
    public static readonly Npc LyssasMuse = new() { Ids = new int[] { 1944 }, Name = "Lyssa's Muse", WikiUrl = "https://wiki.guildwars.com/wiki/Lyssa%27s_Muse" };
    public static readonly Npc VoiceOfGrenth = new() { Ids = new int[] { 1945 }, Name = "Voice Of Grenth", WikiUrl = "https://wiki.guildwars.com/wiki/Voice_of_Grenth" };
    public static readonly Npc AvatarOfDwayna = new() { Ids = new int[] { 1946 }, Name = "Avatar Of Dwayna", WikiUrl = "https://wiki.guildwars.com/wiki/Avatar_of_Dwayna" };
    public static readonly Npc KrytanMerchant = new() { Ids = new int[] { 1950, 1993, 1997, 2007, 2021, 2037, 2040, 2048 }, Name = "Krytan Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc KrytanHerald = new() { Ids = new int[] { 1958 }, Name = "Krytan Herald", WikiUrl = "https://wiki.guildwars.com/wiki/Krytan_Herald" };
    public static readonly Npc Lionguard = new() { Ids = new int[] { 1961, 1969, 2868 }, Name = "Lionguard", WikiUrl = "https://wiki.guildwars.com/wiki/Lionguard" };
    public static readonly Npc WintunTheBlack = new() { Ids = new int[] { 1964 }, Name = "Wintun The Black", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc RestlessSpirit = new() { Ids = new int[] { 1965 }, Name = "Restless Spirit", WikiUrl = "https://wiki.guildwars.com/wiki/Restless_Spirit" };
    public static readonly Npc AscalonianSettler = new() { Ids = new int[] { 1986, 1987 }, Name = "Ascalonian Settler", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalonian_Settler" };
    public static readonly Npc AscalonSettler = new() { Ids = new int[] { 1986, 1987 }, Name = "Ascalon Settler", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalon_Settler" };
    public static readonly Npc SettlementGuard = new() { Ids = new int[] { 1989 }, Name = "Settlement Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Settlement_Guard" };
    public static readonly Npc CaptainGreywind = new() { Ids = new int[] { 1990 }, Name = "Captain Greywind", WikiUrl = "https://wiki.guildwars.com/wiki/Captain_Greywind" };
    public static readonly Npc AscalonianGhost = new() { Ids = new int[] { 1998, 2141, 2353, 2354, 2355, 2534, 5617, 4975 }, Name = "Ascalonian Ghost", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Ghosts" };
    public static readonly Npc KrytanSmith = new() { Ids = new int[] { 2000 }, Name = "Krytan Smith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc WhiteMantleZealot = new() { Ids = new int[] { 2006, 2206, 2207 }, Name = "White Mantle Zealot", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Zealot" };
    public static readonly Npc CaptainGrumby = new() { Ids = new int[] { 2016 }, Name = "Captain Grumby", WikiUrl = "https://wiki.guildwars.com/wiki/Captain_Grumby" };
    public static readonly Npc CapturedChosen = new() { Ids = new int[] { 2034 }, Name = "Captured Chosen", WikiUrl = "https://wiki.guildwars.com/wiki/Captured_Chosen" };
    public static readonly Npc Ascalonian = new() { Ids = new int[] { 2066, 2071, 2872 }, Name = "Ascalonian", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalonian" };
    public static readonly Npc AscalonianEngineer = new() { Ids = new int[] { 2077 }, Name = "Ascalonian Engineer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc DeldrimorMerchant = new() { Ids = new int[] { 2111, 2140 }, Name = "Deldrimor Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dwarves" };
    public static readonly Npc DwarvenWeaponsmith = new() { Ids = new int[] { 2112 }, Name = "Dwarven Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dwarves" };
    public static readonly Npc CanthanMerchant = new() { Ids = new int[] { 2117, 2118, 2119, 2121, 3276, 3277, 3291 }, Name = "Canthan Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans"  };
    public static readonly Npc IrwynTheSevere = new() { Ids = new int[] { 2168 }, Name = "Irwyn The Severe", WikiUrl = "https://wiki.guildwars.com/wiki/Irwyn_the_Severe" };
    public static readonly Npc SelwinTheFervent = new() { Ids = new int[] { 2169 }, Name = "Selwin The Fervent", WikiUrl = "https://wiki.guildwars.com/wiki/Selwin_the_Fervent" };
    public static readonly Npc EdgarTheIronFist = new() { Ids = new int[] { 2170 }, Name = "Edgar The Iron Fist", WikiUrl = "https://wiki.guildwars.com/wiki/Edgar_the_Iron_Fist" };
    public static readonly Npc InnerCouncilMemberArgyle = new() { Ids = new int[] { 2171 }, Name = "Inner Council Member Argyle", WikiUrl = "https://wiki.guildwars.com/wiki/Inner_Council_Member_Argyle" };
    public static readonly Npc BraimaTheCallous = new() { Ids = new int[] { 2173 }, Name = "Braima The Callous", WikiUrl = "https://wiki.guildwars.com/wiki/Braima_the_Callous" };
    public static readonly Npc CyrusTheUnflattering = new() { Ids = new int[] { 2175 }, Name = "Cyrus The Unflattering", WikiUrl = "https://wiki.guildwars.com/wiki/Cyrus_the_Unflattering" };
    public static readonly Npc InnerCouncilMemberCuthbert = new() { Ids = new int[] { 2177 }, Name = "Inner Council Member Cuthbert", WikiUrl = "https://wiki.guildwars.com/wiki/Inner_Council_Member_Cuthbert" };
    public static readonly Npc MantonTheIndulgent = new() { Ids = new int[] { 2179 }, Name = "Manton The Indulgent", WikiUrl = "https://wiki.guildwars.com/wiki/Manton_the_Indulgent" };
    public static readonly Npc WhiteMantleWarriorBoss = new() { Ids = new int[] { 2181 }, Name = "White Mantle Warrior Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc CuthbertTheChaste = new() { Ids = new int[] { 2182 }, Name = "Cuthbert The Chaste", WikiUrl = "https://wiki.guildwars.com/wiki/Cuthbert_the_Chaste" };
    public static readonly Npc PleohTheUgly = new() { Ids = new int[] { 2185 }, Name = "Pleoh The Ugly", WikiUrl = "https://wiki.guildwars.com/wiki/Pleoh_the_Ugly" };
    public static readonly Npc JusticiarHablion = new() { Ids = new int[] { 2187 }, Name = "Justiciar Hablion", WikiUrl = "https://wiki.guildwars.com/wiki/Justiciar_Hablion" };
    public static readonly Npc Markis = new() { Ids = new int[] { 2189 }, Name = "Markis", WikiUrl = "https://wiki.guildwars.com/wiki/Markis" };
    public static readonly Npc ConfessorDorian = new() { Ids = new int[] { 2190 }, Name = "Confessor Dorian", WikiUrl = "https://wiki.guildwars.com/wiki/Confessor_Dorian" };
    public static readonly Npc WhiteMantleSycophant = new() { Ids = new int[] { 2197 }, Name = "White Mantle Sycophant", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Sycophant" };
    public static readonly Npc WhiteMantleRitualist = new() { Ids = new int[] { 2198 }, Name = "White Mantle Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Ritualist" };
    public static readonly Npc WhiteMantleSavant = new() { Ids = new int[] { 2199 }, Name = "White Mantle Savant", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Savant" };
    public static readonly Npc WhiteMantleAbbot = new() { Ids = new int[] { 2200 }, Name = "White Mantle Abbot", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Abbot" };
    public static readonly Npc WhiteMantlePriest = new() { Ids = new int[] { 2201 }, Name = "White Mantle Priest", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Priest" };
    public static readonly Npc WhiteMantleKnight = new() { Ids = new int[] { 2202 }, Name = "White Mantle Knight", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Knight" };
    public static readonly Npc WhiteMantleJusticiar = new() { Ids = new int[] { 2204, 2205 }, Name = "White Mantle Justiciar", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Justiciar" };
    public static readonly Npc WhiteMantleSeeker = new() { Ids = new int[] { 2208, 2227 }, Name = "White Mantle Seeker", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Seeker" };
    public static readonly Npc WhiteMantleRanger = new() { Ids = new int[] { 2209 }, Name = "White Mantle Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc WhiteMantleElementalist = new() { Ids = new int[] { 2219 }, Name = "White Mantle Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc JusticiarThommis = new() { Ids = new int[] { 2223 }, Name = "Justiciar Thommis", WikiUrl = "https://wiki.guildwars.com/wiki/Justiciar_Thommis" };
    public static readonly Npc BoneHorror = new() { Ids = new int[] { 2230 }, Name = "Bone Horror", WikiUrl = "https://wiki.guildwars.com/wiki/Bone_Horror" };
    public static readonly Npc BoneFiend = new() { Ids = new int[] { 2231 }, Name = "Bone Fiend", WikiUrl = "https://wiki.guildwars.com/wiki/Bone_Fiend" };
    public static readonly Npc MursaatMesmerBoss = new() { Ids = new int[] { 2235 }, Name = "Mursaat Mesmer Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Mesmer_(boss)" };
    public static readonly Npc MursaatNecromancerBoss = new() { Ids = new int[] { 2236 }, Name = "Mursaat Necromancer Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Necromancer_(boss)" };
    public static readonly Npc MursaatElementalistBoss = new() { Ids = new int[] { 2237 }, Name = "Mursaat Elementalist Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Elementalist_(boss)" };
    public static readonly Npc MursaatMonkBoss = new() { Ids = new int[] { 2238 }, Name = "Mursaat Monk Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Monk_(boss)" };
    public static readonly Npc MursaatWarriorBoss = new() { Ids = new int[] { 2239 }, Name = "Mursaat Warrior Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Armor_(boss)" };
    public static readonly Npc MursaatRangerBoss = new() { Ids = new int[] { 2240 }, Name = "Mursaat Ranger Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Bow_(boss)" };
    public static readonly Npc MursaatMesmer = new() { Ids = new int[] { 2241 }, Name = "Mursaat Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Mesmer" };
    public static readonly Npc MursaatNecromancer = new() { Ids = new int[] { 2242 }, Name = "Mursaat Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Necromancer" };
    public static readonly Npc MursaatElementalist = new() { Ids = new int[] { 2243 }, Name = "Mursaat Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Elementalist" };
    public static readonly Npc MursaatMonk = new() { Ids = new int[] { 2245 }, Name = "Mursaat Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Mursaat_Monk" };
    public static readonly Npc JadeArmor = new() { Ids = new int[] { 2249 }, Name = "Jade Armor", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Armor" };
    public static readonly Npc JadeBow = new() { Ids = new int[] { 2250 }, Name = "Jade Bow", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Bow" };
    public static readonly Npc EtherSeal = new() { Ids = new int[] { 2251 }, Name = "Ether Seal", WikiUrl = "https://wiki.guildwars.com/wiki/Ether_Seal" };
    public static readonly Npc HeppBilespitter = new() { Ids = new int[] { 2255 }, Name = "Hepp Bilespitter", WikiUrl = "https://wiki.guildwars.com/wiki/Hepp_Bilespitter" };
    public static readonly Npc MosskRottail = new() { Ids = new int[] { 2256 }, Name = "Mossk Rottail", WikiUrl = "https://wiki.guildwars.com/wiki/Mossk_Rottail" };
    public static readonly Npc Thornwrath = new() { Ids = new int[] { 2257 }, Name = "Thornwrath", WikiUrl = "https://wiki.guildwars.com/wiki/Thornwrath" };
    public static readonly Npc WindRiderBoss = new() { Ids = new int[] { 2261 }, Name = "Wind Rider Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_rider_bosses" };
    public static readonly Npc GrechTrundle = new() { Ids = new int[] { 2262 }, Name = "Grech Trundle", WikiUrl = "https://wiki.guildwars.com/wiki/Grech_Trundle" };
    public static readonly Npc WyddKindlerun = new() { Ids = new int[] { 2263 }, Name = "Wydd Kindlerun", WikiUrl = "https://wiki.guildwars.com/wiki/Wydd_Kindlerun" };
    public static readonly Npc TreeOfVitality = new() { Ids = new int[] { 2264 }, Name = "Tree Of Vitality", WikiUrl = "https://wiki.guildwars.com/wiki/Tree_of_Vitality" };
    public static readonly Npc KaraBloodtail = new() { Ids = new int[] { 2268 }, Name = "Kara Bloodtail", WikiUrl = "https://wiki.guildwars.com/wiki/Kara_Bloodtail" };
    public static readonly Npc MaguumaElementalistBoss = new() { Ids = new int[] { 2269 }, Name = "Maguuma Elementalist Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_centaur_bosses" };
    public static readonly Npc ThornStalkerMonkBoss = new() { Ids = new int[] { 2273 }, Name = "Thorn Stalker Monk Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_centaur_bosses" };
    public static readonly Npc DrogoGreatmane = new() { Ids = new int[] { 2285 }, Name = "Drogo Greatmane", WikiUrl = "https://wiki.guildwars.com/wiki/Drogo_Greatmane" };
    public static readonly Npc GaleStormsend = new() { Ids = new int[] { 2287 }, Name = "Gale Stormsend", WikiUrl = "https://wiki.guildwars.com/wiki/Gale_Stormsend" };
    public static readonly Npc WindRider = new() { Ids = new int[] { 2289, 2290, 6302 }, Name = "Wind Rider", WikiUrl = "https://wiki.guildwars.com/wiki/Wind_Rider" };
    public static readonly Npc RootBehemoth = new() { Ids = new int[] { 2292 }, Name = "Root Behemoth", WikiUrl = "https://wiki.guildwars.com/wiki/Root_Behemoth" };
    public static readonly Npc MaguumaEnchanter = new() { Ids = new int[] { 2294 }, Name = "Maguuma Enchanter", WikiUrl = "https://wiki.guildwars.com/wiki/Maguuma_Enchanter" };
    public static readonly Npc MaguumaWarlock = new() { Ids = new int[] { 2295 }, Name = "Maguuma Warlock", WikiUrl = "https://wiki.guildwars.com/wiki/Maguuma_Warlock" };
    public static readonly Npc MaguumaAvenger = new() { Ids = new int[] { 2296 }, Name = "Maguuma Avenger", WikiUrl = "https://wiki.guildwars.com/wiki/Maguuma_Avenger" };
    public static readonly Npc MaguumaProtector = new() { Ids = new int[] { 2297 }, Name = "Maguuma Protector", WikiUrl = "https://wiki.guildwars.com/wiki/Maguuma_Protector" };
    public static readonly Npc MaguumaWarrior = new() { Ids = new int[] { 2298, 2299 }, Name = "Maguuma Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Maguuma_Warrior" };
    public static readonly Npc MaguumaHunter = new() { Ids = new int[] { 2300 }, Name = "Maguuma Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Maguuma_Hunter" };
    public static readonly Npc FeveredDevourer = new() { Ids = new int[] { 2301 }, Name = "Fevered Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Fevered_Devourer" };
    public static readonly Npc ThornDevourer = new() { Ids = new int[] { 2302 }, Name = "Thorn Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Thorn_Devourer" };
    public static readonly Npc ThornDevourerDrone = new() { Ids = new int[] { 2303 }, Name = "Thorn Devourer Drone", WikiUrl = "https://wiki.guildwars.com/wiki/Thorn_Devourer_Drone" };
    public static readonly Npc ThornStalker = new() { Ids = new int[] { 2304 }, Name = "Thorn Stalker", WikiUrl = "https://wiki.guildwars.com/wiki/Thorn_Stalker" };
    public static readonly Npc ThornStalkerSprout = new() { Ids = new int[] { 2305 }, Name = "Thorn Stalker Sprout", WikiUrl = "https://wiki.guildwars.com/wiki/Thorn_Stalker_Sprout" };
    public static readonly Npc LifePod = new() { Ids = new int[] { 2306 }, Name = "Life Pod", WikiUrl = "https://wiki.guildwars.com/wiki/Life_Pod" };
    public static readonly Npc EntanglingRoots = new() { Ids = new int[] { 2307 }, Name = "Entangling Roots", WikiUrl = "https://wiki.guildwars.com/wiki/Entangling_Roots" };
    public static readonly Npc RedwoodShepherd = new() { Ids = new int[] { 2308 }, Name = "Redwood Shepherd", WikiUrl = "https://wiki.guildwars.com/wiki/Redwood_Shepherd" };
    public static readonly Npc MossScarab = new() { Ids = new int[] { 2309, 2310 }, Name = "Moss Scarab", WikiUrl = "https://wiki.guildwars.com/wiki/Moss_Scarab" };
    public static readonly Npc MaguumaSpider = new() { Ids = new int[] { 2312 }, Name = "Maguuma Spider", WikiUrl = "https://wiki.guildwars.com/wiki/Maguuma_Spider" };
    public static readonly Npc JungleTroll = new() { Ids = new int[] { 2313, 2314 }, Name = "Jungle Troll", WikiUrl = "https://wiki.guildwars.com/wiki/Jungle_Troll" };
    public static readonly Npc HormFrostrider = new() { Ids = new int[] { 2472 }, Name = "Horm Frostrider", WikiUrl = "https://wiki.guildwars.com/wiki/Horm_Frostrider" };
    public static readonly Npc DigoMurkstalker = new() { Ids = new int[] { 2501 }, Name = "Digo Murkstalker", WikiUrl = "https://wiki.guildwars.com/wiki/Digo_Murkstalker" };
    public static readonly Npc CeruGloomrunner = new() { Ids = new int[] { 2502 }, Name = "Ceru Gloomrunner", WikiUrl = "https://wiki.guildwars.com/wiki/Ceru_Gloomrunner" };
    public static readonly Npc EnslavedFrostGiant = new() { Ids = new int[] { 2530 }, Name = "Enslaved Frost Giant", WikiUrl = "https://wiki.guildwars.com/wiki/Enslaved_Frost_Giant" };
    public static readonly Npc BlessedGriffon = new() { Ids = new int[] { 2532 }, Name = "Blessed Griffon", WikiUrl = "https://wiki.guildwars.com/wiki/Blessed_Griffon" };
    public static readonly Npc IceImp = new() { Ids = new int[] { 2533, 6947 }, Name = "Ice Imp", WikiUrl = "https://wiki.guildwars.com/wiki/Ice_Imp" };
    public static readonly Npc AzureShadow = new() { Ids = new int[] { 2535 }, Name = "Azure Shadow", WikiUrl = "https://wiki.guildwars.com/wiki/Azure_Shadow" };
    public static readonly Npc Pinesoul = new() { Ids = new int[] { 2536 }, Name = "Pinesoul", WikiUrl = "https://wiki.guildwars.com/wiki/Pinesoul" };
    public static readonly Npc AvicaraBrave = new() { Ids = new int[] { 2540 }, Name = "Avicara Brave", WikiUrl = "https://wiki.guildwars.com/wiki/Avicara_Brave" };
    public static readonly Npc AvicaraFierce = new() { Ids = new int[] { 2541 }, Name = "Avicara Fierce", WikiUrl = "https://wiki.guildwars.com/wiki/Avicara_Fierce" };
    public static readonly Npc MountainTroll = new() { Ids = new int[] { 2546 }, Name = "Mountain Troll", WikiUrl = "https://wiki.guildwars.com/wiki/Mountain_Troll" };
    public static readonly Npc Seer = new() { Ids = new int[] { 2549 }, Name = "Seer", WikiUrl = "https://wiki.guildwars.com/wiki/Seer" };
    public static readonly Npc Eidolon = new() { Ids = new int[] { 2552 }, Name = "Eidolon", WikiUrl = "https://wiki.guildwars.com/wiki/Eidolon" };
    public static readonly Npc EnslavedEttin = new() { Ids = new int[] { 2599 }, Name = "Enslaved Ettin", WikiUrl = "https://wiki.guildwars.com/wiki/Enslaved_Ettin" };
    public static readonly Npc StoneSummitMesmerBoss = new() { Ids = new int[] { 2629 }, Name = "Stone Summit Mesmer Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_dolyak_bosses" };
    public static readonly Npc HormakIroncurse = new() { Ids = new int[] { 2630 }, Name = "Hormak Ironcurse", WikiUrl = "https://wiki.guildwars.com/wiki/Hormak_Ironcurse" };
    public static readonly Npc IceElementalElementalistBoss = new() { Ids = new int[] { 2631 }, Name = "Ice Elemental Elementalist Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_elemental_bosses" };
    public static readonly Npc StoneSummitMonkBoss = new() { Ids = new int[] { 2632 }, Name = "Stone Summit Monk Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_dolyak_bosses" };
    public static readonly Npc StoneSummitWarriorBoss = new() { Ids = new int[] { 2634 }, Name = "Stone Summit Warrior Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_dolyak_bosses" };
    public static readonly Npc DagnarStonepate = new() { Ids = new int[] { 2637 }, Name = "Dagnar Stonepate", WikiUrl = "https://wiki.guildwars.com/wiki/Dagnar_Stonepate" };
    public static readonly Npc SummitBeastmaster = new() { Ids = new int[] { 2648 }, Name = "Summit Beastmaster", WikiUrl = "https://wiki.guildwars.com/wiki/Summit_Beastmaster" };
    public static readonly Npc StoneSummitHeretic = new() { Ids = new int[] { 2650 }, Name = "Stone Summit Heretic", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Heretic" };
    public static readonly Npc DolyakMaster = new() { Ids = new int[] { 2651 }, Name = "Dolyak Master", WikiUrl = "https://wiki.guildwars.com/wiki/Dolyak_Master" };
    public static readonly Npc StoneSummitGnasher = new() { Ids = new int[] { 2653, 6698 }, Name = "Stone Summit Gnasher", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Gnasher" };
    public static readonly Npc StoneSummitCarver = new() { Ids = new int[] { 2654, 6692, 6701 }, Name = "Stone Summit Carver", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Carver" };
    public static readonly Npc SiegeIceGolem = new() { Ids = new int[] { 2656 }, Name = "Siege Ice Golem", WikiUrl = "https://wiki.guildwars.com/wiki/Siege_Ice_Golem" };
    public static readonly Npc SummitGiantHerder = new() { Ids = new int[] { 2657 }, Name = "Summit Giant Herder", WikiUrl = "https://wiki.guildwars.com/wiki/Summit_Giant_Herder" };
    public static readonly Npc MolesQuibus = new() { Ids = new int[] { 2658 }, Name = "Moles Quibus", WikiUrl = "https://wiki.guildwars.com/wiki/Moles_Quibus" };
    public static readonly Npc MaligoLibens = new() { Ids = new int[] { 2659 }, Name = "Maligo Libens", WikiUrl = "https://wiki.guildwars.com/wiki/Maligo_Libens" };
    public static readonly Npc ScelusProsum = new() { Ids = new int[] { 2660 }, Name = "Scelus Prosum", WikiUrl = "https://wiki.guildwars.com/wiki/Scelus_Prosum" };
    public static readonly Npc TortitudoProbo = new() { Ids = new int[] { 2661 }, Name = "Tortitudo Probo", WikiUrl = "https://wiki.guildwars.com/wiki/Tortitudo_Probo" };
    public static readonly Npc ValetudoRubor = new() { Ids = new int[] { 2662 }, Name = "Valetudo Rubor", WikiUrl = "https://wiki.guildwars.com/wiki/Valetudo_Rubor" };
    public static readonly Npc SparkOfTheTitans = new() { Ids = new int[] { 2668 }, Name = "Spark Of The Titans", WikiUrl = "https://wiki.guildwars.com/wiki/Spark_of_the_Titans" };
    public static readonly Npc RisenAshenHulk = new() { Ids = new int[] { 2669 }, Name = "Risen Ashen Hulk", WikiUrl = "https://wiki.guildwars.com/wiki/Risen_Ashen_Hulk" };
    public static readonly Npc BurningTitan = new() { Ids = new int[] { 2670 }, Name = "Burning Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Burning_Titan" };
    public static readonly Npc HandOfTheTitans = new() { Ids = new int[] { 2671 }, Name = "Hand Of The Titans", WikiUrl = "https://wiki.guildwars.com/wiki/Hand_of_the_Titans" };
    public static readonly Npc FistOfTheTitans = new() { Ids = new int[] { 2672 }, Name = "Fist Of The Titans", WikiUrl = "https://wiki.guildwars.com/wiki/Fist_of_the_Titans" };
    public static readonly Npc UndeadLich = new() { Ids = new int[] { 2695, 4953 }, Name = "Undead Lich", WikiUrl = "https://wiki.guildwars.com/wiki/Undead_Lich" };
    public static readonly Npc UndeadPrinceRurik = new() { Ids = new int[] { 2698 }, Name = "Undead Prince Rurik", WikiUrl = "https://wiki.guildwars.com/wiki/Undead_Prince_Rurik" };
    public static readonly Npc ZaimGrimeclaw = new() { Ids = new int[] { 2700 }, Name = "Zaim Grimeclaw", WikiUrl = "https://wiki.guildwars.com/wiki/Zaim_Grimeclaw" };
    public static readonly Npc Ruinwing = new() { Ids = new int[] { 2729 }, Name = "Ruinwing", WikiUrl = "https://wiki.guildwars.com/wiki/Ruinwing" };
    public static readonly Npc Hellhound = new() { Ids = new int[] { 2730 }, Name = "Hellhound", WikiUrl = "https://wiki.guildwars.com/wiki/Hellhound" };
    public static readonly Npc GraspingGhoul = new() { Ids = new int[] { 2732, 2731 }, Name = "Grasping Ghoul", WikiUrl = "https://wiki.guildwars.com/wiki/Grasping_Ghoul" };
    public static readonly Npc SkeletonRanger = new() { Ids = new int[] { 2739 }, Name = "Skeleton Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Ranger" };
    public static readonly Npc BoneDragon = new() { Ids = new int[] { 2741 }, Name = "Bone Dragon", WikiUrl = "https://wiki.guildwars.com/wiki/Bone_Dragon" };
    public static readonly Npc VizierKhilbron = new() { Ids = new int[] { 2748, 2749 }, Name = "Vizier Khilbron", WikiUrl = "https://wiki.guildwars.com/wiki/Vizier_Khilbron" };
    public static readonly Npc JythSprayburst = new() { Ids = new int[] { 2763 }, Name = "Jyth Sprayburst", WikiUrl = "https://wiki.guildwars.com/wiki/Jyth_Sprayburst" };
    public static readonly Npc DosakaruFevertouch = new() { Ids = new int[] { 2766 }, Name = "Dosakaru Fevertouch", WikiUrl = "https://wiki.guildwars.com/wiki/Dosakaru_Fevertouch" };
    public static readonly Npc SkintekaruManshredder = new() { Ids = new int[] { 2768 }, Name = "Skintekaru Manshredder", WikiUrl = "https://wiki.guildwars.com/wiki/Skintekaru_Manshredder" };
    public static readonly Npc GossDarkweb = new() { Ids = new int[] { 2770 }, Name = "Goss Darkweb", WikiUrl = "https://wiki.guildwars.com/wiki/Goss_Darkweb" };
    public static readonly Npc FerkMallet = new() { Ids = new int[] { 2773 }, Name = "Ferk Mallet", WikiUrl = "https://wiki.guildwars.com/wiki/Ferk_Mallet" };
    public static readonly Npc VulgPainbrain = new() { Ids = new int[] { 2774 }, Name = "Vulg Painbrain", WikiUrl = "https://wiki.guildwars.com/wiki/Vulg_Painbrain" };
    public static readonly Npc GrenthsCursed = new() { Ids = new int[] { 2780 }, Name = "Grenth's Cursed", WikiUrl = "https://wiki.guildwars.com/wiki/Grenth%27s_Cursed" };
    public static readonly Npc MaxineColdstone = new() { Ids = new int[] { 2784 }, Name = "Maxine Coldstone", WikiUrl = "https://wiki.guildwars.com/wiki/Maxine_Coldstone" };
    public static readonly Npc RwekKhawlMawl = new() { Ids = new int[] { 2785 }, Name = "Rwek Khawl Mawl", WikiUrl = "https://wiki.guildwars.com/wiki/Rwek_Khawl_Mawl" };
    public static readonly Npc BreezeKeeper = new() { Ids = new int[] { 2789 }, Name = "Breeze Keeper", WikiUrl = "https://wiki.guildwars.com/wiki/Breeze_Keeper" };
    public static readonly Npc CragBehemoth = new() { Ids = new int[] { 2790 }, Name = "Crag Behemoth", WikiUrl = "https://wiki.guildwars.com/wiki/Crag_Behemoth" };
    public static readonly Npc Drake = new() { Ids = new int[] { 2791, 8147 }, Name = "Drake", WikiUrl = "https://wiki.guildwars.com/wiki/Drake" };
    public static readonly Npc DarkFlameDryder = new() { Ids = new int[] { 2792 }, Name = "Dark Flame Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Dark_Flame_Dryder" };
    public static readonly Npc IgneousEttin = new() { Ids = new int[] { 2793 }, Name = "Igneous Ettin", WikiUrl = "https://wiki.guildwars.com/wiki/Igneous_Ettin" };
    public static readonly Npc Phantom = new() { Ids = new int[] { 2794 }, Name = "Phantom", WikiUrl = "https://wiki.guildwars.com/wiki/Phantom" };
    public static readonly Npc FleshGolem = new() { Ids = new int[] { 2795 }, Name = "Flesh Golem", WikiUrl = "https://wiki.guildwars.com/wiki/Flesh_Golem" };
    public static readonly Npc MahgoHydra = new() { Ids = new int[] { 2796 }, Name = "Mahgo Hydra", WikiUrl = "https://wiki.guildwars.com/wiki/Mahgo_Hydra" };
    public static readonly Npc Wurm = new() { Ids = new int[] { 2798 }, Name = "Wurm", WikiUrl = "https://wiki.guildwars.com/wiki/Wurm" };
    public static readonly Npc GhostMesmer = new() { Ids = new int[] { 2828 }, Name = "Ghost Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Ghosts" };
    public static readonly Npc GhostWarrior = new() { Ids = new int[] { 2833 }, Name = "Ghost Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Ghosts" };
    public static readonly Npc ShiningBlade = new() { Ids = new int[] { 2842, 2843 }, Name = "Shining Blade", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade" };
    public static readonly Npc FirstwatchSergio = new() { Ids = new int[] { 2857 }, Name = "Firstwatch Sergio", WikiUrl = "https://wiki.guildwars.com/wiki/Firstwatch_Sergio" };
    public static readonly Npc KrytanChild = new() { Ids = new int[] { 2859 }, Name = "Krytan Child", WikiUrl = "https://wiki.guildwars.com/wiki/Krytan_Child" };
    public static readonly Npc Oink = new() { Ids = new int[] { 2860 }, Name = "Oink", WikiUrl = "https://wiki.guildwars.com/wiki/Oink" };
    public static readonly Npc Carlotta = new() { Ids = new int[] { 2861 }, Name = "Carlotta", WikiUrl = "https://wiki.guildwars.com/wiki/Carlotta" };
    public static readonly Npc KingAdelbern = new() { Ids = new int[] { 2862, 2055 }, Name = "King Adelbern", WikiUrl = "https://wiki.guildwars.com/wiki/King_Adelbern" };
    public static readonly Npc DukeBarradin = new() { Ids = new int[] { 2864 }, Name = "Duke Barradin", WikiUrl = "https://wiki.guildwars.com/wiki/Duke_Barradin" };
    public static readonly Npc Joe = new() { Ids = new int[] { 2865 }, Name = "Joe", WikiUrl = "https://wiki.guildwars.com/wiki/Joe" };
    public static readonly Npc Shadow = new() { Ids = new int[] { 2870 }, Name = "Shadow", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow" };
    public static readonly Npc Vanguard = new() { Ids = new int[] { 2871, 6026, 6027, 6029, 6042, 2099, 2100 }, Name = "Vanguard", WikiUrl = "https://wiki.guildwars.com/wiki/Vanguard" };
    public static readonly Npc SpiritOfWinter = new() { Ids = new int[] { 2874 }, Name = "Spirit Of Winter", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Winter" };
    public static readonly Npc SpiritOfSymbiosis = new() { Ids = new int[] { 2879 }, Name = "Spirit Of Symbiosis", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Symbiosis" };
    public static readonly Npc SpiritOfPrimalEchoes = new() { Ids = new int[] { 2880 }, Name = "Spirit Of Primal Echoes", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Primal_Echoes" };
    public static readonly Npc SpiritOfFrozenSoil = new() { Ids = new int[] { 2882 }, Name = "Spirit Of Frozen Soil", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Frozen_Soil" };
    public static readonly Npc Crane = new() { Ids = new int[] { 2953 }, Name = "Crane", WikiUrl = "https://wiki.guildwars.com/wiki/Crane" };
    public static readonly Npc Tiger = new() { Ids = new int[] { 2954 }, Name = "Tiger", WikiUrl = "https://wiki.guildwars.com/wiki/Tiger" };
    public static readonly Npc Lurker = new() { Ids = new int[] { 2955 }, Name = "Lurker", WikiUrl = "https://wiki.guildwars.com/wiki/Lurker" };
    public static readonly Npc ReefLurker = new() { Ids = new int[] { 2956 }, Name = "Reef Lurker", WikiUrl = "https://wiki.guildwars.com/wiki/Reef_Lurker" };
    public static readonly Npc WhiteTiger = new() { Ids = new int[] { 2957 }, Name = "White Tiger", WikiUrl = "https://wiki.guildwars.com/wiki/White_Tiger" };
    public static readonly Npc ElderReefLurker = new() { Ids = new int[] { 2959 }, Name = "Elder Reef Lurker", WikiUrl = "https://wiki.guildwars.com/wiki/Reef_Lurker" };
    public static readonly Npc ElderCrane = new() { Ids = new int[] { 2969 }, Name = "Elder Crane", WikiUrl = "https://wiki.guildwars.com/wiki/Elder_Crane" };
    public static readonly Npc ElderTiger = new() { Ids = new int[] { 2974 }, Name = "Elder Tiger", WikiUrl = "https://wiki.guildwars.com/wiki/Tiger" };
    public static readonly Npc KurzickNoble = new() { Ids = new int[] { 3030, 3337, 3396, 3397, 3398, 3399 }, Name = "Kurzick Noble", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Noble" };
    public static readonly Npc CrimsonSkullMonk = new() { Ids = new int[] { 3055 }, Name = "Crimson Skull Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Healer" };
    public static readonly Npc GullHookbeak = new() { Ids = new int[] { 3058 }, Name = "Gull Hookbeak", WikiUrl = "https://wiki.guildwars.com/wiki/Gull_Hookbeak" };
    public static readonly Npc YrrgSnagtooth = new() { Ids = new int[] { 3059 }, Name = "Yrrg Snagtooth", WikiUrl = "https://wiki.guildwars.com/wiki/Yrrg_Snagtooth" };
    public static readonly Npc YorrtStrongjaw = new() { Ids = new int[] { 3060 }, Name = "Yorrt Strongjaw", WikiUrl = "https://wiki.guildwars.com/wiki/Yorrt_Strongjaw" };
    public static readonly Npc CanthanGuardRecruit = new() { Ids = new int[] { 3069, 3229 }, Name = "Canthan Guard Recruit", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Guard" };
    public static readonly Npc HeadmasterVhang = new() { Ids = new int[] { 3077, 3336, 3490 }, Name = "Headmaster Vhang", WikiUrl = "https://wiki.guildwars.com/wiki/Headmaster_Vhang" };
    public static readonly Npc MasterTogo = new() { Ids = new int[] { 3078, 3081, 3120, 3215 }, Name = "Master Togo", WikiUrl = "https://wiki.guildwars.com/wiki/Master_Togo" };
    public static readonly Npc ZaishenScout = new() { Ids = new int[] { 3079 }, Name = "Zaishen Scout", WikiUrl = "https://wiki.guildwars.com/wiki/Zaishen_Scout" };
    public static readonly Npc YijoTahn = new() { Ids = new int[] { 3082 }, Name = "Yijo Tahn", WikiUrl = "https://wiki.guildwars.com/wiki/Yijo_Tahn" };
    public static readonly Npc ShadyLuxon = new() { Ids = new int[] { 3094 }, Name = "Shady Luxon", WikiUrl = "https://wiki.guildwars.com/wiki/Shady_Luxon" };
    public static readonly Npc SuspiciousKurzick = new() { Ids = new int[] { 3095 }, Name = "Suspicious Kurzick", WikiUrl = "https://wiki.guildwars.com/wiki/Suspicious_Kurzick" };
    public static readonly Npc ZhuHanuku = new() { Ids = new int[] { 3097 }, Name = "Zhu Hanuku", WikiUrl = "https://wiki.guildwars.com/wiki/Zhu_Hanuku" };
    public static readonly Npc ShadowBladeAssassin = new() { Ids = new int[] { 3122 }, Name = "Shadow Blade Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Blade_Assassin" };
    public static readonly Npc AmFahAssassin = new() { Ids = new int[] { 3157, 4191 }, Name = "Am Fah Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Am_Fah_Assassin" };
    public static readonly Npc LuxonAssassin = new() { Ids = new int[] { 3159, 3569, 3603 }, Name = "Luxon Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Assassin" };
    public static readonly Npc LuxonMesmer = new() { Ids = new int[] { 3160, 3570, 3614 }, Name = "Luxon Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Mesmer" };
    public static readonly Npc LuxonElementalist = new() { Ids = new int[] { 3161, 3572, 3615 }, Name = "Luxon Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Elementalist" };
    public static readonly Npc LuxonMonk = new() { Ids = new int[] { 3162, 3339, 3616, 3643 }, Name = "Luxon Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Monk" };
    public static readonly Npc LuxonWarrior = new() { Ids = new int[] { 3163, 3574 }, Name = "Luxon Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Warrior" };
    public static readonly Npc LuxonRanger = new() { Ids = new int[] { 3164, 3575, 3595, 3607 }, Name = "Luxon Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Ranger" };
    public static readonly Npc EmperorKisu = new() { Ids = new int[] { 3196 }, Name = "Emperor Kisu", WikiUrl = "https://wiki.guildwars.com/wiki/Emperor_Kisu" };
    public static readonly Npc Jamei = new() { Ids = new int[] { 3219, 3941 }, Name = "Jamei", WikiUrl = "https://wiki.guildwars.com/wiki/Jamei" };
    public static readonly Npc TalonSilverwing = new() { Ids = new int[] { 3226, 3471, 3501, 5992 }, Name = "Talon Silverwing", WikiUrl = "https://wiki.guildwars.com/wiki/Talon_Silverwing" };
    public static readonly Npc CanthanGuardCaptain = new() { Ids = new int[] { 3231, 3338 }, Name = "Canthan Guard Captain", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Guard_Captain" };
    public static readonly Npc PalaceGuard = new() { Ids = new int[] { 3232, 5636 }, Name = "Palace Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Palace_Guard" };
    public static readonly Npc CanthanChild = new() { Ids = new int[] { 3238 }, Name = "Canthan Child", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Child" };
    public static readonly Npc CanthanNoble = new() { Ids = new int[] { 3241, 3242, 3243, 3244, 3304, 3317, 3333, 3334 }, Name = "Canthan Noble", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Noble" };
    public static readonly Npc CanthanBarkeep = new() { Ids = new int[] { 3247, 3252 }, Name = "Canthan Barkeep", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Peasant" };
    public static readonly Npc CanthanPeasant = new() { Ids = new int[] { 3248, 3256, 3258, 3266, 3289, 3303 }, Name = "Canthan Peasant", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Peasant" };
    public static readonly Npc KurzickGuard = new() { Ids = new int[] { 3249, 3388, 3430, 3431, 3429 }, Name = "Kurzick Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Guard" };
    public static readonly Npc ShingJeaCollector = new() { Ids = new int[] { 3255, 3310 }, Name = "Shing Jea Collector", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc CanthanAdept = new() { Ids = new int[] { 3267 }, Name = "Canthan Adept", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc CanthanTrader = new() { Ids = new int[] { 3269, 3270, 3275, 3279, 3288, 3295, 3311 }, Name = "Canthan Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Canthan_Trader" };
    public static readonly Npc CanthanArmorer = new() { Ids = new int[] { 3272, 3273, 3281 }, Name = "Canthan Armorer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc FireworksMaster = new() { Ids = new int[] { 3274 }, Name = "Fireworks Master", WikiUrl = "https://wiki.guildwars.com/wiki/Fireworks_Master" };
    public static readonly Npc CanthanWeaponsmith = new() { Ids = new int[] { 3280 }, Name = "Canthan Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc ShingJeaTrader = new() { Ids = new int[] { 3290, 3292 }, Name = "Shing Jea Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc Su = new() { Ids = new int[] { 3309, 3468, 3498 }, Name = "Su", WikiUrl = "https://wiki.guildwars.com/wiki/Su" };
    public static readonly Npc SisterTai = new() { Ids = new int[] { 3315, 3470, 3500, 3512 }, Name = "Sister Tai", WikiUrl = "https://wiki.guildwars.com/wiki/Sister_Tai" };
    public static readonly Npc WengGha = new() { Ids = new int[] { 3320 }, Name = "Weng Gha", WikiUrl = "https://wiki.guildwars.com/wiki/Weng_Gha" };
    public static readonly Npc CanthanRangerTrainer = new() { Ids = new int[] { 3326 }, Name = "Canthan Ranger Trainer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc ProfessorGai = new() { Ids = new int[] { 3330, 3473, 3503 }, Name = "Professor Gai", WikiUrl = "https://wiki.guildwars.com/wiki/Professor_Gai" };
    public static readonly Npc AscalonGuardGhost = new() { Ids = new int[] { 3332 }, Name = "Ascalon Guard Ghost", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Ghosts" };
    public static readonly Npc FortuneTeller = new() { Ids = new int[] { 3335 }, Name = "Fortune Teller", WikiUrl = "https://wiki.guildwars.com/wiki/Fortune_Teller" };
    public static readonly Npc CanthanRitualist = new() { Ids = new int[] { 3340 }, Name = "Canthan Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc GeneralKaimerVasburg = new() { Ids = new int[] { 3348 }, Name = "General Kaimer Vasburg", WikiUrl = "https://wiki.guildwars.com/wiki/General_Kaimer_Vasburg" };
    public static readonly Npc KurzickJuggernaut = new() { Ids = new int[] { 3349 }, Name = "Kurzick Juggernaut", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Juggernaut" };
    public static readonly Npc KurzickAssassin = new() { Ids = new int[] { 3350, 3405 }, Name = "Kurzick Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Assassin" };
    public static readonly Npc KurzickMesmer = new() { Ids = new int[] { 3351, 3393 }, Name = "Kurzick Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Mesmer" };
    public static readonly Npc KurzickNecromancer = new() { Ids = new int[] { 3352 }, Name = "Kurzick Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Necromancer" };
    public static readonly Npc KurzickElementalist = new() { Ids = new int[] { 3353 }, Name = "Kurzick Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Elementalist" };
    public static readonly Npc KurzickMonk = new() { Ids = new int[] { 3354 }, Name = "Kurzick Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Monk" };
    public static readonly Npc KurzickWarrior = new() { Ids = new int[] { 3355 }, Name = "Kurzick Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Warrior" };
    public static readonly Npc KurzickRanger = new() { Ids = new int[] { 3356, 3382 }, Name = "Kurzick Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Ranger" };
    public static readonly Npc KurzickRitualist = new() { Ids = new int[] { 3357 }, Name = "Kurzick Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Ritualist" };
    public static readonly Npc Juggernaut = new() { Ids = new int[] { 3367 }, Name = "Juggernaut", WikiUrl = "https://wiki.guildwars.com/wiki/Juggernaut" };
    public static readonly Npc KurzickQuartermaster = new() { Ids = new int[] { 3384 }, Name = "Kurzick Quartermaster", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Quartermaster" };
    public static readonly Npc WarCaptainWomack = new() { Ids = new int[] { 3385 }, Name = "War Captain Womack", WikiUrl = "https://wiki.guildwars.com/wiki/War_Captain_Womack" };
    public static readonly Npc KurzickPeasant = new() { Ids = new int[] { 3392 }, Name = "Kurzick Peasant", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Peasant" };
    public static readonly Npc KurzickTraveler = new() { Ids = new int[] { 3394, 3395 }, Name = "Kurzick Traveler", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Traveler" };
    public static readonly Npc KurzickPriest = new() { Ids = new int[] { 3400, 3426 }, Name = "Kurzick Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Priest" };
    public static readonly Npc KurzickBlacksmith = new() { Ids = new int[] { 3403 }, Name = "Kurzick Blacksmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kurzicks" };
    public static readonly Npc KurzickMerchant = new() { Ids = new int[] { 3408, 3427 }, Name = "Kurzick Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Merchant" };
    public static readonly Npc KurzickWeaponsmith = new() { Ids = new int[] { 3409, 3410 }, Name = "Kurzick Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kurzicks" };
    public static readonly Npc KurzickTrader = new() { Ids = new int[] { 3411, 3419, 3420, 3422, 3425 }, Name = "Kurzick Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kurzicks" };
    public static readonly Npc KurzickBureaucrat = new() { Ids = new int[] { 3414 }, Name = "Kurzick Bureaucrat", WikiUrl = "https://wiki.guildwars.com/wiki/Kurzick_Bureaucrat" };
    public static readonly Npc BaronMirekVasburg = new() { Ids = new int[] { 3416 }, Name = "Baron Mirek Vasburg", WikiUrl = "https://wiki.guildwars.com/wiki/Baron_Mirek_Vasburg" };
    public static readonly Npc CountZuHeltzer = new() { Ids = new int[] { 3417 }, Name = "Count Zu Heltzer", WikiUrl = "https://wiki.guildwars.com/wiki/Count_zu_Heltzer" };
    public static readonly Npc Mai = new() { Ids = new int[] { 3434, 3440, 3446, 3452 }, Name = "Mai", WikiUrl = "https://wiki.guildwars.com/wiki/Mai" };
    public static readonly Npc Kisai = new() { Ids = new int[] { 3435, 3441, 3447, 3453 }, Name = "Kisai", WikiUrl = "https://wiki.guildwars.com/wiki/Kisai" };
    public static readonly Npc Taya = new() { Ids = new int[] { 3436, 3442, 3448, 3454 }, Name = "Taya", WikiUrl = "https://wiki.guildwars.com/wiki/Taya" };
    public static readonly Npc Lukas = new() { Ids = new int[] { 3437, 3443, 3449, 3455, 3479, 3508 }, Name = "Lukas", WikiUrl = "https://wiki.guildwars.com/wiki/Lukas" };
    public static readonly Npc Yuun = new() { Ids = new int[] { 3438, 3444, 3450, 3456 }, Name = "Yuun", WikiUrl = "https://wiki.guildwars.com/wiki/Yuun" };
    public static readonly Npc Aeson = new() { Ids = new int[] { 3439, 3445, 3451, 3457, 3515, 3486 }, Name = "Aeson", WikiUrl = "https://wiki.guildwars.com/wiki/Aeson" };
    public static readonly Npc Panaku = new() { Ids = new int[] { 3466, 3495 }, Name = "Panaku", WikiUrl = "https://wiki.guildwars.com/wiki/Panaku" };
    public static readonly Npc LoSha = new() { Ids = new int[] { 3467, 3497, 5986 }, Name = "Lo Sha", WikiUrl = "https://wiki.guildwars.com/wiki/Lo_Sha" };
    public static readonly Npc KaiYing = new() { Ids = new int[] { 3469, 3499, 3511 }, Name = "Kai Ying", WikiUrl = "https://wiki.guildwars.com/wiki/Kai_Ying" };
    public static readonly Npc Zho = new() { Ids = new int[] { 3472, 3502, 3514, 5995 }, Name = "Zho", WikiUrl = "https://wiki.guildwars.com/wiki/Zho" };
    public static readonly Npc ErysVasburg = new() { Ids = new int[] { 3474, 3504 }, Name = "Erys Vasburg", WikiUrl = "https://wiki.guildwars.com/wiki/Erys_Vasburg" };
    public static readonly Npc Brutus = new() { Ids = new int[] { 3475, 3505 }, Name = "Brutus", WikiUrl = "https://wiki.guildwars.com/wiki/Brutus" };
    public static readonly Npc Sheena = new() { Ids = new int[] { 3476, 3506 }, Name = "Sheena", WikiUrl = "https://wiki.guildwars.com/wiki/Sheena" };
    public static readonly Npc Danika = new() { Ids = new int[] { 3477 }, Name = "Danika", WikiUrl = "https://wiki.guildwars.com/wiki/Danika" };
    public static readonly Npc RedemptorKarl = new() { Ids = new int[] { 3478, 3507 }, Name = "Redemptor Karl", WikiUrl = "https://wiki.guildwars.com/wiki/Redemptor_Karl" };
    public static readonly Npc Emi = new() { Ids = new int[] { 3487 }, Name = "Emi", WikiUrl = "https://wiki.guildwars.com/wiki/Emi" };
    public static readonly Npc Chiyo = new() { Ids = new int[] { 3494 }, Name = "Chiyo", WikiUrl = "https://wiki.guildwars.com/wiki/Chiyo" };
    public static readonly Npc Nika = new() { Ids = new int[] { 3496 }, Name = "Nika", WikiUrl = "https://wiki.guildwars.com/wiki/Nika" };
    public static readonly Npc SeaguardHala = new() { Ids = new int[] { 3510, 3561, 3649, 3480 }, Name = "Seaguard Hala", WikiUrl = "https://wiki.guildwars.com/wiki/Seaguard_Hala" };
    public static readonly Npc Daeman = new() { Ids = new int[] { 3513, 3567, 3645, 3484 }, Name = "Daeman", WikiUrl = "https://wiki.guildwars.com/wiki/Daeman" };
    public static readonly Npc CanthanFarmer = new() { Ids = new int[] { 3524, 3254 }, Name = "Canthan Farmer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Canthans" };
    public static readonly Npc Argo = new() { Ids = new int[] { 3563, 3646, 3481 }, Name = "Argo", WikiUrl = "https://wiki.guildwars.com/wiki/Argo" };
    public static readonly Npc SeaguardGita = new() { Ids = new int[] { 3564, 3647, 3482 }, Name = "Seaguard Gita", WikiUrl = "https://wiki.guildwars.com/wiki/Seaguard_Gita" };
    public static readonly Npc SeaguardEli = new() { Ids = new int[] { 3565,3483 }, Name = "Seaguard Eli", WikiUrl = "https://wiki.guildwars.com/wiki/Seaguard_Eli" };
    public static readonly Npc Aurora = new() { Ids = new int[] { 3566, 3644, 3485 }, Name = "Aurora", WikiUrl = "https://wiki.guildwars.com/wiki/Aurora" };
    public static readonly Npc SiegeTurtle = new() { Ids = new int[] { 3568, 3586 }, Name = "Siege Turtle", WikiUrl = "https://wiki.guildwars.com/wiki/Siege_Turtle" };
    public static readonly Npc LuxonNecromancer = new() { Ids = new int[] { 3571, 3621 }, Name = "Luxon Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Necromancer" };
    public static readonly Npc GiantTurtle = new() { Ids = new int[] { 3585 }, Name = "Giant Turtle", WikiUrl = "https://wiki.guildwars.com/wiki/Giant_Turtle" };
    public static readonly Npc YoungTurtle = new() { Ids = new int[] { 3587 }, Name = "Young Turtle", WikiUrl = "https://wiki.guildwars.com/wiki/Young_Turtle" };
    public static readonly Npc LuxonRitualist = new() { Ids = new int[] { 3598 }, Name = "Luxon Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Ritualist" };
    public static readonly Npc LuxonCommander = new() { Ids = new int[] { 3600, 3642 }, Name = "Luxon Commander", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Commander" };
    public static readonly Npc LuxonAmbassador = new() { Ids = new int[] { 3608 }, Name = "Luxon Ambassador", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Ambassador" };
    public static readonly Npc Luxon = new() { Ids = new int[] { 3609, 3611 }, Name = "Luxon", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon" };
    public static readonly Npc LuxonElder = new() { Ids = new int[] { 3610 }, Name = "Luxon Elder", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Luxons" };
    public static readonly Npc LuxonTraveler = new() { Ids = new int[] { 3612 }, Name = "Luxon Traveler", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Traveler" };
    public static readonly Npc LuxonMagistrate = new() { Ids = new int[] { 3613 }, Name = "Luxon Magistrate", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Luxons" };
    public static readonly Npc LuxonBlacksmith = new() { Ids = new int[] { 3619 }, Name = "Luxon Blacksmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Luxons" };
    public static readonly Npc LuxonMerchant = new() { Ids = new int[] { 3622, 3623, 3627, 3636 }, Name = "Luxon Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Merchant" };
    public static readonly Npc LuxonWeaponsmith = new() { Ids = new int[] { 3624, 3648 }, Name = "Luxon Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Luxons" };
    public static readonly Npc LuxonTrader = new() { Ids = new int[] { 3628, 3631, 3633, 3634 }, Name = "Luxon Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Luxons" };
    public static readonly Npc LuxonGuard = new() { Ids = new int[] { 3638, 3639, 3640 }, Name = "Luxon Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Guard" };
    public static readonly Npc LuxonPriest = new() { Ids = new int[] { 3641 }, Name = "Luxon Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Luxon_Priest" };
    public static readonly Npc ElderRhea = new() { Ids = new int[] { 3651 }, Name = "Elder Rhea", WikiUrl = "https://wiki.guildwars.com/wiki/Elder_Rhea" };
    public static readonly Npc ChkkrLocustLord = new() { Ids = new int[] { 3662 }, Name = "Chkkr Locust Lord", WikiUrl = "https://wiki.guildwars.com/wiki/Chkkr_Locust_Lord" };
    public static readonly Npc BezzrWingstorm = new() { Ids = new int[] { 3663 }, Name = "Bezzr Wingstorm", WikiUrl = "https://wiki.guildwars.com/wiki/Bezzr_Wingstorm" };
    public static readonly Npc ChkkrBrightclaw = new() { Ids = new int[] { 3669 }, Name = "Chkkr Brightclaw", WikiUrl = "https://wiki.guildwars.com/wiki/Chkkr_Brightclaw" };
    public static readonly Npc KonrruTaintedStone = new() { Ids = new int[] { 3670 }, Name = "Konrru Tainted Stone", WikiUrl = "https://wiki.guildwars.com/wiki/Konrru,_Tainted_Stone" };
    public static readonly Npc NandetGlassWeaver = new() { Ids = new int[] { 3671 }, Name = "Nandet Glass Weaver", WikiUrl = "https://wiki.guildwars.com/wiki/Nandet,_Glass_Weaver" };
    public static readonly Npc HarggPlaguebinder = new() { Ids = new int[] { 3674 }, Name = "Hargg Plaguebinder", WikiUrl = "https://wiki.guildwars.com/wiki/Hargg_Plaguebinder" };
    public static readonly Npc TarlokEvermind = new() { Ids = new int[] { 3675 }, Name = "Tarlok Evermind", WikiUrl = "https://wiki.guildwars.com/wiki/Tarlok_Evermind" };
    public static readonly Npc MungriMagicbox = new() { Ids = new int[] { 3676 }, Name = "Mungri Magicbox", WikiUrl = "https://wiki.guildwars.com/wiki/Mungri_Magicbox" };
    public static readonly Npc TarnenTheBully = new() { Ids = new int[] { 3677 }, Name = "Tarnen The Bully", WikiUrl = "https://wiki.guildwars.com/wiki/Tarnen_the_Bully" };
    public static readonly Npc WaggSpiritspeak = new() { Ids = new int[] { 3679 }, Name = "Wagg Spiritspeak", WikiUrl = "https://wiki.guildwars.com/wiki/Wagg_Spiritspeak" };
    public static readonly Npc StrongrootTanglebranch = new() { Ids = new int[] { 3682 }, Name = "Strongroot Tanglebranch", WikiUrl = "https://wiki.guildwars.com/wiki/Strongroot_Tanglebranch" };
    public static readonly Npc InallaySplintercall = new() { Ids = new int[] { 3696 }, Name = "Inallay Splintercall", WikiUrl = "https://wiki.guildwars.com/wiki/Inallay_Splintercall" };
    public static readonly Npc ArborEarthcall = new() { Ids = new int[] { 3700 }, Name = "Arbor Earthcall", WikiUrl = "https://wiki.guildwars.com/wiki/Arbor_Earthcall" };
    public static readonly Npc SalkeFurFriend = new() { Ids = new int[] { 3704 }, Name = "Salke Fur Friend", WikiUrl = "https://wiki.guildwars.com/wiki/Salke_Fur_Friend" };
    public static readonly Npc BloodDrinker = new() { Ids = new int[] { 3708 }, Name = "Blood Drinker", WikiUrl = "https://wiki.guildwars.com/wiki/Blood_Drinker" };
    public static readonly Npc FungalWallow = new() { Ids = new int[] { 3709 }, Name = "Fungal Wallow", WikiUrl = "https://wiki.guildwars.com/wiki/Fungal_Wallow" };
    public static readonly Npc MantisHunter = new() { Ids = new int[] { 3711 }, Name = "Mantis Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Mantis_Hunter" };
    public static readonly Npc MantisDreamweaver = new() { Ids = new int[] { 3712 }, Name = "Mantis Dreamweaver", WikiUrl = "https://wiki.guildwars.com/wiki/Mantis_Dreamweaver" };
    public static readonly Npc MantisStormcaller = new() { Ids = new int[] { 3713 }, Name = "Mantis Stormcaller", WikiUrl = "https://wiki.guildwars.com/wiki/Mantis_Stormcaller" };
    public static readonly Npc MantisMender = new() { Ids = new int[] { 3714 }, Name = "Mantis Mender", WikiUrl = "https://wiki.guildwars.com/wiki/Mantis_Mender" };
    public static readonly Npc PainHungryGaki = new() { Ids = new int[] { 3715 }, Name = "Pain Hungry Gaki", WikiUrl = "https://wiki.guildwars.com/wiki/Pain_Hungry_Gaki" };
    public static readonly Npc SkillHungryGaki = new() { Ids = new int[] { 3716 }, Name = "Skill Hungry Gaki", WikiUrl = "https://wiki.guildwars.com/wiki/Skill_Hungry_Gaki" };
    public static readonly Npc StoneScaleKirin = new() { Ids = new int[] { 3717 }, Name = "Stone Scale Kirin", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Scale_Kirin" };
    public static readonly Npc DredgeGutter = new() { Ids = new int[] { 3718 }, Name = "Dredge Gutter", WikiUrl = "https://wiki.guildwars.com/wiki/Dredge_Gutter" };
    public static readonly Npc DredgeGardener = new() { Ids = new int[] { 3719 }, Name = "Dredge Gardener", WikiUrl = "https://wiki.guildwars.com/wiki/Dredge_Gardener" };
    public static readonly Npc DredgeGuardian = new() { Ids = new int[] { 3720 }, Name = "Dredge Guardian", WikiUrl = "https://wiki.guildwars.com/wiki/Dredge_Guardian" };
    public static readonly Npc Undergrowth = new() { Ids = new int[] { 3723 }, Name = "Undergrowth", WikiUrl = "https://wiki.guildwars.com/wiki/Undergrowth" };
    public static readonly Npc StoneRain = new() { Ids = new int[] { 3724 }, Name = "Stone Rain", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Rain" };
    public static readonly Npc StoneSoul = new() { Ids = new int[] { 3726 }, Name = "Stone Soul", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Soul" };
    public static readonly Npc WardenOfTheMind = new() { Ids = new int[] { 3729 }, Name = "Warden Of The Mind", WikiUrl = "https://wiki.guildwars.com/wiki/Warden_of_the_Mind" };
    public static readonly Npc WardenOfEarth = new() { Ids = new int[] { 3730 }, Name = "Warden Of Earth", WikiUrl = "https://wiki.guildwars.com/wiki/Warden_of_Earth" };
    public static readonly Npc WardenOfTheTrunk = new() { Ids = new int[] { 3733 }, Name = "Warden Of The Trunk", WikiUrl = "https://wiki.guildwars.com/wiki/Warden_of_the_Trunk" };
    public static readonly Npc WardenOfTheLeaf = new() { Ids = new int[] { 3736 }, Name = "Warden Of The Leaf", WikiUrl = "https://wiki.guildwars.com/wiki/Warden_of_the_Leaf" };
    public static readonly Npc WardenOfTheSummer = new() { Ids = new int[] { 3737 }, Name = "Warden Of The Summer", WikiUrl = "https://wiki.guildwars.com/wiki/Warden_of_the_Summer" };
    public static readonly Npc DredgeMelee = new() { Ids = new int[] { 3741 }, Name = "Dredge Melee", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dredge" };
    public static readonly Npc SickenedLynx = new() { Ids = new int[] { 3765 }, Name = "Sickened Lynx", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Lynx" };
    public static readonly Npc SickenedMoa = new() { Ids = new int[] { 3766 }, Name = "Sickened Moa", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Moa" };
    public static readonly Npc SickenedStalker = new() { Ids = new int[] { 3767 }, Name = "Sickened Stalker", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Stalker" };
    public static readonly Npc SickenedWolf = new() { Ids = new int[] { 3768 }, Name = "Sickened Wolf", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Wolf" };
    public static readonly Npc SickenedWarthog = new() { Ids = new int[] { 3769 }, Name = "Sickened Warthog", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Warthog" };
    public static readonly Npc SickenedBear = new() { Ids = new int[] { 3770 }, Name = "Sickened Bear", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Bear" };
    public static readonly Npc SickenedGuard = new() { Ids = new int[] { 3771, 3774 }, Name = "Sickened Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Guard" };
    public static readonly Npc SickenedServant = new() { Ids = new int[] { 3772 }, Name = "Sickened Servant", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Servant" };
    public static readonly Npc SickenedScribe = new() { Ids = new int[] { 3773 }, Name = "Sickened Scribe", WikiUrl = "https://wiki.guildwars.com/wiki/Sickened_Scribe" };
    public static readonly Npc AfflictedYijo = new() { Ids = new int[] { 3780 }, Name = "Afflicted Yijo", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Yijo" };
    public static readonly Npc TheAfflictedKana = new() { Ids = new int[] { 3781 }, Name = "The Afflicted Kana", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Kana" };
    public static readonly Npc AfflictedRangerBoss = new() { Ids = new int[] { 3783 }, Name = "Afflicted Ranger Boss", WikiUrl = "https://wiki.guildwars.com/wiki/List_of_afflicted_bosses" };
    public static readonly Npc DiseasedMinister = new() { Ids = new int[] { 3784 }, Name = "Diseased Minister", WikiUrl = "https://wiki.guildwars.com/wiki/Diseased_Minister" };
    public static readonly Npc AfflictedHorror = new() { Ids = new int[] { 3785 }, Name = "Afflicted Horror", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Horror" };
    public static readonly Npc TheAfflictedLiYun = new() { Ids = new int[] { 3795 }, Name = "The Afflicted Li Yun", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Li_Yun" };
    public static readonly Npc TheAfflictedKam = new() { Ids = new int[] { 3797 }, Name = "The Afflicted Kam", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Kam" };
    public static readonly Npc TheAfflictedMiju = new() { Ids = new int[] { 3798 }, Name = "The Afflicted Miju", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Miju" };
    public static readonly Npc TheAfflictedHakaru = new() { Ids = new int[] { 3801 }, Name = "The Afflicted Hakaru", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Hakaru" };
    public static readonly Npc TheAfflictedSenku = new() { Ids = new int[] { 3802 }, Name = "The Afflicted Senku", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Senku" };
    public static readonly Npc TheAfflictedHsinJun = new() { Ids = new int[] { 3803 }, Name = "The Afflicted Hsin Jun", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Hsin_Jun" };
    public static readonly Npc TheAfflictedJingme = new() { Ids = new int[] { 3806 }, Name = "The Afflicted Jingme", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Jingme" };
    public static readonly Npc TheAfflictedMaaka = new() { Ids = new int[] { 3807 }, Name = "The Afflicted Maaka", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Maaka" };
    public static readonly Npc TheAfflictedXenxo = new() { Ids = new int[] { 3809 }, Name = "The Afflicted Xenxo", WikiUrl = "https://wiki.guildwars.com/wiki/The_Afflicted_Xenxo" };
    public static readonly Npc AfflictedAssassin = new() { Ids = new int[] { 3818, 3819, 3823 }, Name = "Afflicted Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Assassin" };
    public static readonly Npc AfflictedBull = new() { Ids = new int[] { 3825 }, Name = "Afflicted Bull", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Bull" };
    public static readonly Npc AfflictedMesmer = new() { Ids = new int[] { 3826, 3831 }, Name = "Afflicted Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Mesmer" };
    public static readonly Npc AfflictedNecromancer = new() { Ids = new int[] { 3833, 3838 }, Name = "Afflicted Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Necromancer" };
    public static readonly Npc AfflictedElementalist = new() { Ids = new int[] { 3840, 3841, 3845 }, Name = "Afflicted Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Elementalist" };
    public static readonly Npc AfflictedMonk = new() { Ids = new int[] { 3847, 3848 }, Name = "Afflicted Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Monk" };
    public static readonly Npc AfflictedWarrior = new() { Ids = new int[] { 3854, 3859 }, Name = "Afflicted Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Warrior" };
    public static readonly Npc AfflictedRanger = new() { Ids = new int[] { 3861, 3862, 3866 }, Name = "Afflicted Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Ranger" };
    public static readonly Npc AfflictedRavager = new() { Ids = new int[] { 3868 }, Name = "Afflicted Ravager", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Ravager" };
    public static readonly Npc AfflictedRitualist = new() { Ids = new int[] { 3869 }, Name = "Afflicted Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Afflicted_Ritualist" };
    public static readonly Npc AhvaSankii = new() { Ids = new int[] { 3878 }, Name = "Ahva Sankii", WikiUrl = "https://wiki.guildwars.com/wiki/Ahva_Sankii" };
    public static readonly Npc PeiTheSkullBlade = new() { Ids = new int[] { 3879 }, Name = "Pei The Skull Blade", WikiUrl = "https://wiki.guildwars.com/wiki/Pei_the_Skull_Blade" };
    public static readonly Npc YingkoTheSkullClaw = new() { Ids = new int[] { 3881 }, Name = "Yingko The Skull Claw", WikiUrl = "https://wiki.guildwars.com/wiki/Yingko_the_Skull_Claw" };
    public static readonly Npc FengTheSkullSymbol = new() { Ids = new int[] { 3883 }, Name = "Feng The Skull Symbol", WikiUrl = "https://wiki.guildwars.com/wiki/Feng_The_Skull_Symbol" };
    public static readonly Npc CaptainQuimang = new() { Ids = new int[] { 3884 }, Name = "Captain Quimang", WikiUrl = "https://wiki.guildwars.com/wiki/Captain_Quimang" };
    public static readonly Npc JinTheSkullBow = new() { Ids = new int[] { 3885 }, Name = "Jin The Skull Bow", WikiUrl = "https://wiki.guildwars.com/wiki/Jin_the_Skull_Bow" };
    public static readonly Npc MikiTheSkullSpirit = new() { Ids = new int[] { 3886 }, Name = "Miki The Skull Spirit", WikiUrl = "https://wiki.guildwars.com/wiki/Miki_the_Skull_Spirit" };
    public static readonly Npc TahkayunTsi = new() { Ids = new int[] { 3887 }, Name = "Tahkayun Tsi", WikiUrl = "https://wiki.guildwars.com/wiki/Tahkayun_Tsi" };
    public static readonly Npc YunlaiDeathkeeper = new() { Ids = new int[] { 3888 }, Name = "Yunlai Deathkeeper", WikiUrl = "https://wiki.guildwars.com/wiki/Yunlai_Deathkeeper" };
    public static readonly Npc ZiinjuuLifeCrawler = new() { Ids = new int[] { 3889 }, Name = "Ziinjuu Life Crawler", WikiUrl = "https://wiki.guildwars.com/wiki/Ziinjuu_Life_Crawler" };
    public static readonly Npc Cow = new() { Ids = new int[] { 3892 }, Name = "Cow", WikiUrl = "https://wiki.guildwars.com/wiki/Cow" };
    public static readonly Npc BonesnapTurtle = new() { Ids = new int[] { 3895 }, Name = "Bonesnap Turtle", WikiUrl = "https://wiki.guildwars.com/wiki/Bonesnap_Turtle" };
    public static readonly Npc CrimsonSkullEtherFiend = new() { Ids = new int[] { 3896 }, Name = "Crimson Skull Ether Fiend", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Ether_Fiend" };
    public static readonly Npc CrimsonSkullMentalist = new() { Ids = new int[] { 3898 }, Name = "Crimson Skull Mentalist", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Mentalist" };
    public static readonly Npc CrimsonSkullMesmer = new() { Ids = new int[] { 3899 }, Name = "Crimson Skull Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Mesmer" };
    public static readonly Npc CrimsonSkullHealer = new() { Ids = new int[] { 3900 }, Name = "Crimson Skull Healer", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Healer" };
    public static readonly Npc CrimsonSkullMender = new() { Ids = new int[] { 3903 }, Name = "Crimson Skull Mender", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Mender" };
    public static readonly Npc CrimsonSkullHunter = new() { Ids = new int[] { 3904 }, Name = "Crimson Skull Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Hunter" };
    public static readonly Npc CrimsonSkullLongbow = new() { Ids = new int[] { 3906 }, Name = "Crimson Skull Longbow", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Longbow" };
    public static readonly Npc CrimsonSkullRaider = new() { Ids = new int[] { 3907 }, Name = "Crimson Skull Raider", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Raider" };
    public static readonly Npc CrimsonSkullSeer = new() { Ids = new int[] { 3908 }, Name = "Crimson Skull Seer", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Seer" };
    public static readonly Npc CrimsonSkullSpiritLord = new() { Ids = new int[] { 3910 }, Name = "Crimson Skull Spirit Lord", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Spirit_Lord" };
    public static readonly Npc CrimsonSkullRitualist = new() { Ids = new int[] { 3911 }, Name = "Crimson Skull Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Skull_Ritualist" };
    public static readonly Npc MantidDrone = new() { Ids = new int[] { 3914, 4168 }, Name = "Mantid Drone", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Drone" };
    public static readonly Npc MantidDroneHatchling = new() { Ids = new int[] { 3921 }, Name = "Mantid Drone Hatchling ", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Drone_Hatchling" };
    public static readonly Npc MantidMonitor = new() { Ids = new int[] { 3924, 4169 }, Name = "Mantid Monitor", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Monitor" };
    public static readonly Npc MantidGlitterfang = new() { Ids = new int[] { 3929 }, Name = "Mantid Glitterfang", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Glitterfang" };
    public static readonly Npc MantidMonitorHatchling = new() { Ids = new int[] { 3933 }, Name = "Mantid Monitor Hatchling", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Monitor_Hatchling" };
    public static readonly Npc NagaWelp = new() { Ids = new int[] { 3936 }, Name = "Naga Welp", WikiUrl = "https://wiki.guildwars.com/wiki/Naga_Welp" };
    public static readonly Npc NagaSpellblade = new() { Ids = new int[] { 3939 }, Name = "Naga Spellblade", WikiUrl = "https://wiki.guildwars.com/wiki/Naga_Spellblade" };
    public static readonly Npc NagaWitch = new() { Ids = new int[] { 3940 }, Name = "Naga Witch", WikiUrl = "https://wiki.guildwars.com/wiki/Naga_Witch" };
    public static readonly Npc NagaSibyl = new() { Ids = new int[] { 3942 }, Name = "Naga Sibyl", WikiUrl = "https://wiki.guildwars.com/wiki/Naga_Sibyl" };
    public static readonly Npc SensaliAssassin = new() { Ids = new int[] { 3943 }, Name = "Sensali Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Sensali_Assassin" };
    public static readonly Npc SensaliBlood = new() { Ids = new int[] { 3945 }, Name = "Sensali Blood", WikiUrl = "https://wiki.guildwars.com/wiki/Sensali_Blood" };
    public static readonly Npc SensaliFighter = new() { Ids = new int[] { 3947 }, Name = "Sensali Fighter", WikiUrl = "https://wiki.guildwars.com/wiki/Sensali_Fighter" };
    public static readonly Npc Kappa = new() { Ids = new int[] { 3950, 3951, 4040 }, Name = "Kappa", WikiUrl = "https://wiki.guildwars.com/wiki/Kappa" };
    public static readonly Npc MountainYeti = new() { Ids = new int[] { 3954 }, Name = "Mountain Yeti", WikiUrl = "https://wiki.guildwars.com/wiki/Mountain_Yeti" };
    public static readonly Npc LonghairYeti = new() { Ids = new int[] { 3955 }, Name = "Longhair Yeti", WikiUrl = "https://wiki.guildwars.com/wiki/Longhair_Yeti" };
    public static readonly Npc RedYeti = new() { Ids = new int[] { 3956 }, Name = "Red Yeti", WikiUrl = "https://wiki.guildwars.com/wiki/Red_Yeti" };
    public static readonly Npc Zunraa = new() { Ids = new int[] { 3958 }, Name = "Zunraa", WikiUrl = "https://wiki.guildwars.com/wiki/Zunraa" };
    public static readonly Npc Kuunavang = new() { Ids = new int[] { 3965 }, Name = "Kuunavang", WikiUrl = "https://wiki.guildwars.com/wiki/Kuunavang" };
    public static readonly Npc RazortongueFrothspit = new() { Ids = new int[] { 3970 }, Name = "Razortongue Frothspit", WikiUrl = "https://wiki.guildwars.com/wiki/Razortongue_Frothspit" };
    public static readonly Npc KaySeyStormray = new() { Ids = new int[] { 3971 }, Name = "KaySey Stormray", WikiUrl = "https://wiki.guildwars.com/wiki/KaySey_Stormray" };
    public static readonly Npc MiellaLightwing = new() { Ids = new int[] { 3981 }, Name = "Miella Lightwing", WikiUrl = "https://wiki.guildwars.com/wiki/Miella_Lightwing" };
    public static readonly Npc SnapjawWindshell = new() { Ids = new int[] { 3982 }, Name = "Snapjaw Windshell", WikiUrl = "https://wiki.guildwars.com/wiki/Snapjaw_Windshell" };
    public static readonly Npc ArrahhshMountainclub = new() { Ids = new int[] { 3987 }, Name = "Arrahhsh Mountainclub", WikiUrl = "https://wiki.guildwars.com/wiki/Arrahhsh_Mountainclub" };
    public static readonly Npc AmadisWindOfTheSea = new() { Ids = new int[] { 3993 }, Name = "Amadis Wind Of The Sea", WikiUrl = "https://wiki.guildwars.com/wiki/Amadis,_Wind_of_the_Sea" };
    public static readonly Npc GeofferPainBringer = new() { Ids = new int[] { 3998 }, Name = "Geoffer Pain Bringer", WikiUrl = "https://wiki.guildwars.com/wiki/Geoffer_Pain_Bringer" };
    public static readonly Npc KenriiSeaSorrow = new() { Ids = new int[] { 4005 }, Name = "Kenrii Sea Sorrow", WikiUrl = "https://wiki.guildwars.com/wiki/Kenrii_Sea_Sorrow" };
    public static readonly Npc SiskaScalewand = new() { Ids = new int[] { 4007 }, Name = "Siska Scalewand", WikiUrl = "https://wiki.guildwars.com/wiki/Siska_Scalewand" };
    public static readonly Npc SarssStormscale = new() { Ids = new int[] { 4009 }, Name = "Sarss Stormscale", WikiUrl = "https://wiki.guildwars.com/wiki/Sarss,_Stormscale" };
    public static readonly Npc SskaiDragonsBirth = new() { Ids = new int[] { 4011 }, Name = "Sskai Dragon's Birth", WikiUrl = "https://wiki.guildwars.com/wiki/Sskai,_Dragon%27s_Birth" };
    public static readonly Npc SsynCoiledGrasp = new() { Ids = new int[] { 4013 }, Name = "Ssyn Coiled Grasp", WikiUrl = "https://wiki.guildwars.com/wiki/Ssyn_Coiled_Grasp" };
    public static readonly Npc ScuttleFish = new() { Ids = new int[] { 4018 }, Name = "Scuttle Fish", WikiUrl = "https://wiki.guildwars.com/wiki/Scuttle_Fish" };
    public static readonly Npc CreepingCarp = new() { Ids = new int[] { 4020 }, Name = "Creeping Carp", WikiUrl = "https://wiki.guildwars.com/wiki/Creeping_Carp" };
    public static readonly Npc Irukandji = new() { Ids = new int[] { 4021 }, Name = "Irukandji", WikiUrl = "https://wiki.guildwars.com/wiki/Irukandji" };
    public static readonly Npc Yeti = new() { Ids = new int[] { 4023, 4024 }, Name = "Yeti", WikiUrl = "https://wiki.guildwars.com/wiki/Yeti" };
    public static readonly Npc RotWallow = new() { Ids = new int[] { 4025 }, Name = "Rot Wallow", WikiUrl = "https://wiki.guildwars.com/wiki/Rot_Wallow" };
    public static readonly Npc LeviathanClaw = new() { Ids = new int[] { 4027 }, Name = "Leviathan Claw", WikiUrl = "https://wiki.guildwars.com/wiki/Leviathan_Claw" };
    public static readonly Npc LeviathanMouth = new() { Ids = new int[] { 4028 }, Name = "Leviathan Mouth", WikiUrl = "https://wiki.guildwars.com/wiki/Leviathan_Mouth" };
    public static readonly Npc KrakenSpawn = new() { Ids = new int[] { 4029 }, Name = "Kraken Spawn", WikiUrl = "https://wiki.guildwars.com/wiki/Kraken_Spawn" };
    public static readonly Npc SaltsprayDragon = new() { Ids = new int[] { 4032 }, Name = "Saltspray Dragon", WikiUrl = "https://wiki.guildwars.com/wiki/Saltspray_Dragon" };
    public static readonly Npc Albax = new() { Ids = new int[] { 4033 }, Name = "Albax", WikiUrl = "https://wiki.guildwars.com/wiki/Albax" };
    public static readonly Npc RockhideDragon = new() { Ids = new int[] { 4034 }, Name = "Rockhide Dragon", WikiUrl = "https://wiki.guildwars.com/wiki/Rockhide_Dragon" };
    public static readonly Npc OutcastAssassin = new() { Ids = new int[] { 4035 }, Name = "Outcast Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Outcast_Assassin" };
    public static readonly Npc OutcastDeathhand = new() { Ids = new int[] { 4036 }, Name = "Outcast Deathhand", WikiUrl = "https://wiki.guildwars.com/wiki/Outcast_Deathhand" };
    public static readonly Npc OutcastWarrior = new() { Ids = new int[] { 4037 }, Name = "Outcast Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Outcast_Warrior" };
    public static readonly Npc OutcastRitualist = new() { Ids = new int[] { 4039 }, Name = "Outcast Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Outcast_Ritualist" };
    public static readonly Npc NagaWarrior = new() { Ids = new int[] { 4042 }, Name = "Naga Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Naga_Warrior" };
    public static readonly Npc NagaArcher = new() { Ids = new int[] { 4043 }, Name = "Naga Archer", WikiUrl = "https://wiki.guildwars.com/wiki/Naga_Archer" };
    public static readonly Npc NagaRitualist = new() { Ids = new int[] { 4044 }, Name = "Naga Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Naga_Ritualist" };
    public static readonly Npc IslandGuardian = new() { Ids = new int[] { 4045 }, Name = "Island Guardian", WikiUrl = "https://wiki.guildwars.com/wiki/Island_Guardian" };
    public static readonly Npc SenkaiLordOfThe1000DaggersGuild = new() { Ids = new int[] { 4056 }, Name = "Senkai Lord Of The 1000 Daggers Guild", WikiUrl = "https://wiki.guildwars.com/wiki/Senkai,_Lord_of_the_1,000_Daggers_Guild" };
    public static readonly Npc RitualistsConstruct = new() { Ids = new int[] { 4080, 4097 }, Name = "Ritualist's Construct", WikiUrl = "https://wiki.guildwars.com/wiki/Ritualist%27s_Construct" };
    public static readonly Npc AssassinsConstruct = new() { Ids = new int[] { 4081, 4090 }, Name = "Assassin's Construct", WikiUrl = "https://wiki.guildwars.com/wiki/Assassin%27s_Construct" };
    public static readonly Npc ElementalsConstruct = new() { Ids = new int[] { 4093 }, Name = "Elemental's Construct", WikiUrl = "https://wiki.guildwars.com/wiki/Elemental%27s_Construct" };
    public static readonly Npc RangersConstruct = new() { Ids = new int[] { 4096 }, Name = "Ranger's Construct", WikiUrl = "https://wiki.guildwars.com/wiki/Ranger%27s_Construct" };
    public static readonly Npc ShiroTagachi = new() { Ids = new int[] { 4120, 4952 }, Name = "Shiro Tagachi", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro_Tagachi" };
    public static readonly Npc ShirokenAssassin = new() { Ids = new int[] { 4125 }, Name = "Shiro'ken Assassin", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro%27ken_Assassin" };
    public static readonly Npc ShirokenNecromancer = new() { Ids = new int[] { 4127 }, Name = "Shiro'ken Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro%27ken_Necromancer" };
    public static readonly Npc ShirokenWarrior = new() { Ids = new int[] { 4130 }, Name = "Shiro'ken Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro%27ken_Warrior" };
    public static readonly Npc ShirokenRanger = new() { Ids = new int[] { 4131 }, Name = "Shiro'ken Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro%27ken_Ranger" };
    public static readonly Npc SpiritOfPortals = new() { Ids = new int[] { 4133 }, Name = "Spirit Of Portals", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Portals" };
    public static readonly Npc XuekaoTheDeceptive = new() { Ids = new int[] { 4174 }, Name = "Xuekao The Deceptive", WikiUrl = "https://wiki.guildwars.com/wiki/Xuekao,_the_Deceptive" };
    public static readonly Npc MinaShatterStorm = new() { Ids = new int[] { 4176 }, Name = "Mina Shatter Storm", WikiUrl = "https://wiki.guildwars.com/wiki/Mina_Shatter_Storm" };
    public static readonly Npc AmFahLeader = new() { Ids = new int[] { 4179 }, Name = "Am Fah Leader", WikiUrl = "https://wiki.guildwars.com/wiki/Am_Fah_Leader" };
    public static readonly Npc MeynsangTheSadistic = new() { Ids = new int[] { 4181 }, Name = "Meynsang The Sadistic", WikiUrl = "https://wiki.guildwars.com/wiki/Meynsang_the_Sadistic" };
    public static readonly Npc JinThePurifier = new() { Ids = new int[] { 4184 }, Name = "Jin The Purifier", WikiUrl = "https://wiki.guildwars.com/wiki/Jin,_the_Purifier" };
    public static readonly Npc LianDragonsPetal = new() { Ids = new int[] { 4186 }, Name = "Lian Dragon's Petal", WikiUrl = "https://wiki.guildwars.com/wiki/Lian,_Dragon%27s_Petal" };
    public static readonly Npc ShenTheMagistrate = new() { Ids = new int[] { 4187 }, Name = "Shen The Magistrate", WikiUrl = "https://wiki.guildwars.com/wiki/Shen,_the_Magistrate" };
    public static readonly Npc WingThreeBlade = new() { Ids = new int[] { 4188 }, Name = "Wing Three Blade", WikiUrl = "https://wiki.guildwars.com/wiki/Wing,_Three_Blade" };
    public static readonly Npc AmFahNecromancer = new() { Ids = new int[] { 4192 }, Name = "Am Fah Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Am_Fah_Necromancer" };
    public static readonly Npc AmFahHealer = new() { Ids = new int[] { 4193 }, Name = "Am Fah Healer", WikiUrl = "https://wiki.guildwars.com/wiki/Am_Fah_Healer" };
    public static readonly Npc AmFahMarksman = new() { Ids = new int[] { 4194 }, Name = "Am Fah Marksman", WikiUrl = "https://wiki.guildwars.com/wiki/Am_Fah_Marksman" };
    public static readonly Npc JadeBrotherhoodMesmer = new() { Ids = new int[] { 4195 }, Name = "Jade Brotherhood Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Brotherhood_Mesmer" };
    public static readonly Npc JadeBrotherhoodMage = new() { Ids = new int[] { 4196 }, Name = "Jade Brotherhood Mage", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Brotherhood_Mage" };
    public static readonly Npc JadeBrotherhoodKnight = new() { Ids = new int[] { 4197 }, Name = "Jade Brotherhood Knight", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Brotherhood_Knight" };
    public static readonly Npc JadeBrotherhoodRitualist = new() { Ids = new int[] { 4198 }, Name = "Jade Brotherhood Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Jade_Brotherhood_Ritualist" };
    public static readonly Npc SpiritOfPain = new() { Ids = new int[] { 4214 }, Name = "Spirit Of Pain", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Pain" };
    public static readonly Npc SpiritOfDestruction = new() { Ids = new int[] { 4215 }, Name = "Spirit Of Destruction", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Destruction" };
    public static readonly Npc SpiritOfUnion = new() { Ids = new int[] { 4217, 4224 }, Name = "Spirit Of Union", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Union" };
    public static readonly Npc SpiritOfLife = new() { Ids = new int[] { 4218 }, Name = "Spirit Of Life", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Life" };
    public static readonly Npc SpiritOfBloodSong = new() { Ids = new int[] { 4227 }, Name = "Spirit Of Blood Song", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Blood_Song" };
    public static readonly Npc SpiritOfWanderlust = new() { Ids = new int[] { 4228 }, Name = "Spirit Of Wanderlust", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Wanderlust" };
    public static readonly Npc SpiritOfLaceration = new() { Ids = new int[] { 4232 }, Name = "Spirit Of Laceration", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Laceration" };
    public static readonly Npc SpiritOfEquinox = new() { Ids = new int[] { 4236 }, Name = "Spirit Of Equinox", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Equinox" };
    public static readonly Npc SpiritOfFamine = new() { Ids = new int[] { 4238 }, Name = "Spirit Of Famine", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Famine" };
    public static readonly Npc SpiritOfBrambles = new() { Ids = new int[] { 4239 }, Name = "Spirit Of Brambles", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Brambles" };
    public static readonly Npc Flamingo = new() { Ids = new int[] { 4242 }, Name = "Flamingo", WikiUrl = "https://wiki.guildwars.com/wiki/Flamingo" };
    public static readonly Npc ElderCrocodile = new() { Ids = new int[] { 4268 }, Name = "Elder Crocodile", WikiUrl = "https://wiki.guildwars.com/wiki/Elder_Crocodile" };
    public static readonly Npc TaromRockbreaker = new() { Ids = new int[] { 4330 }, Name = "Tarom Rockbreaker", WikiUrl = "https://wiki.guildwars.com/wiki/Tarom_Rockbreaker" };
    public static readonly Npc HaiossBlessedWind = new() { Ids = new int[] { 4332 }, Name = "Haioss Blessed Wind", WikiUrl = "https://wiki.guildwars.com/wiki/Haioss,_Blessed_Wind" };
    public static readonly Npc ChinehSoaringLight = new() { Ids = new int[] { 4333 }, Name = "Chineh Soaring Light", WikiUrl = "https://wiki.guildwars.com/wiki/Chineh_Soaring_Light" };
    public static readonly Npc Apocrypha = new() { Ids = new int[] { 4335 }, Name = "Apocrypha", WikiUrl = "https://wiki.guildwars.com/wiki/Apocrypha" };
    public static readonly Npc HassinSoftskin = new() { Ids = new int[] { 4336 }, Name = "Hassin Softskin", WikiUrl = "https://wiki.guildwars.com/wiki/Hassin_Softskin" };
    public static readonly Npc SunehStormbringer = new() { Ids = new int[] { 4338 }, Name = "Suneh Stormbringer", WikiUrl = "https://wiki.guildwars.com/wiki/Suneh_Stormbringer" };
    public static readonly Npc StalkingNephila = new() { Ids = new int[] { 4346 }, Name = "Stalking Nephila", WikiUrl = "https://wiki.guildwars.com/wiki/Stalking_Nephila" };
    public static readonly Npc WaterDjinn = new() { Ids = new int[] { 4349, 4907 }, Name = "Water Djinn", WikiUrl = "https://wiki.guildwars.com/wiki/Water_Djinn" };
    public static readonly Npc RinkhalMonitor = new() { Ids = new int[] { 4354 }, Name = "Rinkhal Monitor", WikiUrl = "https://wiki.guildwars.com/wiki/Rinkhal_Monitor" };
    public static readonly Npc IrontoothDrake = new() { Ids = new int[] { 4356 }, Name = "Irontooth Drake", WikiUrl = "https://wiki.guildwars.com/wiki/Irontooth_Drake" };
    public static readonly Npc SkreeHatchling = new() { Ids = new int[] { 4360 }, Name = "Skree Hatchling", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Hatchling" };
    public static readonly Npc SkreeFledgeling = new() { Ids = new int[] { 4361 }, Name = "Skree Fledgeling", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Fledgeling" };
    public static readonly Npc SkreeGriffon = new() { Ids = new int[] { 4362 }, Name = "Skree Griffon", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Griffon" };
    public static readonly Npc SkreeTalon = new() { Ids = new int[] { 4363 }, Name = "Skree Talon", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Talon" };
    public static readonly Npc SkreeHunter = new() { Ids = new int[] { 4364 }, Name = "Skree Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Hunter" };
    public static readonly Npc SkreeWarbler = new() { Ids = new int[] { 4365 }, Name = "Skree Warbler", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Warbler" };
    public static readonly Npc RidgebackSkale = new() { Ids = new int[] { 4366, 4369, 4377, 4378 }, Name = "Ridgeback Skale", WikiUrl = "https://wiki.guildwars.com/wiki/Ridgeback_Skale" };
    public static readonly Npc SkaleLasher = new() { Ids = new int[] { 4367, 4370 }, Name = "Skale Lasher", WikiUrl = "https://wiki.guildwars.com/wiki/Skale_Lasher" };
    public static readonly Npc SkaleBlighter = new() { Ids = new int[] { 4368, 4376 }, Name = "Skale Blighter", WikiUrl = "https://wiki.guildwars.com/wiki/Skale_Blighter" };
    public static readonly Npc FrigidSkale = new() { Ids = new int[] { 4371, 4379 }, Name = "Frigid Skale", WikiUrl = "https://wiki.guildwars.com/wiki/Frigid_Skale" };
    public static readonly Npc JuvenileBladedTermite = new() { Ids = new int[] { 4380 }, Name = "Juvenile Bladed Termite", WikiUrl = "https://wiki.guildwars.com/wiki/Juvenile_Bladed_Termite" };
    public static readonly Npc GrubLance = new() { Ids = new int[] { 4381 }, Name = "Grub Lance", WikiUrl = "https://wiki.guildwars.com/wiki/Grub_Lance" };
    public static readonly Npc BladedTermite = new() { Ids = new int[] { 4382 }, Name = "Bladed Termite", WikiUrl = "https://wiki.guildwars.com/wiki/Bladed_Termite" };
    public static readonly Npc PreyingLance = new() { Ids = new int[] { 4383 }, Name = "Preying Lance", WikiUrl = "https://wiki.guildwars.com/wiki/Preying_Lance" };
    public static readonly Npc StormseedJacaranda = new() { Ids = new int[] { 4387, 4389, 4391 }, Name = "Stormseed Jacaranda", WikiUrl = "https://wiki.guildwars.com/wiki/Stormseed_Jacaranda" };
    public static readonly Npc FangedIboga = new() { Ids = new int[] { 4388, 4392 }, Name = "Fanged Iboga", WikiUrl = "https://wiki.guildwars.com/wiki/Fanged_Iboga" };
    public static readonly Npc MandragorImp = new() { Ids = new int[] { 4395, 4400, 4930 }, Name = "Mandragor Imp", WikiUrl = "https://wiki.guildwars.com/wiki/Mandragor_Imp" };
    public static readonly Npc MandragorSlither = new() { Ids = new int[] { 4396, 4402, 4932 }, Name = "Mandragor Slither", WikiUrl = "https://wiki.guildwars.com/wiki/Mandragor_Slither" };
    public static readonly Npc StonefleshMandragor = new() { Ids = new int[] { 4401, 4931 }, Name = "Stoneflesh Mandragor", WikiUrl = "https://wiki.guildwars.com/wiki/Stoneflesh_Mandragor" };
    public static readonly Npc GraspOfChaos = new() { Ids = new int[] { 4404 }, Name = "Grasp Of Chaos", WikiUrl = "https://wiki.guildwars.com/wiki/Grasp_of_Chaos" };
    public static readonly Npc Dehjah = new() { Ids = new int[] { 4406 }, Name = "Dehjah", WikiUrl = "https://wiki.guildwars.com/wiki/Dehjah" };
    public static readonly Npc BoklonBlackwater = new() { Ids = new int[] { 4414 }, Name = "Boklon Blackwater", WikiUrl = "https://wiki.guildwars.com/wiki/Boklon_Blackwater" };
    public static readonly Npc GlugKlugg = new() { Ids = new int[] { 4420 }, Name = "Glug Klugg", WikiUrl = "https://wiki.guildwars.com/wiki/Glug_Klugg" };
    public static readonly Npc ZhedShadowhoof = new() { Ids = new int[] { 4437, 4940, 4440 }, Name = "Zhed Shadowhoof", WikiUrl = "https://wiki.guildwars.com/wiki/Zhed_Shadowhoof" };
    public static readonly Npc Tahlkora = new() { Ids = new int[] { 4456, 4459 }, Name = "Tahlkora", WikiUrl = "https://wiki.guildwars.com/wiki/Tahlkora" };
    public static readonly Npc MasterOfWhispers = new() { Ids = new int[] { 4464 }, Name = "Master Of Whispers", WikiUrl = "https://wiki.guildwars.com/wiki/Master_of_Whispers" };
    public static readonly Npc AcolyteJin = new() { Ids = new int[] { 4469 }, Name = "Acolyte Jin", WikiUrl = "https://wiki.guildwars.com/wiki/Acolyte_Jin" };
    public static readonly Npc AcolyteSousuke = new() { Ids = new int[] { 4487, 4490 }, Name = "Acolyte Sousuke", WikiUrl = "https://wiki.guildwars.com/wiki/Acolyte_Sousuke" };
    public static readonly Npc Melonni = new() { Ids = new int[] { 4493, 4496 }, Name = "Melonni ", WikiUrl = "https://wiki.guildwars.com/wiki/Melonni" };
    public static readonly Npc Khim = new() { Ids = new int[] { 4531, 4549, 4578 }, Name = "Khim", WikiUrl = "https://wiki.guildwars.com/wiki/Khim" };
    public static readonly Npc Herta = new() { Ids = new int[] { 4532, 4537, 4544, 4551, 4566, 4576, 5989, 4586 }, Name = "Herta", WikiUrl = "https://wiki.guildwars.com/wiki/Herta" };
    public static readonly Npc Gehraz = new() { Ids = new int[] { 4533, 4540, 4547, 4554, 4571, 4581, 4591 }, Name = "Gehraz", WikiUrl = "https://wiki.guildwars.com/wiki/Gehraz" };
    public static readonly Npc Sogolon = new() { Ids = new int[] { 4534, 4541, 4548, 4555, 4572, 4582, 4592 }, Name = "Sogolon", WikiUrl = "https://wiki.guildwars.com/wiki/Sogolon" };
    public static readonly Npc Kihm = new() { Ids = new int[] { 4535, 4542, 4568 }, Name = "Kihm", WikiUrl = "https://wiki.guildwars.com/wiki/Kihm" };
    public static readonly Npc Odurra = new() { Ids = new int[] { 4536, 4543, 4550, 4563, 4573, 4583 }, Name = "Odurra", WikiUrl = "https://wiki.guildwars.com/wiki/Odurra" };
    public static readonly Npc Timera = new() { Ids = new int[] { 4538, 4545, 4552 }, Name = "Timera", WikiUrl = "https://wiki.guildwars.com/wiki/Timera" };
    public static readonly Npc Abasi = new() { Ids = new int[] { 4539, 4553, 4546 }, Name = "Abasi", WikiUrl = "https://wiki.guildwars.com/wiki/Abasi" };
    public static readonly Npc Sunspear = new() { Ids = new int[] { 4698, 4726, 4727, 4774, 4778, 4779, 4781, 4782, 4784, 4786, 4811, 4739, 4738 }, Name = "Sunspear", WikiUrl = "https://wiki.guildwars.com/wiki/Sunspear" };
    public static readonly Npc SunspearOfficer = new() { Ids = new int[] { 4700, 4701, 4705, 4723 }, Name = "Sunspear Officer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Istani" };
    public static readonly Npc Dzajo = new() { Ids = new int[] { 4702 }, Name = "Dzajo", WikiUrl = "https://wiki.guildwars.com/wiki/Dzajo" };
    public static readonly Npc ShoreWatcher = new() { Ids = new int[] { 4704 }, Name = "Shorewatcher", WikiUrl = "https://wiki.guildwars.com/wiki/Shorewatcher" };
    public static readonly Npc YoungChild = new() { Ids = new int[] { 4707, 4708 }, Name = "Young Child", WikiUrl = "https://wiki.guildwars.com/wiki/Young_Child" };
    public static readonly Npc IstaniNoble = new() { Ids = new int[] { 4709, 4710, 4711, 4733, 4737 }, Name = "Istani Noble", WikiUrl = "https://wiki.guildwars.com/wiki/Istani_Noble" };
    public static readonly Npc IstaniCommoner = new() { Ids = new int[] { 4712, 4713, 4715, 4722, 4724, 4725, 4729, 4730 }, Name = "Istani Commoner", WikiUrl = "https://wiki.guildwars.com/wiki/Istani_Commoner" };
    public static readonly Npc MonkSutoni = new() { Ids = new int[] { 4719 }, Name = "Monk Sutoni", WikiUrl = "https://wiki.guildwars.com/wiki/Monk_Sutoni" };
    public static readonly Npc Hagon = new() { Ids = new int[] { 4771 }, Name = "Hagon", WikiUrl = "https://wiki.guildwars.com/wiki/Hagon" };
    public static readonly Npc SunspearQuartermaster = new() { Ids = new int[] { 4772 }, Name = "Sunspear Quartermaster", WikiUrl = "https://wiki.guildwars.com/wiki/Sunspear_Quartermaster" };
    public static readonly Npc SunspearCaster = new() { Ids = new int[] { 4773 }, Name = "Sunspear Caster", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Istani" };
    public static readonly Npc Kina = new() { Ids = new int[] { 4776 }, Name = "Kina", WikiUrl = "https://wiki.guildwars.com/wiki/Kina" };
    public static readonly Npc ElderSuhl = new() { Ids = new int[] { 4813 }, Name = "Elder Suhl", WikiUrl = "https://wiki.guildwars.com/wiki/Elder_Suhl" };
    public static readonly Npc Kormir = new() { Ids = new int[] { 4865, 4864 }, Name = "Kormir", WikiUrl = "https://wiki.guildwars.com/wiki/Kormir" };
    public static readonly Npc DzabelLandGuardian = new() { Ids = new int[] { 4895 }, Name = "Dzabel Land Guardian", WikiUrl = "https://wiki.guildwars.com/wiki/Dzabel_Land_Guardian" };
    public static readonly Npc TheDrought = new() { Ids = new int[] { 4896 }, Name = "The Drought", WikiUrl = "https://wiki.guildwars.com/wiki/The_Drought" };
    public static readonly Npc CrackedMesa = new() { Ids = new int[] { 4904 }, Name = "Cracked Mesa", WikiUrl = "https://wiki.guildwars.com/wiki/Cracked_Mesa" };
    public static readonly Npc StoneShardCrag = new() { Ids = new int[] { 4905 }, Name = "Stone Shard Crag", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Shard_Crag" };
    public static readonly Npc BloodCowlHeket = new() { Ids = new int[] { 4909, 4694 }, Name = "Blood Cowl Heket", WikiUrl = "https://wiki.guildwars.com/wiki/Blood_Cowl_Heket" };
    public static readonly Npc BlueTongueHeket = new() { Ids = new int[] { 4910, 4695 }, Name = "Blue Tongue Heket", WikiUrl = "https://wiki.guildwars.com/wiki/Blue_Tongue_Heket" };
    public static readonly Npc StoneaxeHeket = new() { Ids = new int[] { 4911, 4696 }, Name = "Stoneaxe Heket", WikiUrl = "https://wiki.guildwars.com/wiki/Stoneaxe_Heket" };
    public static readonly Npc BeastSwornHeket = new() { Ids = new int[] { 4912, 4697 }, Name = "Beast Sworn Heket", WikiUrl = "https://wiki.guildwars.com/wiki/Beast_Sworn_Heket" };
    public static readonly Npc SteelfangDrake = new() { Ids = new int[] { 4918 }, Name = "Steelfang Drake", WikiUrl = "https://wiki.guildwars.com/wiki/Steelfang_Drake" };
    public static readonly Npc KuskaleBlighter = new() { Ids = new int[] { 4919 }, Name = "Kuskale Blighter", WikiUrl = "https://wiki.guildwars.com/wiki/Kuskale_Blighter" };
    public static readonly Npc RidgebackKuskale = new() { Ids = new int[] { 4920 }, Name = "Ridgeback Kuskale", WikiUrl = "https://wiki.guildwars.com/wiki/Ridgeback_Kuskale" };
    public static readonly Npc KuskaleLasher = new() { Ids = new int[] { 4921 }, Name = "Kuskale Lasher", WikiUrl = "https://wiki.guildwars.com/wiki/Kuskale_Lasher" };
    public static readonly Npc FrigidKuskale = new() { Ids = new int[] { 4922 }, Name = "Frigid Kuskale", WikiUrl = "https://wiki.guildwars.com/wiki/Frigid_Kuskale" };
    public static readonly Npc Droughtling = new() { Ids = new int[] { 4934 }, Name = "Droughtling", WikiUrl = "https://wiki.guildwars.com/wiki/Droughtling" };
    public static readonly Npc XunlaiChest = new() { Ids = new int[] { 5001 }, Name = "Xunlai Chest", WikiUrl = "https://wiki.guildwars.com/wiki/Xunlai_Chest" };
    public static readonly Npc CommanderWerishakul = new() { Ids = new int[] { 5020 }, Name = "Commander Werishakul", WikiUrl = "https://wiki.guildwars.com/wiki/Commander_Werishakul" };
    public static readonly Npc MidshipmanBennis = new() { Ids = new int[] { 5023 }, Name = "Midshipman Bennis", WikiUrl = "https://wiki.guildwars.com/wiki/Midshipman_Bennis" };
    public static readonly Npc AdmiralKaya = new() { Ids = new int[] { 5033 }, Name = "Admiral Kaya", WikiUrl = "https://wiki.guildwars.com/wiki/Admiral_Kaya" };
    public static readonly Npc CorsairWizard = new() { Ids = new int[] { 5034 }, Name = "Corsair Wizard", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Wizard" };
    public static readonly Npc CorsairBlackhand = new() { Ids = new int[] { 5035 }, Name = "Corsair Blackhand", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Blackhand" };
    public static readonly Npc CorsairCook = new() { Ids = new int[] { 5036 }, Name = "Corsair Cook", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Cook" };
    public static readonly Npc CorsairBosun = new() { Ids = new int[] { 5037, 5063 }, Name = "Corsair Bosun", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Bosun" };
    public static readonly Npc CorsairRaider = new() { Ids = new int[] { 5041, 5065 }, Name = "Corsair Raider", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Raider" };
    public static readonly Npc CorsairParagon = new() { Ids = new int[] { 5043 }, Name = "Corsair Paragon", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Istani" };
    public static readonly Npc CorsairMindReader = new() { Ids = new int[] { 5044 }, Name = "Corsair Mind Reader", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Mind_Reader" };
    public static readonly Npc CorsairDoctor = new() { Ids = new int[] { 5047 }, Name = "Corsair Doctor", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Doctor" };
    public static readonly Npc CorsairWeaponsMaster = new() { Ids = new int[] { 5048 }, Name = "Corsair Weapons Master", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Weapons_Master" };
    public static readonly Npc CorsairGrappler = new() { Ids = new int[] { 5050 }, Name = "Corsair Grappler", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Grappler" };
    public static readonly Npc CorsairAdmiral = new() { Ids = new int[] { 5051 }, Name = "Corsair Admiral", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Admiral" };
    public static readonly Npc CorsairSeer = new() { Ids = new int[] { 5052 }, Name = "Corsair Seer", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Seer" };
    public static readonly Npc CorsairFlogger = new() { Ids = new int[] { 5053 }, Name = "Corsair Flogger", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Flogger" };
    public static readonly Npc CorsairReefFinder = new() { Ids = new int[] { 5054 }, Name = "Corsair Reef Finder", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Reef_Finder" };
    public static readonly Npc CorsairMedic = new() { Ids = new int[] { 5055 }, Name = "Corsair Medic", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Medic" };
    public static readonly Npc CorsairThug = new() { Ids = new int[] { 5056 }, Name = "Corsair Thug", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Thug" };
    public static readonly Npc CorsairLookout = new() { Ids = new int[] { 5057 }, Name = "Corsair Lookout", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Lookout" };
    public static readonly Npc CorsairMarauder = new() { Ids = new int[] { 5058 }, Name = "Corsair Marauder", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Marauder" };
    public static readonly Npc CorsairCaptain = new() { Ids = new int[] { 5059 }, Name = "Corsair Captain", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Captain" };
    public static readonly Npc CorsairCutthroat = new() { Ids = new int[] { 5064 }, Name = "Corsair Cutthroat", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Cutthroat" };
    public static readonly Npc CorsairBerserker = new() { Ids = new int[] { 5066 }, Name = "Corsair Berserker", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Berserker" };
    public static readonly Npc CorsairCommandant = new() { Ids = new int[] { 5067 }, Name = "Corsair Commandant", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Commandant" };
    public static readonly Npc Corsair = new() { Ids = new int[] { 5072, 5079 }, Name = "Corsair", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair" };
    public static readonly Npc GatekeeperKahno = new() { Ids = new int[] { 5073 }, Name = "Gatekeeper Kahno", WikiUrl = "https://wiki.guildwars.com/wiki/Gatekeeper_Kahno" };
    public static readonly Npc UnluckySimon = new() { Ids = new int[] { 5074 }, Name = "Unlucky Simon", WikiUrl = "https://wiki.guildwars.com/wiki/Unlucky_Simon" };
    public static readonly Npc CorsairWarrior = new() { Ids = new int[] { 5076 }, Name = "Corsair Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Istani" };
    public static readonly Npc IronhookHube = new() { Ids = new int[] { 5077 }, Name = "Ironhook Hube", WikiUrl = "https://wiki.guildwars.com/wiki/Ironhook_Hube" };
    public static readonly Npc OneEyedRugger = new() { Ids = new int[] { 5078 }, Name = "One-Eyed Rugger", WikiUrl = "https://wiki.guildwars.com/wiki/One-Eyed_Rugger" };
    public static readonly Npc OrderOfWhispers = new() { Ids = new int[] { 5218, 5683 }, Name = "Order Of Whispers", WikiUrl = "https://wiki.guildwars.com/wiki/Order_of_Whispers" };
    public static readonly Npc ColonelChaklin = new() { Ids = new int[] { 5229 }, Name = "Colonel Chaklin", WikiUrl = "https://wiki.guildwars.com/wiki/Colonel_Chaklin" };
    public static readonly Npc ColonelCusto = new() { Ids = new int[] { 5230 }, Name = "Colonel Custo", WikiUrl = "https://wiki.guildwars.com/wiki/Colonel_Custo" };
    public static readonly Npc CorporalLuluh = new() { Ids = new int[] { 5231 }, Name = "Corporal Luluh", WikiUrl = "https://wiki.guildwars.com/wiki/Corporal_Luluh" };
    public static readonly Npc AcolyteofDwayna = new() { Ids = new int[] { 5237 }, Name = "Acolyte of Dwayna", WikiUrl = "https://wiki.guildwars.com/wiki/Acolyte_of_Dwayna" };
    public static readonly Npc GeneralKahyet = new() { Ids = new int[] { 5241 }, Name = "General Kahyet", WikiUrl = "https://wiki.guildwars.com/wiki/General_Kahyet" };
    public static readonly Npc CaptainBesuz = new() { Ids = new int[] { 5271 }, Name = "Captain Besuz", WikiUrl = "https://wiki.guildwars.com/wiki/Captain_Besuz" };
    public static readonly Npc DreamerHahla = new() { Ids = new int[] { 5278 }, Name = "Dreamer Hahla", WikiUrl = "https://wiki.guildwars.com/wiki/Dreamer_Hahla" };
    public static readonly Npc KournanSpotter = new() { Ids = new int[] { 5282 }, Name = "Kournan Spotter", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Spotter" };
    public static readonly Npc KournanEngineer = new() { Ids = new int[] { 5305 }, Name = "Kournan Engineer", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Engineer" };
    public static readonly Npc KournanSeer = new() { Ids = new int[] { 5321, 5319 }, Name = "Kournan Seer", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Seer" };
    public static readonly Npc KournanOppressor = new() { Ids = new int[] { 5325, 5323 }, Name = "Kournan Oppressor", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Oppressor" };
    public static readonly Npc KournanScribe = new() { Ids = new int[] { 5329, 5327 }, Name = "Kournan Scribe", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Scribe" };
    public static readonly Npc KournanPriest = new() { Ids = new int[] { 5333, 5331 }, Name = "Kournan Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Priest" };
    public static readonly Npc KournanGuard = new() { Ids = new int[] { 5336, 5340, 5364, 5365, 5370, 5337, 5368 }, Name = "Kournan Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Guard" };
    public static readonly Npc KournanBowman = new() { Ids = new int[] { 5345, 5343 }, Name = "Kournan Bowman", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Bowman" };
    public static readonly Npc KournanZealot = new() { Ids = new int[] { 5349, 5347 }, Name = "Kournan Zealot", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Zealot" };
    public static readonly Npc KournanPhalanx = new() { Ids = new int[] { 5351, 5354 }, Name = "Kournan Phalanx", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Phalanx" };
    public static readonly Npc KournanFieldCommander = new() { Ids = new int[] { 5353 }, Name = "Kournan Field Commander", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Field_Commander" };
    public static readonly Npc KournanChild = new() { Ids = new int[] { 5362, 5363 }, Name = "Kournan Child", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Child" };
    public static readonly Npc KournanNoble = new() { Ids = new int[] { 5373, 5374 }, Name = "Kournan Noble", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Noble" };
    public static readonly Npc KournanPeasant = new() { Ids = new int[] { 5375, 5376, 5377, 5378, 5379, 5380 }, Name = "Kournan Peasant", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Peasant" };
    public static readonly Npc WanderingPriest = new() { Ids = new int[] { 5383, 5384 }, Name = "Wandering Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Wandering_Priest" };
    public static readonly Npc Ashnod = new() { Ids = new int[] { 5389 }, Name = "Ashnod", WikiUrl = "https://wiki.guildwars.com/wiki/Ashnod" };
    public static readonly Npc Raleva = new() { Ids = new int[] { 5390 }, Name = "Raleva", WikiUrl = "https://wiki.guildwars.com/wiki/Raleva" };
    public static readonly Npc KournanTrader = new() { Ids = new int[] { 5402, 5396, 5397, 5400 }, Name = "Kournan Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kournans" };
    public static readonly Npc HarbingerOfTwilight = new() { Ids = new int[] { 5405, 5409 }, Name = "Harbinger Of Twilight", WikiUrl = "https://wiki.guildwars.com/wiki/Harbinger_of_Twilight" };
    public static readonly Npc RestlessDead = new() { Ids = new int[] { 5541 }, Name = "Restless Dead", WikiUrl = "https://wiki.guildwars.com/wiki/Restless_Dead" };
    public static readonly Npc RelentlessCorpse = new() { Ids = new int[] { 5542 }, Name = "Relentless Corpse", WikiUrl = "https://wiki.guildwars.com/wiki/Relentless_Corpse" };
    public static readonly Npc GhostlySunspearCommander = new() { Ids = new int[] { 5545 }, Name = "Ghostly Sunspear Commander", WikiUrl = "https://wiki.guildwars.com/wiki/Ghostly_Sunspear_Commander" };
    public static readonly Npc Kahdash = new() { Ids = new int[] { 5546 }, Name = "Kahdash", WikiUrl = "https://wiki.guildwars.com/wiki/Kahdash" };
    public static readonly Npc VabbianGuard = new() { Ids = new int[] { 5632, 5639, 5645, 5634, 5647, 5637 }, Name = "Vabbian Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Vabbian_Guard" };
    public static readonly Npc VabbianChild = new() { Ids = new int[] { 5649, 5648 }, Name = "Vabbian Child", WikiUrl = "https://wiki.guildwars.com/wiki/Vabbian_Child" };
    public static readonly Npc VabbianNoble = new() { Ids = new int[] { 5650, 5652 }, Name = "Vabbian Noble", WikiUrl = "https://wiki.guildwars.com/wiki/Vabbian_Noble" };
    public static readonly Npc RoyalChefHatundo = new() { Ids = new int[] { 5654 }, Name = "Royal Chef Hatundo", WikiUrl = "https://wiki.guildwars.com/wiki/Royal_Chef_Hatundo" };
    public static readonly Npc VabbianMerchant = new() { Ids = new int[] { 5670, 5673, 5669, 5681, 5675, 5676, 5677 }, Name = "Vabbian Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Vabbians" };
    public static readonly Npc SpiritOfInfuriatingHeat = new() { Ids = new int[] { 5715 }, Name = "Spirit Of Infuriating Heat", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Infuriating_Heat" };
    public static readonly Npc SpiritOfToxicity = new() { Ids = new int[] { 5716 }, Name = "Spirit Of Toxicity", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Toxicity" };
    public static readonly Npc SpiritOfFury = new() { Ids = new int[] { 5722 }, Name = "Spirit Of Fury", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Fury" };
    public static readonly Npc AlbinoRat = new() { Ids = new int[] { 5777 }, Name = "Albino Rat", WikiUrl = "https://wiki.guildwars.com/wiki/Albino_Rat" };
    public static readonly Npc WhiteCrab = new() { Ids = new int[] { 5778 }, Name = "White Crab", WikiUrl = "https://wiki.guildwars.com/wiki/White_Crab" };
    public static readonly Npc BlackWolf = new() { Ids = new int[] { 5780 }, Name = "Black Wolf", WikiUrl = "https://wiki.guildwars.com/wiki/Black_Wolf" };
    public static readonly Npc WhiteWolf = new() { Ids = new int[] { 5781 }, Name = "White Wolf", WikiUrl = "https://wiki.guildwars.com/wiki/White_Wolf" };
    public static readonly Npc MountainEagle = new() { Ids = new int[] { 5782 }, Name = "Mountain Eagle", WikiUrl = "https://wiki.guildwars.com/wiki/Mountain_Eagle" };
    public static readonly Npc PolarBear = new() { Ids = new int[] { 5783 }, Name = "Polar Bear", WikiUrl = "https://wiki.guildwars.com/wiki/Polar_Bear" };
    public static readonly Npc WhiteMoa = new() { Ids = new int[] { 5784 }, Name = "White Moa", WikiUrl = "https://wiki.guildwars.com/wiki/White_Moa" };
    public static readonly Npc Rabbit = new() { Ids = new int[] { 5842 }, Name = "Rabbit", WikiUrl = "https://wiki.guildwars.com/wiki/Rabbit" };
    public static readonly Npc ArcticWolf = new() { Ids = new int[] { 5843 }, Name = "Arctic Wolf", WikiUrl = "https://wiki.guildwars.com/wiki/Arctic_Wolf" };
    public static readonly Npc Stonewolf = new() { Ids = new int[] { 5844 }, Name = "Stonewolf", WikiUrl = "https://wiki.guildwars.com/wiki/Stonewolf" };
    public static readonly Npc Vekk = new() { Ids = new int[] { 5913 }, Name = "Vekk", WikiUrl = "https://wiki.guildwars.com/wiki/Vekk" };
    public static readonly Npc OgdenStonehealer = new() { Ids = new int[] { 5932 }, Name = "Ogden Stonehealer", WikiUrl = "https://wiki.guildwars.com/wiki/Ogden_Stonehealer" };
    public static readonly Npc Livia = new() { Ids = new int[] { 5948 }, Name = "Livia", WikiUrl = "https://wiki.guildwars.com/wiki/Livia" };
    public static readonly Npc Xandra = new() { Ids = new int[] { 5974 }, Name = "Xandra", WikiUrl = "https://wiki.guildwars.com/wiki/Xandra" };
    public static readonly Npc Jora = new() { Ids = new int[] { 5983 }, Name = "Jora", WikiUrl = "https://wiki.guildwars.com/wiki/Jora" };
    public static readonly Npc Bartholos = new() { Ids = new int[] { 6058 }, Name = "Bartholos", WikiUrl = "https://wiki.guildwars.com/wiki/Bartholos" };
    public static readonly Npc ShiningBladeCaster = new() { Ids = new int[] { 6064 }, Name = "Shining Blade Caster", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc KilroyStonekin = new() { Ids = new int[] { 6174 }, Name = "Kilroy Stonekin", WikiUrl = "https://wiki.guildwars.com/wiki/Kilroy_Stonekin" };
    public static readonly Npc DwarvenMiner = new() { Ids = new int[] { 6181 }, Name = "Dwarven Miner", WikiUrl = "https://wiki.guildwars.com/wiki/Dwarven_Miner" };
    public static readonly Npc WildermWrathspew = new() { Ids = new int[] { 6256 }, Name = "Wilderm Wrathspew", WikiUrl = "https://wiki.guildwars.com/wiki/Wilderm_Wrathspew" };
    public static readonly Npc FlanussBroadwing = new() { Ids = new int[] { 6258 }, Name = "Flanuss Broadwing", WikiUrl = "https://wiki.guildwars.com/wiki/Flanuss_Broadwing" };
    public static readonly Npc MobrinLordOfTheMarsh = new() { Ids = new int[] { 6261 }, Name = "Mobrin Lord Of The Marsh", WikiUrl = "https://wiki.guildwars.com/wiki/Mobrin,_Lord_of_the_Marsh" };
    public static readonly Npc PywattTheSwift = new() { Ids = new int[] { 6262 }, Name = "Pywatt The Swift", WikiUrl = "https://wiki.guildwars.com/wiki/Pywatt_the_Swift" };
    public static readonly Npc BrynnEarthporter = new() { Ids = new int[] { 6268 }, Name = "Brynn Earthporter", WikiUrl = "https://wiki.guildwars.com/wiki/Brynn_Earthporter" };
    public static readonly Npc KraitHypnoss = new() { Ids = new int[] { 6287 }, Name = "Krait Hypnoss", WikiUrl = "https://wiki.guildwars.com/wiki/Krait_Hypnoss" };
    public static readonly Npc KraitArcanoss = new() { Ids = new int[] { 6288 }, Name = "Krait Arcanoss", WikiUrl = "https://wiki.guildwars.com/wiki/Krait_Arcanoss" };
    public static readonly Npc KraitDevouss = new() { Ids = new int[] { 6289 }, Name = "Krait Devouss", WikiUrl = "https://wiki.guildwars.com/wiki/Krait_Devouss" };
    public static readonly Npc KraitNecross = new() { Ids = new int[] { 6290 }, Name = "Krait Necross", WikiUrl = "https://wiki.guildwars.com/wiki/Krait_Necross" };
    public static readonly Npc KraitNeoss = new() { Ids = new int[] { 6293 }, Name = "Krait Neoss", WikiUrl = "https://wiki.guildwars.com/wiki/Krait_Neoss" };
    public static readonly Npc SavageOakheart = new() { Ids = new int[] { 6301 }, Name = "Savage Oakheart", WikiUrl = "https://wiki.guildwars.com/wiki/Savage_Oakheart" };
    public static readonly Npc SkelkAfflictor = new() { Ids = new int[] { 6303 }, Name = "Skelk Afflictor", WikiUrl = "https://wiki.guildwars.com/wiki/Skelk_Afflictor" };
    public static readonly Npc SkelkScourger = new() { Ids = new int[] { 6304 }, Name = "Skelk Scourger", WikiUrl = "https://wiki.guildwars.com/wiki/Skelk_Scourger" };
    public static readonly Npc SkelkReaper = new() { Ids = new int[] { 6305 }, Name = "Skelk Reaper", WikiUrl = "https://wiki.guildwars.com/wiki/Skelk_Reaper" };
    public static readonly Npc Angorodon = new() { Ids = new int[] { 6306 }, Name = "Angorodon", WikiUrl = "https://wiki.guildwars.com/wiki/Angorodon" };
    public static readonly Npc Ferothrax = new() { Ids = new int[] { 6307 }, Name = "Ferothrax", WikiUrl = "https://wiki.guildwars.com/wiki/Ferothrax" };
    public static readonly Npc Ceratadon = new() { Ids = new int[] { 6308 }, Name = "Ceratadon", WikiUrl = "https://wiki.guildwars.com/wiki/Ceratadon" };
    public static readonly Npc Tyrannus = new() { Ids = new int[] { 6309 }, Name = "Tyrannus", WikiUrl = "https://wiki.guildwars.com/wiki/Tyrannus" };
    public static readonly Npc Raptor = new() { Ids = new int[] { 6310 }, Name = "Raptor", WikiUrl = "https://wiki.guildwars.com/wiki/Raptor" };
    public static readonly Npc AgariTlamatini = new() { Ids = new int[] { 6316 }, Name = "Agari Tlamatini", WikiUrl = "https://wiki.guildwars.com/wiki/Agari_Tlamatini" };
    public static readonly Npc AgariAmini = new() { Ids = new int[] { 6317 }, Name = "Agari Amini", WikiUrl = "https://wiki.guildwars.com/wiki/Agari_Amini" };
    public static readonly Npc AgariNahualli = new() { Ids = new int[] { 6318 }, Name = "Agari Nahualli", WikiUrl = "https://wiki.guildwars.com/wiki/Agari_Nahualli" };
    public static readonly Npc AgariCuicani = new() { Ids = new int[] { 6319 }, Name = "Agari Cuicani", WikiUrl = "https://wiki.guildwars.com/wiki/Agari_Cuicani" };
    public static readonly Npc Bloodweaver = new() { Ids = new int[] { 6328, 6329 }, Name = "Bloodweaver", WikiUrl = "https://wiki.guildwars.com/wiki/Bloodweaver" };
    public static readonly Npc Lifeweaver = new() { Ids = new int[] { 6330, 6331 }, Name = "Lifeweaver", WikiUrl = "https://wiki.guildwars.com/wiki/Lifeweaver" };
    public static readonly Npc Venomweaver = new() { Ids = new int[] { 6333 }, Name = "Venomweaver", WikiUrl = "https://wiki.guildwars.com/wiki/Venomweaver" };
    public static readonly Npc CloudtouchedSimian = new() { Ids = new int[] { 6334 }, Name = "Cloudtouched Simian", WikiUrl = "https://wiki.guildwars.com/wiki/Cloudtouched_Simian" };
    public static readonly Npc RedhandSimian = new() { Ids = new int[] { 6335 }, Name = "Redhand Simian", WikiUrl = "https://wiki.guildwars.com/wiki/Redhand_Simian" };
    public static readonly Npc QuetzalSly = new() { Ids = new int[] { 6337 }, Name = "Quetzal Sly", WikiUrl = "https://wiki.guildwars.com/wiki/Quetzal_Sly" };
    public static readonly Npc QuetzalDark = new() { Ids = new int[] { 6338 }, Name = "Quetzal Dark", WikiUrl = "https://wiki.guildwars.com/wiki/Quetzal_Dark" };
    public static readonly Npc QuetzalStark = new() { Ids = new int[] { 6339 }, Name = "Quetzal Stark", WikiUrl = "https://wiki.guildwars.com/wiki/Quetzal_Stark" };
    public static readonly Npc QuetzalKeen = new() { Ids = new int[] { 6340 }, Name = "Quetzal Keen", WikiUrl = "https://wiki.guildwars.com/wiki/Quetzal_Keen" };
    public static readonly Npc SifShadowhunter = new() { Ids = new int[] { 6347, 6348 }, Name = "Sif Shadowhunter", WikiUrl = "https://wiki.guildwars.com/wiki/Sif_Shadowhunter" };
    public static readonly Npc NornCommoner = new() { Ids = new int[] { 6349, 6385, 6390, 6398, 6404 }, Name = "Norn Commoner", WikiUrl = "https://wiki.guildwars.com/wiki/Norn_Commoner" };
    public static readonly Npc OlafOlafson = new() { Ids = new int[] { 6352 }, Name = "Olaf Olafson", WikiUrl = "https://wiki.guildwars.com/wiki/Olaf_Olafson" };
    public static readonly Npc GunnarPoundfist = new() { Ids = new int[] { 6353 }, Name = "Gunnar Poundfist", WikiUrl = "https://wiki.guildwars.com/wiki/Gunnar_Poundfist" };
    public static readonly Npc NornGuard = new() { Ids = new int[] { 6357, 6380 }, Name = "Norn Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Norn_Guard" };
    public static readonly Npc NornWarrior = new() { Ids = new int[] { 6374 }, Name = "Norn Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Norn_Warrior" };
    public static readonly Npc Eyja = new() { Ids = new int[] { 6384 }, Name = "Eyja", WikiUrl = "https://wiki.guildwars.com/wiki/Eyja" };
    public static readonly Npc NornTrader = new() { Ids = new int[] { 6387, 6392, 6393, 6394, 6395, 6396, 6399, 6400 }, Name = "Norn Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Norn" };
    public static readonly Npc NornWeaponsmith = new() { Ids = new int[] { 6389 }, Name = "Norn Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Norn" };
    public static readonly Npc NornElder = new() { Ids = new int[] { 6397 }, Name = "Norn Elder", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Norn" };
    public static readonly Npc GlacialGriffon = new() { Ids = new int[] { 6411 }, Name = "Glacial Griffon", WikiUrl = "https://wiki.guildwars.com/wiki/Glacial_Griffon" };
    public static readonly Npc SavageNornbear = new() { Ids = new int[] { 6418 }, Name = "Savage Nornbear", WikiUrl = "https://wiki.guildwars.com/wiki/Savage_Nornbear" };
    public static readonly Npc InscribedEttin = new() { Ids = new int[] { 6432 }, Name = "Inscribed Ettin", WikiUrl = "https://wiki.guildwars.com/wiki/Inscribed_Ettin" };
    public static readonly Npc NulfastuEarthbound = new() { Ids = new int[] { 6445 }, Name = "Nulfastu Earthbound", WikiUrl = "https://wiki.guildwars.com/wiki/Nulfastu_Earthbound" };
    public static readonly Npc MyishLadyOfTheLake = new() { Ids = new int[] { 6447 }, Name = "Myish Lady Of The Lake", WikiUrl = "https://wiki.guildwars.com/wiki/Myish,_Lady_of_the_Lake" };
    public static readonly Npc Whiteout = new() { Ids = new int[] { 6448 }, Name = "Whiteout", WikiUrl = "https://wiki.guildwars.com/wiki/Whiteout" };
    public static readonly Npc AvarrTheFallen = new() { Ids = new int[] { 6454 }, Name = "Avarr The Fallen", WikiUrl = "https://wiki.guildwars.com/wiki/Avarr_The_Fallen" };
    public static readonly Npc ModniirPriest = new() { Ids = new int[] { 6473 }, Name = "Modniir Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Modniir_Priest" };
    public static readonly Npc ModniirBerserker = new() { Ids = new int[] { 6475 }, Name = "Modniir Berserker", WikiUrl = "https://wiki.guildwars.com/wiki/Modniir_Berserker" };
    public static readonly Npc ModniirHunter = new() { Ids = new int[] { 6476 }, Name = "Modniir Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Modniir_Hunter" };
    public static readonly Npc Avalanche = new() { Ids = new int[] { 6477 }, Name = "Avalanche", WikiUrl = "https://wiki.guildwars.com/wiki/Avalanche" };
    public static readonly Npc FrozenElemental = new() { Ids = new int[] { 6478 }, Name = "Frozen Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Frozen_Elemental" };
    public static readonly Npc ChillingWisp = new() { Ids = new int[] { 6479 }, Name = "Chilling Wisp", WikiUrl = "https://wiki.guildwars.com/wiki/Chilling_Wisp" };
    public static readonly Npc JotunSkullsmasher = new() { Ids = new int[] { 6480 }, Name = "Jotun Skullsmasher", WikiUrl = "https://wiki.guildwars.com/wiki/Jotun_Skullsmasher" };
    public static readonly Npc JotunMindbreaker = new() { Ids = new int[] { 6481 }, Name = "Jotun Mindbreaker", WikiUrl = "https://wiki.guildwars.com/wiki/Jotun_Mindbreaker" };
    public static readonly Npc JotunBladeturner = new() { Ids = new int[] { 6482 }, Name = "Jotun Bladeturner", WikiUrl = "https://wiki.guildwars.com/wiki/Jotun_Bladeturner" };
    public static readonly Npc JotunBloodcurdler = new() { Ids = new int[] { 6483 }, Name = "Jotun Bloodcurdler", WikiUrl = "https://wiki.guildwars.com/wiki/Jotun_Bloodcurdler" };
    public static readonly Npc BerserkingWendigo = new() { Ids = new int[] { 6484 }, Name = "Berserking Wendigo", WikiUrl = "https://wiki.guildwars.com/wiki/Berserking_Wendigo" };
    public static readonly Npc BerserkingAuroch = new() { Ids = new int[] { 6485 }, Name = "Berserking Auroch", WikiUrl = "https://wiki.guildwars.com/wiki/Berserking_Aurochs" };
    public static readonly Npc BerserkingMinotaur = new() { Ids = new int[] { 6486 }, Name = "Berserking Minotaur", WikiUrl = "https://wiki.guildwars.com/wiki/Berserking_Minotaur" };
    public static readonly Npc BerserkingBison = new() { Ids = new int[] { 6487 }, Name = "Berserking Bison", WikiUrl = "https://wiki.guildwars.com/wiki/Berserking_Bison" };
    public static readonly Npc MountainPinesoul = new() { Ids = new int[] { 6488 }, Name = "Mountain Pinesoul", WikiUrl = "https://wiki.guildwars.com/wiki/Mountain_Pinesoul" };
    public static readonly Npc MountainAloe = new() { Ids = new int[] { 6489 }, Name = "Mountain Aloe", WikiUrl = "https://wiki.guildwars.com/wiki/Mountain_Aloe" };
    public static readonly Npc SpectralVaettir = new() { Ids = new int[] { 6490 }, Name = "Spectral Vaettir", WikiUrl = "https://wiki.guildwars.com/wiki/Spectral_Vaettir" };
    public static readonly Npc FrostWurm = new() { Ids = new int[] { 6491 }, Name = "Frost Wurm", WikiUrl = "https://wiki.guildwars.com/wiki/Frost_Wurm" };
    public static readonly Npc CharrProphet = new() { Ids = new int[] { 6624 }, Name = "Charr Prophet", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Prophet" };
    public static readonly Npc FronisIrontoe = new() { Ids = new int[] { 6690 }, Name = "Fronis Irontoe", WikiUrl = "https://wiki.guildwars.com/wiki/Fronis_Irontoe" };
    public static readonly Npc StoneSummitRanger = new() { Ids = new int[] { 6695 }, Name = "Stone Summit Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Ranger" };
    public static readonly Npc StoneSummitHealer = new() { Ids = new int[] { 6699 }, Name = "Stone Summit Healer", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Healer" };
    public static readonly Npc StoneSummitCrusher = new() { Ids = new int[] { 6702, 6993, 2645 }, Name = "Stone Summit Crusher", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Crusher" };
    public static readonly Npc AsuranMaterialTrader = new() { Ids = new int[] { 6712 }, Name = "Asuran Material Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Asura" };
    public static readonly Npc Lork = new() { Ids = new int[] { 6718 }, Name = "Lork", WikiUrl = "https://wiki.guildwars.com/wiki/Lork" };
    public static readonly Npc Gadd = new() { Ids = new int[] { 6721 }, Name = "Gadd", WikiUrl = "https://wiki.guildwars.com/wiki/Gadd" };
    public static readonly Npc PurifierKreweMember = new() { Ids = new int[] { 6756 }, Name = "Purifier Krewe Member", WikiUrl = "https://wiki.guildwars.com/wiki/Purifier_Krewe_Member" };
    public static readonly Npc Blorf = new() { Ids = new int[] { 6757 }, Name = "Blorf", WikiUrl = "https://wiki.guildwars.com/wiki/Blorf" };
    public static readonly Npc AsuranElder = new() { Ids = new int[] { 6771 }, Name = "Asuran Elder", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Asura" };
    public static readonly Npc AsuranRuneTrader = new() { Ids = new int[] { 6774 }, Name = "Asuran Rune Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Asura" };
    public static readonly Npc Asuran = new() { Ids = new int[] { 6775 }, Name = "Asuran", WikiUrl = "https://wiki.guildwars.com/wiki/Asuran" };
    public static readonly Npc AsuranChild = new() { Ids = new int[] { 6777 }, Name = "Asuran Child", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Asura" };
    public static readonly Npc Fonk = new() { Ids = new int[] { 6782 }, Name = "Fonk", WikiUrl = "https://wiki.guildwars.com/wiki/Fonk" };
    public static readonly Npc EnchantedScythe = new() { Ids = new int[] { 6815 }, Name = "Enchanted Scythe", WikiUrl = "https://wiki.guildwars.com/wiki/Enchanted_Scythe" };
    public static readonly Npc EnchantedShield = new() { Ids = new int[] { 6816 }, Name = "Enchanted Shield", WikiUrl = "https://wiki.guildwars.com/wiki/Enchanted_Shield" };
    public static readonly Npc DredgeCaster = new() { Ids = new int[] { 6837 }, Name = "Dredge Caster", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dredge" };
    public static readonly Npc BloodthirstIncubus = new() { Ids = new int[] { 6845 }, Name = "Bloodthirst Incubus", WikiUrl = "https://wiki.guildwars.com/wiki/Bloodthirst_Incubus" };
    public static readonly Npc CryptwingIncubus = new() { Ids = new int[] { 6849 }, Name = "Cryptwing Incubus", WikiUrl = "https://wiki.guildwars.com/wiki/Cryptwing_Incubus" };
    public static readonly Npc StormcloudIncubus = new() { Ids = new int[] { 6851 }, Name = "Stormcloud Incubus", WikiUrl = "https://wiki.guildwars.com/wiki/Stormcloud_Incubus" };
    public static readonly Npc SkelkSlasher = new() { Ids = new int[] { 6853 }, Name = "Skelk Slasher", WikiUrl = "https://wiki.guildwars.com/wiki/Skelk_Slasher" };
    public static readonly Npc SkelkCorrupter = new() { Ids = new int[] { 6854 }, Name = "Skelk Corrupter", WikiUrl = "https://wiki.guildwars.com/wiki/Skelk_Corrupter" };
    public static readonly Npc SkelkRampager = new() { Ids = new int[] { 6855 }, Name = "Skelk Rampager", WikiUrl = "https://wiki.guildwars.com/wiki/Skelk_Rampager" };
    public static readonly Npc EnchantedAxe = new() { Ids = new int[] { 6862 }, Name = "Enchanted Axe", WikiUrl = "https://wiki.guildwars.com/wiki/Enchanted_Axe" };
    public static readonly Npc ShimmeringOoze = new() { Ids = new int[] { 6888, 6889, 6890 }, Name = "Shimmering Ooze", WikiUrl = "https://wiki.guildwars.com/wiki/Shimmering_Ooze" };
    public static readonly Npc OminousOoze = new() { Ids = new int[] { 6891 }, Name = "Ominous Ooze", WikiUrl = "https://wiki.guildwars.com/wiki/Ominous_Ooze" };
    public static readonly Npc EarthboundOoze = new() { Ids = new int[] { 6894, 6896 }, Name = "Earthbound Ooze", WikiUrl = "https://wiki.guildwars.com/wiki/Earthbound_Ooze" };
    public static readonly Npc CorruptedAloe = new() { Ids = new int[] { 6905 }, Name = "Corrupted Aloe", WikiUrl = "https://wiki.guildwars.com/wiki/Corrupted_Aloe" };
    public static readonly Npc FungalBloom = new() { Ids = new int[] { 6906 }, Name = "Fungal Bloom", WikiUrl = "https://wiki.guildwars.com/wiki/Fungal_Bloom" };
    public static readonly Npc InscribedGuardian = new() { Ids = new int[] { 6909 }, Name = "Inscribed Guardian", WikiUrl = "https://wiki.guildwars.com/wiki/Inscribed_Guardian" };
    public static readonly Npc FragmentOfAntiquities = new() { Ids = new int[] { 6933 }, Name = "Fragment Of Antiquities", WikiUrl = "https://wiki.guildwars.com/wiki/Fragment_of_Antiquities" };
    public static readonly Npc RemnantOfAntiquities = new() { Ids = new int[] { 6934 }, Name = "Remnant Of Antiquities", WikiUrl = "https://wiki.guildwars.com/wiki/Remnant_of_Antiquities" };
    public static readonly Npc RegentOfIce = new() { Ids = new int[] { 6935 }, Name = "Regent Of Ice", WikiUrl = "https://wiki.guildwars.com/wiki/Regent_of_Ice" };
    public static readonly Npc ChromaticDrake = new() { Ids = new int[] { 6938 }, Name = "Chromatic Drake", WikiUrl = "https://wiki.guildwars.com/wiki/Chromatic_Drake" };
    public static readonly Npc TerrorbondDryder = new() { Ids = new int[] { 6942 }, Name = "Terrorbond Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Terrorbond_Dryder" };
    public static readonly Npc DreadgazeDryder = new() { Ids = new int[] { 6943 }, Name = "Dreadgaze Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Dreadgaze_Dryder" };
    public static readonly Npc BloodtaintDryder = new() { Ids = new int[] { 6944 }, Name = "Bloodtaint Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Bloodtaint_Dryder" };
    public static readonly Npc SoulfireDryder = new() { Ids = new int[] { 6945 }, Name = "Soulfire Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Soulfire_Dryder" };
    public static readonly Npc ShatteredElemental = new() { Ids = new int[] { 6948 }, Name = "Shattered Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Shattered_Elemental" };
    public static readonly Npc WhirlingWisp = new() { Ids = new int[] { 6949 }, Name = "Whirling Wisp", WikiUrl = "https://wiki.guildwars.com/wiki/Whirling_Wisp" };
    public static readonly Npc IcyStalagmite = new() { Ids = new int[] { 6950 }, Name = "Icy Stalagmite", WikiUrl = "https://wiki.guildwars.com/wiki/Icy_Stalagmite" };
    public static readonly Npc ShadowVaettir = new() { Ids = new int[] { 6953 }, Name = "Shadow Vaettir", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Vaettir" };
    public static readonly Npc ScourgeVaettir = new() { Ids = new int[] { 6956 }, Name = "Scourge Vaettir", WikiUrl = "https://wiki.guildwars.com/wiki/Scourge_Vaettir" };
    public static readonly Npc MistVaettir = new() { Ids = new int[] { 6959 }, Name = "Mist Vaettir", WikiUrl = "https://wiki.guildwars.com/wiki/Mist_Vaettir" };
    public static readonly Npc CursedBrigand = new() { Ids = new int[] { 7009 }, Name = "Cursed Brigand", WikiUrl = "https://wiki.guildwars.com/wiki/Cursed_Brigand" };
    public static readonly Npc DamnedCrewman = new() { Ids = new int[] { 7012 }, Name = "Damned Crewman", WikiUrl = "https://wiki.guildwars.com/wiki/Damned_Crewman" };
    public static readonly Npc FendiNin = new() { Ids = new int[] { 7013 }, Name = "Fendi Nin", WikiUrl = "https://wiki.guildwars.com/wiki/Fendi_Nin" };
    public static readonly Npc SoulOfFendiNin = new() { Ids = new int[] { 7014 }, Name = "Soul Of Fendi Nin", WikiUrl = "https://wiki.guildwars.com/wiki/Soul_of_Fendi_Nin" };
    public static readonly Npc PirateGhost = new() { Ids = new int[] { 7020 }, Name = "Pirate Ghost", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Ghosts" };
    public static readonly Npc CryptWraith = new() { Ids = new int[] { 7028 }, Name = "Crypt Wraith", WikiUrl = "https://wiki.guildwars.com/wiki/Crypt_Wraith" };
    public static readonly Npc ShockPhantom = new() { Ids = new int[] { 7032 }, Name = "Shock Phantom", WikiUrl = "https://wiki.guildwars.com/wiki/Shock_Phantom" };
    public static readonly Npc SkeletonIllusionist = new() { Ids = new int[] { 7036 }, Name = "Skeleton Illusionist", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Illusionist" };
    public static readonly Npc SkeletonWizard = new() { Ids = new int[] { 7037 }, Name = "Skeleton Wizard", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Wizard" };
    public static readonly Npc SkeletalHound = new() { Ids = new int[] { 7038 }, Name = "Skeletal Hound", WikiUrl = "https://wiki.guildwars.com/wiki/Skeletal_Hound" };
    public static readonly Npc SkeletonPriest = new() { Ids = new int[] { 7040 }, Name = "Skeleton Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Priest" };
    public static readonly Npc SkeletonArcher = new() { Ids = new int[] { 7041 }, Name = "Skeleton Archer", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Archer" };
    public static readonly Npc DecayedDragon = new() { Ids = new int[] { 7042 }, Name = "Decayed Dragon", WikiUrl = "https://wiki.guildwars.com/wiki/Decayed_Dragon" };
    public static readonly Npc ZombieBrute = new() { Ids = new int[] { 7043 }, Name = "Zombie Brute", WikiUrl = "https://wiki.guildwars.com/wiki/Zombie_Brute" };
    public static readonly Npc ZombieNecromancer = new() { Ids = new int[] { 7044 }, Name = "Zombie Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/Zombie_Necromancer" };
    public static readonly Npc ChainedCleric = new() { Ids = new int[] { 7046 }, Name = "Chained Cleric", WikiUrl = "https://wiki.guildwars.com/wiki/Chained_Cleric" };
    public static readonly Npc WintersdayMoa = new() { Ids = new int[] { 7374 }, Name = "Wintersday Moa", WikiUrl = "https://wiki.guildwars.com/wiki/Wintersday_Moa" };
    public static readonly Npc BlessedSnowman = new() { Ids = new int[] { 7376 }, Name = "Blessed Snowman", WikiUrl = "https://wiki.guildwars.com/wiki/Blessed_Snowman" };
    public static readonly Npc CordialSnowman = new() { Ids = new int[] { 7379 }, Name = "Cordial Snowman", WikiUrl = "https://wiki.guildwars.com/wiki/Cordial_Snowman" };
    public static readonly Npc PiousSnowman = new() { Ids = new int[] { 7386 }, Name = "Pious Snowman", WikiUrl = "https://wiki.guildwars.com/wiki/Pious_Snowman" };
    public static readonly Npc AngrySnowman = new() { Ids = new int[] { 7411 }, Name = "Angry Snowman", WikiUrl = "https://wiki.guildwars.com/wiki/Angry_Snowman" };
    public static readonly Npc JackFrost = new() { Ids = new int[] { 7435 }, Name = "Jack Frost", WikiUrl = "https://wiki.guildwars.com/wiki/Jack_Frost" };
    public static readonly Npc ValgarTempestcrafter = new() { Ids = new int[] { 7604 }, Name = "Valgar Tempestcrafter", WikiUrl = "https://wiki.guildwars.com/wiki/Valgar_Tempestcrafter" };
    public static readonly Npc NicholasSandford = new() { Ids = new int[] { 7659 }, Name = "Nicholas Sandford", WikiUrl = "https://wiki.guildwars.com/wiki/Nicholas_Sandford" };
    public static readonly Npc ProfessorYakkington = new() { Ids = new int[] { 7660 }, Name = "Professor Yakkington", WikiUrl = "https://wiki.guildwars.com/wiki/Professor_Yakkington" };
    public static readonly Npc PinkDyeVendor = new() { Ids = new int[] { 7670 }, Name = "Pink Dye Vendor", WikiUrl = "https://wiki.guildwars.com/wiki/Sadie_Salvitas" };
    public static readonly Npc Zenjal = new() { Ids = new int[] { 7748 }, Name = "Zenjal", WikiUrl = "https://wiki.guildwars.com/wiki/Zenjal" };
    public static readonly Npc LieutenantLangmar = new() { Ids = new int[] { 7757 }, Name = "Lieutenant Langmar", WikiUrl = "https://wiki.guildwars.com/wiki/Lieutenant_Langmar" };
    public static readonly Npc BlazefiendGriefblade = new() { Ids = new int[] { 7795 }, Name = "Blazefiend Griefblade", WikiUrl = "https://wiki.guildwars.com/wiki/Blazefiend_Griefblade" };
    public static readonly Npc CharrStalker = new() { Ids = new int[] { 7801 }, Name = "Charr Stalker", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Stalker" };
    public static readonly Npc CharrFireCaller = new() { Ids = new int[] { 7803, 1643 }, Name = "Charr Fire Caller", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Fire_Caller" };
    public static readonly Npc ForemanTheCrier = new() { Ids = new int[] { 7974, 7974 }, Name = "Foreman The Crier", WikiUrl = "https://wiki.guildwars.com/wiki/Foreman_the_Crier" };
    public static readonly Npc Salma = new() { Ids = new int[] { 7987 }, Name = "Salma", WikiUrl = "https://wiki.guildwars.com/wiki/Salma" };
    public static readonly Npc ScoutMelthoran = new() { Ids = new int[] { 8054 }, Name = "Scout Melthoran", WikiUrl = "https://wiki.guildwars.com/wiki/Scout_Melthoran" };
    public static readonly Npc ShiningBladeRecruit = new() { Ids = new int[] { 8058, 8059 }, Name = "Shining Blade Recruit", WikiUrl = "https://wiki.guildwars.com/wiki/Shining_Blade_Recruit" };
    public static readonly Npc CharmingPeacekeeper = new() { Ids = new int[] { 8103, 8105 }, Name = "Charming Peacekeeper", WikiUrl = "https://wiki.guildwars.com/wiki/Charming_Peacekeeper" };
    public static readonly Npc PeacekeeperFirebrand = new() { Ids = new int[] { 8110, 8111, 8113 }, Name = "Peacekeeper Firebrand", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Firebrand" };
    public static readonly Npc DivinePeacekeeper = new() { Ids = new int[] { 8117, 8115 }, Name = "Divine Peacekeeper", WikiUrl = "https://wiki.guildwars.com/wiki/Divine_Peacekeeper" };
    public static readonly Npc PeacekeeperGoon = new() { Ids = new int[] { 8135, 8133 }, Name = "Peacekeeper Goon", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Goon" };
    public static readonly Npc PeacekeeperMarksman = new() { Ids = new int[] { 8137, 8138 }, Name = "Peacekeeper Marksman", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Marksman" };
    public static readonly Npc PeacekeeperClairvoyant = new() { Ids = new int[] { 8151, 8154, 8152 }, Name = "Peacekeeper Clairvoyant", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Clairvoyant" };
    public static readonly Npc PeacekeeperMentor = new() { Ids = new int[] { 8155, 8156 }, Name = "Peacekeeper Mentor", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Mentor" };
    public static readonly Npc InsatiableVakar = new() { Ids = new int[] { 8172 }, Name = "Insatiable Vakar", WikiUrl = "https://wiki.guildwars.com/wiki/Insatiable_Vakar" };
    public static readonly Npc WhiteMantleNecromancer = new() { Ids = new int[] { 8249 }, Name = "White Mantle Necromancer", WikiUrl = "https://wiki.guildwars.com/wiki/White_Mantle_Ritualist" };
    public static readonly Npc MinistryOfPurity = new() { Ids = new int[] { 8582 }, Name = "Ministry Of Purity", WikiUrl = "https://wiki.guildwars.com/wiki/Ministry_of_Purity" };
    public static readonly Npc Julyia = new() { Ids = new int[] { 41 }, Name = "Julyia", WikiUrl = "https://wiki.guildwars.com/wiki/Julyia" };
    public static readonly Npc Narcissia = new() { Ids = new int[] { 49 }, Name = "Narcissia", WikiUrl = "https://wiki.guildwars.com/wiki/Narcissia" };
    public static readonly Npc ZenSiert = new() { Ids = new int[] { 50 }, Name = "Zen Siert", WikiUrl = "https://wiki.guildwars.com/wiki/Zen_Siert" };
    public static readonly Npc VincentEvan = new() { Ids = new int[] { 44 }, Name = "Vincent Evan", WikiUrl = "https://wiki.guildwars.com/wiki/Vincent_Evan" };
    public static readonly Npc CassieSanti = new() { Ids = new int[] { 39 }, Name = "Cassie Santi", WikiUrl = "https://wiki.guildwars.com/wiki/Cassie_Santi" };
    public static readonly Npc DirkShadowrise = new() { Ids = new int[] { 43 }, Name = "Dirk Shadowrise", WikiUrl = "https://wiki.guildwars.com/wiki/Dirk_Shadowrise" };
    public static readonly Npc LuzyFiera = new() { Ids = new int[] { 45 }, Name = "Luzy Fiera", WikiUrl = "https://wiki.guildwars.com/wiki/Luzy_Fiera" };
    public static readonly Npc RuneTrader = new() { Ids = new int[] { 190 }, Name = "Rune Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Rune_Trader" };
    public static readonly Npc CraftingMaterialTrader = new() { Ids = new int[] { 191 }, Name = "Crafting Material Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Crafting_Material_Trader" };
    public static readonly Npc RareMaterialTrader = new() { Ids = new int[] { 192 }, Name = "Rare Material Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Rare_Material_Trader" };
    public static readonly Npc DyeTrader = new() { Ids = new int[] { 193 }, Name = "Dye Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Dye_Trader" };
    public static readonly Npc ScrollTrader = new() { Ids = new int[] { 194 }, Name = "Scroll Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Scroll_Trader" };
    public static readonly Npc Pudash = new() { Ids = new int[] { 31 }, Name = "Pudash", WikiUrl = "https://wiki.guildwars.com/wiki/Pudash" };
    public static readonly Npc Blenkeh = new() { Ids = new int[] { 53 }, Name = "Blenkeh", WikiUrl = "https://wiki.guildwars.com/wiki/Blenkeh" };
    public static readonly Npc MotokoKai = new() { Ids = new int[] { 46 }, Name = "Motoko Kai", WikiUrl = "https://wiki.guildwars.com/wiki/Motoko_Kai" };
    public static readonly Npc ErrolHyl = new() { Ids = new int[] { 34 }, Name = "Errol Hyl", WikiUrl = "https://wiki.guildwars.com/wiki/Errol_Hyl" };
    public static readonly Npc Merchant = new() { Ids = new int[] { 196 }, Name = "Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Merchant" };
    public static readonly Npc Weaponsmith = new() { Ids = new int[] { 197 }, Name = "Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Weaponsmith" };
    public static readonly Npc SkillTrainer = new() { Ids = new int[] { 195 }, Name = "Skill Trainer", WikiUrl = "https://wiki.guildwars.com/wiki/Skill_Trainer" };
    public static readonly Npc Dahlia = new() { Ids = new int[] { 32 }, Name = "Dahlia", WikiUrl = "https://wiki.guildwars.com/wiki/Dahlia" };
    public static readonly Npc RedemptorFrohs = new() { Ids = new int[] { 40 }, Name = "Redemptor Frohs", WikiUrl = "https://wiki.guildwars.com/wiki/Redemptor_Frohs" };
    public static readonly Npc AuroraAllesandra = new() { Ids = new int[] { 54 }, Name = "Aurora Allesandra", WikiUrl = "https://wiki.guildwars.com/wiki/Aurora_Allesandra" };
    public static readonly Npc Hinata = new() { Ids = new int[] { 47 }, Name = "Hinata", WikiUrl = "https://wiki.guildwars.com/wiki/Hinata" };
    public static readonly Npc LuluXan = new() { Ids = new int[] { 36 }, Name = "Lulu Xan", WikiUrl = "https://wiki.guildwars.com/wiki/Lulu_Xan" };
    public static readonly Npc Bellicus = new() { Ids = new int[] { 42 }, Name = "Bellicus", WikiUrl = "https://wiki.guildwars.com/wiki/Bellicus" };
    public static readonly Npc FestivalHatKeeper = new() { Ids = new int[] { 198 }, Name = "Festival Hat Keeper", WikiUrl = "https://wiki.guildwars.com/wiki/Festival_Hat_Keeper" };
    public static readonly Npc GuildEmblemer = new() { Ids = new int[] { 199 }, Name = "Guild Emblemer", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Emblemer" };
    public static readonly Npc Tannaros = new() { Ids = new int[] { 38 }, Name = "Tannaros", WikiUrl = "https://wiki.guildwars.com/wiki/Tannaros" };
    public static readonly Npc Disenmaedel = new() { Ids = new int[] { 33 }, Name = "Disenmaedel", WikiUrl = "https://wiki.guildwars.com/wiki/Disenmaedel" };
    public static readonly Npc KahXan = new() { Ids = new int[] { 48 }, Name = "Kah Xan", WikiUrl = "https://wiki.guildwars.com/wiki/Kah_Xan" };
    public static readonly Npc Lonai = new() { Ids = new int[] { 4821 }, Name = "Lonai", WikiUrl = "https://wiki.guildwars.com/wiki/Lonai" };
    public static readonly Npc Koss = new() { Ids = new int[] { 4475 }, Name = "Koss", WikiUrl = "https://wiki.guildwars.com/wiki/Koss" };
    public static readonly Npc Dunkoro = new() { Ids = new int[] { 4483 }, Name = "Dunkoro", WikiUrl = "https://wiki.guildwars.com/wiki/Dunkoro" };
    public static readonly Npc Smuggler = new() { Ids = new int[] { 5075 }, Name = "Smuggler", WikiUrl = "https://wiki.guildwars.com/wiki/Smuggler" };
    public static readonly Npc Dalzid = new() { Ids = new int[] { 4742 }, Name = "Dalzid", WikiUrl = "https://wiki.guildwars.com/wiki/Dalzid" };
    public static readonly Npc Burreh = new() { Ids = new int[] { 5386 }, Name = "Burreh", WikiUrl = "https://wiki.guildwars.com/wiki/Burreh" };
    public static readonly Npc Benera = new() { Ids = new int[] { 5393 }, Name = "Benera", WikiUrl = "https://wiki.guildwars.com/wiki/Benera" };
    public static readonly Npc Megundeh = new() { Ids = new int[] { 5399 }, Name = "Megundeh", WikiUrl = "https://wiki.guildwars.com/wiki/Megundeh" };
    public static readonly Npc Shausha = new() { Ids = new int[] { 4740 }, Name = "Shausha", WikiUrl = "https://wiki.guildwars.com/wiki/Shausha" };
    public static readonly Npc Ahamid = new() { Ids = new int[] { 4741 }, Name = "Ahamid", WikiUrl = "https://wiki.guildwars.com/wiki/Ahamid" };
    public static readonly Npc Stasheh = new() { Ids = new int[] { 5398 }, Name = "Stasheh", WikiUrl = "https://wiki.guildwars.com/wiki/Stasheh" };
    public static readonly Npc Marlani = new() { Ids = new int[] { 4743 }, Name = "Marlani", WikiUrl = "https://wiki.guildwars.com/wiki/Marlani" };
    public static readonly Npc Sinbi = new() { Ids = new int[] { 5382 }, Name = "Sinbi", WikiUrl = "https://wiki.guildwars.com/wiki/Sinbi" };
    public static readonly Npc Kerendu = new() { Ids = new int[] { 5401 }, Name = "Kerendu", WikiUrl = "https://wiki.guildwars.com/wiki/Kerendu" };
    public static readonly Npc Nerashi = new() { Ids = new int[] { 4814 }, Name = "Nerashi", WikiUrl = "https://wiki.guildwars.com/wiki/Nerashi" };
    public static readonly Npc VeldtBeetleLance = new() { Ids = new int[] { 4926 }, Name = "Veldt Beetle Lance", WikiUrl = "https://wiki.guildwars.com/wiki/Veldt_Beetle_Lance" };
    public static readonly Npc VeldtNephila = new() { Ids = new int[] { 4902 }, Name = "Veldt Nephila", WikiUrl = "https://wiki.guildwars.com/wiki/Veldt_Nephila" };
    public static readonly Npc VeldtBeetleQueen = new() { Ids = new int[] { 4923 }, Name = "Veldt Beetle Queen", WikiUrl = "https://wiki.guildwars.com/wiki/Veldt_Beetle_Queen" };
    public static readonly Npc BladedVeldtTermite = new() { Ids = new int[] { 4924 }, Name = "Bladed Veldt Termite", WikiUrl = "https://wiki.guildwars.com/wiki/Bladed_Veldt_Termite" };
    public static readonly Npc RampagingNtouka = new() { Ids = new int[] { 4915 }, Name = "Rampaging Ntouka", WikiUrl = "https://wiki.guildwars.com/wiki/Rampaging_Ntouka" };
    public static readonly Npc CrestedNtoukaBird = new() { Ids = new int[] { 4913 }, Name = "Crested Ntouka Bird", WikiUrl = "https://wiki.guildwars.com/wiki/Crested_Ntouka_Bird" };
    public static readonly Npc KournanEliteZealot = new() { Ids = new int[] { 5269 }, Name = "Kournan Elite Zealot", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Elite_Zealot" };
    public static readonly Npc KournanEliteSpear = new() { Ids = new int[] { 5270 }, Name = "Kournan Elite Spear", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Elite_Spear" };
    public static readonly Npc KournanEliteGuard = new() { Ids = new int[] { 5268 }, Name = "Kournan Elite Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Elite_Guard" };
    public static readonly Npc KournanEliteScribe = new() { Ids = new int[] { 5267 }, Name = "Kournan Elite Scribe", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Elite_Scribe" };
    public static readonly Npc SpiritofShelter = new() { Ids = new int[] { 4223 }, Name = "Spirit of Shelter", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Shelter" };
    public static readonly Npc AdmiralKantoh = new() { Ids = new int[] { 5226 }, Name = "Admiral Kantoh", WikiUrl = "https://wiki.guildwars.com/wiki/Admiral_Kantoh" };
    public static readonly Npc MirzaVeldrunner = new() { Ids = new int[] { 4950 }, Name = "Mirza Veldrunner", WikiUrl = "https://wiki.guildwars.com/wiki/Mirza_Veldrunner" };
    public static readonly Npc CorsairTorturer = new() { Ids = new int[] { 5045 }, Name = "Corsair Torturer", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Torturer" };
    public static readonly Npc CorsairLieutenant = new() { Ids = new int[] { 5049 }, Name = "Corsair Lieutenant", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Lieutenant" };
    public static readonly Npc CorsairWindMaster = new() { Ids = new int[] { 5046 }, Name = "Corsair Wind Master", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Wind_Master" };
    public static readonly Npc SpiritOfVampirism = new() { Ids = new int[] { 5723 }, Name = "Spirit of Vampirism", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Vampirism" };
    public static readonly Npc SpiritOfSuffering = new() { Ids = new int[] { 4231 }, Name = "Spirit of Suffering", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Suffering" };
    public static readonly Npc SpiritOfHate = new() { Ids = new int[] { 4230 }, Name = "Spirit of Hate", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Hate" };
    public static readonly Npc SpiritOfAnger = new() { Ids = new int[] { 4229 }, Name = "Spirit of Anger", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Anger" };
    public static readonly Npc TuskedHunter = new() { Ids = new int[] { 4917 }, Name = "Tusked Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Tusked_Hunter" };
    public static readonly Npc TuskedHowler = new() { Ids = new int[] { 4916 }, Name = "Tusked Howler", WikiUrl = "https://wiki.guildwars.com/wiki/Tusked_Howler" };
    public static readonly Npc KournanWeaponsmith = new() { Ids = new int[] { 5391 }, Name = "Kournan Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kournans" };
    public static readonly Npc VeldrunnerCentaur = new() { Ids = new int[] { 4949, 4951, 4948 }, Name = "Veldrunner Centaur", WikiUrl = "https://wiki.guildwars.com/wiki/Veldrunner_Centaur" };
    public static readonly Npc KournanTaskmaster = new() { Ids = new int[] { 5276 }, Name = "Kournan Taskmaster", WikiUrl = "https://wiki.guildwars.com/wiki/Kournan_Taskmaster" };
    public static readonly Npc TaskmasterSadiBelai = new() { Ids = new int[] { 5243 }, Name = "Taskmaster Sadi-Belai", WikiUrl = "https://wiki.guildwars.com/wiki/Taskmaster_Sadi-Belai" };
    public static readonly Npc TaskmasterVanahk = new() { Ids = new int[] { 5242 }, Name = "Taskmaster Vanahk", WikiUrl = "https://wiki.guildwars.com/wiki/Taskmaster_Vanahk" };
    public static readonly Npc OverseerHaubeh = new() { Ids = new int[] { 5246 }, Name = "Overseer Haubeh", WikiUrl = "https://wiki.guildwars.com/wiki/Overseer_Haubeh" };
    public static readonly Npc OverseerBoktek = new() { Ids = new int[] { 5245 }, Name = "Overseer Boktek", WikiUrl = "https://wiki.guildwars.com/wiki/Overseer_Boktek" };
    public static readonly Npc TaskmasterSuli = new() { Ids = new int[] { 5244 }, Name = "Taskmaster Suli", WikiUrl = "https://wiki.guildwars.com/wiki/Taskmaster_Suli" };
    public static readonly Npc KehmaktheTranquil = new() { Ids = new int[] { 4898 }, Name = "Kehmak the Tranquil", WikiUrl = "https://wiki.guildwars.com/wiki/Kehmak_the_Tranquil" };
    public static readonly Npc GeneralBayel = new() { Ids = new int[] { 5406 }, Name = "General Bayel", WikiUrl = "https://wiki.guildwars.com/wiki/General_Bayel" };
    public static readonly Npc FocusofHanaku = new() { Ids = new int[] { 3978 }, Name = "Focus of Hanaku", WikiUrl = "https://wiki.guildwars.com/wiki/Focus_of_Hanaku" };
    public static readonly Npc SpiritofDisenchantment = new() { Ids = new int[] { 4225 }, Name = "Spirit of Disenchantment", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Disenchantment" };
    public static readonly Npc VampiricHorror = new() { Ids = new int[] { 4210 }, Name = "Vampiric Horror", WikiUrl = "https://wiki.guildwars.com/wiki/Vampiric_Horror" };
    public static readonly Npc DragonMoss = new() { Ids = new int[] { 3722 }, Name = "Dragon Moss", WikiUrl = "https://wiki.guildwars.com/wiki/Dragon_Moss" };
    public static readonly Npc SpiritofDissonance = new() { Ids = new int[] { 4221 }, Name = "Spirit of Dissonance", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Dissonance" };
    public static readonly Npc SkreeGriffin = new() { Ids = new int[] { 4677 }, Name = "Skree Griffin", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Griffin" };
    public static readonly Npc SkreeTracker = new() { Ids = new int[] { 4679 }, Name = "Skree Tracker", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Tracker" };
    public static readonly Npc SkreeSinger = new() { Ids = new int[] { 4680 }, Name = "Skree Singer", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Singer" };
    public static readonly Npc Lioness = new() { Ids = new int[] { 4243 }, Name = "Lioness", WikiUrl = "https://wiki.guildwars.com/wiki/Lioness" };
    public static readonly Npc Kehanni = new() { Ids = new int[] { 5689 }, Name = "Kehanni", WikiUrl = "https://wiki.guildwars.com/wiki/Kehanni" };
    public static readonly Npc ScytheclawBehemoth = new() { Ids = new int[] { 4669 }, Name = "Scytheclaw Behemoth", WikiUrl = "https://wiki.guildwars.com/wiki/Scytheclaw_Behemoth" };
    public static readonly Npc BehemothGravebane = new() { Ids = new int[] { 4667 }, Name = "Behemoth Gravebane", WikiUrl = "https://wiki.guildwars.com/wiki/Behemoth_Gravebane" };
    public static readonly Npc RockBeetle = new() { Ids = new int[] { 4687 }, Name = "Rock Beetle", WikiUrl = "https://wiki.guildwars.com/wiki/Rock_Beetle" };
    public static readonly Npc RainBeetle = new() { Ids = new int[] { 4685 }, Name = "Rain Beetle", WikiUrl = "https://wiki.guildwars.com/wiki/Rain_Beetle" };
    public static readonly Npc MargoniteSorcerer = new() { Ids = new int[] { 5535 }, Name = "Margonite Sorcerer", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Sorcerer" };
    public static readonly Npc MargoniteSeer = new() { Ids = new int[] { 5533 }, Name = "Margonite Seer", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Seer" };
    public static readonly Npc HajokEarthguardian = new() { Ids = new int[] { 4646 }, Name = "Hajok Earthguardian", WikiUrl = "https://wiki.guildwars.com/wiki/Hajok_Earthguardian" };
    public static readonly Npc MargoniteCleric = new() { Ids = new int[] { 5536 }, Name = "Margonite Cleric", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Cleric" };
    public static readonly Npc TaintheCorrupter = new() { Ids = new int[] { 5516 }, Name = "Tain the Corrupter", WikiUrl = "https://wiki.guildwars.com/wiki/Tain_the_Corrupter" };
    public static readonly Npc SkreeRaider = new() { Ids = new int[] { 4678 }, Name = "Skree Raider", WikiUrl = "https://wiki.guildwars.com/wiki/Skree_Raider" };
    public static readonly Npc MakdehtheAggravating = new() { Ids = new int[] { 4638 }, Name = "Makdeh the Aggravating", WikiUrl = "https://wiki.guildwars.com/wiki/Makdeh_the_Aggravating" };
    public static readonly Npc MargoniteWarlock = new() { Ids = new int[] { 5534 }, Name = "Margonite Warlock", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Warlock" };
    public static readonly Npc MargoniteExecutioner = new() { Ids = new int[] { 5537 }, Name = "Margonite Executioner", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Executioner" };
    public static readonly Npc MargoniteAscendant = new() { Ids = new int[] { 5540 }, Name = "Margonite Ascendant", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Ascendant" };
    public static readonly Npc LushivahrtheInvoker = new() { Ids = new int[] { 5517 }, Name = "Lushivahr the Invoker", WikiUrl = "https://wiki.guildwars.com/wiki/Lushivahr_the_Invoker" };
    public static readonly Npc MargoniteReaper = new() { Ids = new int[] { 5539 }, Name = "Margonite Reaper", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Reaper" };
    public static readonly Npc CorporalSuli = new() { Ids = new int[] { 5224 }, Name = "Corporal Suli", WikiUrl = "https://wiki.guildwars.com/wiki/Corporal_Suli" };
    public static readonly Npc LieutenantVanahk = new() { Ids = new int[] { 5223 }, Name = "Lieutenant Vanahk", WikiUrl = "https://wiki.guildwars.com/wiki/Lieutenant_Vanahk" };
    public static readonly Npc Lion = new() { Ids = new int[] { 4244 }, Name = "Lion", WikiUrl = "https://wiki.guildwars.com/wiki/Lion" };
    public static readonly Npc SpiritofFavorableWinds = new() { Ids = new int[] { 2883 }, Name = "Spirit of Favorable Winds", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Favorable_Winds" };
    public static readonly Npc MirageIboga = new() { Ids = new int[] { 4690 }, Name = "Mirage Iboga", WikiUrl = "https://wiki.guildwars.com/wiki/Mirage_Iboga" };
    public static readonly Npc StormJacaranda = new() { Ids = new int[] { 4691 }, Name = "Storm Jacaranda", WikiUrl = "https://wiki.guildwars.com/wiki/Storm_Jacaranda" };
    public static readonly Npc EnchantedBrambles = new() { Ids = new int[] { 4692 }, Name = "Enchanted Brambles", WikiUrl = "https://wiki.guildwars.com/wiki/Enchanted_Brambles" };
    public static readonly Npc WhistlingThornbrush = new() { Ids = new int[] { 4693 }, Name = "Whistling Thornbrush", WikiUrl = "https://wiki.guildwars.com/wiki/Whistling_Thornbrush" };
    public static readonly Npc MargoniteBowmaster = new() { Ids = new int[] { 5538 }, Name = "Margonite Bowmaster", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Bowmaster" };
    public static readonly Npc VabbianDyeTrader = new() { Ids = new int[] { 5674 }, Name = "Vabbian Dye Trader", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Vabbians" };
    public static readonly Npc VabbianWeaponsmith = new() { Ids = new int[] { 5671, 5672 }, Name = "Vabbian Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Vabbians" };
    public static readonly Npc ChumabthePrideful = new() { Ids = new int[] { 4658 }, Name = "Chumab the Prideful", WikiUrl = "https://wiki.guildwars.com/wiki/Chumab_the_Prideful" };
    public static readonly Npc YameshMindclouder = new() { Ids = new int[] { 4653 }, Name = "Yamesh Mindclouder", WikiUrl = "https://wiki.guildwars.com/wiki/Yamesh_Mindclouder" };
    public static readonly Npc JahaiRat = new() { Ids = new int[] { 4245 }, Name = "Jahai Rat", WikiUrl = "https://wiki.guildwars.com/wiki/Jahai_Rat" };
    public static readonly Npc BoltenLargebelly = new() { Ids = new int[] { 4656 }, Name = "Bolten Largebelly", WikiUrl = "https://wiki.guildwars.com/wiki/Bolten_Largebelly" };
    public static readonly Npc VabbianPriest = new() { Ids = new int[] { 5664, 5702 }, Name = "Vabbian Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Vabbian_Priest" };
    public static readonly Npc GeneralMorgahn = new() { Ids = new int[] { 4446 }, Name = "General Morgahn", WikiUrl = "https://wiki.guildwars.com/wiki/General_Morgahn" };
    public static readonly Npc VabbianScholar = new() { Ids = new int[] { 5699, 5679, 5678, 5682 }, Name = "Vabbian Scholar", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Vabbians" };
    public static readonly Npc TheGreatZehtuka = new() { Ids = new int[] { 5697 }, Name = "The Great Zehtuka", WikiUrl = "https://wiki.guildwars.com/wiki/The_Great_Zehtuka" };
    public static readonly Npc VabbiGuardCaptain = new() { Ids = new int[] { 5640 }, Name = "Vabbi Guard Captain", WikiUrl = "https://wiki.guildwars.com/wiki/Vabbi_Guard_Captain" };
    public static readonly Npc PrinceAhmturtheMighty = new() { Ids = new int[] { 5692 }, Name = "Prince Ahmtur the Mighty", WikiUrl = "https://wiki.guildwars.com/wiki/Prince_Ahmtur_the_Mighty" };
    public static readonly Npc LieutenantMurunda = new() { Ids = new int[] { 5641 }, Name = "Lieutenant Murunda", WikiUrl = "https://wiki.guildwars.com/wiki/Lieutenant_Murunda" };
    public static readonly Npc PrinceBokkatheMagnificent = new() { Ids = new int[] { 5691 }, Name = "Prince Bokka the Magnificent", WikiUrl = "https://wiki.guildwars.com/wiki/Prince_Bokka_the_Magnificent" };
    public static readonly Npc Goren = new() { Ids = new int[] { 4434 }, Name = "Goren", WikiUrl = "https://wiki.guildwars.com/wiki/Goren" };
    public static readonly Npc PrinceMehtutheWise = new() { Ids = new int[] { 5693 }, Name = "Prince Mehtu the Wise", WikiUrl = "https://wiki.guildwars.com/wiki/Prince_Mehtu_the_Wise" };
    public static readonly Npc VabbianBlacksmith = new() { Ids = new int[] { 5667 }, Name = "Vabbian Blacksmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Vabbians" };
    public static readonly Npc YammironEtherLord = new () { Ids = new int[] { 4636 }, Name = "Yammiron, Ether Lord", WikiUrl = "https://wiki.guildwars.com/wiki/Yammiron,_Ether_Lord" };
    public static readonly Npc RoaringEther = new() { Ids = new int[] { 4675, 4676 }, Name = "Roaring Ether", WikiUrl = "https://wiki.guildwars.com/wiki/Roaring_Ether" };
    public static readonly Npc SapphireDjinn = new() { Ids = new int[] { 4673, 4312 }, Name = "Sapphire Djinn", WikiUrl = "https://wiki.guildwars.com/wiki/Sapphire_Djinn" };
    public static readonly Npc RubyDjinn = new() { Ids = new int[] { 4670, 4311 }, Name = "Ruby Djinn", WikiUrl = "https://wiki.guildwars.com/wiki/Ruby_Djinn" };
    public static readonly Npc CobaltMokele = new() { Ids = new int[] { 4664 }, Name = "Cobalt Mokele", WikiUrl = "https://wiki.guildwars.com/wiki/Cobalt_Mokele" };
    public static readonly Npc JisholDarksong = new() { Ids = new int[] { 4626 }, Name = "Jishol Darksong", WikiUrl = "https://wiki.guildwars.com/wiki/Jishol_Darksong" };
    public static readonly Npc CobaltShrieker = new() { Ids = new int[] { 4665 }, Name = "Cobalt Shrieker", WikiUrl = "https://wiki.guildwars.com/wiki/Cobalt_Shrieker" };
    public static readonly Npc Norgu = new() { Ids = new int[] { 4429 }, Name = "Norgu", WikiUrl = "https://wiki.guildwars.com/wiki/Norgu" };
    public static readonly Npc StoneSummitDark = new() { Ids = new int[] { 5712 }, Name = "Stone Summit Dark", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Dwarves#Stone_Summit" };
    public static readonly Npc MargoniteParagonBoss = new() { Ids = new int[] { 5475 }, Name = "Margonite Paragon Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Category:Margonite_bosses" };
    public static readonly Npc LyssanPriest = new() { Ids = new int[] { 5709 }, Name = "Lyssan Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Lyssan_Priest" };
    public static readonly Npc DiscipleOfSecrets = new() { Ids = new int[] { 5694 }, Name = "Disciple of Secrets", WikiUrl = "https://wiki.guildwars.com/wiki/Disciple_of_Secrets" };
    public static readonly Npc Varesh = new() { Ids = new int[] { 5294, 5290 }, Name = "Varesh", WikiUrl = "https://wiki.guildwars.com/wiki/Varesh" };
    public static readonly Npc MargoniteMonkBoss = new() { Ids = new int[] { 5473 }, Name = "Margonite Monk Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Category:Margonite_bosses" };
    public static readonly Npc GeneralDoriah = new() { Ids = new int[] { 5474 }, Name = "General Doriah", WikiUrl = "https://wiki.guildwars.com/wiki/General_Doriah" };
    public static readonly Npc GeneralTirraj = new() { Ids = new int[] { 5472 }, Name = "General Tirraj", WikiUrl = "https://wiki.guildwars.com/wiki/General_Tirraj" };
    public static readonly Npc JarimiyaTheUnmerciful = new() { Ids = new int[] { 4657 }, Name = "Jarimiya the Unmerciful", WikiUrl = "https://wiki.guildwars.com/wiki/Jarimiya_the_Unmerciful" };
    public static readonly Npc RiktundTheVicious = new() { Ids = new int[] { 4624 }, Name = "Riktund the Vicious", WikiUrl = "https://wiki.guildwars.com/wiki/Riktund_the_Vicious" };
    public static readonly Npc SetikorFireflower = new() { Ids = new int[] { 4651 }, Name = "Setikor Fireflower", WikiUrl = "https://wiki.guildwars.com/wiki/Setikor_Fireflower" };
    public static readonly Npc MessengerOfLyssa = new() { Ids = new int[] { 5708 }, Name = "Messenger of Lyssa", WikiUrl = "https://wiki.guildwars.com/wiki/Messenger_of_Lyssa" };
    public static readonly Npc VabbianGuardCaptain = new() { Ids = new int[] { 5635 }, Name = "Vabbian Guard Captain", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Vabbians" };
    public static readonly Npc ElderJonah = new() { Ids = new int[] { 5286 }, Name = "Elder Jonah", WikiUrl = "https://wiki.guildwars.com/wiki/Elder_Jonah" };
    public static readonly Npc Lormeh = new() { Ids = new int[] { 5387 }, Name = "Lormeh", WikiUrl = "https://wiki.guildwars.com/wiki/Lormeh" };
    public static readonly Npc MadnessTitan = new() { Ids = new int[] { 4970 }, Name = "Madness Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Madness_Titan" };
    public static readonly Npc ShadowRanger = new() { Ids = new int[] { 4966, 2808 }, Name = "Shadow Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Ranger" };
    public static readonly Npc ShadowMonk = new() { Ids = new int[] { 4964, 2806 }, Name = "Shadow Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Monk" };
    public static readonly Npc ShadowMesmer = new() { Ids = new int[] { 4962, 2804 }, Name = "Shadow Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Mesmer" };
    public static readonly Npc GravenMonolith = new() { Ids = new int[] { 4316, 4315, 4317 }, Name = "Graven Monolith", WikiUrl = "https://wiki.guildwars.com/wiki/Graven_Monolith" };
    public static readonly Npc Harbinger = new() { Ids = new int[] { 5404 }, Name = "Harbinger", WikiUrl = "https://wiki.guildwars.com/wiki/Harbinger" };
    public static readonly Npc SpiritOfSeborhin = new() { Ids = new int[] { 5584 }, Name = "Spirit of Seborhin", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Seborhin" };
    public static readonly Npc HorticulturistHinon = new() { Ids = new int[] { 5710 }, Name = "Horticulturist Hinon", WikiUrl = "https://wiki.guildwars.com/wiki/Horticulturist_Hinon" };
    public static readonly Npc IstaniPeasant = new() { Ids = new int[] { 4851, 4850, 4852 }, Name = "Istani Peasant", WikiUrl = "https://wiki.guildwars.com/wiki/Istani_Peasant" };
    public static readonly Npc PriestZeinZuu = new() { Ids = new int[] { 5467 }, Name = "Priest Zein Zuu", WikiUrl = "https://wiki.guildwars.com/wiki/Priest_Zein_Zuu" };
    public static readonly Npc ScribeWensal = new() { Ids = new int[] { 5466 }, Name = "Scribe Wensal", WikiUrl = "https://wiki.guildwars.com/wiki/Scribe_Wensal" };
    public static readonly Npc CommanderChutal = new() { Ids = new int[] { 5471 }, Name = "Commander Chutal", WikiUrl = "https://wiki.guildwars.com/wiki/Commander_Chutal" };
    public static readonly Npc ZealotSheoli = new() { Ids = new int[] { 5470 }, Name = "Zealot Sheoli", WikiUrl = "https://wiki.guildwars.com/wiki/Zealot_Sheoli" };
    public static readonly Npc NtoukaBird = new() { Ids = new int[] { 4914 }, Name = "Ntouka Bird", WikiUrl = "https://wiki.guildwars.com/wiki/Ntouka_Bird" };
    public static readonly Npc TormentedLand = new() { Ids = new int[] { 4943 }, Name = "Tormented Land", WikiUrl = "https://wiki.guildwars.com/wiki/Tormented_Land" };
    public static readonly Npc SergeantBehnwa = new() { Ids = new int[] { 5235 }, Name = "Sergeant Behnwa", WikiUrl = "https://wiki.guildwars.com/wiki/Sergeant_Behnwa" };
    public static readonly Npc ElderHyena = new() { Ids = new int[] { 4258 }, Name = "Elder Hyena", WikiUrl = "https://wiki.guildwars.com/wiki/Elder_Hyena" };
    public static readonly Npc KorrLivingFlame = new () { Ids = new int[] { 4877 }, Name = "Korr Living Flame", WikiUrl = "https://wiki.guildwars.com/wiki/Korr,_Living_Flame" };
    public static readonly Npc ImmolatedDjinn = new() { Ids = new int[] { 4906 }, Name = "Immolated Djinn", WikiUrl = "https://wiki.guildwars.com/wiki/Immolated_Djinn" };
    public static readonly Npc AscensionPilgrim = new() { Ids = new int[] { 5007 }, Name = "Ascension Pilgrim", WikiUrl = "https://wiki.guildwars.com/wiki/Ascension_Pilgrim" };
    public static readonly Npc DynasticSpirit = new() { Ids = new int[] { 5006, 5611, 5005, 5613 }, Name = "Dynastic Spirit", WikiUrl = "https://wiki.guildwars.com/wiki/Dynastic_Spirit" };
    public static readonly Npc DiamondDjinn = new() { Ids = new int[] { 4671 }, Name = "Diamond Djinn", WikiUrl = "https://wiki.guildwars.com/wiki/Diamond_Djinn" };
    public static readonly Npc VahlenTheSilent = new() { Ids = new int[] { 5566 }, Name = "Vahlen the Silent", WikiUrl = "https://wiki.guildwars.com/wiki/Vahlen_the_Silent" };
    public static readonly Npc AwakenedAcolyte = new() { Ids = new int[] { 5577 }, Name = "Awakened Acolyte", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Acolyte" };
    public static readonly Npc AwakenedDefiler = new() { Ids = new int[] { 5575 }, Name = "Awakened Defiler", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Defiler" };
    public static readonly Npc AwakenedDuneCarver = new() { Ids = new int[] { 5582 }, Name = "Awakened Dune Carver", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Dune_Carver" };
    public static readonly Npc AwakenedThoughtLeech = new() { Ids = new int[] { 5574 }, Name = "Awakened Thought Leech", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Thought_Leech" };
    public static readonly Npc CarvenEffigy = new() { Ids = new int[] { 5576, 5587, 5623 }, Name = "Carven Effigy", WikiUrl = "https://wiki.guildwars.com/wiki/Carven_Effigy" };
    public static readonly Npc AwakenedGrayGiant = new() { Ids = new int[] { 5579, 5628 }, Name = "Awakened Gray Giant", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Gray_Giant" };
    public static readonly Npc SpiritOfQuicksand = new() { Ids = new int[] { 5718 }, Name = "Spirit of Quicksand", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Quicksand" };
    public static readonly Npc ShamblingMesa = new() { Ids = new int[] { 4321 }, Name = "Shambling Mesa", WikiUrl = "https://wiki.guildwars.com/wiki/Shambling_Mesa" };
    public static readonly Npc SandstormCrag = new() { Ids = new int[] { 4322 }, Name = "Sandstorm Crag", WikiUrl = "https://wiki.guildwars.com/wiki/Sandstorm_Crag" };
    public static readonly Npc ShahaitheCunning = new() { Ids = new int[] { 5090 }, Name = "Shahai the Cunning", WikiUrl = "https://wiki.guildwars.com/wiki/Shahai_the_Cunning" };
    public static readonly Npc PalawaJoko = new() { Ids = new int[] { 5607 }, Name = "Palawa Joko", WikiUrl = "https://wiki.guildwars.com/wiki/Palawa_Joko" };
    public static readonly Npc QueenAijundu = new() { Ids = new int[] { 5568 }, Name = "Queen Aijundu", WikiUrl = "https://wiki.guildwars.com/wiki/Queen_Aijundu" };
    public static readonly Npc AwakenedBlademaster = new() { Ids = new int[] { 5578 }, Name = "Awakened Blademaster", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Blademaster" };
    public static readonly Npc AwakenedCavalier = new() { Ids = new int[] { 5583 }, Name = "Awakened Cavalier", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Cavalier" };
    public static readonly Npc ChakehTheLonely = new() { Ids = new int[] { 5573 }, Name = "Chakeh the Lonely", WikiUrl = "https://wiki.guildwars.com/wiki/Chakeh_the_Lonely" };
    public static readonly Npc AvahTheCrafty = new() { Ids = new int[] { 5571 }, Name = "Avah the Crafty", WikiUrl = "https://wiki.guildwars.com/wiki/Avah_the_Crafty" };
    public static readonly Npc ChunduTheMeek = new() { Ids = new int[] { 5572 }, Name = "Chundu the Meek", WikiUrl = "https://wiki.guildwars.com/wiki/Chundu_the_Meek" };
    public static readonly Npc AmindTheBitter = new() { Ids = new int[] { 5569 }, Name = "Amind the Bitter", WikiUrl = "https://wiki.guildwars.com/wiki/Amind_the_Bitter" };
    public static readonly Npc NehmakTheUnpleasant = new() { Ids = new int[] { 5570 }, Name = "Nehmak the Unpleasant", WikiUrl = "https://wiki.guildwars.com/wiki/Nehmak_the_Unpleasant" };
    public static readonly Npc JununduYoung = new() { Ids = new int[] { 5599 }, Name = "Junundu Young", WikiUrl = "https://wiki.guildwars.com/wiki/Junundu_Young" };
    public static readonly Npc SahlahjarTheDead = new() { Ids = new int[] { 4828 }, Name = "Sahlahjar the Dead", WikiUrl = "https://wiki.guildwars.com/wiki/Sahlahjar_the_Dead" };
    public static readonly Npc MinionOfJoko = new() { Ids = new int[] { 5592 }, Name = "Minion of Joko", WikiUrl = "https://wiki.guildwars.com/wiki/Minion_of_Joko" };
    public static readonly Npc RavenousMandragor = new() { Ids = new int[] { 4305 }, Name = "Ravenous Mandragor", WikiUrl = "https://wiki.guildwars.com/wiki/Ravenous_Mandragor" };
    public static readonly Npc MandragorTerror = new() { Ids = new int[] { 4307 }, Name = "Mandragor Terror", WikiUrl = "https://wiki.guildwars.com/wiki/Mandragor_Terror" };
    public static readonly Npc MandragorSandDevil = new() { Ids = new int[] { 4306 }, Name = "Mandragor Sand Devil", WikiUrl = "https://wiki.guildwars.com/wiki/Mandragor_Sand_Devil" };
    public static readonly Npc GhostlyScout = new() { Ids = new int[] { 5547, 5548 }, Name = "Ghostly Scout", WikiUrl = "https://wiki.guildwars.com/wiki/Ghostly_Scout" };
    public static readonly Npc BladedDuneTermite = new() { Ids = new int[] { 4319 }, Name = "Bladed Dune Termite", WikiUrl = "https://wiki.guildwars.com/wiki/Bladed_Dune_Termite" };
    public static readonly Npc DuneBeetleLance = new() { Ids = new int[] { 4320 }, Name = "Dune Beetle Lance", WikiUrl = "https://wiki.guildwars.com/wiki/Dune_Beetle_Lance" };
    public static readonly Npc DuneSpider = new() { Ids = new int[] { 4303 }, Name = "Dune Spider", WikiUrl = "https://wiki.guildwars.com/wiki/Dune_Spider" };
    public static readonly Npc AwakenedHead = new() { Ids = new int[] { 5580 }, Name = "Awakened Head", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened_Head" };
    public static readonly Npc UndeadGeneral = new() { Ids = new int[] { 5606 }, Name = "Undead General", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Skeletons" };
    public static readonly Npc Chirah = new() { Ids = new int[] { 5272 }, Name = "Chirah", WikiUrl = "https://wiki.guildwars.com/wiki/Chirah" };
    public static readonly Npc AwakenedMonk = new() { Ids = new int[] { 5626 }, Name = "Awakened Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened" };
    public static readonly Npc AwakenedMesmer = new() { Ids = new int[] { 5625 }, Name = "Awakened Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened" };
    public static readonly Npc AwakenedDervish = new() { Ids = new int[] { 5630 }, Name = "Awakened Dervish", WikiUrl = "https://wiki.guildwars.com/wiki/Awakened" };
    public static readonly Npc Awata = new() { Ids = new int[] { 5624 }, Name = "Awata", WikiUrl = "https://wiki.guildwars.com/wiki/Awata" };
    public static readonly Npc Thrall = new() { Ids = new int[] { 5588, 5589, 5585, 5590 }, Name = "Thrall", WikiUrl = "https://wiki.guildwars.com/wiki/Thrall" };
    public static readonly Npc GhostlyPriest = new() { Ids = new int[] { 5615 }, Name = "Ghostly Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Ghostly_Priest" };
    public static readonly Npc PrimevalKingJahnus = new() { Ids = new int[] { 5596 }, Name = "Primeval King Jahnus", WikiUrl = "https://wiki.guildwars.com/wiki/Primeval_King_Jahnus" };
    public static readonly Npc NomadGiant = new() { Ids = new int[] { 4314 }, Name = "Nomad Giant", WikiUrl = "https://wiki.guildwars.com/wiki/Nomad_Giant" };
    public static readonly Npc KoahmTheWeary = new() { Ids = new int[] { 5559 }, Name = "Koahm the Weary", WikiUrl = "https://wiki.guildwars.com/wiki/Koahm_the_Weary" };
    public static readonly Npc SadisticGiant = new() { Ids = new int[] { 4313 }, Name = "Sadistic Giant", WikiUrl = "https://wiki.guildwars.com/wiki/Sadistic_Giant" };
    public static readonly Npc UhiwiTheSmoky = new() { Ids = new int[] { 4300 }, Name = "Uhiwi the Smoky", WikiUrl = "https://wiki.guildwars.com/wiki/Uhiwi_the_Smoky" };
    public static readonly Npc ElderSiegeWurm = new() { Ids = new int[] { 5610 }, Name = "Elder Siege Wurm", WikiUrl = "https://wiki.guildwars.com/wiki/Elder_Siege_Wurm" };
    public static readonly Npc AmireshThePious = new() { Ids = new int[] { 5563 }, Name = "Amiresh the Pious", WikiUrl = "https://wiki.guildwars.com/wiki/Amiresh_the_Pious" };
    public static readonly Npc HordeofDarkness = new() { Ids = new int[] { 5486 }, Name = "Horde of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Horde_of_Darkness" };
    public static readonly Npc DesertWurm = new() { Ids = new int[] { 4323 }, Name = "Desert Wurm", WikiUrl = "https://wiki.guildwars.com/wiki/Desert_Wurm" };
    public static readonly Npc BladeOfCorruption = new() { Ids = new int[] { 5447 }, Name = "Blade of Corruption", WikiUrl = "https://wiki.guildwars.com/wiki/Blade_of_Corruption" };
    public static readonly Npc CaptainMehhan = new() { Ids = new int[] { 5366 }, Name = "Captain Mehhan", WikiUrl = "https://wiki.guildwars.com/wiki/Captain_Mehhan" };
    public static readonly Npc AwakenedParagon = new() { Ids = new int[] { 5631 }, Name = "Awakened Paragon", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Zombies#Mummies_(Awakened)" };
    public static readonly Npc TormentedSoul = new() { Ids = new int[] { 4983, 4984, 4988, 4989 }, Name = "Tormented Soul", WikiUrl = "https://wiki.guildwars.com/wiki/Tormented_Soul" };
    public static readonly Npc SecretKeeper = new() { Ids = new int[] { 4985 }, Name = "Secret Keeper", WikiUrl = "https://wiki.guildwars.com/wiki/Secret_Keeper" };
    public static readonly Npc WordOfMadness = new() { Ids = new int[] { 5446 }, Name = "Word of Madness", WikiUrl = "https://wiki.guildwars.com/wiki/Word_of_Madness" };
    public static readonly Npc RainOfTerror = new() { Ids = new int[] { 5445 }, Name = "Rain of Terror", WikiUrl = "https://wiki.guildwars.com/wiki/Rain_of_Terror" };
    public static readonly Npc ShadowOfFear = new() { Ids = new int[] { 5444 }, Name = "Shadow of Fear", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_of_Fear" };
    public static readonly Npc ScytheOfChaos = new() { Ids = new int[] { 5449, 4959, 7316 }, Name = "Scythe of Chaos", WikiUrl = "https://wiki.guildwars.com/wiki/Scythe_of_Chaos" };
    public static readonly Npc SpearOfTorment = new() { Ids = new int[] { 5450 }, Name = "Spear of Torment", WikiUrl = "https://wiki.guildwars.com/wiki/Spear_of_Torment" };
    public static readonly Npc HeraldOfNightmares = new() { Ids = new int[] { 5443 }, Name = "Herald of Nightmares", WikiUrl = "https://wiki.guildwars.com/wiki/Herald_of_Nightmares" };
    public static readonly Npc ArmOfInsanity = new() { Ids = new int[] { 5448 }, Name = "Arm of Insanity", WikiUrl = "https://wiki.guildwars.com/wiki/Arm_of_Insanity" };
    public static readonly Npc OnslaughtOfTerror = new() { Ids = new int[] { 5430 }, Name = "Onslaught of Terror", WikiUrl = "https://wiki.guildwars.com/wiki/Onslaught_of_Terror" };
    public static readonly Npc ZombieMonk = new() { Ids = new int[] { 5003 }, Name = "Zombie Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Zombies#Zombies" };
    public static readonly Npc ChimorTheLightblooded = new() { Ids = new int[] { 5520 }, Name = "Chimor the Lightblooded", WikiUrl = "https://wiki.guildwars.com/wiki/Chimor_the_Lightblooded" };
    public static readonly Npc ScoutAhktum = new() { Ids = new int[] { 5017 }, Name = "Scout Ahktum", WikiUrl = "https://wiki.guildwars.com/wiki/Scout_Ahktum" };
    public static readonly Npc Thenemi = new() { Ids = new int[] { 5018 }, Name = "Thenemi", WikiUrl = "https://wiki.guildwars.com/wiki/Thenemi" };
    public static readonly Npc GarfazSteelfur = new() { Ids = new int[] { 5014 }, Name = "Garfaz Steelfur", WikiUrl = "https://wiki.guildwars.com/wiki/Garfaz_Steelfur" };
    public static readonly Npc CaptainYithlis = new() { Ids = new int[] { 5013 }, Name = "Captain Yithlis", WikiUrl = "https://wiki.guildwars.com/wiki/Captain_Yithlis" };
    public static readonly Npc Igraine = new() { Ids = new int[] { 5015 }, Name = "Igraine", WikiUrl = "https://wiki.guildwars.com/wiki/Igraine" };
    public static readonly Npc TheLost = new() { Ids = new int[] { 5016 }, Name = "The Lost", WikiUrl = "https://wiki.guildwars.com/wiki/The_Lost" };
    public static readonly Npc AbaddonsAdjutant = new() { Ids = new int[] { 5483 }, Name = "Abaddon's Adjutant", WikiUrl = "https://wiki.guildwars.com/wiki/Abaddon%27s_Adjutant" };
    public static readonly Npc EmissaryOfDhuum = new() { Ids = new int[] { 5412, 5425 }, Name = "Emissary of Dhuum", WikiUrl = "https://wiki.guildwars.com/wiki/Emissary_of_Dhuum" };
    public static readonly Npc TerrorwebDryder = new() { Ids = new int[] { 2321 }, Name = "Terrorweb Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Terrorweb_Dryder" };
    public static readonly Npc Rukkassa = new() { Ids = new int[] { 4973 }, Name = "Rukkassa", WikiUrl = "https://wiki.guildwars.com/wiki/Rukkassa" };
    public static readonly Npc TorturewebDryder = new() { Ids = new int[] { 5427, 5215 }, Name = "Tortureweb Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Tortureweb_Dryder" };
    public static readonly Npc LostSoul = new() { Ids = new int[] { 2358 }, Name = "Lost Soul", WikiUrl = "https://wiki.guildwars.com/wiki/Lost_Soul" };
    public static readonly Npc Apostate = new() { Ids = new int[] { 5491 }, Name = "Apostate", WikiUrl = "https://wiki.guildwars.com/wiki/Apostate" };
    public static readonly Npc StormOfAnguish = new() { Ids = new int[] { 5436 }, Name = "Storm of Anguish", WikiUrl = "https://wiki.guildwars.com/wiki/Storm_of_Anguish" };
    public static readonly Npc ShriekerOfDread = new() { Ids = new int[] { 5439 }, Name = "Shrieker of Dread", WikiUrl = "https://wiki.guildwars.com/wiki/Shrieker_of_Dread" };
    public static readonly Npc ShirokenElementalist = new() { Ids = new int[] { 4128 }, Name = "Shiro'ken Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro%27ken_Elementalist" };
    public static readonly Npc PainTitan = new() { Ids = new int[] { 4969 }, Name = "Pain Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Pain_Titan" };
    public static readonly Npc ShirokenMonk = new() { Ids = new int[] { 4129 }, Name = "Shiro'ken Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro%27ken_Monk" };
    public static readonly Npc ShirokenMesmer = new() { Ids = new int[] { 4126 }, Name = "Shiro'ken Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Shiro%27ken_Mesmer" };
    public static readonly Npc TitanAbomination = new() { Ids = new int[] { 4968 }, Name = "Titan Abomination", WikiUrl = "https://wiki.guildwars.com/wiki/Titan_Abomination" };
    public static readonly Npc BoundTiendi = new() { Ids = new int[] { 4087 }, Name = "Bound Tiendi", WikiUrl = "https://wiki.guildwars.com/wiki/Bound_Tiendi" };
    public static readonly Npc BoundKaichen = new() { Ids = new int[] { 4085 }, Name = "Bound Kaichen", WikiUrl = "https://wiki.guildwars.com/wiki/Bound_Kaichen" };
    public static readonly Npc WrathfulStorm = new() { Ids = new int[] { 4961, 7320 }, Name = "Wrathful Storm", WikiUrl = "https://wiki.guildwars.com/wiki/Wrathful_Storm" };
    public static readonly Npc GraspOfInsanity = new() { Ids = new int[] { 4960, 7317 }, Name = "Grasp of Insanity", WikiUrl = "https://wiki.guildwars.com/wiki/Grasp_of_Insanity" };
    public static readonly Npc TormentClaw = new() { Ids = new int[] { 5461, 7319 }, Name = "Torment Claw", WikiUrl = "https://wiki.guildwars.com/wiki/Torment_Claw" };
    public static readonly Npc BoundHaoLi = new() { Ids = new int[] { 4082 }, Name = "Bound Hao Li", WikiUrl = "https://wiki.guildwars.com/wiki/Bound_Hao_Li" };
    public static readonly Npc IgnisCruor = new() { Ids = new int[] { 4978 }, Name = "Ignis Cruor", WikiUrl = "https://wiki.guildwars.com/wiki/Ignis_Cruor" };
    public static readonly Npc ShadowBeast = new() { Ids = new int[] { 4967, 2809 }, Name = "Shadow Beast", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Beast" };
    public static readonly Npc CreoVulnero = new() { Ids = new int[] { 4957 }, Name = "Creo Vulnero", WikiUrl = "https://wiki.guildwars.com/wiki/Creo_Vulnero" };
    public static readonly Npc PortalWraith = new() { Ids = new int[] { 2764 }, Name = "Portal Wraith", WikiUrl = "https://wiki.guildwars.com/wiki/Portal_Wraith" };
    public static readonly Npc ArmageddonLord = new() { Ids = new int[] { 2674 }, Name = "Armageddon Lord", WikiUrl = "https://wiki.guildwars.com/wiki/Armageddon_Lord" };
    public static readonly Npc JoyousSoul = new() { Ids = new int[] { 5011, 5009, 5010, 5012, 5008 }, Name = "Joyous Soul", WikiUrl = "https://wiki.guildwars.com/wiki/Joyous_Soul" };
    public static readonly Npc MagridTheSly = new() { Ids = new int[] { 4451 }, Name = "Magrid the Sly", WikiUrl = "https://wiki.guildwars.com/wiki/Magrid_the_Sly" };
    public static readonly Npc Zenmai = new() { Ids = new int[] { 3552 }, Name = "Zenmai", WikiUrl = "https://wiki.guildwars.com/wiki/Zenmai" };
    public static readonly Npc Abaddon = new() { Ids = new int[] { 5142 }, Name = "Abaddon", WikiUrl = "https://wiki.guildwars.com/wiki/Abaddon" };
    public static readonly Npc CorsairRunner = new() { Ids = new int[] { 5091 }, Name = "Corsair Runner", WikiUrl = "https://wiki.guildwars.com/wiki/Corsair_Runner" };
    public static readonly Npc Abyssal = new() { Ids = new int[] { 2810, 5194 }, Name = "Abyssal", WikiUrl = "https://wiki.guildwars.com/wiki/Abyssal" };
    public static readonly Npc GhostChampion = new() { Ids = new int[] { 2826 }, Name = "Ghost Champion", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Ghosts" };
    public static readonly Npc ShadowWarrior = new() { Ids = new int[] { 2807, 4965 }, Name = "Shadow Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Warrior" };
    public static readonly Npc ShadowElemental = new() { Ids = new int[] { 2805, 4963 }, Name = "Shadow Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Shadow_Elemental" };
    public static readonly Npc SkeletalEtherBreaker = new() { Ids = new int[] { 2816 }, Name = "Skeletal Ether Breaker", WikiUrl = "https://wiki.guildwars.com/wiki/Skeletal_Ether_Breaker" };
    public static readonly Npc SkeletalIcehand = new() { Ids = new int[] { 2817 }, Name = "Skeletal Icehand", WikiUrl = "https://wiki.guildwars.com/wiki/Skeletal_Icehand" };
    public static readonly Npc SkeletalBond = new() { Ids = new int[] { 2818 }, Name = "Skeletal Bond", WikiUrl = "https://wiki.guildwars.com/wiki/Skeletal_Bond" };
    public static readonly Npc SkeletalBerserker = new() { Ids = new int[] { 2819 }, Name = "Skeletal Berserker", WikiUrl = "https://wiki.guildwars.com/wiki/Skeletal_Berserker" };
    public static readonly Npc SpiritShepherd = new() { Ids = new int[] { 2813 }, Name = "Spirit Shepherd", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_Shepherd" };
    public static readonly Npc SpiritWood = new() { Ids = new int[] { 2812 }, Name = "Spirit Wood", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_Wood" };
    public static readonly Npc SpiritofNaturesRenewal = new() { Ids = new int[] { 2887 }, Name = "Spirit of Nature's Renewal", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Nature%27s_Renewal" };
    public static readonly Npc RockBorerWorm = new() { Ids = new int[] { 2821 }, Name = "Rock Borer Worm", WikiUrl = "https://wiki.guildwars.com/wiki/Rock_Borer_Worm" };
    public static readonly Npc SpiritofExtinction = new() { Ids = new int[] { 2876 }, Name = "Spirit of Extinction", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Extinction" };
    public static readonly Npc ArmoredCaveSpider = new() { Ids = new int[] { 2800 }, Name = "Armored Cave Spider", WikiUrl = "https://wiki.guildwars.com/wiki/Armored_Cave_Spider" };
    public static readonly Npc Banshee = new() { Ids = new int[] { 2326 }, Name = "Banshee", WikiUrl = "https://wiki.guildwars.com/wiki/Banshee" };
    public static readonly Npc ForestGriffon = new() { Ids = new int[] { 2827 }, Name = "Forest Griffon", WikiUrl = "https://wiki.guildwars.com/wiki/Forest_Griffon" };
    public static readonly Npc SkeletalImpaler = new() { Ids = new int[] { 2820 }, Name = "Skeletal Impaler", WikiUrl = "https://wiki.guildwars.com/wiki/Skeletal_Impaler" };
    public static readonly Npc FlamingScepterMage = new() { Ids = new int[] { 2832 }, Name = "Flaming Scepter Mage", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Ghosts" };
    public static readonly Npc EternalForgemaster = new() { Ids = new int[] { 2829 }, Name = "Eternal Forgemaster", WikiUrl = "https://wiki.guildwars.com/wiki/Eternal_Forgemaster" };
    public static readonly Npc EternalRanger = new() { Ids = new int[] { 2834 }, Name = "Eternal Ranger", WikiUrl = "https://wiki.guildwars.com/wiki/Eternal_Ranger" };
    public static readonly Npc SeedofCorruption = new() { Ids = new int[] { 2811 }, Name = "Seed of Corruption", WikiUrl = "https://wiki.guildwars.com/wiki/Seed_of_Corruption" };
    public static readonly Npc DoubtersDryder = new() { Ids = new int[] { 2803 }, Name = "Doubter's Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Doubter%27s_Dryder" };
    public static readonly Npc ObsidianFurnaceDrake = new() { Ids = new int[] { 2802 }, Name = "Obsidian Furnace Drake", WikiUrl = "https://wiki.guildwars.com/wiki/Obsidian_Furnace_Drake" };
    public static readonly Npc SmokeWalker = new() { Ids = new int[] { 2801 }, Name = "Smoke Walker", WikiUrl = "https://wiki.guildwars.com/wiki/Smoke_Walker" };
    public static readonly Npc InfernalWurm = new() { Ids = new int[] { 2822 }, Name = "Infernal Wurm", WikiUrl = "https://wiki.guildwars.com/wiki/Infernal_Wurm" };
    public static readonly Npc AncientSkale = new() { Ids = new int[] { 2814 }, Name = "Ancient Skale", WikiUrl = "https://wiki.guildwars.com/wiki/Ancient_Skale" };
    public static readonly Npc DragonLich = new() { Ids = new int[] { 2823 }, Name = "Dragon Lich", WikiUrl = "https://wiki.guildwars.com/wiki/Dragon_Lich" };
    public static readonly Npc VisionOfDespair = new() { Ids = new int[] { 5440 }, Name = "Vision of Despair", WikiUrl = "https://wiki.guildwars.com/wiki/Vision_of_Despair" };
    public static readonly Npc SaevioProelium = new() { Ids = new int[] { 4956 }, Name = "Saevio Proelium", WikiUrl = "https://wiki.guildwars.com/wiki/Saevio_Proelium" };
    public static readonly Npc BringerOfDeceit = new() { Ids = new int[] { 5441 }, Name = "Bringer of Deceit", WikiUrl = "https://wiki.guildwars.com/wiki/Bringer_of_Deceit" };
    public static readonly Npc SpiritOfQuickeningZephyr = new() { Ids = new int[] { 2886 }, Name = "Spirit of Quickening Zephyr", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Quickening_Zephyr" };
    public static readonly Npc FlameOfFervor = new() { Ids = new int[] { 5437 }, Name = "Flame of Fervor", WikiUrl = "https://wiki.guildwars.com/wiki/Flame_of_Fervor" };
    public static readonly Npc WaterBornTitan = new() { Ids = new int[] { 2677 }, Name = "Water Born Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Water_Born_Titan" };
    public static readonly Npc WildGrowth = new() { Ids = new int[] { 2678 }, Name = "Wild Growth", WikiUrl = "https://wiki.guildwars.com/wiki/Wild_Growth" };
    public static readonly Npc SeedOfSuffering = new() { Ids = new int[] { 5438 }, Name = "Seed of Suffering", WikiUrl = "https://wiki.guildwars.com/wiki/Seed_of_Suffering" };
    public static readonly Npc FortuneTellerGhost = new() { Ids = new int[] { 4977 }, Name = "Fortune Teller Ghost", WikiUrl = "https://wiki.guildwars.com/wiki/Fortune_Teller" };
    public static readonly Npc EarthBornTitan = new() { Ids = new int[] { 2676 }, Name = "Earth Born Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Earth_Born_Titan" };
    public static readonly Npc WindBornTitan = new() { Ids = new int[] { 2675 }, Name = "Wind Born Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Wind_Born_Titan" };
    public static readonly Npc RottingTitan = new() { Ids = new int[] { 2679 }, Name = "Rotting Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Rotting_Titan" };
    public static readonly Npc ForgottenIllusionist = new() { Ids = new int[] { 4974, 1861 }, Name = "Forgotten Illusionist", WikiUrl = "https://wiki.guildwars.com/wiki/Forgotten_Illusionist" };
    public static readonly Npc WieshurTheInspiring = new() { Ids = new int[] { 5523 }, Name = "Wieshur the Inspiring", WikiUrl = "https://wiki.guildwars.com/wiki/Wieshur_the_Inspiring" };
    public static readonly Npc HautohThePilferer = new() { Ids = new int[] { 5524 }, Name = "Hautoh the Pilferer", WikiUrl = "https://wiki.guildwars.com/wiki/Hautoh_the_Pilferer" };
    public static readonly Npc LetumContineo = new() { Ids = new int[] { 4980 }, Name = "Letum Contineo", WikiUrl = "https://wiki.guildwars.com/wiki/Letum_Contineo" };
    public static readonly Npc SecurisPhasmatis = new() { Ids = new int[] { 4979 }, Name = "Securis Phasmatis", WikiUrl = "https://wiki.guildwars.com/wiki/Securis_Phasmatis" };
    public static readonly Npc Razakel = new() { Ids = new int[] { 5426 }, Name = "Razakel", WikiUrl = "https://wiki.guildwars.com/wiki/Razakel" };
    public static readonly Npc BindingGuardian = new() { Ids = new int[] { 5222 }, Name = "Binding Guardian", WikiUrl = "https://wiki.guildwars.com/wiki/Binding_Guardian" };
    public static readonly Npc Razah = new() { Ids = new int[] { 4502 }, Name = "Razah", WikiUrl = "https://wiki.guildwars.com/wiki/Razah" };
    public static readonly Npc MargoniteAnurTuk = new() { Ids = new int[] { 5171 }, Name = "Margonite Anur Tuk", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Tuk" };
    public static readonly Npc MargoniteAnurSu = new() { Ids = new int[] { 5168 }, Name = "Margonite Anur Su", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Su" };
    public static readonly Npc MargoniteAnurDabi = new() { Ids = new int[] { 5167 }, Name = "Margonite Anur Dabi", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Dabi" };
    public static readonly Npc MargoniteAnurVu = new() { Ids = new int[] { 5170 }, Name = "Margonite Anur Vu", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Vu" };
    public static readonly Npc MargoniteAnurKi = new() { Ids = new int[] { 5169 }, Name = "Margonite Anur Ki", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Ki" };
    public static readonly Npc MargoniteAnurRund = new() { Ids = new int[] { 5173 }, Name = "Margonite Anur Rund", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Rund" };
    public static readonly Npc WindOfDarkness = new() { Ids = new int[] { 5192 }, Name = "Wind of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Wind_of_Darkness" };
    public static readonly Npc ChillOfDarkness = new() { Ids = new int[] { 5189 }, Name = "Chill of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Chill_of_Darkness" };
    public static readonly Npc ClawOfDarkness = new() { Ids = new int[] { 5191 }, Name = "Claw of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Claw_of_Darkness" };
    public static readonly Npc ThoughtOfDarkness = new() { Ids = new int[] { 5188 }, Name = "Thought of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Thought_of_Darkness" };
    public static readonly Npc CurseOfDarkness = new() { Ids = new int[] { 5193 }, Name = "Curse of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Curse_of_Darkness" };
    public static readonly Npc ScourgeOfDarkness = new() { Ids = new int[] { 5190 }, Name = "Scourge of Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/Scourge_of_Darkness" };
    public static readonly Npc MargoniteAnurRuk = new() { Ids = new int[] { 5172 }, Name = "Margonite Anur Ruk", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Ruk" };
    public static readonly Npc MargoniteAnurMank = new() { Ids = new int[] { 5174 }, Name = "Margonite Anur Mank", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Mank" };
    public static readonly Npc HeartTormentor = new() { Ids = new int[] { 5207 }, Name = "Heart Tormentor", WikiUrl = "https://wiki.guildwars.com/wiki/Heart_Tormentor" };
    public static readonly Npc WaterTormentor = new() { Ids = new int[] { 5206 }, Name = "Water Tormentor", WikiUrl = "https://wiki.guildwars.com/wiki/Water_Tormentor" };
    public static readonly Npc SpiritTormentor = new() { Ids = new int[] { 5209 }, Name = "Spirit Tormentor", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_Tormentor" };
    public static readonly Npc SanityTormentor = new() { Ids = new int[] { 5212 }, Name = "Sanity Tormentor", WikiUrl = "https://wiki.guildwars.com/wiki/Sanity_Tormentor" };
    public static readonly Npc MindTormentor = new() { Ids = new int[] { 5204 }, Name = "Mind Tormentor", WikiUrl = "https://wiki.guildwars.com/wiki/Mind_Tormentor" };
    public static readonly Npc SoulTormentor = new() { Ids = new int[] { 5205 }, Name = "Soul Tormentor", WikiUrl = "https://wiki.guildwars.com/wiki/Soul_Tormentor" };
    public static readonly Npc FleshTormentor = new() { Ids = new int[] { 5208 }, Name = "Flesh Tormentor", WikiUrl = "https://wiki.guildwars.com/wiki/Flesh_Tormentor" };
    public static readonly Npc MargoniteAnurKaya = new() { Ids = new int[] { 5166 }, Name = "Margonite Anur Kaya", WikiUrl = "https://wiki.guildwars.com/wiki/Margonite_Anur_Kaya" };
    public static readonly Npc StygianBrute = new() { Ids = new int[] { 5176 }, Name = "Stygian Brute", WikiUrl = "https://wiki.guildwars.com/wiki/Stygian_Brute" };
    public static readonly Npc StygianGolem = new() { Ids = new int[] { 5177 }, Name = "Stygian Golem", WikiUrl = "https://wiki.guildwars.com/wiki/Stygian_Golem" };
    public static readonly Npc ShaunurTheDivine = new() { Ids = new int[] { 5159 }, Name = "Shaunur the Divine", WikiUrl = "https://wiki.guildwars.com/wiki/Shaunur_the_Divine" };
    public static readonly Npc LordJadoth = new() { Ids = new int[] { 5144 }, Name = "Lord Jadoth", WikiUrl = "https://wiki.guildwars.com/wiki/Lord_Jadoth" };
    public static readonly Npc TurepMakerOfOrphans = new () { Ids = new int[] { 5160 }, Name = "Turep, Maker of Orphans", WikiUrl = "https://wiki.guildwars.com/wiki/Turep,_Maker_of_Orphans" };
    public static readonly Npc StygianHunger = new() { Ids = new int[] { 5175 }, Name = "Stygian Hunger", WikiUrl = "https://wiki.guildwars.com/wiki/Stygian_Hunger" };
    public static readonly Npc SpiritOfTruth = new() { Ids = new int[] { 4986 }, Name = "Spirit of Truth", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Truth" };
    public static readonly Npc TheDarkness = new() { Ids = new int[] { 5152 }, Name = "The Darkness", WikiUrl = "https://wiki.guildwars.com/wiki/The_Darkness" };
    public static readonly Npc RageTitan = new() { Ids = new int[] { 5201 }, Name = "Rage Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Rage_Titan" };
    public static readonly Npc DespairTitan = new() { Ids = new int[] { 5203 }, Name = "Despair Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Despair_Titan" };
    public static readonly Npc GreaterDreamRider = new() { Ids = new int[] { 5216 }, Name = "Greater Dream Rider", WikiUrl = "https://wiki.guildwars.com/wiki/Greater_Dream_Rider" };
    public static readonly Npc AnguishTitan = new() { Ids = new int[] { 5198 }, Name = "Anguish Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Anguish_Titan" };
    public static readonly Npc MiseryTitan = new() { Ids = new int[] { 5195 }, Name = "Misery Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Misery_Titan" };
    public static readonly Npc FuryTitan = new() { Ids = new int[] { 5200 }, Name = "Fury Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Fury_Titan" };
    public static readonly Npc DementiaTitan = new() { Ids = new int[] { 5197 }, Name = "Dementia Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Dementia_Titan" };
    public static readonly Npc BanishedDreamRider = new() { Ids = new int[] { 7321 }, Name = "Banished Dream Rider", WikiUrl = "https://wiki.guildwars.com/wiki/Banished_Dream_Rider" };
    public static readonly Npc ChaosWurm = new() { Ids = new int[] { 7326 }, Name = "Chaos Wurm", WikiUrl = "https://wiki.guildwars.com/wiki/Chaos_Wurm" };
    public static readonly Npc GuardianOfKomalie = new() { Ids = new int[] { 5162, 5161 }, Name = "Guardian of Komalie", WikiUrl = "https://wiki.guildwars.com/wiki/Guardian_of_Komalie" };
    public static readonly Npc TheFury = new() { Ids = new int[] { 5149 }, Name = "The Fury", WikiUrl = "https://wiki.guildwars.com/wiki/The_Fury" };
    public static readonly Npc StygianHorror = new() { Ids = new int[] { 5178 }, Name = "Stygian Horror", WikiUrl = "https://wiki.guildwars.com/wiki/Stygian_Horror" };
    public static readonly Npc StygianFiend = new() { Ids = new int[] { 5179 }, Name = "Stygian Fiend", WikiUrl = "https://wiki.guildwars.com/wiki/Stygian_Fiend" };
    public static readonly Npc StygianUnderlord = new() { Ids = new int[] { 5163, 5164 }, Name = "Stygian Underlord", WikiUrl = "https://wiki.guildwars.com/wiki/Stygian_Underlord" };
    public static readonly Npc StygianLord = new() { Ids = new int[] { 5148, 5147, 5146, 5145 }, Name = "Stygian Lord", WikiUrl = "https://wiki.guildwars.com/wiki/Stygian_Lord" };
    public static readonly Npc CharrRitualist = new() { Ids = new int[] { 6601, 6600 }, Name = "Charr Ritualist", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Charr" };
    public static readonly Npc SiegeDevourer = new() { Ids = new int[] { 6531, 6614 }, Name = "Siege Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Siege_Devourer" };
    public static readonly Npc MantidDigger = new() { Ids = new int[] { 6673 }, Name = "Mantid Digger", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Digger" };
    public static readonly Npc MantidNymph = new() { Ids = new int[] { 6672 }, Name = "Mantid Nymph", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Nymph" };
    public static readonly Npc HoraiWingshielder = new() { Ids = new int[] { 6646 }, Name = "Horai Wingshielder", WikiUrl = "https://wiki.guildwars.com/wiki/Horai_Wingshielder" };
    public static readonly Npc MantidQueen = new() { Ids = new int[] { 6674 }, Name = "Mantid Queen", WikiUrl = "https://wiki.guildwars.com/wiki/Mantid_Queen" };
    public static readonly Npc CharrHexreaper = new() { Ids = new int[] { 6618 }, Name = "Charr Hexreaper", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Hexreaper" };
    public static readonly Npc CharrSeeker = new() { Ids = new int[] { 6634 }, Name = "Charr Seeker", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Seeker" };
    public static readonly Npc CharrAxemaster = new() { Ids = new int[] { 6627 }, Name = "Charr Axemaster", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Axemaster" };
    public static readonly Npc CharrFlameshielder = new() { Ids = new int[] { 6621 }, Name = "Charr Flameshielder", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Flameshielder" };
    public static readonly Npc CharrDominator = new() { Ids = new int[] { 6616 }, Name = "Charr Dominator", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Dominator" };
    public static readonly Npc CharrBlademaster = new() { Ids = new int[] { 6631 }, Name = "Charr Blademaster", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Blademaster" };
    public static readonly Npc MolotovRocktail = new() { Ids = new int[] { 6649 }, Name = "Molotov Rocktail", WikiUrl = "https://wiki.guildwars.com/wiki/Molotov_Rocktail" };
    public static readonly Npc ArmoredSaurus = new() { Ids = new int[] { 6653, 6652 }, Name = "Armored Saurus", WikiUrl = "https://wiki.guildwars.com/wiki/Armored_Saurus" };
    public static readonly Npc GronFierceclaw = new() { Ids = new int[] { 6593 }, Name = "Gron Fierceclaw", WikiUrl = "https://wiki.guildwars.com/wiki/Gron_Fierceclaw" };
    public static readonly Npc BonworFierceblade = new() { Ids = new int[] { 6590 }, Name = "Bonwor Fierceblade", WikiUrl = "https://wiki.guildwars.com/wiki/Bonwor_Fierceblade" };
    public static readonly Npc SeerFiercereign = new() { Ids = new int[] { 6584 }, Name = "Seer Fiercereign", WikiUrl = "https://wiki.guildwars.com/wiki/Seer_Fiercereign" };
    public static readonly Npc CowlFiercetongue = new() { Ids = new int[] { 6586 }, Name = "Cowl Fiercetongue", WikiUrl = "https://wiki.guildwars.com/wiki/Cowl_Fiercetongue" };
    public static readonly Npc RoanFierceheart = new() { Ids = new int[] { 6588 }, Name = "Roan Fierceheart", WikiUrl = "https://wiki.guildwars.com/wiki/Roan_Fierceheart" };
    public static readonly Npc CharrWardkeeper = new() { Ids = new int[] { 6637 }, Name = "Charr Wardkeeper", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Wardkeeper" };
    public static readonly Npc EliteCharrGuard = new() { Ids = new int[] { 6574 }, Name = "Elite Charr Guard", WikiUrl = "https://wiki.guildwars.com/wiki/Elite_Charr_Guard" };
    public static readonly Npc CapturedVanguardSoldier = new() { Ids = new int[] { 6043, 6044, 6045 }, Name = "Captured Vanguard Soldier", WikiUrl = "https://wiki.guildwars.com/wiki/Captured_Vanguard_Soldier" };
    public static readonly Npc HierophantBurntsoul = new() { Ids = new int[] { 6554 }, Name = "Hierophant Burntsoul", WikiUrl = "https://wiki.guildwars.com/wiki/Hierophant_Burntsoul" };
    public static readonly Npc CharrAvenger = new() { Ids = new int[] { 6639 }, Name = "Charr Avenger", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Avenger" };
    public static readonly Npc DestroyerofThoughts = new() { Ids = new int[] { 6145 }, Name = "Destroyer of Thoughts", WikiUrl = "https://wiki.guildwars.com/wiki/Destroyer_of_Thoughts" };
    public static readonly Npc DestroyerofDeeds = new() { Ids = new int[] { 6168 }, Name = "Destroyer of Deeds", WikiUrl = "https://wiki.guildwars.com/wiki/Destroyer_of_Deeds" };
    public static readonly Npc DestroyerofHordes = new() { Ids = new int[] { 6169 }, Name = "Destroyer of Hordes", WikiUrl = "https://wiki.guildwars.com/wiki/Destroyer_of_Hordes" };
    public static readonly Npc DestroyerofBones = new() { Ids = new int[] { 6157 }, Name = "Destroyer of Bones", WikiUrl = "https://wiki.guildwars.com/wiki/Destroyer_of_Bones" };
    public static readonly Npc DestroyerofSinew = new() { Ids = new int[] { 6156 }, Name = "Destroyer of Sinew", WikiUrl = "https://wiki.guildwars.com/wiki/Destroyer_of_Sinew" };
    public static readonly Npc CaptainLangmar = new() { Ids = new int[] { 6032 }, Name = "Captain Langmar", WikiUrl = "https://wiki.guildwars.com/wiki/Captain_Langmar" };
    public static readonly Npc VileMandragor = new() { Ids = new int[] { 6656 }, Name = "Vile Mandragor", WikiUrl = "https://wiki.guildwars.com/wiki/Vile_Mandragor" };
    public static readonly Npc MandragorSmokeDevil = new() { Ids = new int[] { 6658 }, Name = "Mandragor Smoke Devil", WikiUrl = "https://wiki.guildwars.com/wiki/Mandragor_Smoke_Devil" };
    public static readonly Npc MandragorDustDevil = new() { Ids = new int[] { 6657 }, Name = "Mandragor Dust Devil", WikiUrl = "https://wiki.guildwars.com/wiki/Mandragor_Dust_Devil" };
    public static readonly Npc DeadlySkale = new() { Ids = new int[] { 6675 }, Name = "Deadly Skale", WikiUrl = "https://wiki.guildwars.com/wiki/Deadly_Skale" };
    public static readonly Npc CharrMender = new() { Ids = new int[] { 6626 }, Name = "Charr Mender", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Mender" };
    public static readonly Npc ThraexisThundermaw = new() { Ids = new int[] { 6644 }, Name = "Thraexis Thundermaw", WikiUrl = "https://wiki.guildwars.com/wiki/Thraexis_Thundermaw" };
    public static readonly Npc KatyeBloodburner = new() { Ids = new int[] { 6551 }, Name = "Katye Bloodburner", WikiUrl = "https://wiki.guildwars.com/wiki/Katye_Bloodburner" };
    public static readonly Npc AnmattheTrickster = new() { Ids = new int[] { 6550 }, Name = "Anmat the Trickster", WikiUrl = "https://wiki.guildwars.com/wiki/Anmat_the_Trickster" };
    public static readonly Npc GrawlChampion = new() { Ids = new int[] { 6670 }, Name = "Grawl Champion", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl_Champion" };
    public static readonly Npc GrawlDarkPriest = new() { Ids = new int[] { 6669 }, Name = "Grawl Dark Priest", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl_Dark_Priest" };
    public static readonly Npc SpiritofPreservation = new() { Ids = new int[] { 4219 }, Name = "Spirit of Preservation", WikiUrl = "https://wiki.guildwars.com/wiki/Spirit_of_Preservation" };
    public static readonly Npc TumbledElemental = new() { Ids = new int[] { 6678 }, Name = "Tumbled Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Tumbled_Elemental" };
    public static readonly Npc FlowstoneElemental = new() { Ids = new int[] { 6915 }, Name = "Flowstone Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Flowstone_Elemental" };
    public static readonly Npc MagmaBlister = new() { Ids = new int[] { 6916 }, Name = "Magma Blister", WikiUrl = "https://wiki.guildwars.com/wiki/Magma_Blister" };
    public static readonly Npc GrawlDemagogue = new() { Ids = new int[] { 6671 }, Name = "Grawl Demagogue", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl_Demagogue" };
    public static readonly Npc BurningSpirit = new() { Ids = new int[] { 6918 }, Name = "Burning Spirit", WikiUrl = "https://wiki.guildwars.com/wiki/Burning_Spirit" };
    public static readonly Npc IgnustheEternal = new() { Ids = new int[] { 6654 }, Name = "Ignus the Eternal", WikiUrl = "https://wiki.guildwars.com/wiki/Ignus_the_Eternal" };
    public static readonly Npc SwarmofBees = new() { Ids = new int[] { 6640 }, Name = "Swarm of Bees", WikiUrl = "https://wiki.guildwars.com/wiki/Swarm_of_Bees" };
    public static readonly Npc MergoyleWavebreaker = new() { Ids = new int[] { 1723 }, Name = "Mergoyle Wavebreaker", WikiUrl = "https://wiki.guildwars.com/wiki/Mergoyle_Wavebreaker" };
    public static readonly Npc SnowEttin = new() { Ids = new int[] { 2491 }, Name = "Snow Ettin", WikiUrl = "https://wiki.guildwars.com/wiki/Snow_Ettin" };
    public static readonly Npc IceGolem = new() { Ids = new int[] { 2647 }, Name = "Ice Golem", WikiUrl = "https://wiki.guildwars.com/wiki/Ice_Golem" };
    public static readonly Npc WhiskarFeatherstorm = new() { Ids = new int[] { 2479 }, Name = "Whiskar Featherstorm", WikiUrl = "https://wiki.guildwars.com/wiki/Whiskar_Featherstorm" };
    public static readonly Npc Snow = new() { Ids = new int[] { 2548 }, Name = "Snow", WikiUrl = "https://wiki.guildwars.com/wiki/Snow" };
    public static readonly Npc MasterSeekerNathaniel = new() { Ids = new int[] { 2229 }, Name = "Master Seeker Nathaniel", WikiUrl = "https://wiki.guildwars.com/wiki/Master_Seeker_Nathaniel" };
    public static readonly Npc SnowEttinBoss = new() { Ids = new int[] { 2481 }, Name = "Snow Ettin Boss", WikiUrl = "https://wiki.guildwars.com/wiki/Snow_Ettin" };
    public static readonly Npc ShiverpeakProtector = new() { Ids = new int[] { 2487 }, Name = "Shiverpeak Protector", WikiUrl = "https://wiki.guildwars.com/wiki/Shiverpeak_Protector" };
    public static readonly Npc ShiverpeakWarrior = new() { Ids = new int[] { 2488 }, Name = "Shiverpeak Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Shiverpeak_Warrior" };
    public static readonly Npc ShiverpeakLongbow = new() { Ids = new int[] { 2489 }, Name = "Shiverpeak Longbow", WikiUrl = "https://wiki.guildwars.com/wiki/Shiverpeak_Longbow" };
    public static readonly Npc MoroStormcalf = new() { Ids = new int[] { 2475 }, Name = "Moro Stormcalf", WikiUrl = "https://wiki.guildwars.com/wiki/Moro_Stormcalf" };
    public static readonly Npc JoloLighthaunch = new() { Ids = new int[] { 2476 }, Name = "Jolo Lighthaunch", WikiUrl = "https://wiki.guildwars.com/wiki/Jolo_Lighthaunch" };
    public static readonly Npc SnowWolf = new() { Ids = new int[] { 1350 }, Name = "Snow Wolf", WikiUrl = "https://wiki.guildwars.com/wiki/Snow_Wolf" };
    public static readonly Npc FrostfireDryder = new() { Ids = new int[] { 2490, 2483, 2485, 2484 }, Name = "Frostfire Dryder", WikiUrl = "https://wiki.guildwars.com/wiki/Frostfire_Dryder" };
    public static readonly Npc StoneSummitSage = new() { Ids = new int[] { 2641 }, Name = "Stone Summit Sage", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Sage" };
    public static readonly Npc DolyakRider = new() { Ids = new int[] { 2640 }, Name = "Dolyak Rider", WikiUrl = "https://wiki.guildwars.com/wiki/Dolyak_Rider" };
    public static readonly Npc StoneSummitHowler = new() { Ids = new int[] { 2642 }, Name = "Stone Summit Howler", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Howler" };
    public static readonly Npc StoneSummitScout = new() { Ids = new int[] { 2646 }, Name = "Stone Summit Scout", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Summit_Scout" };
    public static readonly Npc ShalisIronmantle = new() { Ids = new int[] { 2622 }, Name = "Shalis Ironmantle", WikiUrl = "https://wiki.guildwars.com/wiki/Shalis_Ironmantle" };
    public static readonly Npc SummitAxeWielder = new() { Ids = new int[] { 2643 }, Name = "Summit Axe Wielder", WikiUrl = "https://wiki.guildwars.com/wiki/Summit_Axe_Wielder" };
    public static readonly Npc SarisHeadstaver = new() { Ids = new int[] { 2612 }, Name = "Saris Headstaver", WikiUrl = "https://wiki.guildwars.com/wiki/Saris_Headstaver" };
    public static readonly Npc TorisStonehammer = new() { Ids = new int[] { 2616 }, Name = "Toris Stonehammer", WikiUrl = "https://wiki.guildwars.com/wiki/Toris_Stonehammer" };
    public static readonly Npc TheJudge = new() { Ids = new int[] { 2614 }, Name = "The Judge", WikiUrl = "https://wiki.guildwars.com/wiki/The_Judge" };
    public static readonly Npc BoulderElemental = new() { Ids = new int[] { 2439 }, Name = "Boulder Elemental", WikiUrl = "https://wiki.guildwars.com/wiki/Boulder_Elemental" };
    public static readonly Npc StoneFury = new() { Ids = new int[] { 2442 }, Name = "Stone Fury", WikiUrl = "https://wiki.guildwars.com/wiki/Stone_Fury" };
    public static readonly Npc CharrMartyr = new() { Ids = new int[] { 1648 }, Name = "Charr Martyr", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Martyr" };
    public static readonly Npc CharrFlameWielder = new() { Ids = new int[] { 1641 }, Name = "Charr Flame Wielder", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Flame_Wielder" };
    public static readonly Npc CharrMindSpark = new() { Ids = new int[] { 1636 }, Name = "Charr Mind Spark", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Mind_Spark" };
    public static readonly Npc CharrAshWalker = new() { Ids = new int[] { 1639 }, Name = "Charr Ash Walker", WikiUrl = "https://wiki.guildwars.com/wiki/Charr_Ash_Walker" };
    public static readonly Npc StormRider = new() { Ids = new int[] { 2425 }, Name = "Storm Rider", WikiUrl = "https://wiki.guildwars.com/wiki/Storm_Rider" };
    public static readonly Npc FlashGargoyle = new() { Ids = new int[] { 2447 }, Name = "Flash Gargoyle", WikiUrl = "https://wiki.guildwars.com/wiki/Flash_Gargoyle" };
    public static readonly Npc AscalonWarrior = new() { Ids = new int[] { 2060 }, Name = "Ascalon Warrior", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalon_Warrior" };
    public static readonly Npc ResurrectGargoyle = new() { Ids = new int[] { 2451 }, Name = "Resurrect Gargoyle", WikiUrl = "https://wiki.guildwars.com/wiki/Resurrect_Gargoyle" };
    public static readonly Npc WhiptailDevourer = new() { Ids = new int[] { 2432 }, Name = "Whiptail Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Whiptail_Devourer" };
    public static readonly Npc MalletRunecolumn = new() { Ids = new int[] { 2394 }, Name = "Mallet Runecolumn", WikiUrl = "https://wiki.guildwars.com/wiki/Mallet_Runecolumn" };
    public static readonly Npc CrownofThorns = new() { Ids = new int[] { 2455 }, Name = "Crown of Thorns", WikiUrl = "https://wiki.guildwars.com/wiki/Crown_of_Thorns" };
    public static readonly Npc DrimCindershot = new() { Ids = new int[] { 1601 }, Name = "Drim Cindershot", WikiUrl = "https://wiki.guildwars.com/wiki/Drim_Cindershot" };
    public static readonly Npc AscalonianHunter = new() { Ids = new int[] { 2052 }, Name = "Ascalonian Hunter", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalonian_Hunter" };
    public static readonly Npc MirashDreambreaker = new() { Ids = new int[] { 1596 }, Name = "Mirash Dreambreaker", WikiUrl = "https://wiki.guildwars.com/wiki/Mirash_Dreambreaker" };
    public static readonly Npc AscalonianCrafter = new() { Ids = new int[] { 2068 }, Name = "Ascalonian Crafter", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonianWeaponsmith = new() { Ids = new int[] { 2087 }, Name = "Ascalonian Weaponsmith", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc AscalonianMerchant = new() { Ids = new int[] { 2101, 2015 }, Name = "Ascalonian Merchant", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc Viggo = new() { Ids = new int[] { 2139 }, Name = "Viggo", WikiUrl = "https://wiki.guildwars.com/wiki/Viggo" };
    public static readonly Npc GorgaanHatemonger = new() { Ids = new int[] { 1600 }, Name = "Gorgaan Hatemonger", WikiUrl = "https://wiki.guildwars.com/wiki/Gorgaan_Hatemonger" };
    public static readonly Npc PlagueDevourer = new() { Ids = new int[] { 2431 }, Name = "Plague Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Plague_Devourer" };
    public static readonly Npc FlintTouchstone = new() { Ids = new int[] { 2404 }, Name = "Flint Touchstone", WikiUrl = "https://wiki.guildwars.com/wiki/Flint_Touchstone" };
    public static readonly Npc Grawl = new() { Ids = new int[] { 2458 }, Name = "Grawl", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl" };
    public static readonly Npc GrawlUlodyte = new() { Ids = new int[] { 2457 }, Name = "Grawl Ulodyte", WikiUrl = "https://wiki.guildwars.com/wiki/Grawl_Ulodyte" };
    public static readonly Npc Renegade = new() { Ids = new int[] { 2437 }, Name = "Renegade", WikiUrl = "https://wiki.guildwars.com/wiki/Renegade" };
    public static readonly Npc RenegadeElementalist = new() { Ids = new int[] { 2436 }, Name = "Renegade Elementalist", WikiUrl = "https://wiki.guildwars.com/wiki/Renegade_Elementalist" };
    public static readonly Npc CrimsonDevourer = new() { Ids = new int[] { 2434 }, Name = "Crimson Devourer", WikiUrl = "https://wiki.guildwars.com/wiki/Crimson_Devourer" };
    public static readonly Npc LarrkEtherburn = new() { Ids = new int[] { 2375 }, Name = "Larrk Etherburn", WikiUrl = "https://wiki.guildwars.com/wiki/Larrk_Etherburn" };
    public static readonly Npc AscalonianMage = new() { Ids = new int[] { 1942 }, Name = "Ascalonian Mage", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Ascalon" };
    public static readonly Npc PriestessRashena = new() { Ids = new int[] { 2067 }, Name = "Priestess Rashena", WikiUrl = "https://wiki.guildwars.com/wiki/Priestess_Rashenna" };
    public static readonly Npc IgnisPhanaura = new() { Ids = new int[] { 2406 }, Name = "Ignis Phanaura", WikiUrl = "https://wiki.guildwars.com/wiki/Ignis_Phanaura" };
    public static readonly Npc AscalonStriker = new() { Ids = new int[] { 2051 }, Name = "Ascalon Striker", WikiUrl = "https://wiki.guildwars.com/wiki/Ascalon_Striker" };
    public static readonly Npc RynCursewing = new() { Ids = new int[] { 1681 }, Name = "Ryn Cursewing", WikiUrl = "https://wiki.guildwars.com/wiki/Ryn_Cursewing" };
    public static readonly Npc BouladthePerverse = new() { Ids = new int[] { 2721 }, Name = "Boulad the Perverse", WikiUrl = "https://wiki.guildwars.com/wiki/Boulad_the_Perverse" };
    public static readonly Npc SkeletonSorcerer = new() { Ids = new int[] { 2737 }, Name = "Skeleton Sorcerer", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Sorcerer" };
    public static readonly Npc ZombieWarlock = new() { Ids = new int[] { 2743 }, Name = "Zombie Warlock", WikiUrl = "https://wiki.guildwars.com/wiki/Zombie_Warlock" };
    public static readonly Npc SkeletonMonk = new() { Ids = new int[] { 2738 }, Name = "Skeleton Monk", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Monk" };
    public static readonly Npc SkeletonMesmer = new() { Ids = new int[] { 2736 }, Name = "Skeleton Mesmer", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Mesmer" };
    public static readonly Npc Snakebite = new() { Ids = new int[] { 8055 }, Name = "Snakebite", WikiUrl = "https://wiki.guildwars.com/wiki/Snakebite" };
    public static readonly Npc GrimPeacekeeper = new() { Ids = new int[] { 8107 }, Name = "Grim Peacekeeper", WikiUrl = "https://wiki.guildwars.com/wiki/Grim_Peacekeeper" };
    public static readonly Npc PeacekeeperSibyl = new() { Ids = new int[] { 8148 }, Name = "Peacekeeper Sibyl", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Sibyl" };
    public static readonly Npc AncientOakheart = new() { Ids = new int[] { 1734 }, Name = "Ancient Oakheart", WikiUrl = "https://wiki.guildwars.com/wiki/Ancient_Oakheart" };
    public static readonly Npc ReedStalker = new() { Ids = new int[] { 1730 }, Name = "Reed Stalker", WikiUrl = "https://wiki.guildwars.com/wiki/Reed_Stalker" };
    public static readonly Npc SpinedAloe = new() { Ids = new int[] { 1731 }, Name = "Spined Aloe", WikiUrl = "https://wiki.guildwars.com/wiki/Spined_Aloe" };
    public static readonly Npc SilentPeacekeeper = new() { Ids = new int[] { 8098 }, Name = "Silent Peacekeeper", WikiUrl = "https://wiki.guildwars.com/wiki/Silent_Peacekeeper" };
    public static readonly Npc SkeletonBowmaster = new() { Ids = new int[] { 2740 }, Name = "Skeleton Bowmaster", WikiUrl = "https://wiki.guildwars.com/wiki/Skeleton_Bowmaster" };
    public static readonly Npc BogSkaleBlighter = new() { Ids = new int[] { 1736 }, Name = "Bog Skale Blighter", WikiUrl = "https://wiki.guildwars.com/wiki/Bog_Skale_Blighter" };
    public static readonly Npc AbbotRamoth = new() { Ids = new int[] { 2212 }, Name = "Abbot Ramoth", WikiUrl = "https://wiki.guildwars.com/wiki/Abbot_Ramoth" };
    public static readonly Npc WinglordCaromi = new() { Ids = new int[] { 1703 }, Name = "Winglord Caromi", WikiUrl = "https://wiki.guildwars.com/wiki/Winglord_Caromi" };
    public static readonly Npc CaromiTenguElite = new() { Ids = new int[] { 1745 }, Name = "Caromi Tengu Elite", WikiUrl = "https://wiki.guildwars.com/wiki/Caromi_Tengu_Elite" };
    public static readonly Npc PeacekeeperEnforcer = new() { Ids = new int[] { 8119, 8127 }, Name = "Peacekeeper Enforcer", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Enforcer" };
    public static readonly Npc ForestMinotaur = new() { Ids = new int[] { 1728 }, Name = "Forest Minotaur", WikiUrl = "https://wiki.guildwars.com/wiki/Forest_Minotaur" };
    public static readonly Npc KrytanCollector = new() { Ids = new int[] { 1486 }, Name = "Krytan Collector", WikiUrl = "https://wiki.guildwars.com/wiki/Guild_Wars_Wiki:Projects/NPC_models/Humans/Kryta" };
    public static readonly Npc FogNightmare = new() { Ids = new int[] { 1729 }, Name = "Fog Nightmare", WikiUrl = "https://wiki.guildwars.com/wiki/Fog_Nightmare" };
    public static readonly Npc PeacekeeperHuntsman = new() { Ids = new int[] { 8146 }, Name = "Peacekeeper Huntsman", WikiUrl = "https://wiki.guildwars.com/wiki/Peacekeeper_Huntsman" };
    public static readonly Npc FenTroll = new() { Ids = new int[] { 1748 }, Name = "Fen Troll", WikiUrl = "https://wiki.guildwars.com/wiki/Fen_Troll" };
    public static readonly Npc Bandit = new() { Ids = new int[] { 1720 }, Name = "Bandit", WikiUrl = "https://wiki.guildwars.com/wiki/Bandit" };
    public static readonly Npc Galrath = new() { Ids = new int[] { 2191 }, Name = "Galrath", WikiUrl = "https://wiki.guildwars.com/wiki/Galrath" };
    public static readonly Npc ApprenticeofVerata = new() { Ids = new int[] { 1717 }, Name = "Apprentice of Verata", WikiUrl = "https://wiki.guildwars.com/wiki/Apprentice_of_Verata" };
    public static readonly Npc ShepherdofVerata = new() { Ids = new int[] { 1718 }, Name = "Shepherd of Verata", WikiUrl = "https://wiki.guildwars.com/wiki/Shepherd_of_Verata" };
    public static readonly Npc EyesofVerata = new() { Ids = new int[] { 1719 }, Name = "Eyes of Verata", WikiUrl = "https://wiki.guildwars.com/wiki/Eyes_of_Verata" };
    public static readonly Npc SageofVerata = new() { Ids = new int[] { 1716 }, Name = "Sage of Verata", WikiUrl = "https://wiki.guildwars.com/wiki/Sage_of_Verata" };
    public static readonly Npc DamnedCleric = new() { Ids = new int[] { 2745 }, Name = "Damned Cleric", WikiUrl = "https://wiki.guildwars.com/wiki/Damned_Cleric" };
    public static readonly Npc Wraith = new() { Ids = new int[] { 2734 }, Name = "Wraith", WikiUrl = "https://wiki.guildwars.com/wiki/Wraith" };
    public static readonly Npc RottingDragon = new() { Ids = new int[] { 2838 }, Name = "Rotting Dragon", WikiUrl = "https://wiki.guildwars.com/wiki/Rotting_Dragon" };
    public static readonly Npc Rotscale = new() { Ids = new int[] { 2837 }, Name = "Rotscale", WikiUrl = "https://wiki.guildwars.com/wiki/Rotscale" };
    public static readonly Npc NecridHorseman = new() { Ids = new int[] { 2744 }, Name = "Necrid Horseman", WikiUrl = "https://wiki.guildwars.com/wiki/Necrid_Horseman" };
    public static readonly Npc FrynRageflame = new() { Ids = new int[] { 2277 }, Name = "Fryn Rageflame", WikiUrl = "https://wiki.guildwars.com/wiki/Fryn_Rageflame" };
    public static readonly Npc ArkhelHavenwood = new() { Ids = new int[] { 2510 }, Name = "Arkhel Havenwood", WikiUrl = "https://wiki.guildwars.com/wiki/Arkhel_Havenwood" };
    public static readonly Npc EdibboKepkep = new() { Ids = new int[] { 2521 }, Name = "Edibbo Kepkep", WikiUrl = "https://wiki.guildwars.com/wiki/Edibbo_Kepkep" };
    public static readonly Npc HailBlackice = new() { Ids = new int[] { 2506 }, Name = "Hail Blackice", WikiUrl = "https://wiki.guildwars.com/wiki/Hail_Blackice" };
    public static readonly Npc RuneEthercrash = new() { Ids = new int[] { 2505 }, Name = "Rune Ethercrash", WikiUrl = "https://wiki.guildwars.com/wiki/Rune_Ethercrash" };
    public static readonly Npc DarkTitan = new() { Ids = new int[] { 2683 }, Name = " Dark Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Dark_Titan" };
    public static readonly Npc TitansHeart = new() { Ids = new int[] { 2681 }, Name = "Titan's Heart", WikiUrl = "https://wiki.guildwars.com/wiki/Titan%27s_Heart" };
    public static readonly Npc TitansMalice = new() { Ids = new int[] { 2680 }, Name = "Titan's Malice", WikiUrl = "https://wiki.guildwars.com/wiki/Titan%27s_Malice" };
    public static readonly Npc IcyBrute = new() { Ids = new int[] { 2682 }, Name = "Icy Brute", WikiUrl = "https://wiki.guildwars.com/wiki/Icy_Brute" };
    public static readonly Npc RykArrowwing = new() { Ids = new int[] { 2519 }, Name = "Ryk Arrowwing", WikiUrl = "https://wiki.guildwars.com/wiki/Ryk_Arrowwing" };
    public static readonly Npc SyrHonorcrest = new() { Ids = new int[] { 2518 }, Name = "Syr Honorcrest", WikiUrl = "https://wiki.guildwars.com/wiki/Syr_Honorcrest" };
    public static readonly Npc FrostTitan = new() { Ids = new int[] { 2684 }, Name = "Frost Titan", WikiUrl = "https://wiki.guildwars.com/wiki/Frost_Titan" };
    public static readonly Npc EvirsoSectus = new() { Ids = new int[] { 2664 }, Name = "Evirso Sectus", WikiUrl = "https://wiki.guildwars.com/wiki/Evirso_Sectus" };

    public static IEnumerable<Npc> Npcs { get; } = new List<Npc>()
    {
        Unknown,
        RitualPriest,
        CanthanGuard,
        ZaishenRepresentative,
        CanthanAmbassador,
        PriestOfBalthazar,
        Tolkano,
        XunlaiAgent,
        VabbianCommoner,
        VabbianArtisan,
        AbaddonsCursed,
        Lynx,
        Strider,
        MelandrusStalker,
        Wolf,
        Warthog,
        BlackBear,
        DuneLizard,
        MossSpider,
        MoaBird,
        PrizeWinningHog,
        GiantNeedleSpider,
        DeadlyCryptSpider,
        GiantTreeSpider,
        CarrionDevourer,
        SnappingDevourer,
        DiseasedDevourer,
        LashDevourer,
        IceElemental,
        StoneElemental,
        HulkingStoneElemental,
        Gargoyle,
        ShatterGargoyle,
        BanditFirestarter,
        BanditRaider,
        BanditBloodSworn,
        NightmareNecromancer,
        AloeHusk,
        LargeAloeSeed,
        AloeSeed,
        Oakheart,
        RiverSkale,
        SkaleBroodcaller,
        RiverSkaleTad,
        GrawlInvader,
        GrawlLongspear,
        GrawlShaman,
        RedEyeTheUnholy,
        JawSmokeskin,
        BlazeBloodbane,
        Haversdan,
        WarmasterTydus,
        AscalonNoble,
        AscalonianGuard,
        AscalonMesmer,
        AscalonMerchant,
        AscalonCrafter,
        AscalonNecromancer,
        RalenaStormbringer,
        AscalonMonk,
        AscalonBrawler,
        AscalonGuard,
        AscalonianFarmer,
        AscalonTamer,
        AcademyMonk,
        AscalonianTownsfolk,
        AscalonianPeasant,
        Krytan,
        Gwen,
        FarrahCappo,
        Cynn,
        Devona,
        AscalonDuke,
        PrinceRurik,
        LadyAlthea,
        NecromancerMunne,
        ElementalistAziure,
        AscalonRanger,
        Skullreaver,
        RestlessCorpse,
        RagingCadaver,
        Ventari,
        ShiningBladeScout,
        Evennia,
        Saidra,
        ShiningBladeMesmer,
        ShiningBladeNecromancer,
        ShiningBladeElementalist,
        GarethQuickblade,
        ShiningBladeWarrior,
        AlariDoubleblade,
        ShiningBladeRanger,
        DwarvenSmith,
        DeldrimorCaster,
        DeldrimorWarrior,
        DwarvenSoldier,
        DeldrimorRanger,
        KingJalisIronhammer,
        BrechnarIronhammer,
        DwarvenSage,
        DwarvenScout,
        CharrChaot,
        CharrAshenClaw,
        CharrShaman,
        CharrAxeFiend,
        CharrBladeStorm,
        CharrHunter,
        SquawNimblecrest,
        GypsieEttin,
        HillGiant,
        InfernoImp,
        FireImp,
        BogSkale,
        CaromiTenguWild,
        CaromiTenguBrave,
        CaromiTenguScout,
        TrechSchmoogle,
        CootleSizzlehorn,
        MinaBrillianthaunch,
        AguoGruffmane,
        ShegZamnMada,
        VisionOfGlint,
        GhostlyHero,
        StormKin,
        DuneBurrower,
        LosaruWindcaster,
        LosaruLifeband,
        LosaruBladehand,
        LosaruBowmaster,
        SandElemental,
        RockshotDevourer,
        SandDrake,
        DesertGriffon,
        Hydra,
        Minotaur,
        JadeScarab,
        RockEaterScarab,
        SiegeWurm,
        SandGiant,
        MarrowScarab,
        ScarabNestBuilder,
        AyassahHess,
        BysshaHisst,
        CyssGresshla,
        CustodianKora,
        GossAleessh,
        HessperSasso,
        IssahSshay,
        JossoEssher,
        CustodianHulgar,
        CustodianPhebus,
        FacetOfDarkness,
        TissDanssir,
        UusshVisshta,
        VassaSsiss,
        WissperInssani,
        CustodianDellus,
        CustodianJenus,
        ForgottenCursebearer,
        ForgottenArcanist,
        ForgottenSage,
        EnchantedHammer,
        EnchantedSword,
        EnchantedBow,
        EnemyPriest,
        ForgottenChampion,
        ForgottenAvenger,
        Forgotten,
        Dunham,
        Claude,
        Orion,
        Alesia,
        LittleThom,
        Stefan,
        Reyna,
        Lina,
        Eve,
        Mhenlo,
        Aidan,
        Olias,
        LyssasMuse,
        VoiceOfGrenth,
        AvatarOfDwayna,
        KrytanMerchant,
        KrytanHerald,
        Lionguard,
        WintunTheBlack,
        RestlessSpirit,
        AscalonianSettler,
        AscalonSettler,
        SettlementGuard,
        CaptainGreywind,
        AscalonianGhost,
        KrytanSmith,
        WhiteMantleZealot,
        CaptainGrumby,
        CapturedChosen,
        Ascalonian,
        AscalonianEngineer,
        DeldrimorMerchant,
        DwarvenWeaponsmith,
        CanthanMerchant,
        IrwynTheSevere,
        SelwinTheFervent,
        EdgarTheIronFist,
        InnerCouncilMemberArgyle,
        BraimaTheCallous,
        CyrusTheUnflattering,
        InnerCouncilMemberCuthbert,
        MantonTheIndulgent,
        WhiteMantleWarriorBoss,
        CuthbertTheChaste,
        PleohTheUgly,
        JusticiarHablion,
        Markis,
        ConfessorDorian,
        WhiteMantleSycophant,
        WhiteMantleRitualist,
        WhiteMantleSavant,
        WhiteMantleAbbot,
        WhiteMantlePriest,
        WhiteMantleKnight,
        WhiteMantleJusticiar,
        WhiteMantleSeeker,
        WhiteMantleRanger,
        WhiteMantleElementalist,
        JusticiarThommis,
        BoneHorror,
        BoneFiend,
        MursaatMesmerBoss,
        MursaatNecromancerBoss,
        MursaatElementalistBoss,
        MursaatMonkBoss,
        MursaatWarriorBoss,
        MursaatRangerBoss,
        MursaatMesmer,
        MursaatNecromancer,
        MursaatElementalist,
        MursaatMonk,
        JadeArmor,
        JadeBow,
        EtherSeal,
        HeppBilespitter,
        MosskRottail,
        Thornwrath,
        WindRiderBoss,
        GrechTrundle,
        WyddKindlerun,
        TreeOfVitality,
        KaraBloodtail,
        MaguumaElementalistBoss,
        ThornStalkerMonkBoss,
        DrogoGreatmane,
        GaleStormsend,
        WindRider,
        RootBehemoth,
        MaguumaEnchanter,
        MaguumaWarlock,
        MaguumaAvenger,
        MaguumaProtector,
        MaguumaWarrior,
        MaguumaHunter,
        FeveredDevourer,
        ThornDevourer,
        ThornDevourerDrone,
        ThornStalker,
        ThornStalkerSprout,
        LifePod,
        EntanglingRoots,
        RedwoodShepherd,
        MossScarab,
        MaguumaSpider,
        JungleTroll,
        HormFrostrider,
        DigoMurkstalker,
        CeruGloomrunner,
        EnslavedFrostGiant,
        BlessedGriffon,
        IceImp,
        AzureShadow,
        Pinesoul,
        AvicaraBrave,
        AvicaraFierce,
        MountainTroll,
        Seer,
        Eidolon,
        EnslavedEttin,
        StoneSummitMesmerBoss,
        HormakIroncurse,
        IceElementalElementalistBoss,
        StoneSummitMonkBoss,
        StoneSummitWarriorBoss,
        DagnarStonepate,
        SummitBeastmaster,
        StoneSummitHeretic,
        DolyakMaster,
        StoneSummitGnasher,
        StoneSummitCarver,
        SiegeIceGolem,
        SummitGiantHerder,
        MolesQuibus,
        MaligoLibens,
        ScelusProsum,
        TortitudoProbo,
        ValetudoRubor,
        SparkOfTheTitans,
        RisenAshenHulk,
        BurningTitan,
        HandOfTheTitans,
        FistOfTheTitans,
        UndeadLich,
        UndeadPrinceRurik,
        ZaimGrimeclaw,
        Ruinwing,
        Hellhound,
        GraspingGhoul,
        SkeletonRanger,
        BoneDragon,
        VizierKhilbron,
        JythSprayburst,
        DosakaruFevertouch,
        SkintekaruManshredder,
        GossDarkweb,
        FerkMallet,
        VulgPainbrain,
        GrenthsCursed,
        MaxineColdstone,
        RwekKhawlMawl,
        BreezeKeeper,
        CragBehemoth,
        Drake,
        DarkFlameDryder,
        IgneousEttin,
        Phantom,
        FleshGolem,
        MahgoHydra,
        Wurm,
        GhostMesmer,
        GhostWarrior,
        ShiningBlade,
        FirstwatchSergio,
        KrytanChild,
        Oink,
        Carlotta,
        KingAdelbern,
        DukeBarradin,
        Joe,
        Shadow,
        Vanguard,
        SpiritOfWinter,
        SpiritOfSymbiosis,
        SpiritOfPrimalEchoes,
        SpiritOfFrozenSoil,
        Crane,
        Tiger,
        Lurker,
        ReefLurker,
        WhiteTiger,
        ElderReefLurker,
        ElderCrane,
        ElderTiger,
        KurzickNoble,
        CrimsonSkullMonk,
        GullHookbeak,
        YrrgSnagtooth,
        YorrtStrongjaw,
        CanthanGuardRecruit,
        HeadmasterVhang,
        MasterTogo,
        ZaishenScout,
        YijoTahn,
        ShadyLuxon,
        SuspiciousKurzick,
        ZhuHanuku,
        ShadowBladeAssassin,
        AmFahAssassin,
        LuxonAssassin,
        LuxonMesmer,
        LuxonElementalist,
        LuxonMonk,
        LuxonWarrior,
        LuxonRanger,
        EmperorKisu,
        Jamei,
        TalonSilverwing,
        CanthanGuardCaptain,
        PalaceGuard,
        CanthanChild,
        CanthanNoble,
        CanthanBarkeep,
        CanthanPeasant,
        KurzickGuard,
        ShingJeaCollector,
        CanthanAdept,
        CanthanTrader,
        CanthanArmorer,
        FireworksMaster,
        CanthanWeaponsmith,
        ShingJeaTrader,
        Su,
        SisterTai,
        WengGha,
        CanthanRangerTrainer,
        ProfessorGai,
        AscalonGuardGhost,
        FortuneTeller,
        CanthanRitualist,
        GeneralKaimerVasburg,
        KurzickJuggernaut,
        KurzickAssassin,
        KurzickMesmer,
        KurzickNecromancer,
        KurzickElementalist,
        KurzickMonk,
        KurzickWarrior,
        KurzickRanger,
        KurzickRitualist,
        Juggernaut,
        KurzickQuartermaster,
        WarCaptainWomack,
        KurzickPeasant,
        KurzickTraveler,
        KurzickPriest,
        KurzickBlacksmith,
        KurzickMerchant,
        KurzickWeaponsmith,
        KurzickTrader,
        KurzickBureaucrat,
        BaronMirekVasburg,
        CountZuHeltzer,
        Mai,
        Kisai,
        Taya,
        Lukas,
        Yuun,
        Aeson,
        Panaku,
        LoSha,
        KaiYing,
        Zho,
        ErysVasburg,
        Brutus,
        Sheena,
        Danika,
        RedemptorKarl,
        Emi,
        Chiyo,
        Nika,
        SeaguardHala,
        Daeman,
        Argo,
        SeaguardGita,
        SeaguardEli,
        Aurora,
        SiegeTurtle,
        LuxonNecromancer,
        GiantTurtle,
        YoungTurtle,
        LuxonRitualist,
        LuxonCommander,
        LuxonAmbassador,
        Luxon,
        LuxonElder,
        LuxonTraveler,
        LuxonMagistrate,
        LuxonBlacksmith,
        LuxonMerchant,
        LuxonWeaponsmith,
        LuxonTrader,
        LuxonGuard,
        LuxonPriest,
        ElderRhea,
        ChkkrLocustLord,
        BezzrWingstorm,
        ChkkrBrightclaw,
        KonrruTaintedStone,
        NandetGlassWeaver,
        HarggPlaguebinder,
        TarlokEvermind,
        MungriMagicbox,
        TarnenTheBully,
        WaggSpiritspeak,
        StrongrootTanglebranch,
        InallaySplintercall,
        ArborEarthcall,
        SalkeFurFriend,
        BloodDrinker,
        FungalWallow,
        MantisHunter,
        MantisDreamweaver,
        MantisStormcaller,
        MantisMender,
        PainHungryGaki,
        SkillHungryGaki,
        StoneScaleKirin,
        DredgeGutter,
        DredgeGardener,
        DredgeGuardian,
        Undergrowth,
        StoneRain,
        StoneSoul,
        WardenOfTheMind,
        WardenOfEarth,
        WardenOfTheTrunk,
        WardenOfTheLeaf,
        WardenOfTheSummer,
        DredgeMelee,
        SickenedLynx,
        SickenedMoa,
        SickenedStalker,
        SickenedWolf,
        SickenedWarthog,
        SickenedBear,
        SickenedGuard,
        SickenedServant,
        SickenedScribe,
        AfflictedYijo,
        TheAfflictedKana,
        AfflictedRangerBoss,
        DiseasedMinister,
        AfflictedHorror,
        TheAfflictedLiYun,
        TheAfflictedKam,
        TheAfflictedMiju,
        TheAfflictedHakaru,
        TheAfflictedSenku,
        TheAfflictedHsinJun,
        TheAfflictedJingme,
        TheAfflictedMaaka,
        TheAfflictedXenxo,
        AfflictedAssassin,
        AfflictedBull,
        AfflictedMesmer,
        AfflictedNecromancer,
        AfflictedElementalist,
        AfflictedMonk,
        AfflictedWarrior,
        AfflictedRanger,
        AfflictedRavager,
        AfflictedRitualist,
        AhvaSankii,
        PeiTheSkullBlade,
        YingkoTheSkullClaw,
        FengTheSkullSymbol,
        CaptainQuimang,
        JinTheSkullBow,
        MikiTheSkullSpirit,
        TahkayunTsi,
        YunlaiDeathkeeper,
        ZiinjuuLifeCrawler,
        Cow,
        BonesnapTurtle,
        CrimsonSkullEtherFiend,
        CrimsonSkullMentalist,
        CrimsonSkullMesmer,
        CrimsonSkullHealer,
        CrimsonSkullMender,
        CrimsonSkullHunter,
        CrimsonSkullLongbow,
        CrimsonSkullRaider,
        CrimsonSkullSeer,
        CrimsonSkullSpiritLord,
        CrimsonSkullRitualist,
        MantidDrone,
        MantidDroneHatchling,
        MantidMonitor,
        MantidGlitterfang,
        MantidMonitorHatchling,
        NagaWelp,
        NagaSpellblade,
        NagaWitch,
        NagaSibyl,
        SensaliAssassin,
        SensaliBlood,
        SensaliFighter,
        Kappa,
        MountainYeti,
        LonghairYeti,
        RedYeti,
        Zunraa,
        Kuunavang,
        RazortongueFrothspit,
        KaySeyStormray,
        MiellaLightwing,
        SnapjawWindshell,
        ArrahhshMountainclub,
        AmadisWindOfTheSea,
        GeofferPainBringer,
        KenriiSeaSorrow,
        SiskaScalewand,
        SarssStormscale,
        SskaiDragonsBirth,
        SsynCoiledGrasp,
        ScuttleFish,
        CreepingCarp,
        Irukandji,
        Yeti,
        RotWallow,
        LeviathanClaw,
        LeviathanMouth,
        KrakenSpawn,
        SaltsprayDragon,
        Albax,
        RockhideDragon,
        OutcastAssassin,
        OutcastDeathhand,
        OutcastWarrior,
        OutcastRitualist,
        NagaWarrior,
        NagaArcher,
        NagaRitualist,
        IslandGuardian,
        SenkaiLordOfThe1000DaggersGuild,
        RitualistsConstruct,
        AssassinsConstruct,
        ElementalsConstruct,
        RangersConstruct,
        ShiroTagachi,
        ShirokenAssassin,
        ShirokenNecromancer,
        ShirokenWarrior,
        ShirokenRanger,
        SpiritOfPortals,
        XuekaoTheDeceptive,
        MinaShatterStorm,
        AmFahLeader,
        MeynsangTheSadistic,
        JinThePurifier,
        LianDragonsPetal,
        ShenTheMagistrate,
        WingThreeBlade,
        AmFahNecromancer,
        AmFahHealer,
        AmFahMarksman,
        JadeBrotherhoodMesmer,
        JadeBrotherhoodMage,
        JadeBrotherhoodKnight,
        JadeBrotherhoodRitualist,
        SpiritOfPain,
        SpiritOfDestruction,
        SpiritOfUnion,
        SpiritOfLife,
        SpiritOfBloodSong,
        SpiritOfWanderlust,
        SpiritOfLaceration,
        SpiritOfEquinox,
        SpiritOfFamine,
        SpiritOfBrambles,
        Flamingo,
        ElderCrocodile,
        TaromRockbreaker,
        HaiossBlessedWind,
        ChinehSoaringLight,
        Apocrypha,
        HassinSoftskin,
        SunehStormbringer,
        StalkingNephila,
        WaterDjinn,
        RinkhalMonitor,
        IrontoothDrake,
        SkreeHatchling,
        SkreeFledgeling,
        SkreeGriffon,
        SkreeTalon,
        SkreeHunter,
        SkreeWarbler,
        RidgebackSkale,
        SkaleLasher,
        SkaleBlighter,
        FrigidSkale,
        JuvenileBladedTermite,
        GrubLance,
        BladedTermite,
        PreyingLance,
        StormseedJacaranda,
        FangedIboga,
        MandragorImp,
        MandragorSlither,
        StonefleshMandragor,
        GraspOfChaos,
        Dehjah,
        BoklonBlackwater,
        GlugKlugg,
        Tahlkora,
        MasterOfWhispers,
        AcolyteJin,
        AcolyteSousuke,
        Melonni,
        Khim,
        Herta,
        Gehraz,
        Sogolon,
        Kihm,
        Odurra,
        Timera,
        Abasi,
        Sunspear,
        SunspearOfficer,
        Dzajo,
        ShoreWatcher,
        YoungChild,
        IstaniNoble,
        IstaniCommoner,
        MonkSutoni,
        Hagon,
        SunspearQuartermaster,
        SunspearCaster,
        Kina,
        ElderSuhl,
        Kormir,
        DzabelLandGuardian,
        TheDrought,
        CrackedMesa,
        StoneShardCrag,
        BloodCowlHeket,
        BlueTongueHeket,
        StoneaxeHeket,
        BeastSwornHeket,
        SteelfangDrake,
        KuskaleBlighter,
        RidgebackKuskale,
        KuskaleLasher,
        FrigidKuskale,
        Droughtling,
        XunlaiChest,
        CommanderWerishakul,
        MidshipmanBennis,
        AdmiralKaya,
        CorsairWizard,
        CorsairBlackhand,
        CorsairCook,
        CorsairBosun,
        CorsairRaider,
        CorsairParagon,
        CorsairMindReader,
        CorsairDoctor,
        CorsairWeaponsMaster,
        CorsairGrappler,
        CorsairAdmiral,
        CorsairSeer,
        CorsairFlogger,
        CorsairReefFinder,
        CorsairMedic,
        CorsairThug,
        CorsairLookout,
        CorsairMarauder,
        CorsairCaptain,
        CorsairCutthroat,
        CorsairBerserker,
        CorsairCommandant,
        Corsair,
        GatekeeperKahno,
        UnluckySimon,
        CorsairWarrior,
        IronhookHube,
        OneEyedRugger,
        OrderOfWhispers,
        ColonelChaklin,
        ColonelCusto,
        CorporalLuluh,
        AcolyteofDwayna,
        GeneralKahyet,
        CaptainBesuz,
        DreamerHahla,
        KournanSpotter,
        KournanEngineer,
        KournanSeer,
        KournanOppressor,
        KournanScribe,
        KournanPriest,
        KournanGuard,
        KournanBowman,
        KournanZealot,
        KournanPhalanx,
        KournanFieldCommander,
        KournanChild,
        KournanNoble,
        KournanPeasant,
        WanderingPriest,
        Ashnod,
        Raleva,
        HarbingerOfTwilight,
        RestlessDead,
        RelentlessCorpse,
        GhostlySunspearCommander,
        Kahdash,
        VabbianGuard,
        VabbianChild,
        VabbianNoble,
        RoyalChefHatundo,
        VabbianMerchant,
        SpiritOfInfuriatingHeat,
        SpiritOfToxicity,
        SpiritOfFury,
        AlbinoRat,
        WhiteCrab,
        BlackWolf,
        WhiteWolf,
        MountainEagle,
        PolarBear,
        WhiteMoa,
        Rabbit,
        ArcticWolf,
        Stonewolf,
        Vekk,
        OgdenStonehealer,
        Livia,
        Xandra,
        Jora,
        Bartholos,
        ShiningBladeCaster,
        KilroyStonekin,
        DwarvenMiner,
        WildermWrathspew,
        FlanussBroadwing,
        MobrinLordOfTheMarsh,
        PywattTheSwift,
        BrynnEarthporter,
        KraitHypnoss,
        KraitArcanoss,
        KraitDevouss,
        KraitNecross,
        KraitNeoss,
        SavageOakheart,
        SkelkAfflictor,
        SkelkScourger,
        SkelkReaper,
        Angorodon,
        Ferothrax,
        Ceratadon,
        Tyrannus,
        Raptor,
        AgariTlamatini,
        AgariAmini,
        AgariNahualli,
        AgariCuicani,
        Bloodweaver,
        Lifeweaver,
        Venomweaver,
        CloudtouchedSimian,
        RedhandSimian,
        QuetzalSly,
        QuetzalDark,
        QuetzalStark,
        QuetzalKeen,
        SifShadowhunter,
        NornCommoner,
        OlafOlafson,
        GunnarPoundfist,
        NornGuard,
        NornWarrior,
        Eyja,
        NornTrader,
        NornWeaponsmith,
        NornElder,
        GlacialGriffon,
        SavageNornbear,
        InscribedEttin,
        NulfastuEarthbound,
        MyishLadyOfTheLake,
        Whiteout,
        AvarrTheFallen,
        ModniirPriest,
        ModniirBerserker,
        ModniirHunter,
        Avalanche,
        FrozenElemental,
        ChillingWisp,
        JotunSkullsmasher,
        JotunMindbreaker,
        JotunBladeturner,
        JotunBloodcurdler,
        BerserkingWendigo,
        BerserkingAuroch,
        BerserkingMinotaur,
        BerserkingBison,
        MountainPinesoul,
        MountainAloe,
        SpectralVaettir,
        FrostWurm,
        CharrProphet,
        FronisIrontoe,
        StoneSummitRanger,
        StoneSummitHealer,
        StoneSummitCrusher,
        AsuranMaterialTrader,
        Lork,
        Gadd,
        PurifierKreweMember,
        Blorf,
        AsuranElder,
        AsuranRuneTrader,
        Asuran,
        AsuranChild,
        Fonk,
        EnchantedScythe,
        EnchantedShield,
        DredgeCaster,
        BloodthirstIncubus,
        CryptwingIncubus,
        StormcloudIncubus,
        SkelkSlasher,
        SkelkCorrupter,
        SkelkRampager,
        EnchantedAxe,
        ShimmeringOoze,
        OminousOoze,
        EarthboundOoze,
        CorruptedAloe,
        FungalBloom,
        InscribedGuardian,
        FragmentOfAntiquities,
        RemnantOfAntiquities,
        RegentOfIce,
        ChromaticDrake,
        TerrorbondDryder,
        DreadgazeDryder,
        BloodtaintDryder,
        SoulfireDryder,
        ShatteredElemental,
        WhirlingWisp,
        IcyStalagmite,
        ShadowVaettir,
        ScourgeVaettir,
        MistVaettir,
        CursedBrigand,
        DamnedCrewman,
        FendiNin,
        SoulOfFendiNin,
        PirateGhost,
        CryptWraith,
        ShockPhantom,
        SkeletonIllusionist,
        SkeletonWizard,
        SkeletalHound,
        SkeletonPriest,
        SkeletonArcher,
        DecayedDragon,
        ZombieBrute,
        ZombieNecromancer,
        ChainedCleric,
        WintersdayMoa,
        BlessedSnowman,
        CordialSnowman,
        PiousSnowman,
        AngrySnowman,
        JackFrost,
        ValgarTempestcrafter,
        NicholasSandford,
        ProfessorYakkington,
        PinkDyeVendor,
        Zenjal,
        LieutenantLangmar,
        BlazefiendGriefblade,
        CharrStalker,
        CharrFireCaller,
        ForemanTheCrier,
        Salma,
        ScoutMelthoran,
        ShiningBladeRecruit,
        CharmingPeacekeeper,
        PeacekeeperFirebrand,
        DivinePeacekeeper,
        PeacekeeperGoon,
        PeacekeeperMarksman,
        PeacekeeperClairvoyant,
        PeacekeeperMentor,
        InsatiableVakar,
        WhiteMantleNecromancer,
        MinistryOfPurity,
        Julyia,
        Narcissia,
        ZenSiert,
        VincentEvan,
        CassieSanti,
        DirkShadowrise,
        LuzyFiera,
        RuneTrader,
        CraftingMaterialTrader,
        RareMaterialTrader,
        DyeTrader,
        ScrollTrader,
        Pudash,
        Blenkeh,
        MotokoKai,
        ErrolHyl,
        Merchant,
        Weaponsmith,
        SkillTrainer,
        Dahlia,
        RedemptorFrohs,
        AuroraAllesandra,
        Hinata,
        LuluXan,
        Bellicus,
        FestivalHatKeeper,
        GuildEmblemer,
        Tannaros,
        Disenmaedel,
        KahXan,
        Lonai,
        Koss,
        Dunkoro,
        Smuggler,
        Dalzid,
        Burreh,
        Benera,
        Megundeh,
        Shausha,
        Ahamid,
        Stasheh,
        Marlani,
        Sinbi,
        Kerendu,
        Nerashi,
        VeldtBeetleLance,
        VeldtNephila,
        VeldtBeetleQueen,
        BladedVeldtTermite,
        RampagingNtouka,
        CrestedNtoukaBird,
        KournanEliteZealot,
        KournanEliteSpear,
        KournanEliteGuard,
        KournanEliteScribe,
        SpiritofShelter,
        AdmiralKantoh,
        MirzaVeldrunner,
        CanthanFarmer,
        CorsairTorturer,
        CorsairLieutenant,
        CorsairWindMaster,
        SpiritOfVampirism,
        SpiritOfSuffering,
        SpiritOfHate,
        SpiritOfAnger,
        TuskedHunter,
        TuskedHowler,
        ZhedShadowhoof,
        KournanTrader,
        KournanWeaponsmith,
        VeldrunnerCentaur,
        KournanTaskmaster,
        TaskmasterSadiBelai,
        TaskmasterVanahk,
        OverseerHaubeh,
        OverseerBoktek,
        TaskmasterSuli,
        KehmaktheTranquil,
        GeneralBayel,
        FocusofHanaku,
        SpiritofDisenchantment,
        VampiricHorror,
        DragonMoss,
        SpiritofDissonance,
        SkreeGriffin,
        SkreeTracker,
        SkreeSinger,
        Lioness,
        Kehanni,
        ScytheclawBehemoth,
        BehemothGravebane,
        RockBeetle,
        RainBeetle,
        MargoniteSorcerer,
        MargoniteSeer,
        HajokEarthguardian,
        MargoniteCleric,
        TaintheCorrupter,
        SkreeRaider,
        MakdehtheAggravating,
        MargoniteWarlock,
        MargoniteExecutioner,
        MargoniteAscendant,
        LushivahrtheInvoker,
        MargoniteReaper,
        CorporalSuli,
        LieutenantVanahk,
        Lion,
        SpiritofFavorableWinds,
        MirageIboga,
        StormJacaranda,
        EnchantedBrambles,
        WhistlingThornbrush,
        MargoniteBowmaster,
        VabbianDyeTrader,
        VabbianWeaponsmith,
        ChumabthePrideful,
        YameshMindclouder,
        JahaiRat,
        BoltenLargebelly,
        VabbianPriest,
        GeneralMorgahn,
        VabbianScholar,
        TheGreatZehtuka,
        VabbiGuardCaptain,
        PrinceAhmturtheMighty,
        LieutenantMurunda,
        PrinceBokkatheMagnificent,
        Goren,
        PrinceMehtutheWise,
        VabbianBlacksmith,
        YammironEtherLord,
        RoaringEther,
        SapphireDjinn,
        RubyDjinn,
        CobaltMokele,
        JisholDarksong,
        CobaltShrieker,
        Norgu,
        StoneSummitDark,
        MargoniteParagonBoss,
        LyssanPriest,
        DiscipleOfSecrets,
        Varesh,
        MargoniteMonkBoss,
        GeneralDoriah,
        GeneralTirraj,
        JarimiyaTheUnmerciful,
        RiktundTheVicious,
        SetikorFireflower,
        MessengerOfLyssa,
        VabbianGuardCaptain,
        ElderJonah,
        Lormeh,
        MadnessTitan,
        ShadowRanger,
        ShadowMonk,
        ShadowMesmer,
        GravenMonolith,
        Harbinger,
        SpiritOfSeborhin,
        HorticulturistHinon,
        IstaniPeasant,
        PriestZeinZuu,
        ScribeWensal,
        CommanderChutal,
        ZealotSheoli,
        NtoukaBird,
        TormentedLand,
        SergeantBehnwa,
        ElderHyena,
        KorrLivingFlame,
        ImmolatedDjinn,
        AscensionPilgrim,
        DynasticSpirit,
        DiamondDjinn,
        VahlenTheSilent,
        AwakenedAcolyte,
        AwakenedDefiler,
        AwakenedDuneCarver,
        AwakenedThoughtLeech,
        CarvenEffigy,
        AwakenedGrayGiant,
        SpiritOfQuicksand,
        ShamblingMesa,
        SandstormCrag,
        ShahaitheCunning,
        PalawaJoko,
        QueenAijundu,
        AwakenedBlademaster,
        AwakenedCavalier,
        ChakehTheLonely,
        AvahTheCrafty,
        ChunduTheMeek,
        AmindTheBitter,
        NehmakTheUnpleasant,
        JununduYoung,
        SahlahjarTheDead,
        MinionOfJoko,
        RavenousMandragor,
        MandragorTerror,
        MandragorSandDevil,
        GhostlyScout,
        BladedDuneTermite,
        DuneBeetleLance,
        DuneSpider,
        AwakenedHead,
        UndeadGeneral,
        Chirah,
        AwakenedMonk,
        AwakenedMesmer,
        AwakenedDervish,
        Awata,
        Thrall,
        GhostlyPriest,
        PrimevalKingJahnus,
        NomadGiant,
        KoahmTheWeary,
        SadisticGiant,
        UhiwiTheSmoky,
        ElderSiegeWurm,
        AmireshThePious,
        HordeofDarkness,
        DesertWurm,
        BladeOfCorruption,
        CaptainMehhan,
        AwakenedParagon,
        TormentedSoul,
        SecretKeeper,
        WordOfMadness,
        RainOfTerror,
        ShadowOfFear,
        ScytheOfChaos,
        SpearOfTorment,
        HeraldOfNightmares,
        ArmOfInsanity,
        OnslaughtOfTerror,
        ZombieMonk,
        ChimorTheLightblooded,
        ScoutAhktum,
        Thenemi,
        GarfazSteelfur,
        CaptainYithlis,
        Igraine,
        TheLost,
        AbaddonsAdjutant,
        EmissaryOfDhuum,
        TerrorwebDryder,
        Rukkassa,
        TorturewebDryder,
        LostSoul,
        Apostate,
        StormOfAnguish,
        ShriekerOfDread,
        ShirokenElementalist,
        PainTitan,
        ShirokenMonk,
        ShirokenMesmer,
        TitanAbomination,
        BoundTiendi,
        BoundKaichen,
        WrathfulStorm,
        GraspOfInsanity,
        TormentClaw,
        BoundHaoLi,
        IgnisCruor,
        ShadowBeast,
        CreoVulnero,
        PortalWraith,
        ArmageddonLord,
        JoyousSoul,
        MagridTheSly,
        Zenmai,
        Abaddon,
        CorsairRunner,
        Abyssal,
        GhostChampion,
        ShadowWarrior,
        ShadowElemental,
        SkeletalEtherBreaker,
        SkeletalIcehand,
        SkeletalBond,
        SkeletalBerserker,
        SpiritShepherd,
        SpiritWood,
        SpiritofNaturesRenewal,
        RockBorerWorm,
        SpiritofExtinction,
        ArmoredCaveSpider,
        Banshee,
        ForestGriffon,
        SkeletalImpaler,
        FlamingScepterMage,
        EternalForgemaster,
        EternalRanger,
        SeedofCorruption,
        DoubtersDryder,
        ObsidianFurnaceDrake,
        SmokeWalker,
        InfernalWurm,
        AncientSkale,
        DragonLich,
        VisionOfDespair,
        SaevioProelium,
        BringerOfDeceit,
        SpiritOfQuickeningZephyr,
        FlameOfFervor,
        WaterBornTitan,
        WildGrowth,
        SeedOfSuffering,
        EarthBornTitan,
        WindBornTitan,
        RottingTitan,
        ForgottenIllusionist,
        WieshurTheInspiring,
        HautohThePilferer,
        LetumContineo,
        SecurisPhasmatis,
        Razakel,
        BindingGuardian,
        Razah,
        MargoniteAnurTuk,
        MargoniteAnurSu,
        MargoniteAnurDabi,
        MargoniteAnurVu,
        MargoniteAnurKi,
        MargoniteAnurRund,
        WindOfDarkness,
        ChillOfDarkness,
        ClawOfDarkness,
        ThoughtOfDarkness,
        CurseOfDarkness,
        ScourgeOfDarkness,
        MargoniteAnurRuk,
        MargoniteAnurMank,
        HeartTormentor,
        WaterTormentor,
        SpiritTormentor,
        SanityTormentor,
        MindTormentor,
        SoulTormentor,
        FleshTormentor,
        MargoniteAnurKaya,
        StygianBrute,
        StygianGolem,
        ShaunurTheDivine,
        LordJadoth,
        TurepMakerOfOrphans,
        StygianHunger,
        SpiritOfTruth,
        TheDarkness,
        RageTitan,
        DespairTitan,
        GreaterDreamRider,
        AnguishTitan,
        MiseryTitan,
        FuryTitan,
        DementiaTitan,
        BanishedDreamRider,
        ChaosWurm,
        GuardianOfKomalie,
        TheFury,
        StygianHorror,
        StygianFiend,
        StygianUnderlord,
        StygianLord,
        FortuneTellerGhost,
        CharrRitualist,
        SiegeDevourer,
        MantidDigger,
        MantidNymph,
        HoraiWingshielder,
        MantidQueen,
        CharrHexreaper,
        CharrSeeker,
        CharrAxemaster,
        CharrFlameshielder,
        CharrDominator,
        CharrBlademaster,
        MolotovRocktail,
        ArmoredSaurus,
        GronFierceclaw,
        BonworFierceblade,
        SeerFiercereign,
        CowlFiercetongue,
        RoanFierceheart,
        CharrWardkeeper,
        EliteCharrGuard,
        CapturedVanguardSoldier,
        HierophantBurntsoul,
        CharrAvenger,
        DestroyerofThoughts,
        DestroyerofDeeds,
        DestroyerofHordes,
        DestroyerofBones,
        DestroyerofSinew,
        CaptainLangmar,
        VileMandragor,
        MandragorSmokeDevil,
        MandragorDustDevil,
        DeadlySkale,
        CharrMender,
        ThraexisThundermaw,
        KatyeBloodburner,
        AnmattheTrickster,
        GrawlChampion,
        GrawlDarkPriest,
        SpiritofPreservation,
        TumbledElemental,
        FlowstoneElemental,
        MagmaBlister,
        GrawlDemagogue,
        BurningSpirit,
        IgnustheEternal,
        SwarmofBees,
        MergoyleWavebreaker,
        SnowEttin,
        IceGolem,
        WhiskarFeatherstorm,
        Snow,
        MasterSeekerNathaniel,
        SnowEttinBoss,
        ShiverpeakProtector,
        ShiverpeakWarrior,
        ShiverpeakLongbow,
        MoroStormcalf,
        JoloLighthaunch,
        SnowWolf,
        FrostfireDryder,
        StoneSummitSage,
        DolyakRider,
        StoneSummitHowler,
        StoneSummitScout,
        ShalisIronmantle,
        SummitAxeWielder,
        SarisHeadstaver,
        TorisStonehammer,
        TheJudge,
        BoulderElemental,
        StoneFury,
        CharrMartyr,
        CharrFlameWielder,
        CharrMindSpark,
        CharrAshWalker,
        StormRider,
        FlashGargoyle,
        AscalonWarrior,
        ResurrectGargoyle,
        WhiptailDevourer,
        MalletRunecolumn,
        CrownofThorns,
        DrimCindershot,
        AscalonianHunter,
        MirashDreambreaker,
        AscalonianCrafter,
        AscalonianWeaponsmith,
        AscalonianMerchant,
        Viggo,
        GorgaanHatemonger,
        PlagueDevourer,
        FlintTouchstone,
        Grawl,
        GrawlUlodyte,
        Renegade,
        RenegadeElementalist,
        CrimsonDevourer,
        LarrkEtherburn,
        AscalonianMage,
        PriestessRashena,
        IgnisPhanaura,
        AscalonStriker,
        RynCursewing,
        BouladthePerverse,
        SkeletonSorcerer,
        ZombieWarlock,
        SkeletonMonk,
        SkeletonMesmer,
        Snakebite,
        GrimPeacekeeper,
        PeacekeeperSibyl,
        AncientOakheart,
        ReedStalker,
        SpinedAloe,
        SilentPeacekeeper,
        SkeletonBowmaster,
        BogSkaleBlighter,
        AbbotRamoth,
        WinglordCaromi,
        CaromiTenguElite,
        PeacekeeperEnforcer,
        ForestMinotaur,
        KrytanCollector,
        FogNightmare,
        PeacekeeperHuntsman,
        FenTroll,
        Bandit,
        Galrath,
        ApprenticeofVerata,
        ShepherdofVerata,
        EyesofVerata,
        SageofVerata,
        DamnedCleric,
        Wraith,
        RottingDragon,
        Rotscale,
        NecridHorseman,
        FrynRageflame,
        ArkhelHavenwood,
        EdibboKepkep,
        HailBlackice,
        RuneEthercrash,
        DarkTitan,
        TitansHeart,
        TitansMalice,
        IcyBrute,
        RykArrowwing,
        SyrHonorcrest,
        FrostTitan,
        EvirsoSectus,
    };


    public static bool TryParse(int id, out Npc npc)
    {
        npc = Npcs.Where(n => n.Ids.Any(nId => nId == id)).FirstOrDefault()!;
        if (npc is null)
        {
            return false;
        }

        return true;
    }
    public static bool TryParse(string name, out Npc npc)
    {
        npc = Npcs.Where(n => n.Name == name).FirstOrDefault()!;
        if (npc is null)
        {
            return false;
        }

        return true;
    }
    public static Npc Parse(int id)
    {
        if (TryParse(id, out var npc) is false)
        {
            throw new InvalidOperationException($"Could not find an npc with id {id}");
        }

        return npc;
    }
    public static Npc Parse(string name)
    {
        if (TryParse(name, out var npc) is false)
        {
            throw new InvalidOperationException($"Could not find an npc with name {name}");
        }

        return npc;
    }

    public int[] Ids { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string WikiUrl { get; private set; } = string.Empty;

    private Npc()
    {
    }
}
