using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class Offsets
    {
        public class Client
        {
            #region  Clients Offsets
            public static uint Interval = 0x5808,
             G_Client = 0x1780F28,
             NameInGame = G_Client + 0x5544,
             ClanInGame = G_Client + 0x55B0,
             Teleport = G_Client + 0x28,
             GodMode = G_Client + 0x1B,
             PointsInGame = G_Client + 0x55EE,
             KillsInGame = G_Client + 0x55F2,
             DeathInGame = G_Client + 0x55F6,
             VSATInGame = G_Client + 0x57EF,
             AutoPronePlayer = G_Client + 0x57F0,
             PlayerSpeedInGame = G_Client + 0x54F0,
             ToggleLag = G_Client + 0x543B,
             AllPerksPlayer = G_Client + 0x548,
             ThirdPersonPlayer = G_Client + 0x84,
             InGamePrestige = G_Client + 0x556F,
             InGameLevel = G_Client + 0x556B,
             InvisiblePlayer = G_Client + 0xFF,
             CamoOnline1 = G_Client + 0x2A3,
             CamoOnline2 = G_Client + 0x287,
             CamoLocal1 = G_Client + 0x2BF,
             CamoLocal2 = G_Client + 0x2DB,
             TeamInGame = G_Client + 0x5507,
             ScoreStreak1 = G_Client + 0x42F,
             ScoreStreak2 = G_Client + 0x431,
             ScoreStreak3 = G_Client + 0x434,
             RemoveScoreStreak1 = G_Client + 0x55F,
             RemoveScoreStreak2 = G_Client + 0x557,
             RemoveScoreStreak3 = G_Client + 0x553,
             EMP = G_Client + 0x1B,
             BlackScreenOffset1 = G_Client + 0x5A8,
             BlackScreenOffset2 = G_Client + 0x5A4,
             NightVision = G_Client + 0x1A,
             SkipTimer = G_Client + 0x5697,
             Poison = G_Client + 0x5E3,
             SkateMode = G_Client + 0xE,
             WeaponFuckedup = G_Client + 0x54F7,
             Jumper = G_Client + 0x54F0,
             PlayerStatus = G_Client + 0x5423,
             Vision = G_Client + 0x103,
             Freeze = G_Client + 0x5697,
             KillPlayer = G_Client + 0x30,
             NFreeze = 0x1781028,
             PlayerIsAlive = 0x178634B,
             SetClientViewAngles = 0x001e1bf0,
             ReturnVelocity = 0x1780F5C,
             Buttons = 0x17865C4,
             EarthQuake = 0x1781087,
             T_Bag = 0x1781027,
             GivePlayerWeapon = 0x2A81C4,
             AddAmmo = 0x1E6698,
             G_Spawn = 0x278AC0,
             HeldWeapon = 0x17810E3,
             Cbuf_AddText = 0x313c18;


            #endregion
        }
        public class NonHost
        {
            #region Non-Host
            public static uint RedBox1 = 0x000783E0;
            public static uint RedBox2 = 0x00078604;
            public static uint Name = 0x026C0658;
            public static uint LocalName = Name + 0x27;
            public static uint Laser = 0xEF68C;
            public static uint VSAT = 0x00033C60;
            public static uint WallHack1 = 0x1CBF9F8;
            public static uint WallHack2 = 0x000834D0;
            public static uint SteadyAim = 0x5F0A20;  //On: 0x2C, 0x04, 0x00, 0x00 |  Off: 0x2C, 0x04, 0x00, 0x02
            public static uint FPS1 = 0x8E3590;
            public static uint FPS2 = 0x37FEC;
            public static uint FPSText = 0x8E3290;
            public static uint BigName = 0x01cc6e98;
            public static uint SkyColor = 0x01cc28d8;
            public static uint BodyColor = 0x01CC143C;
            public static uint FOV = 0x1CC52D8;
            public static uint FovX = 0x01CCD678;
            public static uint FovY = 0x01CCD6D8;
            public static uint FovZ = 0x01CCD738;
            public static uint NoRecoil = 0xF9E54;
            public static uint UAV = 0x33CB4;
            public static uint FloatingBodies = 0x1CD03D8;
            public static uint TargetFinder = 0x1CC4BF8;
            public static uint EndProbation = 0x0097012C; //0x52FC6C   
            public static uint RotateMap = 0x1CC52D8;
            public static uint SplitScreen = 0x01cbe2b8,
                Clan = 0x2708238;
            #endregion
        }
        public class Stats
        {
            #region Stats
            public static uint Prestige = 0x26FD014;
            public static uint Level = Prestige + 0x18;
            public static uint Score = Prestige + 0x3C;
            public static uint Wins = Prestige + 0x13E;
            public static uint Tokens = Prestige + 0x9924;
            public static uint Losses = Prestige - 0x432;
            public static uint Deaths = Prestige - 0x6D2;
            public static uint Kills = Prestige - 0x4A4;
            public static uint TimePlayed = Prestige + 0xF6;
            public static uint HeadShots = Prestige - 0x5D0;
            public static uint Unlock10Classes = Prestige + 0xB50E; //(0x44, 0x80, 0x08, 0x10, 0x01, 0x22, 0x40, 0x04)
            public static uint UnlockAll = Prestige + 0x1CFA;
            public static uint GhostCard = Prestige + 0xB205;
            public static uint RoxannCard = Prestige + 0xB208;

            public class ZM
            {
                public static uint Kills = 0x26FC90C,
                    Deaths = 0x26FC948,
                    HeadShots = 0x26FC884,
                    Downs = 0x26FC910,
                    Perks = 0x26FC918,
                    Miles = 0x26FC93C,
                    Gibs = 0x26FC91C,
                    Bullets = 0x26FC940,
                    Doors = 0x26FC938,
                    Grenades = 0x26FC934,
                    Hits = 0x26FC944,
                    Revives = 0x26FC914;
            }
            #endregion
        }
        public enum Medals
        {
            AfterLife = 0x026FCD4A,
            BloodThirsty = 0x026FCDEC,
            LongShot = 0x026FCE0A,
            DoubleKill = 0x026FCE2E,
            TripleKill = 0x026FCE34,
            FuryKill = 0x26FCE3A,
            FrenzyKill = 0x026FCE40,
            SuperKill = 0x026FCE46,
            MegaKill = 0x026FCE4C,
            Merciless = 0x26FCDCE,
            UltraKill = 0x026FCE52,
            FirstBlood = 0x026FCCEA,
            OneShotOneKill = 0x026FCD56,
            NuClear = 0x26FCDE6,
            Unstoppable = 0x26FCDF2,
            Brutal = 0x26FCDE0,
            Relentless = 0x26FCDDA
        }

        public class Lobby
        {
            public static uint Jump = 0x005BE0B4;
            public static uint Speed = 0x1CA4E78;
            public static uint KnockBack = 0x01CA4ED8,
                RapidFire = 0x01CB2AF2,
                NoClip = 0x5D5C68;
        }
        public class ClassModsOffsets
        {
            public class MultiPlayer
            {
                public class Class1Offsets
                {
                    public static uint Primary = 0x27078BA;
                    public static uint Secondary = 0x27078C8;
                    public static uint PerkGreed1 = 0x27078d9;
                    public static uint PerkGreed2 = 0x27078da;
                    public static uint PerkGreed3 = 0x27078db;
                    public static uint Lethal = 0x27078DC;
                    public static uint Tactical = 0x27078DE;
                }
                public class Class3Offsets
                {
                    public static uint Primary = 0x2707923;
                    public static uint Secondary = 0x2707931;
                    public static uint PerkGreed1 = 0x2707942;
                    public static uint PerkGreed2 = 0x2707943;
                    public static uint PerkGreed3 = 0x2707944;
                    public static uint Lethal = 0x2707945;
                    public static uint Tactical = 0x2707947;
                }
                public class Class5Offsets
                {
                    public static uint Primary = 0x270798C;
                    public static uint Secondary = 0x270799A;
                    public static uint PerkGreed1 = 0x27079AB;
                    public static uint PerkGreed2 = 0x27079AC;
                    public static uint PerkGreed3 = 0x27079AD;
                    public static uint Lethal = 0x27079AE;
                    public static uint Tactical = 0x27079B0;
                }
                public class Class7Offsets
                {
                    public static uint Primary = 0x27079F5;
                    public static uint Secondary = 0x2707A03;
                    public static uint PerkGreed1 = 0x2707A14;
                    public static uint PerkGreed2 = 0x2707A15;
                    public static uint PerkGreed3 = 0x2707A16;
                    public static uint Lethal = 0x2707A17;
                    public static uint Tactical = 0x2707A19;
                }
                public class Class9Offsets
                {
                    public static uint Primary = 0x2707A5E;
                    public static uint Secondary = 0x2707A6C;
                    public static uint PerkGreed1 = 0x2707A7D;
                    public static uint PerkGreed2 = 0x2707A7E;
                    public static uint PerkGreed3 = 0x2707A7F;
                    public static uint Lethal = 0x2707A80;
                    public static uint Tactical = 0x2707A82;
                }
            }
            public class League
            {
                public class Class1Offsets
                {
                    public static uint Primary = 0x2707CCC;
                    public static uint Secondary = 0x2707CDA;
                    public static uint PerkGreed1 = 0x2707CEB;
                    public static uint PerkGreed2 = 0x2707CEC;
                    public static uint PerkGreed3 = 0x2707CED;
                    public static uint Lethal = 0x2707CEE;
                    public static uint Tactical = 0x2707CF0;
                }
                public class Class3Offsets
                {
                    public static uint Primary = 0x2707D35;
                    public static uint Secondary = 0x2707D43;
                    public static uint PerkGreed1 = 0x2707D54;
                    public static uint PerkGreed2 = 0x2707D55;
                    public static uint PerkGreed3 = 0x2707D56;
                    public static uint Lethal = 0x2707D57;
                    public static uint Tactical = 0x2707D59;
                }
            }
        }

        public class ChangeStr
        {
            public enum StrOffset
            {
                NatTypeStr = 0x309375F7,
                TimeRemaining = 0x30937A94,
                MuteAllPlayer = 0x3093AEB7,
                Muting = 0x3093AE4E,
                UnmuteAllPlayer = 0x3093AF24,
                YouHaveTheMaxNumOfiTems = 0x3093B34F,
                MaxPlayerThatAllowed = 0x3093B65A,
                Online = 0x3094116E,//10
                DoYouWantToGoTheater = 0x30941B2D,//29
                FindMatchPickaGame = 0x3091B06A,//35
                CreateAClassDes = 0x30904F8D,//23
                FriendsBu = 0x308E3CAE,//7
                PartyPravicyTitle = 0x30912448,//13
                PartyPravicy = 0x30922190,//13
                BackButton = 0x308DC3B2,//4
                InPartyMaxPlayer = 0x309425D0,//20
                AddControler = 0x308EC8F7,//24
                BeginTheGame = 0x3091B26E,//14
                PlayLists_FindGame = 0x3093C458,//9
                ChooseClass = 0x309106D2,//12
                CUSTOM_GAMES = 0x30920148,//12
                PUBLIC_MATCH = 0x3090FE68,//12
                LEAGUE_PLAY = 0x3093A88E,//11
                THEATER = 0x30915CEA,//7
                STORE = 0x30931F89,//5
                OPTIONS = 0x3092591B,//7
                CREATE_A_CLASS = 0x30904F62,//14
                LOBBY_LEADER_BOARDS = 0x309123BF,//17
                NEED_MORE_PLAYER = 0x30937C20,//32
                Waiting_for_the_host = 0x30937DE5,//19
                Game_starting_in = 0x30931408,//16
                LEAVE_Game = 0x3090EAE8,//10
                MULTIPLAYER_MENU = 0x3091B3A0,//16
                ROUND_ENDING_KILLCAM = 0x308E18C5,//20
                Joinging_sesion_in_progress = 0x309425D0,//27
                Invite_To_Game = 0x3093029D,//14
                Done = 0x308ECBBA,//4
                Party_Leader = 0x3093C7D9,//12
                In_Category = 0x3094118D, //19
                ScoreStreaks_Des = 0x309051ED,//34
                DisBand_Title = 0x30946348,//14
                Disband_Des = 0x30946370,
                Leave_Disband_Party = 0x309463CF,//22
                Bring_Party = 0x30946482,//11
                Waiting_for_other = 0x308E549D,//25
                Match_Begin = 0x308DBC3B,//12
                Awaiting_Textures = 0x308E6A64,//16
                Good_Games = 0x3093791B,//10
                System_Info = 0x309374A5,//11
                Awaiting_GameState = 0x308E353B,//17
                Awaiting_Connections = 0x308E34DB,//20
                Final_KillCam = 0x308DFE7B,//13
                Customer_Link = 0x30937695,//21
                KillCam = 0x308D9948,//7
                MultiPlayer = 0x309258EF,
                ZOMBIES = 0x307D0E90
            }
        }
    }
}
