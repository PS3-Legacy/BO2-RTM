using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    //BO 2 Offsets Bytes Codding By BISOON I hope it's helpful
    class BIS
    {
        public static List<string> MyNames()
        {
            List<string> Myname = new List<string>();
            Myname.Add("BISOON");
            Myname.Add("i1WLz_");
            Myname.Add("Hnyw");
            Myname.Add("xiKrKz");
            Myname.Add("xiWLz");
            Myname.Add("MHWF");
            return Myname;
        }
        public class NonHost
        {
            #region NonHost Bytes
            public static byte[] VSATOn = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            public static byte[] VSATOff = new byte[] { 0x40, 0x81, 0x00, 0x44 };
            public static byte[] UAVOn = new byte[] { 0x2C, 0x03, 0x00, 0x01 };
            public static byte[] UAVOff = new byte[] { 0x2C, 0x03, 0x00, 0x00 };
            public static byte[] LaserOn = new byte[] { 0x2C, 0x03, 0x00, 0x01 };
            public static byte[] LaserOff = new byte[] { 0x2C, 0x03, 0x00, 0x00 };
            public static byte[] SteadyAimOn = new byte[] { 0x2C, 0x04, 0x00, 0x00 };
            public static byte[] SteadyAimOff = new byte[] { 0x2C, 0x04, 0x00, 0x02 };
            public static byte[] RedBoxOffset1On = new byte[] { 0x38, 0x60, 0x00, 0x01 };
            public static byte[] RedBoxOffset2On = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            public static byte[] RedBoxOffset1Off = new byte[] { 0x38, 0x60, 0x00, 0x00 };
            public static byte[] RedBoxOffset2Off = new byte[] { 0x41, 0x81, 0x01, 0x0C };
            public static byte[] BigNameOn = new byte[] { 0x3F, 0xFF, 0xFF, 0x00 };
            public static byte[] BigNameOff = new byte[] { 0x3f, 0x26, 0x66, 0x66 };
            public static byte[] WallHackOffset1On = new byte[] { 0x00 };
            public static byte[] WallHackOffset1Off = new byte[] { 0x01 };
            public static byte[] WallHackOffset2On = new byte[] { 0x38, 0xC0, 0xFF, 0xFF };
            public static byte[] WallHackOffset2Off = new byte[] { 0x63, 0x26, 0x00, 0x00 };
            public static byte[] Unlock10Classes = new byte[] { 0x44, 0x8D, 0x88, 0x11, 0x33, 0x62, 0x44, 0xAC };
            public static byte[] FloatingBodiesOn = new byte[] { 0x43, 0x48 };
            public static byte[] FloatingBodiesOff = new byte[] { 0xC4, 0x48 };
            public static byte[] TargetFinderOn = new byte[] { 0x01 };
            public static byte[] TargetFinderOff = new byte[] { 0x00 };
            public static byte[] RotateMapOn = new byte[] { 0x46, 0xE6, 0x00, 0x00 };
            public static byte[] RotateMapOff = new byte[] { 0x41, 0x20, 0x00, 0x00 };
            public static byte[] SplitScreenOn = new byte[] { 0x01 };
            public static byte[] SplitScreenOff = new byte[] { 0x00 };
            #endregion
            public class SkyColor
            {
                #region  SkyColor Bytes
                public static byte[] Black = new byte[] { 0xFF, 0x80 };
                public static byte[] Bright = new byte[] { 0x5F, 0x80 };
                public static byte[] Fog = new byte[] { 0x3D, 0x80 };
                public static byte[] Shine = new byte[] { 0x3E, 0x80 };
                public static byte[] VeryLight = new byte[] { 0x5F, 0xFF };
                public static byte[] Defualt = new byte[] { 0x3F, 0x80 };
                #endregion
            }
            public class BodyColor
            {
                #region BodyColor
                public static byte[] Green = new byte[] { 0x3F, 0xFF, 0x00, 0x00, 0x3F, 0x00 };
                public static byte[] Light = new byte[] { 0x4F, 0x80, 0x00, 0x00, 0x4F, 0x80, 0x00, 0x00 };
                public static byte[] StrongRed = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                public static byte[] LightGreen = new byte[] { 0x6F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 };
                public static byte[] Normal = new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 };
                public static byte[] Blue = new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x6F, 0x80, 0x00 };
                public static byte[] LightBlue = new byte[] { 0x6F, 0x80, 0x00, 0x00, 0x6F, 0x80, 0x00 };
                public static byte[] LightPurple = new byte[] { 0x6F, 0x80, 0x00, 0x00, 0x4F, 0x80, 0x00 };
                public static byte[] Purple = new byte[] { 0x0F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00 };
                public static byte[] Yellow = new byte[] { 0x3F, 0xFF, 0x00, 0x00, 0x1F, 0x00, 0x00 };
                public static byte[] Pink = new byte[] { 0xfF, 0xFF, 0x00, 0x00, 0x3F, 0xFF, 0x00 };
                public static byte[] LightPink = new byte[] { 0x1F, 0xFF, 0x00, 0x00, 0x5F, 0xFF, 0x00 };
                public static byte[] Orange = new byte[] { 0x3F, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00 };
                public static byte[] Brown = new byte[] { 0x3F, 0x00, 0x00, 0x00, 0x3F, 0x00 };
                #endregion
            }
        }
       
        
        public class Client
        {
            public static byte[] GodModOn = new byte[] { 0x05 };
            public static byte[] GodModOff = new byte[] { 0x08 };
            public static byte[] VSATInGameOn = new byte[] { 0x0F };
            public static byte[] VSATInGameOff = new byte[] { 0x00 };
            public static byte[] AutoPronePlayerOn = new byte[] { 0x01 };
            public static byte[] AutoPronePlayerOff = new byte[] { 0x00 };
            public static byte[] PlayerSpeedOn = new byte[] { 0x40 };
            public static byte[] PlayerSpeedOff = new byte[] { 0x3F };
            public static byte[] ToggleLagOn = new byte[] { 0x00 };
            public static byte[] ToggleLagOff = new byte[] { 0x02 };
            public static byte[] AllPerksOn = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            public static byte[] AllPerksOff = new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01 };
            public static byte[] ThirdPersonPlayerOn = new byte[] { 0x01 };
            public static byte[] ThirdPersonPlayerOff = new byte[] { 0x00 };
            public static byte[] InvisiblePlayerOn = new byte[] { 0xB3 };
            public static byte[] InvisiblePlayerOff = new byte[] { 0x00 };
            public static byte[] ScoreStreakOn = new byte[] { 0x01 };
            public static byte[] ScoreStreakOff = new byte[] { 0x00 };
            public static byte[] RemoveScoreStreakOn = new byte[] { 0x00 };
            public static byte[] RemoveScoreStreakOff = new byte[] { 0x01 };
            public static byte[] BlackScreen1On = new byte[] { 0x00, 0x00 };
            public static byte[] BlackScreen2On = new byte[] { 0x01 };
            public static byte[] BlackScreen1Off = new byte[] { 0x40, 0xC0 };
            public static byte[] BlackScreen2Off = new byte[] { 0x00 };
            public static byte[] EMPOn = new byte[] { 0xE4 };
            public static byte[] EMPOff = new byte[] { 0x04 };
            public static byte[] NightVisionOn = new byte[] { 0x10 };
            public static byte[] NightVisionOff = new byte[] { 0x00 };
            public static byte[] SkipTimer = new byte[] { 0x00 };
            public static byte[] PoisonOn = new byte[] { 0x01 };
            public static byte[] PoisonOff = new byte[] { 0x00 };
            public static byte[] SkateModeOn = new byte[] { 0x01 };
            public static byte[] WeaponFuckedupOn = new byte[] { 0x40 };
            public static byte[] WeaponFuckedupOff = new byte[] { 0xE9 };
            public static byte[] JumperOn = new byte[] { 0x00 };
            public static byte[] JumperOff = new byte[] { 0x3F };
            public static byte[] SpawnPlayer = new byte[] { 0x00 };
            public static byte[] FreezeOn = new byte[] { 0x04 };
            public static byte[] NFreezeOn = new byte[] { 0xFF };
            public static byte[] FreezeOff = new byte[] { 0x00 };
            public static byte[] SvTeleportByte = { 0x00 };
            public static int[] Client_Index = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            public static int[] Weapon_Index = { 2, 4, 6, 8, 0x0a, 0x0c, 0x0e, 0x10, 0x14, 0x18, 0x1c, 0x20, 0x24, 0x28, 0x2C, 0x30, 0x40, 0x41, 0x42, 0x43, 0x4e, 0x4f, 0x50, 0x51, 0x52, 0x54, 0x55, 0x56, 0x57, 0x5b, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c };
            public static int[] Weapon_Index_RPC = { 2, 4, 6, 8, 10, 12, 14, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 53, 54, 55, 56, 58, 60, 62, 64, 65, 66, 67, 69, 71, 72, 74, 77, 78, 79, 80, 81, 82, 84, 85, 86, 87, 89, 90, 91 };
            public static byte[] LobbyWeapon_Index = { 0x02, 0x04, 0x06, 0x08, 0x0a, 0x0c, 0x0e, 0x10, 0x14, 0x18, 0x1C, 0x20, 0x24, 0x28, 0x2C, 0x30, 0x34, 0x35, 0x36, 0x37, 0x38, 0x3A, 0x3C, 0x3E, 0x40, 0x41, 0x42, 0x43, 0x4E, 0x4F, 0x50, 0x51, 0x52, 0x54, 0x55, 0x56, 0x59, 0x5A, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x68, 0x6A, 0x6B, 0x6C };
            public static string[] WeaponName_RPC = { "MP7", "PDW-57", "Vector-K10", "MSMC", "Chiqom", "Skorpian-EVO", "Peacekeeper", "MTAR",
                                                    "Type-25","SWAT","FAL","M27","SCAR","SMR","M8A1","AN-94","Remington","S12","KSG",
                                                    "M1216","MK-48","QBB-LSW","LSAT","HAMR","SVU-AS","DSR-50","Ballista","XPR50","KAP-40 DW",
                                                    "Tac-45 DW","Five-7 DW","Executioner DW","B23R DW","Five-Seven","Tac-45","B23R","Executioner","KAP-40","SMAW","FHJ-18",
                                                    "RPG","Combat-Knife","Assault-Shield","Crossbow","Ballistic-Knife"};
            public enum Weapons : int
            {
                Default_Weapon = 1,
                MP7 = 2,
                PDW57 = 4,
                Vector_K10 = 6,
                MSMC = 8,
                Chiqom = 10,
                Skorpian_EVO = 12,
                Peacekeeper = 14,
                MTAR = 16,
                Type_25 = 20,
                SWAT = 24,
                FAL = 28,
                M27 = 32,
                SCAR = 36,
                SMR = 40,
                M8A1 = 44,
                AN_94 = 48,
                Remington = 52,
                S12 = 53,
                KSG = 54,
                M1216 = 55,
                MK_48 = 56,
                QBB_LSW = 58,
                LSAT = 60,
                HAMR = 62,
                SVU_AS = 64,
                DSR_50 = 65,
                Ballista = 66,
                XPR50 = 67,
                KAP_40_DW = 69,
                Tac_45_DW = 71,
                Five_7_DW = 72,
                Executioner_DW = 74,
                B23R_DW = 77,
                Five_Seven = 78,
                Tac_45 = 79,
                B23R = 80,
                Executioner = 81,
                KAP_40 = 82,
                SMAW = 84,
                FHJ_18 = 85,
                RPG = 86,
                Combat_Knife = 87,
                Assault_Shield = 89,
                Crossbow = 90,
                Ballistic_Knife = 91
            }
            public class TeamBytes
            {
                public static byte[] Teams = { 0x01, 0x02, 0x09, 0x00 };
            }

            public class CamoByte
            {
                public static byte[] Camos = {0x00, 0x01, 0x02, 0x03,0x04,0x05,0x06,
                               0x07,0x08,0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10,
                               0x11,0x12,0x13,0x14,0x15,0x16,0x17,0x18,0x19,0x1A,0x1B,0x1C,0x1D,0x1E,0x1F,0x20,0x21,0x23,
                               0x24,0x25,0x26,0x27,0x28,0x29,0x2A,0x2B};
                public static byte[] RandomCamos = {0x00, 0x01, 0x02, 0x03,0x04,0x05,0x06,
                               0x07,0x08,0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10,
                               0x11,0x12,0x13,0x14,0x15,0x16,0x17,0x18,0x19,0x1A,0x1B,0x1C,0x1D,0x1E,0x1F,0x20,0x21,0x23,
                               0x24,0x25,0x26,0x27,0x28,0x29};

                public static string[] CamoString = { "None", "DEVGRU", "A TACS AU", "ERDL", "Siberia", "Choco", "Blue Tiger", "Bloodshot",
                                                        "Ghostex Delta 6", "Kryptek Typhon", "Carbon Fiber", "Cherry Blossom", "Art Of War",
                                                        "Ronin", "Skulls", "Gold", "Diamond", "Elite", "CE Digital", "Jungle Warfare", "Chamelion",
                                                        "Benjamins", "Dia De Muertos", "Graffiti", "Kawaii", "Party Rock", "Zombies", "Viper", "Bacon",
                                                        "Ghost", "Cyborg", "Dragon", "Aqua", "Breach", "Glam", "Rogue", "Pack A Punch", "Dead Man Hands",
                                                        "Beast", "Octane", "Weaponized 115" };
            }
            public class PlayerVision
            {
                public static byte[] Visions = { 0x00, 0x02, 0x04, 0x06, 0x0A, 0x0C, 0x0E, 0x10 };
            }
            public class PlayerStatus
            {
                public static byte[] Status = { 0x01, 0x00, 0x02, 0x03 };
            }
            public class PlayerModel
            {
                public static string[] Model = { "defaultactor", "german_shepherd", "german_shepherd_vest",
                                                   "german_shepherd_vest_black", "veh_t6_drone_overwatch_light",
                                                   "veh_t6_drone_tank", "veh_t6_drone_rcxd",
                                                   "veh_t6_drone_pegasus_mp"};
            }
        }

        public class Rank
        {
            public static uint[] RankByte = new uint[] { 
        0, 800, 0x76c, 0xce4, 0x14b4, 0x1edc, 0x2b5c, 0x3a34, 0x4b64, 0x5eec, 0x7594, 0x8f5c, 0xac44, 0xcc4c, 0xef74, 0x115bc, 
        0x13f24, 0x16bac, 0x19b54, 0x1ce1c, 0x20404, 0x23d0c, 0x27934, 0x2b87c, 0x2fae4, 0x3406c, 0x38914, 0x3d4dc, 0x423c4, 0x475cc, 0x4caf4, 0x524cc, 
        0x58354, 0x5e68c, 0x64e74, 0x6bb0c, 0x72c54, 0x7a24c, 0x81cf4, 0x89c4c, 0x92054, 0x9a90c, 0xa3674, 0xac88c, 0xb5f54, 0xbfacc, 0xc9af4, 0xd3fcc, 
        0xde954, 0xe9f5c, 0xf4a74, 0x10020c, 0x10be54, 0x117f4c, 0x1244f4, 0x130f4c
     };
        }

        public class ClassModsMP
        {
            public class MultiPlayer
            {
                public class Primary
                {
                    public static byte[] PrimaIndex = { 0x18, 0x24, 0x0C, 0x20, 0x10, 0x2C, 0x08, 0x1C, 0x15, 0x28, 0xE8, 0xEC, 0xDC, 0xD4, 0x00 };
                }
                public class Secondary
                {
                    public static byte[] SeconIndex = { 0x22, 0x32, 0x64, 0x48, 0x55, 0x34, 0x36, 0x30, 0x26, 0x20, 0x00 };
                }
                public class Greed1
                {
                    public static byte[] Greed1_Index = { 0x94, 0x97, 0x96, 0x95, 0x98, 0x00 };
                }
                public class Greed2
                {
                    public static byte[] Greed2_Index = { 0x9D, 0x9B, 0x9C, 0x99, 0x9a, 0x00 };
                }
                public class Greed3
                {
                    public static byte[] Greed3_Index = { 0x9E, 0xA1, 0x9F, 0xA2, 0xA0, 0xA3, 0x00 };
                }
                public class Lethal
                {
                    public static byte[] Lethal_Index = { 0x09, 0x0D, 0x0F, 0x0E, 0x12, 0x26, 0x30, 0x37, 0x2C, 0x2B, 0x27, 0x39, 0x1E, 0x2F, 0x00 };
                }
                public class Tactical
                {
                    public static byte[] Claymore_x2 = { 0x20, 0x12, 0x58 };
                    public static byte[] Combat_Axe_x2 = { 0x00, 0x12, 0x58 };
                    public static byte[] Semtex_x2 = { 0x09, 0x12, 0x58 };
                    public static byte[] C4_x2 = { 0x11, 0x12, 0x58 };
                    public static byte[] Grenade_x2 = { 0xFA, 0x11, 0x58 };
                    public static byte[] Assault_Shield = { 0xCC, 0x11, 0x00 };
                }
            }
            public class League
            {
                public class Primary
                {
                    public static byte[] PrimaIndex = { 0x0D, 0x13, 0x07, 0x11, 0x09, 0x17, 0x05, 0x0F, 0x0B, 0x15, 0x75, 0x77, 0x6F, 0x6B };
                }
                public class Secondary
                {
                    public static byte[] SeconIndex = { 0x11, 0x19, 0x39, 0x1A, 0x07, 0x18, 0x0F, 0x0D };
                }
                public class Greed1
                {
                    public static byte[] Greed1_Index = { 0x4A, 0x4B, 0x4C };
                }
                public class Greed2
                {
                    public static byte[] Greed2_Index = { 0x4E, 0x4D };
                }
                public class Greed3
                {
                    public static byte[] Greed3_Index = { 0x4F, 0x50, 0x51 };
                }
                public class Lethal
                {
                    public static byte[] Magnom = { 0x05, 0x85 };
                    public static byte[] An94 = { 0x0D, 0x80 };
                    public static byte[] Lsat = { 0x13, 0x80 };
                    public static byte[] Ballista = { 0x15, 0x80 };
                    public static byte[] M12M16 = { 0x18, 0x80 };
                    public static byte[] FlashBang = { 0xA5, 0x80 };
                    public static byte[] EMB = { 0xA4, 0x80 };
                }
                public class Tactical
                {
                    public static byte[] Claymore_x2 = { 0x10, 0x09, 0x0C };
                    public static byte[] Combat_Axe_x2 = { 0x00, 0x09, 0x0C };
                    public static byte[] Semtex_x2 = { 0x04, 0x09, 0x0C };
                    public static byte[] C4_x2 = { 0x08, 0x09, 0x0C };
                    public static byte[] b23r2 = { 0x2C, 0x08, 0x02 };
                    public static byte[] Tac45 = { 0x0C, 0x04, 0x04 };
                    public static byte[] Lsat = { 0x98, 0x04, 0x04 };
                    public static byte[] RPG = { 0xDC, 0x08, 0x0C };
                }
            }
        }
        public class ClassModsCu
        {
            public class Primary
            {
                public static byte[] PrimaIndex = { 0x18, 0x24, 0x0C, 0x20, 0x10, 0x2C, 0x08, 0x1C, 0x15, 0x28, 0xE8, 0xEC, 0xDC, 0xD4, 0x00 };
            }
            public class Secondary
            {
                public static byte[] SeconIndex = { 0x22, 0x32, 0x64, 0x48, 0x55, 0x34, 0x36, 0x30, 0x26, 0x20, 0x00 };
            }
            public class Greed1
            {
                public static byte[] Greed1_Index = { 0x94, 0x97, 0x96, 0x95, 0x98, 0x00 };
            }
            public class Greed2
            {
                public static byte[] Greed2_Index = { 0x9D, 0x9B, 0x9C, 0x99, 0x9a, 0x00 };
            }
            public class Greed3
            {
                public static byte[] Greed3_Index = { 0x9E, 0xA1, 0x9F, 0xA2, 0xA0, 0xA3, 0x00 };
            }
            public class Lethal
            {
                public static byte[] Lethal_Index = { 0x09, 0x0D, 0x0F, 0x0E, 0x12, 0x26, 0x30, 0x37, 0x2C, 0x2B, 0x27, 0x39, 0x1E, 0x2F, 0x00 };
            }
           
        }
        
        public class Names
        {
            public static string[] Names_Index = { "^Hba", "^Hkk", "^Hac", "^H~~", "^Band", "[{__}][{_}][{_}]", "[{+moveleft}]", "[{+moveright}]",
                                              "[{+forward}]", "[{+Back}]", "[{+gostand}]", "[{+stance}]","[{+activate}]","[{+switchseat}]","[{+speed_throw}]",
                                          "[{+attack}]","[{+smoke}]","[{+frag}]","[{+melee}]","[{togglemenu}]","[{togglescores}]","[{+movestick}]","^B^^B^^B^^B^^B^","^B^ ^5xiWLz ^7^B","^2CrTor/^3BISOON"};
        }
        public class Lobby
        {
            public static string[] MapNames = {"la","dockside","carrier","drone",
                                                  "express","hijacked","meltdown","overflow","nightclub",
                                                  "raid","slums",
                                                  "village","turbine","socotra","nuketown_2020",
                                                  "dig","pod","takeoff","frostbite","mirage","hydro",
                                                  "skate","downhill","concert","vertigo","magma",
                                                  "Studio","paintball","Uplink"};
            public static int[] Speed_Index = { 10, 30, 60, 90, 130, 190, 250, 350, 550, 700, 999 };
            public static byte[] Jump_Index = { 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49 };
            public static string[] TS_Index = { ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            public static int[] Gravity_Index = { 800, 500, 250, 150, 50 };
            public static string[] GameModes = {"g_gametype tdm;wait 500;map_restart","g_gametype dm;wait 500;map_restart","g_gametype dom;wait 500;map_restart",
                                                   "g_gametype dem;wait 500;map_restart","g_gametype conf;wait 500;map_restart",
                                                   "g_gametype koth;wait 500;map_restart","g_gametype hq;wait 500;map_restart",
                                                   "g_gametype ctf;wait 500;map_restart","g_gametype sd;wait 500;map_restart","g_gametype oneflag;wait 500;map_restart",
                                               "g_gametype oic;wait 500;map_restart","g_gametype sas;wait 500;map_restart","g_gametype gun;wait 500;map_restart"};
            public static string[] Visions = {"default","infrared","mpintro","neutral","remote_mortar_enhanced","remote_mortar_infrared",
                                                 "taser_mine_shock","tvguided_sp"};
        }
        public class ZM
        {
            public class GiveWeapon
            {
                public class Tranzit
                {
                    public static string[] FillCombo()
                    {
                        string[] WeaponsName = { "AK74u", "AK74u P.A.P", "MP5", "MP5 P.A.P", "Chicom", "Chicom P.A.P", "M14", "M14 P.A.P", "M16A1",
                                           "M16A1 P.A.P", "SMR", "SMR P.A.P", "M8A1", "M8A1 P.A.P", "Type-25", "Type-25 P.A.P", "MTAR",
                                           "MTAR P.A.P", "Remington", "Remington P.A.P", "Olympia", "Olympia P.A.P", "S12", "S12 P.A.P",
                                           "M1216", "M1216 P.A.P", "Galil", "Galil P.A.P", "Fal", "Fal P.A.P", "RPD", "RPD P.A.P", "Hamar",
                                           "Hamar P.A.P", "DSR", "DSR P.A.P", "Barret", "Barret P.A.P", "M1911", "Mustang & Sally", "Python",
                                           "Python P.A.P", "Executioner", "Executioner P.A.P", "Kap-40", "Kap-40 P.A.P", "Five-Seven",
                                           "Five-Seven P.A.P", "B23R", "B23R P.A.P", "RPG", "RPG P.A.P", "WarMachine", "WarMachine P.A.P",
                                           "RayGun", "RayGun P.A.P", "RayGun II", "RayGun II P.A.P", "Ballistic Knife",
                                           "Ballistic Knife P.A.P1", "Ballistic Knife P.A.P2",
                                           "Ballistic Knife P.A.P3" };
                        return WeaponsName;
                    }

                    public static string[] EquipName = { "Grenade", "Semtex", "EMP", "Monkey" };
                    public static byte[] EquipByte = { 0x4F, 0x50, 0x52, 0x51 };
                    public static string[] R3Name = { "Zombie Shield", "Galvaknuckles", "Knife","Knife 1","Knife 2" };
                    public static byte[] R3Byte = { 0x46, 0x47, 0x65, 0x49, 0x4A };
                    public static byte[] WeaponByte = { 2, 5, 3, 6, 4, 7, 9, 0x0f, 0x0A, 0x10, 0x0B, 0x12, 0x0C, 0x14, 0x0D, 0x16, 0x0E, 0x18, 0x1A, 0x1E, 0x1B, 0x1F, 0x1C, 0x20, 0x1D, 0x21, 0x22, 0x26, 0x23, 0x27, 0x24, 0x28, 0x25, 0x29, 0x2A, 0x2C, 0x2B, 0x2D, 0x2F, 0x37, 0x30, 0x39, 0x31, 0x3A, 0x32, 0x3B, 0x33, 0x3C, 0x34, 0x3D, 0x40, 0x42, 0x41, 0x43, 0x44, 0x4E, 0x4C, 0x4D, 0x48, 0x49, 0x4A, 0x4B };
                    public static string[] Models = {"c_zom_zombie1_body01","p6_anim_zm_magic_box_fake","p6_anim_zm_magic_box",
                                                        "p6_zm_bank_vault_floor_hatch","p6_zm_door_security_depot","veh_t6_civ_bus_zombie",
                                                        "p6_anim_zm_bus_driver","veh_t6_civ_movingtrk_cab_dead","zombie_teddybear","zombie_teddybear",
                                                    "zombie_vending_sleight_on","zombie_vending_jugg_on","zombie_vending_marathon_on","zombie_vending_doubletap2_on",
                                                    "p6_anim_zm_buildable_pap_on","zombie_vending_tombstone_on","zombie_vending_revive_on",
                                                    "zombie_x2_icon","zombie_firesale","zombie_skull","zombie_bomb","defaultvehicle",
                                                    "defaultactor","c_zom_screecher_fb","c_zom_avagadro_fb","c_zom_player_oldman_fb",
                                                    "c_zom_player_engineer_fb", "c_zom_player_farmgirl_fb","c_zom_player_reporter_fb"};

                   
                }
                public class DieRise
                {
                    public static string[] FillCombo()
                    {
                        string[] WeaponsName = { "AK74u", "AK74u P.A.P", "MP5", "MP5 P.A.P", "Chicom", "Chicom P.A.P", "PDW","PDW P.A.P","M14", "M14 P.A.P", "M16A1",
                                           "M16A1 P.A.P", "SMR", "SMR P.A.P", "M8A1", "M8A1 P.A.P", "Type-25", "Type-25 P.A.P", "MTAR",
                                           "MTAR P.A.P","AN-94","AN-49 P.A.P", "Remington", "Remington P.A.P", "Olympia", "Olympia P.A.P", "S12", "S12 P.A.P",
                                           "M1216", "M1216 P.A.P", "Galil", "Galil P.A.P", "Fal", "Fal P.A.P", "RPD", "RPD P.A.P", "Hamar",
                                           "Hamar P.A.P", "DSR", "DSR P.A.P", "Barret", "Barret P.A.P", "M1911", "Mustang & Sally", "Python",
                                           "Python P.A.P", "Executioner", "Executioner P.A.P", "Kap-40", "Kap-40 P.A.P", "Five-Seven",
                                           "Five-Seven P.A.P", "B23R", "B23R P.A.P", "RPG", "RPG P.A.P", "WarMachine", "WarMachine P.A.P",
                                           "RayGun", "RayGun P.A.P", "RayGun II", "RayGun II P.A.P","Sliquifier","Sliquifier P.A.P", "Ballistic Knife",
                                           "Ballistic Knife P.A.P1", "Ballistic Knife P.A.P2",
                                           "Ballistic Knife P.A.P3" };
                        return WeaponsName;
                    }
                    public static string[] EquipName = { "Grenade", "Semtex", "Monkey" };
                    public static byte[] EquipByte = { 0x55, 0x56, 0x57 };
                    public static string[] R3Name = { "Default", "Pushing", "Knife", "Knife 1", "Galvaknuckles" };
                    public static byte[] R3Byte = { 0x34, 0x37, 0x66, 0x51, 0x4B };
                    public static byte[] WeaponByte = { 2, 5, 3, 6, 4, 7, 9, 0x0a, 0x0b, 0x11, 0x0c, 0x12, 0x0d, 0x14, 0x0e, 0x16, 0x0f, 0x18, 0x10, 0x1a, 0x1c, 0x1d, 0x1e, 0x22, 0x1f, 0x23, 0x20, 0x24,
                                                      0x21, 0x25, 0x26, 0x2a, 0x27, 0x2B, 0x28, 0x2c, 0x29, 0x2D, 0x2E, 0x30, 0x2F, 0x31, 0x35,/**/0x00 , 0x36, 0x3F,0x37,0x40,0x38,0x41, 0x39, 0x42,
                                                      0x3A, 0x43, 0x46, 0x48, 0x47, 0x49, 0x4A, 0x54, 0x52, 0x53, 0x4E, 0x4F, 0x4C, 0x4D, 0x50, 0x51 };
                }
                public class MOTD
                {
                    public static string[] FillCombo()
                    {
                        string[] WeaponsName = {  "MP5", "MP5 P.A.P", "PDW","PDW P.A.P", "UZI","UZI P.A.P","M1927","M1927 P.A.P","M14", "M14 P.A.P",
                                           "MTAR", "MTAR P.A.P","AK47","AK47 P.A.P", "Remington", "Remington P.A.P", "Olympia", "Olympia P.A.P", "S12", "S12 P.A.P",
                                           "Galil", "Galil P.A.P", "Fal", "Fal P.A.P", "LSAT", "LSAT P.A.P",
                                           "DSR", "DSR P.A.P", "Barret", "Barret P.A.P", "M1911",
                                           "Executioner", "Executioner P.A.P", "Five-Seven",
                                           "Five-Seven P.A.P", "B23R", "B23R P.A.P", "RPG", "RPG P.A.P", "DeathMachine", "DeathMachine P.A.P",
                                           "RayGun", "RayGun P.A.P", "RayGun II", "RayGun II P.A.P", "BLUNDERGAT",
                                           "BLUNDERGAT P.A.P", "ACID Gat",
                                           "ACID Gat P.A.P","Electric Hand","Electric Hand P.A.P" };
                        return WeaponsName;
                    }
                    public static string[] EquipName = { "Grenade", "Smoke", "Tomahowk" };
                    public static byte[] EquipByte = { 0x3F, 0x44, 0x3A };
                    public static string[] R3Name = { "Default", "Hand", "Zombie Shield", "White Spark", "Golden Spark" };
                    public static byte[] R3Byte = { 0x40, 0x50, 0x32, 0x41, 0x42 };
                    public static byte[] WeaponByte = { 2, 3, 4, 5, 6, 8, 7, 9, 0x0a, 0x0c, 0x0b, 0x0d, 0x11, 0x12, 0x13, 0x16, 0x14, 0x17, 0x15, 0x18, 0x19, 0x1B,
                                                      0x1A, 0x1C, 0x0F, 0x10, 0x1D, 0x1F, 0x1E, 0x20, 0x22, 0x23, 0x2A, 0x24, 0x2B, 0x25, 0x2C,
                                                      0x2F, 0x30, 0x33, 0x37, 0x31, 0x3E, 0x3C, 0x3D, 0x34, 0x38, 0x35, 0x39, 0x56, 0x58};

                }
                public class Buried
                {
                    public static string[] FillCombo()
                    {
                        string[] WeaponsName = { "AK74", "AK74 P.A.P", "MP5", "MP5 P.A.P", "PDW","PDW P.A.P","M14", "M14 P.A.P", "M16A1",
                                           "M16A1 P.A.P", "SMR", "SMR P.A.P", "MTAR",
                                           "MTAR P.A.P","AN-94","AN-49 P.A.P", "Remington", "Remington P.A.P", "Olympia", "Olympia P.A.P", "S12", "S12 P.A.P",
                                           "M1216", "M1216 P.A.P", "Galil", "Galil P.A.P", "Fal", "Fal P.A.P", "LSAT", "LSAT P.A.P", "Hamar",
                                           "Hamar P.A.P", "DSR", "DSR P.A.P", "Barret", "Barret P.A.P", "M1911", 
                                           "Executioner", "Executioner P.A.P", "Kap-40", "Kap-40 P.A.P", "Five-Seven",
                                           "Five-Seven P.A.P", "B23R", "B23R P.A.P", "RPG", "RPG P.A.P", "WarMachine", "WarMachine P.A.P",
                                           "RayGun", "RayGun P.A.P", "RayGun II", "RayGun II P.A.P", "Ballistic Knife",
                                           "Ballistic Knife P.A.P1", "Ballistic Knife P.A.P2",
                                           "Ballistic Knife P.A.P3","SASSAFRAS","SASSAFRAS P.A.P", "Paralyzer", "Paralyzer P.A.P" };
                        return WeaponsName;
                    }
                    public static string[] R3Name = { "Default", "Galvaknuckles", "Pushing","Boxing", "Knife 1", "Knife 2" };
                    public static byte[] R3Byte = { 0x2B, 0x42, 0x35, 0x62, 0x61, 0x46 };
                    public static byte[] WeaponByte = { 2, 4, 3, 5, 6, 7 , 8, 0x0c, 0x09, 0x0d, 0x0a, 0x0f, 0x0b, 0x11, 0x15, 0x16, 0x17, 0x1B,
                                                      0x18, 0x1C, 0x19, 0x1D, 0x1a, 0x1e, 0x1f, 0x22, 0x20, 0x23, 0x13, 0x14, 0x21, 0x24, 0x25, 0x27,
                                                      0x26, 0x28, 0x2C, 0x2D, 0x35, 0x2e, 0x36, 0x2F, 0x37, 0x30, 0x38, 0x3D, 0x3F, 0x3E, 0x40, 0x41, 0x4b,
                                                      0x49, 0x4a, 0x43, 0x44, 0x45, 0x46, 0x3B, 0x3C, 0x47, 0x48 };
                }
                public class Origins
                {
                    public static string[] FillCombo()
                    {
                        string[] WeaponsName = { "AK74u", "AK74u P.A.P", "Chicom", "Chicom P.A.P", "PDW","PDW P.A.P","M14", "M14 P.A.P", "MP40",
                                           "MP40 P.A.P", "Skorpion Evo", "Skorpion Evo P.A.P", "Type-25", "Type-25 P.A.P", "STG",
                                           "STG P.A.P","Galil","Galil P.A.P","Fal","Fal P.A.P", "Remington", "Remington P.A.P",
                                           "M1216", "M1216 P.A.P", "Hamar",
                                           "Hamar P.A.P", "DSR", "DSR P.A.P", "Ballista", "Ballista P.A.P", "Mauser", "Mauser P.A.P", "Python",
                                           "Python P.A.P", "Kap-40", "Kap-40 P.A.P", "Five-Seven",
                                           "Five-Seven P.A.P", "B23R", "B23R P.A.P", "WarMachine", "WarMachine P.A.P",
                                           "RayGun", "RayGun P.A.P", "RayGun II", "RayGun II P.A.P","Scar-H","Scar-H P.A.P","Wind","Wind P.A.P", "Fire",
                                           "Fire P.A.P", "Lighting",
                                           "Lighting P.A.P","ICE","ICE P.A.P" };
                        return WeaponsName;
                    }
                    public static string[] EquipName = { "Grenade", "Semtex", "Monkey", "Monkey P.A.P" };
                    public static byte[] EquipByte = { 0x56, 0x57, 0x58, 0x59 };
                    public static string[] R3Name = { "Default", "Boxing", "Zombie Shield", "Kung Fu 1", "Kung Fu 2", "Stuff 1", "Stuff 2" };
                    public static byte[] R3Byte = { 0x2E, 0x7D, 0x55, 0x61, 0x60, 0x67, 0x6a };
                    public static byte[] WeaponByte = { 2, 0x20, 3, 5, 7, 8, 0x11, 0x13, 0x0b, 0x0f, 0x0d, 0x10, 0x12, 0x14, 0x16, 0x18, 0x22, 0x25,
                                                      0x23, 0x26, 0x1A, 0x1C, 0x1B, 0x1d, 0x24, 0x27, 0x2A, 0x2b, 0x2c, 0x2d, 0x3b, 0x3d, 0x2f, 0x35,
                                                      0x30, 0x36, 0x31, 0x37, 0x32, 0x38, 0x3f, 0x40, 0x41, 0x44, 0x42, 0x43, 0x17, 0x19, 0x45, 0x49,
                                                      0x46, 0x4c, 0x47, 0x4f, 0x48, 0x52 };
                }
            }
        }
    }
}
