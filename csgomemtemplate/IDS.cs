﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skinchanger
{
    public class IDS
    {



        public class saved
        {
            public int weaponid, skinid;
            public float wear;
        }

        public enum AllWeaponsIDs
        {
            WEAPON_AWP = 9,
            WEAPON_G3SG1 = 11,
            WEAPON_SCAR20 = 38,
            WEAPON_SSG = 40,
            WEAPON_AK47 = 7,
            WEAPON_AUG = 8,
            WEAPON_FAMAS = 10,
            WEAPON_GALILAR = 13,
            WEAPON_M4A1 = 60,
            WEAPON_M4A4 = 16,
            WEAPON_SG553 = 39,
            WEAPON_USP = 61,
            WEAPON_REVOLVER = 64,
            WEAPON_CZ75 = 63,
            WEAPON_DEAGLE = 1,
            WEAPON_BERETTAS = 2,
            WEAPON_FIVESEVEN = 3,
            WEAPON_GLOCK = 4,
            WEAPON_P2000 = 32,
            WEAPON_P250 = 36,
            WEAPON_TEC9 = 30,
            WEAPON_MAC10 = 17,
            WEAPON_MP7 = 33,
            WEAPON_MP9 = 34,
            WEAPON_MP5 = 23,
            WEAPON_PPBIZON = 26,
            WEAPON_P90 = 19,
            WEAPON_UMP45 = 24,
            WEAPON_MAG7 = 27,
            WEAPON_NOVA = 35,
            WEAPON_SAWEDOFF = 29,
            WEAPON_XM1014 = 25,
            WEAPON_M249 = 14,
            WEAPON_NEGEV = 28,

            WEAPON_KNIFE_T = 59,
            WEAPON_KNIFE_CT = 42,
            WEAPON_KNIFE_KARAM = 507,
            WEAPON_KNIFE_BAYONET = 500,
            WEAPON_KNIFE_CLASSIC = 503,
            WEAPON_KNIFE_FLIP = 505,
            WEAPON_KNIFE_GUT = 506,
            WEAPON_KNIFE_M9 = 508,
            WEAPON_KNIFE_HUNTSMAN = 509,
            WEAPON_KNIFE_FALCHION = 512,
            WEAPON_KNIFE_BOWIE = 514,
            WEAPON_KNIFE_BUTTERFLY = 515,
            WEAPON_KNIFE_DAGGERS = 516,
            WEAPON_KNIFE_PARACORD = 517,
            WEAPON_KNIFE_SURVIVAL = 518,
            WEAPON_KNIFE_URSUS = 519,
            WEAPON_KNIFE_NAVAJA = 520,
            WEAPON_KNIFE_NOMAD = 521,
            WEAPON_KNIFE_STILETTO = 522,
            WEAPON_KNIFE_TALON = 523,
            WEAPON_KNIFE_SKELETON = 525,
        };

        public enum AllSkinIDs // did this manually,  you can add the rest of the skins via description 
        {
            Groundwater = 2,
            Candy_Apple = 3,
            Forest_DDPAT = 5,
            Arctic_Camo = 6,
            Desert_Storm = 8,
            Bengal_Tiger = 9,
            Copperhead = 10,
            Skulls = 11,
            Crimson_Web = 12,
            Blue_Streak = 13,
            Red_Laminate = 14,
            Gunsmoke = 15,
            Jungle_Tiger = 16,
            Urban_DDPAT = 17,
            Virus = 20,
            Granite_Marbleized = 21,
            Contrast_Spray = 22,
            Forest_Leaves = 25,
            Lichen_Dashed = 26,
            Bone_Mask = 27,
            Anodized_Navy = 28,
            Snake_Camo = 30,
            Silver = 32,
            Hot_Rod = 33,
            Metallic_DDPAT = 34,
            Ossified = 36,
            Blaze = 37,
            Fade = 38,
            Bulldozer = 39,
            Night = 40,
            Copper = 41,
            Blue_Steel = 42,
            Stained = 43,
            Case_Hardened = 44,
            Contractor = 46,
            Colony = 47,
            Dragon_Tattoo = 48,
            Lightning_Strike = 51,
            Slaughter = 59,
            Dark_Water = 60,
            Hypnotic = 61,
            Bloomstick = 62,
            Cold_Blooded = 67,
            Carbon_Fiber = 70,
            Scorpion = 71,
            Safari_Mesh = 72,
            Wings = 73,
            Polar_Camo = 74,
            Blizzard_Marbleized = 75,
            Winter_Forest = 76,
            Boreal_Forest = 77,
            Forest_Night = 78,
            Orange_DDPAT = 83,
            Pink_DDPAT = 84,
            Mudder = 90,
            Cyanospatter = 92,
            Caramel = 93,
            Grassland = 95,
            Blue_Spruce = 96,
            Ultraviolet = 98,
            Sand_Dune = 99,
            Storm = 100,
            Tornado = 101,
            Whiteout = 102,
            Grassland_Leaves = 104,
            Polar_Mesh = 107,
            Condemned = 110,
            Glacier_Mesh = 111,
            Sand_Mesh = 116,
            Sage_Spray = 119,
            Jungle_Spray = 122,
            Sand_Spray = 124,
            Urban_Perforated = 135,
            Waves_Perforated = 136,
            Orange_Peel = 141,
            Urban_Masked = 143,
            Jungle_Dashed = 147,
            Sand_Dashed = 148,
            Urban_Dashed = 149,
            Jungle = 151,
            Demolition = 153,
            Afterimage = 154,
            Bullet_Rain = 155,
            Death_by_Kitty = 156,
            Palm = 157,
            Walnut = 158,
            Brass = 159,
            Splash = 162,
            Modern_Hunter = 164,
            Splash_Jam = 165,
            Blaze_Orange = 166,
            Radiation_Hazard = 167,
            Nuclear_Threat = 168,
            Fallout_Warning = 169,
            Predator = 170,
            Irradiated_Alert = 171,
            Black_Laminate = 172,
            BOOM = 174,
            Scorched = 175,
            Faded_Zebra = 176,



            Memento = 177,
            Doomkitty = 178,

            Fire_Serpent = 180,
            Corticera = 181,
            Emerald_Dragon = 182,
            Overgrowth = 183,

            Golden_Koi = 185,
            Wave_Spray = 186,
            Zirka = 187,
            Graven = 188,
            Bright_Water = 189,
            Black_Limba = 190,
            Tempest = 191,
            Shattered = 192,
            Bone_Pile = 193,
            Spitfire = 194,
            Demeter = 195,
            Emerald = 196,
            Hazard = 198,
            Dry_Season = 199,
            Mayan_Dreams = 200,

            Jungle_DDPAT = 202,
            Rust_Coat = 203,
            Mosaico = 204,


            Facets = 207,


            Anodized_Gunmetal = 210,
            Ocean_Foam = 211,
            Graphite = 212,
            X_Ray = 215,
            Blue_Titanium = 216,
            Blood_Tiger = 217,
            Hexane = 218,
            Hive = 219,
            Hemoglobin = 220,
            Serum = 221,
            Blood_in_the_Water = 222,
            Nightshade = 223,
            Water_Sigil = 224,
            Ghost_Camo = 225,
            Blue_Laminate = 226,
            Electric_Hive = 227,
            Blind_Spot = 228,
            Azure_Zebra = 229,
            Steel_Disruption = 230,
            Cobalt_Disruption = 231,
            Tropical_Storm = 233,
            Ash_Wood = 234,
            VariCamo = 235,
            Night_Ops = 236,
            Urban_Rubble = 237,
            VariCamo_Blue = 238,
            CaliCamo = 240,
            Hunting_Blind = 241,
            Army_Mesh = 242,
            Gator_Mesh = 243,
            Teardown = 244,
            Army_Recon = 245,
            Amber_Fade = 246,
            Damascus_Steel = 247,
            Red_Quartz = 248,
            Cobalt_Quartz = 249,
            Full_Stop = 250,
            Pit_Viper = 251,
            Silver_Quartz = 252,
            Acid_Fade = 253,
            Nitro = 254,
            Asiimov = 255,
            The_Kraken = 256,
            Guardian = 257,
            Mehndi = 258,
            Redline = 259,
            Pulse = 260,
            Marina = 261,
            Rose_Iron = 262,
            Rising_Skull = 263,
            Sandstorm = 264,
            Kami = 265,
            Magma = 266,
            Cobalt_Halftone = 267,
            Tread_Plate = 268,
            The_Fuschia_Is_Now = 269,
            Victoria = 270,
            Undertow = 271,
            Titanium_Bit = 272,
            Heirloom = 273,
            Copper_Galaxy = 274,
            Red_FragCam = 275,
            Panther = 276,
            Stainless = 277,


            Blue_Fissure = 278,

            Chameleon = 280,
            Corporal = 281,

            Trigon = 283,
            Heat = 284,
            Terrain = 285,
            Antique = 286,

            Sergeant = 288,

            Heaven_Guard = 291,
            Death_Rattle = 293,
            Green_Apple = 294,
            Franklin = 295,
            Meteorite = 296,
            Tuxedo = 297,
            Army_Sheen = 298,
            Caged_Steel = 299,
            Emerald_Pinstripe = 300,
            Atomic_Alloy = 301,
            Vulcan = 302,
            Isaac = 303,
            Slashed = 304,
            Torque = 305,

            Retribution = 307,

            Howl = 309,
            Curse = 310,
            Desert_Warfare = 311,
            Cyrex = 312,
            Orion = 313,

            Poison_Dart = 315,
            Jaguar = 316,
            Bratatat = 317,
            Road_Rash = 318,
            Detour = 319,
            Red_Python = 320,
            Master_Piece = 321,


            Chalice = 325,
            Knight = 326,
            Chainmail = 327,
            Hand_Cannon = 328,
            Dark_Age = 329,
            Briar = 330,
            Royal_Blue = 332,
            Indigo = 333,
            Twist = 334,
            Module = 335,
            Desert_Strike = 336,
            Tatter = 337,

            Caiman = 339,
            Jet_Set = 340,
            First_Class = 341,
            Leather = 342,
            Commuter = 343,
            Dragon_Lore = 344,

            Coach_Class = 346,
            Pilot = 347,
            Red_Leather = 348,
            Osiris = 349,
            Tigris = 350,
            Conspiracy = 351,
            Fowl_Play = 352,
            Water_Elemental = 353,
            Urban_Hazard = 354,

            Koi = 356,
            Ivory = 357,
            Supernova = 358,
            Asiimovv = 359,

            Abyss = 361,
            Labyrinth = 362,
            Traveler = 363,
            Business_Class = 364,
            Olive_Plaid = 365,
            Green_Plaid = 366,
            Reactor = 367,
            Setting_Sun = 368,
            Nuclear_Waste = 369,
            Bone_Machine = 370,
            Styx = 371,
            Nuclear_Garden = 372,
            Contamination = 373,
            Toxic = 374,
            Radiation_Hazardd = 375,
            Chemical_Green = 376,
            Hot_Shot = 377,
            Fallout_Warningg = 378,
            Cerberus = 379,
            Wasteland_Rebel = 380

        };
    }
}
