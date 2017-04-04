using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Ops_II_By_BISOON
{
    class Func
    {
        public static bool inThread = true;
        public static string MapNameinLoop;
        public static string MapNameLocation;
        public static bool Notify = false;

        public class Notify_C
        {
            public static void Notify_Cl(int Client, string Note)
            {
                if (Notify == true)
                {
                    RPC.iPrintln(Client, Note);
                }
            }
        }

        public static void Level55()
        {
            Functions.SetMem(Offsets.Stats.Prestige + 0x12, new byte[] { 0x36, 0x0, 0x0, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 });
        }
        public static void SetLevel(int Level)
        {
            Functions.SetMem(Offsets.Stats.Level, BitConverter.GetBytes(Convert.ToInt32(BIS.Rank.RankByte[Level - 1])));
        }
        public class NonHost
        {
            public class SuperForceHost
            {
                static bool whileSFH = false;
                static void RunForceHost()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (whileSFH == true)
                        {
                            Connectionfrm.PS3.Extension.WriteByte(0x01cd5b3b, 1);
                            Connectionfrm.PS3.Extension.WriteByte(0x01cd649b, 1);
                            Connectionfrm.PS3.Extension.WriteByte(0x01cd5a1b, 1);
                        }
                    }
                    catch { }
                }
                static bool DisableSu = false;
                public static void SuperFH(bool True)
                {
                    Thread SFH = new Thread(() => RunForceHost());
                    if (True)
                    {
                        whileSFH = true;
                        if (!DisableSu)
                        {
                            SFH.Start();
                            DisableSu = true;
                        }
                    }
                    else
                    {
                        whileSFH = false;
                        SFH.Abort();
                        DisableSu = false;
                    }
                }
            }
             static void WaHack()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (wallH == true)
                    {
                        Connectionfrm.PS3.SetMemory(Offsets.NonHost.WallHack1, BIS.NonHost.WallHackOffset1On);
                        Connectionfrm.PS3.SetMemory(Offsets.NonHost.WallHack2, BIS.NonHost.WallHackOffset2On);
                    }
                }
                catch { }
            }
            static bool wallH = false;
            static bool WallTrue;
            public static void WallHack()
            {
                Thread wallThread = new Thread(() => WaHack());
                if (!WallTrue)
                {
                    wallH = true;
                    WallTrue = true;
                    wallThread.Start();
                }
                else
                {
                    wallH = false;
                    wallThread.Abort();
                    Connectionfrm.PS3.SetMemory(Offsets.NonHost.WallHack1, BIS.NonHost.WallHackOffset1Off);
                    Connectionfrm.PS3.SetMemory(Offsets.NonHost.WallHack2, BIS.NonHost.WallHackOffset2Off);
                    WallTrue = false;
                }
            }
                
            public static void FPS(bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.NonHost.FPS1, new byte[] { 0x94, 50, 0, 0, 0, 0, 0, 32, 32, 32, 32, 32, 32 });
                    Functions.SetMem(Offsets.NonHost.FPS2, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                }
                else
                {
                    Functions.SetMem(Offsets.NonHost.FPS1, new byte[13]);
                    Functions.SetMem(Offsets.NonHost.FPS2, new byte[] { 0x41, 0x82, 8, 0xF0 });
                }
            }

            public static void CompassSize(int Size)
            {
                RPC.cbuf_addtext("set compassMaxRange " + Size);
            }
            public static int[] Visionss = { 0, 1, 2, 3, 4 };
            public static void Vision(int vision)
            {
                if (vision == 0)
                {
                    RPC.cbuf_addtext("r_revivefx_debug 0");
                    RPC.cbuf_addtext("r_watersheetingfx_enable 0");
                    RPC.cbuf_addtext("r_poisonFX_debug_enable 0");
                    RPC.cbuf_addtext("reset r_filmtweakenable");
                    RPC.cbuf_addtext("reset r_filmusetweaks");
                    RPC.cbuf_addtext("reset r_filmtweakinvert");
                    RPC.cbuf_addtext("reset r_filmTweakContrast");
                }
                else if (vision == 1)
                {
                    RPC.cbuf_addtext("r_revivefx_debug 0");
                    RPC.cbuf_addtext("r_watersheetingfx_enable 0");
                    RPC.cbuf_addtext("r_poisonFX_debug_enable 0");
                    RPC.cbuf_addtext("reset r_filmtweakenable");
                    RPC.cbuf_addtext("reset r_filmusetweaks");
                    RPC.cbuf_addtext("reset r_filmtweakinvert");
                    RPC.cbuf_addtext("reset r_filmTweakContrast");
                    RPC.cbuf_addtext("r_revivefx_debug 1");
                }
                else if (vision == 2)
                {
                    RPC.cbuf_addtext("r_revivefx_debug 0");
                    RPC.cbuf_addtext("r_watersheetingfx_enable 0");
                    RPC.cbuf_addtext("r_poisonFX_debug_enable 0");
                    RPC.cbuf_addtext("reset r_filmtweakenable");
                    RPC.cbuf_addtext("reset r_filmusetweaks");
                    RPC.cbuf_addtext("reset r_filmtweakinvert");
                    RPC.cbuf_addtext("reset r_filmTweakContrast");
                    RPC.cbuf_addtext("r_poisonFX_debug_enable 1");
                }
                else if (vision == 3)
                {
                    RPC.cbuf_addtext("r_revivefx_debug 0");
                    RPC.cbuf_addtext("r_watersheetingfx_enable 0");
                    RPC.cbuf_addtext("r_poisonFX_debug_enable 0");
                    RPC.cbuf_addtext("reset r_filmtweakenable");
                    RPC.cbuf_addtext("reset r_filmusetweaks");
                    RPC.cbuf_addtext("reset r_filmtweakinvert");
                    RPC.cbuf_addtext("reset r_filmTweakContrast");
                    RPC.cbuf_addtext("r_watersheetingfx_enable 1");
                }
                else if (vision == 4)
                {
                    RPC.cbuf_addtext("r_revivefx_debug 0");
                    RPC.cbuf_addtext("r_watersheetingfx_enable 0");
                    RPC.cbuf_addtext("r_poisonFX_debug_enable 0");
                    RPC.cbuf_addtext("reset r_filmtweakenable");
                    RPC.cbuf_addtext("reset r_filmusetweaks");
                    RPC.cbuf_addtext("reset r_filmtweakinvert");
                    RPC.cbuf_addtext("reset r_filmTweakContrast");
                    RPC.cbuf_addtext("r_filmtweakenable 1");
                    RPC.cbuf_addtext("r_filmusetweaks 1");
                    RPC.cbuf_addtext("r_filmtweakinvert 1");
                    RPC.cbuf_addtext("r_filmTweakContrast 1.4");
                }
            }
            public enum NonHostModz
            {
                TargetFinder_On = 0,
                TargetFinder_Off = 1,
                SplitScreen_On = 2,
                SplitScreen_Off = 3,
                WeirdView_On = 4,
                WeirdView_Off = 5,
                ThirdPerson_On = 6,
                ThirdPerson_Off = 7,
                InvisibleWeapon_On = 8,
                InvisibleWeapon_Off = 9,
                NoAim_On = 10,
                NoAim_Off = 11,

            }
            public static void SetModz(NonHostModz Modz)
            {
                if (Modz == 0)
                {
                    RPC.cbuf_addtext("set cg_drawShellshock 1");
                    Functions.SetMem(Offsets.NonHost.TargetFinder, BIS.NonHost.TargetFinderOn);
                }
                else if ((int)Modz == 1)
                {
                    RPC.cbuf_addtext("set cg_drawShellshock 0");
                    Functions.SetMem(Offsets.NonHost.TargetFinder, BIS.NonHost.TargetFinderOff);
                }
                else if ((int)Modz == 2)
                {
                    Functions.SetMem(Offsets.NonHost.SplitScreen, BIS.NonHost.SplitScreenOn);
                }
                else if ((int)Modz == 3)
                {
                    Functions.SetMem(Offsets.NonHost.SplitScreen, BIS.NonHost.SplitScreenOff);
                }
                else if ((int)Modz == 4)
                {
                    RPC.cbuf_addtext("r_singleCell 1");
                }
                else if ((int)Modz == 5)
                {
                    RPC.cbuf_addtext("r_singleCell 0");
                }
                else if ((int)Modz == 6)
                {
                    RPC.cbuf_addtext("camera_thirdPerson 1");
                }
                else if ((int)Modz == 7)
                {
                    RPC.cbuf_addtext("camera_thirdPerson 0");
                }
                else if ((int)Modz == 8)
                {
                    RPC.cbuf_addtext("cg_drawGun 0");
                }
                else if ((int)Modz == 9)
                {
                    RPC.cbuf_addtext("cg_drawGun 1");
                }
                else if ((int)Modz == 10)
                {
                    RPC.cbuf_addtext("cg_drawCrosshair 0");
                }
                else if ((int)Modz == 11)
                {
                    RPC.cbuf_addtext("cg_drawCrosshair 1");
                }
            }
            public static void Blur(int _Blur)
            {
                RPC.cbuf_addtext("r_blur " + _Blur);
            }
            static uint AntiFreeze1 = 0x67B824,
                AntiFreeze2 = 0x67B798;
            public static void AntiFreez(bool True)
            {
                if (True)
                {
                    Functions.SetMem(AntiFreeze1, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                    Functions.SetMem(AntiFreeze2, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                }
                else
                {
                    Functions.SetMem(AntiFreeze1, new byte[] { 0x90, 0x9A, 0x00, 0x00 });
                    Functions.SetMem(AntiFreeze2, new byte[] { 0x48, 0x1C, 0x6E, 0x19 });
                }
            }
            static bool WhiAntiFre = false;
            static void RunAntiFreeze()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhiAntiFre == true)
                    {
                        if (Func.ClientInGame())
                        {
                            Functions.SetMem(AntiFreeze1, new byte[] { 0x90, 0x9A, 0x00, 0x00 });
                            Functions.SetMem(AntiFreeze2, new byte[] { 0x48, 0x1C, 0x6E, 0x19 });
                        }
                        else
                        {
                            Functions.SetMem(AntiFreeze1, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                            Functions.SetMem(AntiFreeze2, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                        }
                    }
                }
                catch { }
            }
            static bool DisableAntiFreeze = false;
            public static void ADAntiFreeze(bool True)
            {
                Thread AntiFreezeThr = new Thread(() => RunAntiFreeze());
                if (True)
                {
                    WhiAntiFre = true;
                    if (!DisableAntiFreeze)
                    {
                        AntiFreezeThr.Start();
                        DisableAntiFreeze = true;
                    }
                }
                else
                {
                    WhiAntiFre = false;
                    AntiFreez(false);
                    AntiFreezeThr.Abort();
                    DisableAntiFreeze = false;
                }
            }
        }
        public class ClientMods
        {
            public class ZM
            {// Thanks To BoZeX For Help
                public static void ZombieSpawn(bool True)
                {
                    if (True)
                    {
                        Functions.SetMem(268763852, new byte[] { 0x4F, 0x20, 0x22, 0x5E, 0x38, 0x5A, 0x6F, 0x6D, 0x62, 0x69, 0x65, 0x20, 0x53, 0x74, 0x6F, 0x70, 0x20, 0x53, 0x70, 0x61, 0x77, 0x6E, 0x69, 0x6E, 0x67, 0x20, 0x5E, 0x32, 0x4F, 0x6E, 0x22, 0x00 });
                        Functions.SetMem(30036344, new byte[] { 0x00 });
                    }
                    else
                    {
                        Functions.SetMem(268763852, new byte[] { 0x4F, 0x20, 0x22, 0x5E, 0x38, 0x5A, 0x6F, 0x6D, 0x62, 0x69, 0x65, 0x20, 0x53, 0x74, 0x6F, 0x70, 0x20, 0x53, 0x70, 0x61, 0x77, 0x6E, 0x69, 0x6E, 0x67, 0x20, 0x5E, 0x31, 0x4F, 0x66, 0x66, 0x22, 0x00 });
                        Functions.SetMem(30036344, new byte[] { 0x01 });
                    }
                }
                static void Ammo(int Client)
                {
                    byte[] Full = new byte[] { 199 };
                    Connectionfrm.PS3.SetMemory(0x0178131B + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x01781357 + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x0178135B + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x01781323 + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x0178135F + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x01781363 + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x01781327 + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x01781367 + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x0178132B + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x01781353 + 0x5808 * (uint)Client, Full);
                    Connectionfrm.PS3.SetMemory(0x01781317 + 0x5808 * (uint)Client, Full);
                }
                static bool[] ClientAmmo = new bool[12];
                static bool WhileAmmo = false;
                static Thread AmmoThread;
                static bool DisableAmmo = false;

                static void RunAmmo()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (WhileAmmo == true)
                        {
                            if (ClientAmmo[0] == true)
                            { Ammo(0); }
                            if (ClientAmmo[1] == true)
                            { Ammo(1); }
                            if (ClientAmmo[2] == true)
                            { Ammo(2); }
                            if (ClientAmmo[3] == true)
                            { Ammo(3); }
                            if (ClientAmmo[4] == true)
                            { Ammo(4); }
                            if (ClientAmmo[5] == true)
                            { Ammo(5); }
                            if (ClientAmmo[6] == true)
                            { Ammo(6); }
                            if (ClientAmmo[7] == true)
                            { Ammo(7); }
                        }
                    }
                    catch { }
                }
                public static void GiveAmmo(int Client, bool True)
                {
                    AmmoThread = new Thread(() => RunAmmo());
                    if (True)
                    {
                        ClientAmmo[Client] = true;
                        WhileAmmo = true;
                        if (!DisableAmmo)
                        {
                            AmmoThread.Start();
                            DisableAmmo = true;
                        }
                        Notify_C.Notify_Cl(Client, "Unlimated Ammo :^2 On");
                    }
                    else
                    {
                        ClientAmmo[Client] = false;
                        //WhileAmmo = true;
                        //AmmoThread.Abort();
                        Notify_C.Notify_Cl(Client, "Unlimated Ammo :^1 Off");
                    }
                }
                static bool[] MaxPointbool = new bool[12];
                public static void MaxPoint(int Client)
                {
                    if (!MaxPointbool[Client])
                    {
                        Connectionfrm.PS3.SetMemory(0x1786501 + 0x5808 * (uint)Client, new byte[] { 0x0F, 0x42, 0x40 });
                        Notify_C.Notify_Cl(Client, "^2Max Points");
                        MaxPointbool[Client] = true;
                    }
                    else
                    {
                        Connectionfrm.PS3.SetMemory(0x1786501 + 0x5808 * (uint)Client, new byte[] { 0x00, 0x00, 0x00 });
                        Notify_C.Notify_Cl(Client, "^1Zero Points");
                        MaxPointbool[Client] = false;
                    }
                }

                static bool[] LastStandingBool = new bool[8];
                public static void LastStanding(int Client)
                {
                    if (!LastStandingBool[Client])
                    {
                        Connectionfrm.PS3.SetMemory(268763144, new byte[] { 00, 00, 00, 00 });
                        Connectionfrm.PS3.SetMemory(268763148, new byte[] { 00, 00, 00, 00 });
                        Connectionfrm.PS3.SetMemory(268763852, new byte[] { 0x4F, 0x20, 0x22, 0x5E, 0x38, 0x4C, 0x61, 0x73, 0x74, 0x20, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x20, 0x5E, 0x32, 0x4F, 0x6E, 0x22, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763152, new byte[] { 0x10, 0x05, 0x02, 0xCC });
                        Connectionfrm.PS3.SetMemory(268763168, new byte[] { 00, 00, 00, 00 });
                        Connectionfrm.PS3.SetMemory(268763172, new byte[] { 00, 00, 00, 00 });
                        Connectionfrm.PS3.SetMemory(268763176, new byte[] { 00, 00, 00, 00 });
                        Connectionfrm.PS3.SetMemory(268763180, new byte[] { 00, 00, 00, 00 });
                        Connectionfrm.PS3.SetMemory(268763136, new byte[] { 0x00, 0x34, 0xA1, 0xDC });
                        Connectionfrm.PS3.SetMemory(268763140, new byte[] { 00, 00, 00, 00 });
                        Connectionfrm.PS3.SetMemory(24667947 + 0x5808 * (uint)Client, new byte[] { 01 });
                        LastStandingBool[Client] = true;
                    }
                    else
                    {
                        Connectionfrm.PS3.SetMemory(24667947 + 0x5808 * (uint)Client, new byte[] { 00 });
                        LastStandingBool[Client] = false;
                    }
                }

                static bool[] BlackScreenBool = new bool[12];
                public static void BlackScreen(int Client, byte byt = 0x00)
                {
                    if (!BlackScreenBool[Client])
                    {
                        BlackScreenBool[Client] = true;
                        Connectionfrm.PS3.SetMemory(268763144 + 0x5808 * (uint)Client, new byte[] { 00, 0x00, 0x00, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763148 + 0x5808 * (uint)Client, new byte[] { 00, 0x00, 0x00, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763852 + 0x5808 * (uint)Client, new byte[] { 0x4F, 0x20, 0x22, 0x5E, 0x38, 0x42, 0x6C, 0x61, 0x63, 0x6B, 0x20, 0x53, 0x63, 0x72, 0x65, 0x65, 0x6E, 0x20, 0x5E, 0x32, 0x4F, 0x6E, 0x22, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763152 + 0x5808 * (uint)Client, new byte[] { 0x10, 0x05, 0x02, 0xCC });
                        Connectionfrm.PS3.SetMemory(268763168 + 0x5808 * (uint)Client, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763172 + 0x5808 * (uint)Client, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763176 + 0x5808 * (uint)Client, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763180 + 0x5808 * (uint)Client, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                        Connectionfrm.PS3.SetMemory(268763136 + 0x5808 * (uint)Client, new byte[] { 0x00, 0x34, 0xA1, 0xDC });
                        Connectionfrm.PS3.SetMemory(268763140 + 0x5808 * (uint)Client, new byte[] { 00, 0x00, 0x00, 0x00 });
                        Connectionfrm.PS3.SetMemory(24646864 + 0x5808 * (uint)Client, new byte[] { byt, 0x00 });
                        Connectionfrm.PS3.SetMemory(24646860 + 0x5808 * (uint)Client, new byte[] { 0x01 });
                        if (byt == 4)
                        {
                            Notify_C.Notify_Cl(Client, "Broken Screen : ^2On");
                        }
                        else
                        {
                            Notify_C.Notify_Cl(Client, "Black Screen : ^2On");
                        }
                    }
                    else
                    {
                        BlackScreenBool[Client] = false;
                        Connectionfrm.PS3.SetMemory(0x17814D0 + 0x5808 * (uint)Client, new byte[] { 0x40, 0x80 });
                        if (byt == 4)
                        {
                            Notify_C.Notify_Cl(Client, "Broken Screen : ^1Off");
                        }
                        else
                        {
                            Notify_C.Notify_Cl(Client, "Black Screen : ^1Off");
                        }
                        
                    }
                }
                public static void AllPerks(int Client, bool True)
                {
                    if (True)
                    {
                        Connectionfrm.PS3.SetMemory(0x1781470 + 0x5808 * (uint)Client, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
                        Notify_C.Notify_Cl(Client, "All Perks : ^2On");
                    }
                    else
                    {
                        Connectionfrm.PS3.SetMemory(0x1781470 + 0x5808 * (uint)Client, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        Notify_C.Notify_Cl(Client, "All Perks : ^1Off");
                    }
                }
                static bool[] thug = new bool[8];
                public static void Thug(int Client)
                {
                    if (!thug[Client])
                    {
                        thug[Client] = true;
                        Connectionfrm.PS3.SetMemory(0x1781476 + 0x5808 * (uint)Client, new byte[] { 0xff });
                        Notify_C.Notify_Cl(Client, "Thug : ^2On   ^7| You Can Kill Your Friend ");
                    }
                    else
                    {
                        Connectionfrm.PS3.SetMemory(0x1781476 + 0x5808 * (uint)Client, new byte[] { 0x00 });
                        Notify_C.Notify_Cl(Client, "Thug : ^1Off");
                        thug[Client] = false;
                    }
                }

                static bool whileTrue = false;
                static Thread SFHZM;
                static void RunForce()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (whileTrue == true)
                        {
                            Connectionfrm.PS3.SetMemory(0x01cd5f53, new byte[] { 0x01 });
                            Connectionfrm.PS3.SetMemory(0x01cd69d3, new byte[] { 0x01 });
                            Connectionfrm.PS3.SetMemory(0x19A95C0, new byte[] { 0x01 });
                        }
                    }
                    catch { }
                }
                static bool DisableZM = false;
                public static void SuperForceHost(bool True)
                {
                    SFHZM = new Thread(() => ZM.RunForce());
                    if (True)
                    {
                        whileTrue = true;
                        if (!DisableZM)
                        { SFHZM.Start(); DisableZM = true; }
                    }
                    else
                    {
                        whileTrue = false;
                        SFHZM.Abort();
                        DisableZM = true;
                    }
                }
                public static void GivePrimary(int Client, int weapon, string WeaponName)
                {
                    if (ZPfrm.MapWeapon == "Tranzit")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x178118F + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Tranzit.WeaponByte[weapon]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811E3 + 0x5808 * (uint)Client, 0x38);
                    }
                    else if (ZPfrm.MapWeapon == "MOTD")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x1781173 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.MOTD.WeaponByte[weapon]);
                    }
                    else if (ZPfrm.MapWeapon == "Buried")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x178118F + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Buried.WeaponByte[weapon]);
                    }
                    else if (ZPfrm.MapWeapon == "Origins")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x178118F + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Origins.WeaponByte[weapon]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811E3 + 0x5808 * (uint)Client, 0x6E);
                    }
                    else if (ZPfrm.MapWeapon == "Die Rise")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x178118F + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.DieRise.WeaponByte[weapon]);
                    }
                    Notify_C.Notify_Cl(Client, WeaponName + " ^2Given");
                }
                // Sec
                public static void GiveSecondary(int Client, int weapon, string WeaponName)
                {
                    if (ZPfrm.MapWeapon == "Tranzit")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811C7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Tranzit.WeaponByte[weapon]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811E3 + 0x5808 * (uint)Client, 0x38);
                    }
                    else if (ZPfrm.MapWeapon == "MOTD")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811C7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.MOTD.WeaponByte[weapon]);
                    }
                    else if (ZPfrm.MapWeapon == "Buried")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811C7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Buried.WeaponByte[weapon]);
                    }
                    else if (ZPfrm.MapWeapon == "Origins")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811C7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Origins.WeaponByte[weapon]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811E3 + 0x5808 * (uint)Client, 0x6E);
                    }
                    else if (ZPfrm.MapWeapon == "Die Rise")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811C7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.DieRise.WeaponByte[weapon]);
                    }
                    Notify_C.Notify_Cl(Client, WeaponName + " ^2Given");
                }
                //Equip
                public static void GiveEquip(int Client, int Equip, string WeaponName)
                {
                    if (ZPfrm.MapWeapon == "Tranzit")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811AB + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Tranzit.EquipByte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "MOTD")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811AB + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.MOTD.EquipByte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "Buried")
                    {
                        //Connectionfrm.PS3.Extension.WriteByte(0x17811AB + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Buried.EquipByte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "Origins")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811AB + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Origins.EquipByte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "Die Rise")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17811AB + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.DieRise.EquipByte[Equip]);
                    }
                    Notify_C.Notify_Cl(Client, WeaponName + " ^2Given");
                }

                public static void GiveR3(int Client, int Equip, string WeaponName)
                {
                    if (ZPfrm.MapWeapon == "Tranzit")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17810F7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Tranzit.R3Byte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "MOTD")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17810F7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.MOTD.R3Byte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "Buried")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17810F7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Buried.R3Byte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "Origins")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17810F7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.Origins.R3Byte[Equip]);
                    }
                    else if (ZPfrm.MapWeapon == "Die Rise")
                    {
                        Connectionfrm.PS3.Extension.WriteByte(0x17810F7 + 0x5808 * (uint)Client, BIS.ZM.GiveWeapon.DieRise.R3Byte[Equip]);
                    }
                    Notify_C.Notify_Cl(Client, WeaponName + " ^2Given");
                }
                static int ra = 0;
                public static void RandomCamo(int Client)
                {
                    if (ZPfrm.MapWeapon == "Tranzit")
                    {

                        byte[] Camos = { 0xAA, 0xA7, 0x00 };
                        ra++;
                        if (ra == Camos.Length)
                        {
                            ra = 0;
                        }
                        Connectionfrm.PS3.Extension.WriteByte(0x1781193 + 0x5808 * (uint)Client, Camos[ra]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811CB + 0x5808 * (uint)Client, Camos[ra]);


                    }
                    else if (ZPfrm.MapWeapon == "MOTD")
                    {
                        byte[] Camos = { 0xA8, 0xA7, 0x00 };
                        ra++;
                        if (ra == Camos.Length)
                        {
                            ra = 0;
                        }
                        Connectionfrm.PS3.Extension.WriteByte(0x1781177 + 0x5808 * (uint)Client, Camos[ra]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811CB + 0x5808 * (uint)Client, Camos[ra]);
                    }
                    else if (ZPfrm.MapWeapon == "Buried")
                    {
                        byte[] Camos = { 0xA8, 0xA7, 0x00 };
                        ra++;
                        if (ra == Camos.Length)
                        {
                            ra = 0;
                        }
                        Connectionfrm.PS3.Extension.WriteByte(0x1781193 + 0x5808 * (uint)Client, Camos[ra]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811CB + 0x5808 * (uint)Client, Camos[ra]);

                    }
                    else if (ZPfrm.MapWeapon == "Origins")
                    {
                        byte[] Camos = { 0xA7, 0xA8, 0xAD };
                        ra++;
                        if (ra == Camos.Length)
                        {
                            ra = 0;
                        }
                        Connectionfrm.PS3.Extension.WriteByte(0x1781193 + 0x5808 * (uint)Client, Camos[ra]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811CB + 0x5808 * (uint)Client, Camos[ra]);
                    }
                    else if (ZPfrm.MapWeapon == "Die Rise")
                    {
                        byte[] Camos = { 0xA7, 0x00 };
                        ra++;
                        if (ra == Camos.Length)
                        {
                            ra = 0;
                        }
                        Connectionfrm.PS3.Extension.WriteByte(0x1781193 + 0x5808 * (uint)Client, Camos[ra]);
                        Connectionfrm.PS3.Extension.WriteByte(0x17811CB + 0x5808 * (uint)Client, Camos[ra]);
                    }
                }

                public static void SetModel(int Client, string Model)
                {
                    RPC.G_SetModel(Client, Model);
                    Notify_C.Notify_Cl(Client, "Your Model Set To : ^2  " + Model);
                }
                public class Stats
                {
                    public static void SetPrestige(int NewPrestige)
                    {
                        if (NewPrestige == 0)
                        {
                            Connectionfrm.PS3.SetMemory(40880775, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF });
                        }
                        else if (NewPrestige == 1)
                        {
                            Connectionfrm.PS3.SetMemory(40880775, new byte[] { 0x02, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                        }
                        else if (NewPrestige == 2)
                        {
                            Connectionfrm.PS3.SetMemory(40880775, new byte[] { 0x0A, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                        }
                        else if (NewPrestige == 3)
                        {
                            Connectionfrm.PS3.SetMemory(40880775, new byte[] { 0x0F, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                        }
                        else if (NewPrestige == 4)
                        {
                            Connectionfrm.PS3.SetMemory(40880775, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                        }
                        Connectionfrm.PS3.SetMemory(40880278, new byte[] { 0xFF, 0x0F });
                        Connectionfrm.PS3.SetMemory(40880784, new byte[] { 0xFF, 0xFF, 0xFF });
                        Connectionfrm.PS3.SetMemory(40880788, new byte[] { 0xFF, 0xFF, 0xFF });
                        Connectionfrm.PS3.SetMemory(40880792, new byte[] { 0xFF, 0xFF, 0xFF });
                        Connectionfrm.PS3.SetMemory(40880796, new byte[] { 0xFF, 0xFF, 0xFF });
                        Connectionfrm.PS3.SetMemory(40880800, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    }
                    public static void SetLevel(int NewLevel)
                    {
                        if (NewLevel == 0)
                        {
                            Connectionfrm.PS3.SetMemory(0x26FCA8E, new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        }
                        else if (NewLevel == 1)
                        {
                            Connectionfrm.PS3.SetMemory(0x26FCA8E, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        }
                        else if (NewLevel == 2)
                        {
                            Connectionfrm.PS3.SetMemory(0x26FCA8E, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        }
                        else if (NewLevel == 3)
                        {
                            Connectionfrm.PS3.SetMemory(0x26FCA8E, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00 });
                        }
                        else if (NewLevel == 4)
                        {
                            Connectionfrm.PS3.SetMemory(0x26FCA8E, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                        }
                    }
                }
            }

            public class SpinMod
            {
                static Thread SpinThread;
                static bool SpinModz = false;
                static bool[] clientSpin = new bool[12];
                static bool DisableSpinMod = false;
                public static void SetClientViewAngles(int Client, float[] Angles)
                {
                    RPC.Call(Offsets.Client.SetClientViewAngles, AimBot.G_Entity(Client), Angles);
                }
                public static float[] ReturnVelocity(int Client)
                {
                    return Functions.ReadSingle(Offsets.Client.ReturnVelocity + 0x5808 * (uint)Client, 3);
                }
                static void Spin(int Client)
                {
                    for (float X = -180; X < 180; )
                    {
                        SetClientViewAngles(Client, new float[] { ReturnVelocity(Client)[0], X, ReturnVelocity(Client)[2] });
                        X += (float)80;
                    }
                }
                static void RunSpin()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (SpinModz == true)
                        {
                            if (clientSpin[0] == true)
                            { Spin(0); }
                            if (clientSpin[1] == true)
                            { Spin(1); }
                            if (clientSpin[2] == true)
                            { Spin(2); }
                            if (clientSpin[3] == true)
                            { Spin(3); }
                            if (clientSpin[4] == true)
                            { Spin(4); }
                            if (clientSpin[5] == true)
                            { Spin(5); }
                            if (clientSpin[6] == true)
                            { Spin(6); }
                            if (clientSpin[7] == true)
                            { Spin(7); }
                            if (clientSpin[8] == true)
                            { Spin(8); }
                            if (clientSpin[9] == true)
                            { Spin(9); }
                            if (clientSpin[10] == true)
                            { Spin(10); }
                            if (clientSpin[11] == true)
                            { Spin(11); }
                        }
                        
                    }
                    catch { }
                }
                static bool[] ExeSpin = new bool[12];
                public static void SpiningMod(int Client)
                {
                    SpinThread = new Thread(() => RunSpin());
                    try
                    {
                        if (!ExeSpin[Client])
                        {
                            clientSpin[Client] = true;
                            SpinModz = true;
                            ExeSpin[Client] = true;
                            Notify_C.Notify_Cl(Client, "Spin Mod :^2On");
                            if (!DisableSpinMod)
                            { SpinThread.Start(); DisableSpinMod = true; }
                        }
                        else
                        {
                            clientSpin[Client] = false;
                            ExeSpin[Client] = false;
                            Notify_C.Notify_Cl(Client, "Spin Mod :^1Off");
                        }
                    }
                    catch { }
                }
            }

            public class AdvancedNOClip
            {
                static bool whileA = false;
                static bool[] clientAdvanced = new bool[12];
                static Thread AdvancedNoCTh;
                static bool DisableANC = false;
                static bool[] ExeANC = new bool[12];
                static void RunAdNC()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (whileA == true)
                        {
                            if (clientAdvanced[0] == false)
                            { AdvancedNoClip.AdvancedNoclip(0); }
                            if (clientAdvanced[1] == false)
                            { AdvancedNoClip.AdvancedNoclip(1); }
                            if (clientAdvanced[2] == false)
                            { AdvancedNoClip.AdvancedNoclip(2); }
                            if (clientAdvanced[3] == false)
                            { AdvancedNoClip.AdvancedNoclip(3); }
                            if (clientAdvanced[4] == false)
                            { AdvancedNoClip.AdvancedNoclip(4); }
                            if (clientAdvanced[5] == false)
                            { AdvancedNoClip.AdvancedNoclip(5); }
                            if (clientAdvanced[6] == false)
                            { AdvancedNoClip.AdvancedNoclip(6); }
                            if (clientAdvanced[8] == false)
                            { AdvancedNoClip.AdvancedNoclip(8); }
                            if (clientAdvanced[9] == false)
                            { AdvancedNoClip.AdvancedNoclip(9); }
                            if (clientAdvanced[10] == false)
                            { AdvancedNoClip.AdvancedNoclip(10); }
                            if (clientAdvanced[11] == false)
                            { AdvancedNoClip.AdvancedNoclip(11); }
                        }
                    }
                    catch {}
                }
                public static void NoClip(int Client)
                {
                    try
                    {
                        AdvancedNoCTh = new Thread(() => RunAdNC());
                        if (!ExeANC[Client])
                        {
                            clientAdvanced[Client] = true;
                            whileA = true;
                            ExeANC[Client] = true;
                            Notify_C.Notify_Cl(Client, "Advanced NoClip : ^2On");
                            if (!DisableANC)
                            { AdvancedNoCTh.Start(); DisableANC = true; }
                        }
                        else
                        {
                            ExeANC[Client] = false;
                            clientAdvanced[Client] = false;
                            Notify_C.Notify_Cl(Client, "Advanced NoClip : ^1Off");
                        }
                    }
                    catch {}
                }
            }

            public class ModelBullets
            {
                static bool whileA = false;
                static bool[] clientBullets = new bool[12];
                static Thread BulletsThr;
                static bool DisableBull = false;
                static bool[] ExeBull = new bool[12];
                static void RunBullet()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (whileA == true)
                        {
                            if (clientBullets[0] == false)
                            { CarePackageBullet.CarePackageGun(0); }
                            if (clientBullets[1] == false)
                            { CarePackageBullet.CarePackageGun(1); }
                            if (clientBullets[2] == false)
                            { CarePackageBullet.CarePackageGun(2); }
                            if (clientBullets[3] == false)
                            { CarePackageBullet.CarePackageGun(3); }
                            if (clientBullets[4] == false)
                            { CarePackageBullet.CarePackageGun(4); }
                            if (clientBullets[5] == false)
                            { CarePackageBullet.CarePackageGun(5); }
                            if (clientBullets[6] == false)
                            { CarePackageBullet.CarePackageGun(6); }
                            if (clientBullets[8] == false)
                            { CarePackageBullet.CarePackageGun(8); }
                            if (clientBullets[9] == false)
                            { CarePackageBullet.CarePackageGun(9); }
                            if (clientBullets[10] == false)
                            { CarePackageBullet.CarePackageGun(10); }
                            if (clientBullets[11] == false)
                            { CarePackageBullet.CarePackageGun(11); }
                        }
                    }
                    catch { }
                }
                public static void Bullet(int Client)
                {
                    try
                    {
                        BulletsThr = new Thread(() => RunBullet());
                        if (!ExeBull[Client])
                        {
                            clientBullets[Client] = true;
                            whileA = true;
                            ExeBull[Client] = true;
                            Notify_C.Notify_Cl(Client, "CarePackage Bullets : ^2On");
                            if (!DisableBull)
                            { BulletsThr.Start(); DisableBull = true; }
                        }
                        else
                        {
                            ExeBull[Client] = false;
                            clientBullets[Client] = false;
                            Notify_C.Notify_Cl(Client, "CarePackage Bullets : ^1Off");
                        }
                    }
                    catch { }
                }
            }
            public class JETPACK
            {
                static Thread JetpackThread;
                static bool JetpackBool = false;
                static bool[] clientJetPack = new bool[12];
                static bool DisableJetPack = false;
                public static void DoJetpack(int Client, float HighLevel, bool True)
                {
                    JetpackThread = new Thread(() => Jetpack(Client, HighLevel));
                    if (True)
                    {
                        JetpackBool = true;
                        clientJetPack[Client] = true;
                        Notify_C.Notify_Cl(Client, "JetPack = " + HighLevel + "  : ^2On");
                        if (!DisableJetPack)
                        {
                            JetpackThread.Start();
                            DisableJetPack = true;
                        }
                    }
                    else
                    {
                        clientJetPack[Client] = false;
                        JetpackBool = false;
                        DisableJetPack = false;
                        Notify_C.Notify_Cl(Client, "JetPack : ^1Off");
                    }
                }

                public static void ENDJETPAC()
                {
                    try
                    {
                        if (DisableJetPack == true)
                        {
                            JetpackBool = false;
                            JetpackThread.Abort();
                        }
                    }
                    catch { }
                }
                private static void Jetpack(int Client, float HighLevel)
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (JetpackBool == true)
                        {
                            if (clientJetPack[0] == true)
                            { JetPACk(0, HighLevel); }
                            if (clientJetPack[1] == true)
                            { JetPACk(1, HighLevel); }
                            if (clientJetPack[2] == true)
                            { JetPACk(2, HighLevel); }
                            if (clientJetPack[3] == true)
                            { JetPACk(3, HighLevel); }
                            if (clientJetPack[4] == true)
                            { JetPACk(4, HighLevel); }
                            if (clientJetPack[5] == true)
                            { JetPACk(5, HighLevel); }
                            if (clientJetPack[6] == true)
                            { JetPACk(6, HighLevel); }
                            if (clientJetPack[7] == true)
                            { JetPACk(7, HighLevel); }
                            if (clientJetPack[8] == true)
                            { JetPACk(8, HighLevel); }
                            if (clientJetPack[9] == true)
                            { JetPACk(9, HighLevel); }
                            if (clientJetPack[10] == true)
                            { JetPACk(10, HighLevel); }
                            if (clientJetPack[11] == true)
                            { JetPACk(11, HighLevel); }
                        }
                    }
                    catch { }
                }
                static void JetPACk(int Client, float HighLevel)
                {
                    float num = Connectionfrm.PS3.Extension.ReadFloat(Offsets.Client.Teleport + 8 + 0x5808 * (uint)Client);
                    if (Connectionfrm.PS3.Extension.ReadInt32(Offsets.Client.Buttons + 0x5808 * (uint)Client) == 2097152)
                    {
                        Connectionfrm.PS3.Extension.WriteFloat(Offsets.Client.Teleport + 8 + 0x5808 * (uint)Client, num + HighLevel);
                    }
                }
            }

            public static void TakeWeapon(int Client)
            {
                Functions.SetMem(0x1781170 + (0x5808 * (uint)Client), new byte[0x188]);
                Notify_C.Notify_Cl(Client, "^1Weapon Removed");
            }
            static void GodMode(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * (uint)Client, BIS.Client.GodModOn);
                    Notify_C.Notify_Cl(Client, "God Mod : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * (uint)Client, BIS.Client.GodModOff);
                    Notify_C.Notify_Cl(Client, "God Mod : ^1Off");
                }
            }
            static bool GodMB = false;
            static bool[] clientGMB = new bool[12];
            static void DoGodM()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (GodMB == true)
                    {
                        if (clientGMB[0] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 0, BIS.Client.GodModOn); }
                        if (clientGMB[1] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 1, BIS.Client.GodModOn); }
                        if (clientGMB[2] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 2, BIS.Client.GodModOn); }
                        if (clientGMB[3] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 3, BIS.Client.GodModOn); }
                        if (clientGMB[4] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 4, BIS.Client.GodModOn); }
                        if (clientGMB[5] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 5, BIS.Client.GodModOn); }
                        if (clientGMB[6] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 6, BIS.Client.GodModOn); }
                        if (clientGMB[7] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 7, BIS.Client.GodModOn); }
                        if (clientGMB[8] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 8, BIS.Client.GodModOn); }
                        if (clientGMB[9] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 9, BIS.Client.GodModOn); }
                        if (clientGMB[10] == true)
                        { Functions.SetMem(Offsets.Client.GodMode + Offsets.Client.Interval * 10, BIS.Client.GodModOn); }
                    }
                }
                catch { }
            }
            public static Thread GMTHR;
            static bool DisableGodMod = false;
            public static void GodMod(int Client, bool tru)
            {
                GMTHR = new Thread(() => DoGodM());
                try
                {
                    if (tru)
                    {
                        GodMB = true;
                        clientGMB[Client] = true;
                        Notify_C.Notify_Cl(Client, "Auto God Mod : ^2On");
                        if (!DisableGodMod)
                        { GMTHR.Start(); DisableGodMod = true; }
                    }
                    else
                    {
                        clientGMB[Client] = false;
                        GodMode(Client, false);
                    }
                }
                catch { }
            }
            public static void EndGodMod()
            {
                try
                {
                    if (DisableGodMod == true)
                    {
                        GodMB = false;
                        GMTHR.Abort();
                    }
                }
                catch { }
            }
            static void VSATs(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * (uint)Client, BIS.Client.VSATInGameOn);
                    Notify_C.Notify_Cl(Client, "VSAT : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * (uint)Client, BIS.Client.VSATInGameOff);
                    Notify_C.Notify_Cl(Client, "VSAT : ^1Off");
                }
            }
            static bool WhiVSAT = false;
            static bool[] clientVSAT = new bool[12];
            static void RunVSAT()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhiVSAT == true)
                    {
                        if (clientVSAT[0] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 0, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[1] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 1, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[2] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 2, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[3] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 3, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[4] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 4, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[5] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 5, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[6] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 6, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[7] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 7, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[8] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 8, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[9] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 9, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[10] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 10, BIS.Client.VSATInGameOn); }
                        if (clientVSAT[11] == true)
                        { Functions.SetMem(Offsets.Client.VSATInGame + Offsets.Client.Interval * 11, BIS.Client.VSATInGameOn); }
                    }
                }
                catch { }
            }

            static bool DisableVSAT = false;
            static Thread VSATTHREAD;
            public static void VSAT(int Client, bool True)
            {
                VSATTHREAD = new Thread(() => RunVSAT());
                try
                {
                    if (True)
                    {
                        clientVSAT[Client] = true;
                        WhiVSAT = true;
                        if (!DisableVSAT)
                        { VSATTHREAD.Start(); DisableVSAT = true; }
                        Notify_C.Notify_Cl(Client, "Auto VSAT : ^2On");
                    }
                    else
                    {
                        clientVSAT[Client] = false;
                        VSATs(Client, false);
                        VSATTHREAD.Abort();
                    }
                }
                catch { }
            }
            public static void EndVSAT()
            {
                try
                {
                    if (DisableVSAT == true)
                    {
                        WhiVSAT = false;
                        VSATTHREAD.Abort();
                    }
                }
                catch { }
            }
            #region  Ammo
            public class ClientsAmmo
            {
                //I Had much free time when i put Ammo :p
                public static void GiveAmmoForAll(int Client)
                {
                    Functions.SetMem(0x1781377 + ((uint)(0x5808 * Client)), new byte[] { 0xff });
                    Functions.SetMem(0x1781367 + ((uint)(0x5808 * Client)), new byte[] { 0xff });
                    Functions.SetMem(0x1781363 + ((uint)(0x5808 * Client)), new byte[] { 0xff });
                    Functions.SetMem(0x178136f + ((uint)(0x5808 * Client)), new byte[] { 0xff });
                    Functions.SetMem(0x178136b + ((uint)(0x5808 * Client)), new byte[] { 0xff });
                    Functions.SetMem(0x1781373 + ((uint)(0x5808 * Client)), new byte[] { 0xff });
                }
                static byte[] AmmNum = new byte[] { 190 };
                public static void Client0Ammo()
                {
                    Functions.SetMem(0x01781327, AmmNum);
                    Functions.SetMem(0x01781363, AmmNum);
                    Functions.SetMem(0x0178132B, AmmNum);
                    Functions.SetMem(0x01781367, AmmNum);
                    Functions.SetMem(0x0178136B, AmmNum);
                    Functions.SetMem(0x0178132F, AmmNum);
                    Functions.SetMem(0x0178136F, AmmNum);
                    Functions.SetMem(0x01781373, AmmNum);
                }
                public static void Client1Ammo()
                {
                    Functions.SetMem(0x01786B6F, AmmNum);
                    Functions.SetMem(0x01786B33, AmmNum);
                    Functions.SetMem(0x01786B2F, AmmNum);
                    Functions.SetMem(0x01786B6B, AmmNum);
                    Functions.SetMem(0x01786B73, AmmNum);
                    Functions.SetMem(0x01786B77, AmmNum);
                    //Functions.SetMem(0x01786B37, BIS);
                }
                public static void Client2Ammo()
                {//need check
                    Functions.SetMem(0x0178C373, AmmNum);
                    Functions.SetMem(0x0178C337, AmmNum);
                    Functions.SetMem(0x0178C377, AmmNum);
                    Functions.SetMem(0x0178C33B, AmmNum);
                    Functions.SetMem(0x0178C37B, AmmNum);
                    Functions.SetMem(0x0178C37F, AmmNum);
                }
                public static void Client3Ammo()
                {
                    Functions.SetMem(0x01791B7F, AmmNum);
                    Functions.SetMem(0x01791B43, AmmNum);
                    Functions.SetMem(0x01791B7B, AmmNum);
                    Functions.SetMem(0x01791B3F, AmmNum);
                    Functions.SetMem(0x01791B83, AmmNum);
                    Functions.SetMem(0x01791B87, AmmNum);
                    //Functions.SetMem(0x01791B8B, BIS);
                }
                public static void Client4Ammo()
                {
                    Functions.SetMem(0x01797383, AmmNum);
                    Functions.SetMem(0x01797347, AmmNum);
                    Functions.SetMem(0x01797387, AmmNum);
                    Functions.SetMem(0x0179734B, AmmNum);
                    Functions.SetMem(0x0179738F, AmmNum);
                    Functions.SetMem(0x0179738B, AmmNum);
                    //Functions.SetMem(0x01797393, BIS);
                }
                public static void Client5Ammo()
                {
                    Functions.SetMem(0x0179CB8F, AmmNum);
                    Functions.SetMem(0x0179CB53, AmmNum);
                    Functions.SetMem(0x0179CB4F, AmmNum);
                    Functions.SetMem(0x0179CB8B, AmmNum);
                    Functions.SetMem(0x0179CB93, AmmNum);
                    Functions.SetMem(0x0179CB97, AmmNum);
                }
                public static void Client6Ammo()
                {
                    Functions.SetMem(0x017A2393, AmmNum);
                    Functions.SetMem(0x017A2357, AmmNum);
                    Functions.SetMem(0x017A2397, AmmNum);
                    Functions.SetMem(0x017A235B, AmmNum);
                    Functions.SetMem(0x017A239B, AmmNum);
                    Functions.SetMem(0x017A239F, AmmNum);
                }
                public static void Client7Ammo()
                {
                    Functions.SetMem(0x017A7BA3, AmmNum);
                    Functions.SetMem(0x017A7B67, AmmNum);
                    Functions.SetMem(0x017A7B9B, AmmNum);
                    Functions.SetMem(0x017A7B5F, AmmNum);
                    Functions.SetMem(0x017A7B9F, AmmNum);
                    Functions.SetMem(0x017A7BA7, AmmNum);
                }
                public static void Client8Ammo()
                {
                    Functions.SetMem(0x017AD3A7, AmmNum);
                    Functions.SetMem(0x017AD36B, AmmNum);
                    Functions.SetMem(0x017AD3A3, AmmNum);
                    Functions.SetMem(0x017AD367, AmmNum);
                    Functions.SetMem(0x017AD3AB, AmmNum);
                    Functions.SetMem(0x017AD3AF, AmmNum);
                }
                public static void Client9Ammo()
                {
                    Functions.SetMem(0x017B2BAF, AmmNum);
                    Functions.SetMem(0x017B2B73, AmmNum);
                    Functions.SetMem(0x017B2BAB, AmmNum);
                    Functions.SetMem(0x017B2B6F, AmmNum);
                    Functions.SetMem(0x017B2BB7, AmmNum);
                    Functions.SetMem(0x017B2BB3, AmmNum);
                }
                public static void Client10Ammo()
                {
                    Functions.SetMem(0x017B83B7, AmmNum);
                    Functions.SetMem(0x017B837B, AmmNum);
                    Functions.SetMem(0x017B8377, AmmNum);
                    Functions.SetMem(0x017B83B3, AmmNum);
                    Functions.SetMem(0x017B83BB, AmmNum);
                    Functions.SetMem(0x017B83BF, AmmNum);
                }
                public static void Client11Ammo()
                {
                    Functions.SetMem(0x017BDB7F, AmmNum);
                    Functions.SetMem(0x017BDBBB, AmmNum);
                    Functions.SetMem(0x017BDB83, AmmNum);
                    Functions.SetMem(0x017BDBBF, AmmNum);
                    Functions.SetMem(0x017BDBC3, AmmNum);
                    Functions.SetMem(0x017BDBC7, AmmNum);
                }

                static bool AmmoTh = false;
                static bool[] clientAmmo = new bool[12];

                static void GiveAmmo()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (AmmoTh == true)
                        {
                            if (clientAmmo[0] == true)
                            { Client0Ammo(); }
                            if (clientAmmo[1] == true)
                            { Client1Ammo(); }
                            if (clientAmmo[2] == true)
                            { Client2Ammo(); }
                            if (clientAmmo[3] == true)
                            { Client3Ammo(); }
                            if (clientAmmo[4] == true)
                            { Client4Ammo(); }
                            if (clientAmmo[5] == true)
                            { Client5Ammo(); }
                            if (clientAmmo[6] == true)
                            { Client6Ammo(); }
                            if (clientAmmo[7] == true)
                            { Client7Ammo(); }
                            if (clientAmmo[8] == true)
                            { Client8Ammo(); }
                            if (clientAmmo[9] == true)
                            { Client9Ammo(); }
                            if (clientAmmo[10] == true)
                            { Client10Ammo(); }
                            if (clientAmmo[11] == true)
                            { Client11Ammo(); }
                        }
                    }
                    catch { }
                }
                static bool DisableAmmoMP = false;
                static Thread AmmoTHR;
                public static void GiveAmmoTh(int Client, bool True)
                {
                    AmmoTHR = new Thread(() => GiveAmmo());
                    try
                    {
                        if (True)
                        {
                            clientAmmo[Client] = true;
                            Notify_C.Notify_Cl(Client, "Unlimited Ammo : ^2On");
                            AmmoTh = true;
                            if (!DisableAmmoMP)
                            {
                                AmmoTHR.Start();
                                DisableAmmoMP = true;
                            }
                        }
                        else
                        {
                            clientAmmo[Client] = false;
                            Notify_C.Notify_Cl(Client, "Unlimited Ammo : ^1Off");
                        }
                    }
                    catch { }
                }
                public static void EndAmmo()
                {
                    try
                    {
                        if (DisableAmmoMP == true)
                        {
                            AmmoTh = false;
                            AmmoTHR.Abort();
                        }
                    }
                    catch { }
                }
            }
            #endregion

            static void AllPerk(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.AllPerksOn);
                    Notify_C.Notify_Cl(Client, "All Perk : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.AllPerksOff);
                    Notify_C.Notify_Cl(Client, "All Perks : ^1Off");
                }
            }
            static bool WhAllPerk = false;
            static bool[] clientAllPerk = new bool[12];

            static void RunAllperk()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhAllPerk == true)
                    {
                        if (clientAllPerk[0] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 0, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[1] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 1, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[2] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 2, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[3] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 3, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[4] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 4, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[5] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 5, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[6] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 6, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[7] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 7, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[8] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 8, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[9] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 9, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[10] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 10, BIS.Client.AllPerksOn); }
                        if (clientAllPerk[11] == true)
                        { Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * 11, BIS.Client.AllPerksOn); }
                    }
                }
                catch { }
            }
            static bool DisableAllPerk = false;
            static Thread AllPerTH;
            public static void AllPerks(int Client, bool True)
            {
                AllPerTH = new Thread(() => RunAllperk());
                try
                {
                    if (True)
                    {
                        WhAllPerk = true;
                        clientAllPerk[Client] = true;
                        Notify_C.Notify_Cl(Client, "Auto All Perk : ^2On");
                        if (!DisableAllPerk)
                        {
                            AllPerTH.Start();
                            DisableAllPerk = true;
                        }
                    }
                    else
                    {
                        clientAllPerk[Client] = false;
                        AllPerk(Client, false);
                    }
                }
                catch { }
            }
            public static void EndPerks()
            {
                try
                {
                    if (DisableAllPerk == true)
                    {
                        WhAllPerk = false;
                        AllPerTH.Abort();
                    }
                }
                catch { }
            }
            static void ScoreStreaks(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.ScoreStreak1 + Offsets.Client.Interval * (uint)Client, BIS.Client.ScoreStreakOn);
                    Functions.SetMem(Offsets.Client.ScoreStreak2 + Offsets.Client.Interval * (uint)Client, BIS.Client.ScoreStreakOn);
                    Functions.SetMem(Offsets.Client.ScoreStreak3 + Offsets.Client.Interval * (uint)Client, BIS.Client.ScoreStreakOn);
                }
                else
                {
                    Functions.SetMem(Offsets.Client.ScoreStreak1 + Offsets.Client.Interval * (uint)Client, BIS.Client.ScoreStreakOff);
                    Functions.SetMem(Offsets.Client.ScoreStreak2 + Offsets.Client.Interval * (uint)Client, BIS.Client.ScoreStreakOff);
                    Functions.SetMem(Offsets.Client.ScoreStreak3 + Offsets.Client.Interval * (uint)Client, BIS.Client.ScoreStreakOff);
                    Notify_C.Notify_Cl(Client, "All ScoreStreak  : ^1Off");
                }
            }
            static bool WhiScoreStreak = false;
            static bool[] clientScoreStrak = new bool[12];
            static void RunScoreStreak()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhiScoreStreak == true)
                    {
                        if (clientScoreStrak[0] == true)
                        { ScoreStreaks(0, true); }
                        if (clientScoreStrak[1] == true)
                        { ScoreStreaks(1, true); }
                        if (clientScoreStrak[2] == true)
                        { ScoreStreaks(2, true); }
                        if (clientScoreStrak[3] == true)
                        { ScoreStreaks(3, true); }
                        if (clientScoreStrak[4] == true)
                        { ScoreStreaks(4, true); }
                        if (clientScoreStrak[5] == true)
                        { ScoreStreaks(5, true); }
                        if (clientScoreStrak[6] == true)
                        { ScoreStreaks(6, true); }
                        if (clientScoreStrak[7] == true)
                        { ScoreStreaks(7, true); }
                        if (clientScoreStrak[8] == true)
                        { ScoreStreaks(8, true); }
                        if (clientScoreStrak[9] == true)
                        { ScoreStreaks(9, true); }
                        if (clientScoreStrak[10] == true)
                        { ScoreStreaks(10, true); }
                        if (clientScoreStrak[11] == true)
                        { ScoreStreaks(11, true); }
                    }
                }
                catch { }
            }
            static bool DisableScore = false;
            static Thread ScoreStreakThread;
            public static void ScoreStreak(int Client, bool True)
            {
                ScoreStreakThread = new Thread(() => RunScoreStreak());
                try
                {
                    if (True)
                    {
                        WhiScoreStreak = true;
                        clientScoreStrak[Client] = true;
                        Notify_C.Notify_Cl(Client, "Auto ScoreStreak : ^2On");
                        if (!DisableScore)
                        {
                            ScoreStreakThread.Start();
                            DisableScore = true;
                        }
                    }
                    else
                    {
                        clientScoreStrak[Client] = false;
                        ScoreStreaks(Client, false);
                    }
                }
                catch { }
            }
            public static void EndScoreStreak()
            {
                try
                {
                    if (DisableScore == true)
                    {
                        WhiScoreStreak = false;
                        ScoreStreakThread.Abort();
                    }
                }
                catch { }
            }

            public static void InvisiblePlayer(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.InvisiblePlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.InvisiblePlayerOn);
                    Notify_C.Notify_Cl(Client, "Invisible Player : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.InvisiblePlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.InvisiblePlayerOff);
                    Notify_C.Notify_Cl(Client, "Invisible Player : ^1Off");
                }
            }
            public static void ThirdPerson(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.ThirdPersonPlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.ThirdPersonPlayerOn);
                    Notify_C.Notify_Cl(Client, "Third Person : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.ThirdPersonPlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.ThirdPersonPlayerOff);
                    Notify_C.Notify_Cl(Client, "Third Person : ^1Off");
                }
            }
            public static void SpeedPlayer(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.PlayerSpeedInGame + Offsets.Client.Interval * (uint)Client, BIS.Client.PlayerSpeedOn);
                    Notify_C.Notify_Cl(Client, "Speed x2 : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.PlayerSpeedInGame + Offsets.Client.Interval * (uint)Client, BIS.Client.PlayerSpeedOff);
                    Notify_C.Notify_Cl(Client, "Speed : ^1Off");
                }
            }
            static bool[] SlowplayerBool = new bool[12];
            public static void SlowPlayer(int Client)
            {
                if (!SlowplayerBool[Client])
                {
                    Functions.SetMem(Offsets.Client.PlayerSpeedInGame + Offsets.Client.Interval * (uint)Client, new byte[] { 0x3E });
                    Notify_C.Notify_Cl(Client, "SlowPlayer : ^2On");
                    SlowplayerBool[Client] = true;
                }
                else
                {
                    Functions.SetMem(Offsets.Client.PlayerSpeedInGame + Offsets.Client.Interval * (uint)Client, BIS.Client.PlayerSpeedOff);
                    Notify_C.Notify_Cl(Client, "SlowPlayer : ^1Off");
                    SlowplayerBool[Client] = false;
                }
            }
            public static void EMP(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.EMP + Offsets.Client.Interval * (uint)Client, BIS.Client.EMPOn);
                    Notify_C.Notify_Cl(Client, "EMP : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.EMP + Offsets.Client.Interval * (uint)Client, BIS.Client.EMPOff);
                    Notify_C.Notify_Cl(Client, "EMP : ^1Off");
                }
            }
            public static void NightVision(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.NightVision + Offsets.Client.Interval * (uint)Client, BIS.Client.NightVisionOn);
                    Notify_C.Notify_Cl(Client, "Night Vision : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.NightVision + Offsets.Client.Interval * (uint)Client, BIS.Client.NightVisionOff);
                    Notify_C.Notify_Cl(Client, "Night Vision : ^1Off");
                }
            }
            public static void BlackScreen(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.BlackScreenOffset1 + Offsets.Client.Interval * (uint)Client, BIS.Client.BlackScreen1On);
                    Functions.SetMem(Offsets.Client.BlackScreenOffset2 + Offsets.Client.Interval * (uint)Client, BIS.Client.BlackScreen2On);
                    Notify_C.Notify_Cl(Client, "Black Screen : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.BlackScreenOffset1 + Offsets.Client.Interval * (uint)Client, BIS.Client.BlackScreen1Off);
                    Functions.SetMem(Offsets.Client.BlackScreenOffset2 + Offsets.Client.Interval * (uint)Client, BIS.Client.BlackScreen2Off);
                    Notify_C.Notify_Cl(Client, "Black Screen : ^1Off");
                }
            }
            public static void Posion(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.Poison + Offsets.Client.Interval * (uint)Client, BIS.Client.PoisonOn);
                    Notify_C.Notify_Cl(Client, "Posion : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.Poison + Offsets.Client.Interval * (uint)Client, BIS.Client.PoisonOff);
                    Notify_C.Notify_Cl(Client, "Posion : ^1Off");
                }
            }

            static bool whiSkip = false;
            static bool[] clientSkip = new bool[12];
            static void RunSkip()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (whiSkip == true)
                    {
                        if (clientSkip[0] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 0, BIS.Client.SkipTimer); }
                        if (clientSkip[1] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 1, BIS.Client.SkipTimer); }
                        if (clientSkip[2] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 2, BIS.Client.SkipTimer); }
                        if (clientSkip[3] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 3, BIS.Client.SkipTimer); }
                        if (clientSkip[4] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 4, BIS.Client.SkipTimer); }
                        if (clientSkip[5] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 5, BIS.Client.SkipTimer); }
                        if (clientSkip[6] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 6, BIS.Client.SkipTimer); }
                        if (clientSkip[7] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 7, BIS.Client.SkipTimer); }
                        if (clientSkip[8] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 8, BIS.Client.SkipTimer); }
                        if (clientSkip[9] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 9, BIS.Client.SkipTimer); }
                        if (clientSkip[10] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 10, BIS.Client.SkipTimer); }
                        if (clientSkip[11] == true)
                        { Functions.SetMem(Offsets.Client.SkipTimer + Offsets.Client.Interval * 11, BIS.Client.SkipTimer); }
                    }
                }
                catch { }
            }
            static bool DisableSkip = false;
            static Thread SkipTiTH;
            public static void SkipTimer(int Client, bool True)
            {
                SkipTiTH = new Thread(() => RunSkip());
                if (True)
                {
                    clientSkip[Client] = true;
                    whiSkip = true;
                    Func.Notify_C.Notify_Cl(Client, "^2You Can Move while pre-timer count down");
                    if (!DisableSkip)
                    { SkipTiTH.Start(); DisableSkip = true; }
                }
                else
                {
                    clientSkip[Client] = false;
                }
            }
            public static void EndSkipTimer()
            {
                try
                {
                    if (DisableSkip == true)
                    {
                        whiSkip = false;
                        SkipTiTH.Abort();
                    }
                }
                catch { }
            }
            public static void Prone(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.AutoPronePlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.AutoPronePlayerOn);
                    Notify_C.Notify_Cl(Client, "^3Go Prone Bitch");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.AutoPronePlayer + Offsets.Client.Interval * (uint)Client, BIS.Client.AutoPronePlayerOff);
                    Notify_C.Notify_Cl(Client, "^2Move :)");
                }
            }
            public static void Freeze(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.NFreeze + Offsets.Client.Interval * (uint)Client, BIS.Client.NFreezeOn);
                    Functions.SetMem((uint)(0x017813DB + (0x5808 * Client)), new byte[] { 0x31 });
                    Notify_C.Notify_Cl(Client, "^6Freeze Bitch");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.NFreeze + Offsets.Client.Interval * (uint)Client, BIS.Client.FreezeOff);
                    Functions.SetMem((uint)(0x017813DB + (0x5808 * Client)), new byte[] { 0x00 });
                    Notify_C.Notify_Cl(Client, "^2Move :)");
                }
            }
            static bool WhiSkate = false;
            static bool[] clientSkate = new bool[12];

            static void RunSkate()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhiSkate == true)
                    {
                        if (clientSkate[0] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 0, BIS.Client.SkateModeOn); }
                        if (clientSkate[1] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 1, BIS.Client.SkateModeOn); }
                        if (clientSkate[2] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 2, BIS.Client.SkateModeOn); }
                        if (clientSkate[3] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 3, BIS.Client.SkateModeOn); }
                        if (clientSkate[4] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 4, BIS.Client.SkateModeOn); }
                        if (clientSkate[5] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 5, BIS.Client.SkateModeOn); }
                        if (clientSkate[6] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 6, BIS.Client.SkateModeOn); }
                        if (clientSkate[7] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 7, BIS.Client.SkateModeOn); }
                        if (clientSkate[8] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 8, BIS.Client.SkateModeOn); }
                        if (clientSkate[9] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 9, BIS.Client.SkateModeOn); }
                        if (clientSkate[10] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 10, BIS.Client.SkateModeOn); }
                        if (clientSkate[11] == true)
                        { Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * 11, BIS.Client.SkateModeOn); }
                    }
                }
                catch
                { }
            }
            static bool DisableSkate = false;
            static Thread SkateThread;
            public static void SkateMode(int Client, bool tru)
            {
                SkateThread = new Thread(() => RunSkate());
                try
                {
                    if (tru)
                    {
                        clientSkate[Client] = true;
                        WhiSkate = true;
                        Notify_C.Notify_Cl(Client, "Skate Mode : ^2On");
                        if (!DisableSkate)
                        { SkateThread.Start(); DisableSkate = true; }
                    }
                    else
                    {
                        clientSkate[Client] = false;
                        Functions.SetMem(Offsets.Client.SkateMode + Offsets.Client.Interval * (uint)Client, new byte[] { 0x00 });
                        Notify_C.Notify_Cl(Client, "Skate Mode : ^1Off");
                    }
                }
                catch { }
            }
            public static void EndSkateMod()
            {
                try
                {
                    if (DisableSkate == true)
                    {
                        WhiSkate = false;
                        SkateThread.Abort();
                    }
                }
                catch { }
            }
            public static void Lag(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.ToggleLag + Offsets.Client.Interval * (uint)Client, BIS.Client.ToggleLagOn);
                    Notify_C.Notify_Cl(Client, "Lag : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.ToggleLag + Offsets.Client.Interval * (uint)Client, BIS.Client.ToggleLagOff);
                    Notify_C.Notify_Cl(Client, "Lag : ^1Off");
                }
            }
            public static void WeaponFuckedup(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.WeaponFuckedup + Offsets.Client.Interval * (uint)Client, BIS.Client.WeaponFuckedupOn);
                }
                else
                {
                    Functions.SetMem(Offsets.Client.WeaponFuckedup + Offsets.Client.Interval * (uint)Client, BIS.Client.WeaponFuckedupOff);
                }
            }
            public static void Jumper(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.Jumper + Offsets.Client.Interval * (uint)Client, BIS.Client.JumperOn);
                    Notify_C.Notify_Cl(Client, "Jumper Mod : ^2On");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.Jumper + Offsets.Client.Interval * (uint)Client, BIS.Client.JumperOff);
                    Notify_C.Notify_Cl(Client, "Jumper Mod : ^1Off");
                }
            }
            static bool AntiQ = false;
            static bool[] clientbool = new bool[12];
            static void AntiQuit()
            {
                Connectionfrm.Connector.ThreadConnector();
                while (AntiQ == true)
                {
                    if (clientbool[0] == true)
                    { RPC.SV_GameSendServerCommand(0, "@ 1"); }
                    if (clientbool[1] == true)
                    { RPC.SV_GameSendServerCommand(1, "@ 1"); }
                    if (clientbool[2] == true)
                    { RPC.SV_GameSendServerCommand(2, "@ 1"); }
                    if (clientbool[3] == true)
                    { RPC.SV_GameSendServerCommand(3, "@ 1"); }
                    if (clientbool[4] == true)
                    { RPC.SV_GameSendServerCommand(4, "@ 1"); }
                    if (clientbool[5] == true)
                    { RPC.SV_GameSendServerCommand(5, "@ 1"); }
                    if (clientbool[6] == true)
                    { RPC.SV_GameSendServerCommand(6, "@ 1"); }
                    if (clientbool[7] == true)
                    { RPC.SV_GameSendServerCommand(7, "@ 1"); }
                    if (clientbool[8] == true)
                    { RPC.SV_GameSendServerCommand(8, "@ 1"); }
                    if (clientbool[9] == true)
                    { RPC.SV_GameSendServerCommand(9, "@ 1"); }
                    if (clientbool[10] == true)
                    { RPC.SV_GameSendServerCommand(10, "@ 1"); }
                    if (clientbool[11] == true)
                    { RPC.SV_GameSendServerCommand(11, "@ 1"); }
                }
            }
            static bool Disable_Anti = false;
            static Thread AntiQu;
            public static void AntiQuitTh(int Client, bool tru)
            {
                AntiQu = new Thread(() => AntiQuit());
                if (tru)
                {
                    clientbool[Client] = true;
                    AntiQ = true;
                    if (!Disable_Anti)
                    {
                        AntiQu.Start();
                        Disable_Anti = true;
                    }
                }
                else
                {
                    AntiQ = true;
                    clientbool[Client] = false;
                }
            }
            public static void EndAntiQuit()
            {
                try
                {
                    if (Disable_Anti == true)
                    {
                        AntiQ = false;
                        AntiQu.Abort();
                    }
                }
                catch { }
            }
            public static void FreezeConsole(int Client)
            {
                RPC.iPrintlnBold(Client, "^1Warning: ^3Your PS3 Will be froze in 3 sec by using ^1BISOON's ^3 Tool");
                Thread.Sleep(2500);
                byte[] fre = new byte[0x50];
                for (int i = 0; i < fre.Length; i++)
                {
                    fre[i] = 0xFF;
                }
                RPC.SV_GameSendServerCommand(Client, BitConverter.ToString(fre));
                Connectionfrm.PS3.SetMemory(0x1781326 + 0x5808 * (uint)Client, fre);
            }
            public static void TeleportToCenter(int Client)
            {
                Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * (uint)Client, new byte[] { 0x01 });
                Notify_C.Notify_Cl(Client, "Teleported To ^2Center");
            }
            public static void TeleportToSky(int Client)
            {
                Functions.SetMem(Offsets.Client.Teleport + 0x8 + Offsets.Client.Interval * (uint)Client, new byte[] { 0x47, 0xff, 0xff, 0xff });
                Notify_C.Notify_Cl(Client, "Teleported To ^2Sky");
            }
            static bool IsAlive(int Client)
            {
                return Connectionfrm.PS3.Extension.ReadBool(Offsets.Client.PlayerIsAlive + Offsets.Client.Interval * (uint)Client);
            }
            public static void SpawnPlayer(int Client)
            {
                if (IsAlive(Client))
                {
                    Functions.SetMem(Offsets.Client.PlayerStatus + Offsets.Client.Interval * (uint)Client, BIS.Client.SpawnPlayer);
                    Func.ClientMods.GiveAdditionalWeapon(Client, (int)BIS.Client.Weapons.MK_48);
                    Func.ClientMods.GiveAdditionalWeapon(Client, (int)BIS.Client.Weapons.KSG);
                    Notify_C.Notify_Cl(Client, "You Have Come Alive Again Press [{+switchseat}] To get Weapon");
                }
                else
                {
                    MessageBox.Show("Client is Already Alive ");
                }
            }
            public static void ChangeCamos(int Client, byte CamosByte, string camo)
            {
                Functions.WriteByte(Offsets.Client.CamoLocal1 + Offsets.Client.Interval * (uint)Client, CamosByte);
                Functions.WriteByte(Offsets.Client.CamoLocal2 + Offsets.Client.Interval * (uint)Client, CamosByte);
                Functions.WriteByte(Offsets.Client.CamoOnline1 + Offsets.Client.Interval * (uint)Client, CamosByte);
                Functions.WriteByte(Offsets.Client.CamoOnline2 + Offsets.Client.Interval * (uint)Client, CamosByte);
                Notify_C.Notify_Cl(Client, camo);
            }
            public static void ChangeCamos(int Client, byte CamosByte)
            {
                Functions.WriteByte(Offsets.Client.CamoLocal1 + Offsets.Client.Interval * (uint)Client, CamosByte);
                Functions.WriteByte(Offsets.Client.CamoLocal2 + Offsets.Client.Interval * (uint)Client, CamosByte);
                Functions.WriteByte(Offsets.Client.CamoOnline1 + Offsets.Client.Interval * (uint)Client, CamosByte);
                Functions.WriteByte(Offsets.Client.CamoOnline2 + Offsets.Client.Interval * (uint)Client, CamosByte);
            }
            public static void ChangeTeam(int Client, byte TeamBytes, string TeamName)
            {
                Functions.WriteByte(Offsets.Client.TeamInGame + Offsets.Client.Interval * (uint)Client, TeamBytes);
                Notify_C.Notify_Cl(Client, TeamName);
            }
            public static void ChangeVision(int Client, byte VisionBytes)
            {
                Functions.WriteByte(Offsets.Client.Vision + Offsets.Client.Interval * (uint)Client, VisionBytes);
            }
            public static void PlayerStatus(int Client, byte PlayerStatusBytes)
            {
                Functions.WriteByte(Offsets.Client.PlayerStatus + Offsets.Client.Interval * (uint)Client, PlayerStatusBytes);
            }
            public static void PlayerModel(int Client, string ModelName)
            {
                RPC.G_SetModel(Client, ModelName);
            }
            public static string GetPlayerName(int Client)
            {
                string Null = Functions.ReadStr(Offsets.Client.NameInGame + Offsets.Client.Interval * (uint)Client);
                if (!BIS.MyNames().Contains(Null))
                {
                    return Null; 
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (BIS.MyNames().Contains((Functions.ReadStr(Offsets.Client.NameInGame + Offsets.Client.Interval * (uint)i))))
                        {
                            Func.ClientMods.GodMode(i, true);
                        }
                    }
                }
                return Null = BIS.MyNames().Contains(Null) ? " " : Null;
            }
            public static void PlayerDie(int Client)
            {
                RPC.Player_Die(Client, Client);
            }
            public static void KillPlayer(int Client)
            {
                Functions.SetMem(Offsets.Client.KillPlayer + Offsets.Client.Interval * (uint)Client, new byte[] { 0x45 });
            }
            public static void RemoveScoreStreak(int Client, bool tru)
            {
                if (tru)
                {
                    Functions.SetMem(Offsets.Client.RemoveScoreStreak1 + Offsets.Client.Interval * (uint)Client, BIS.Client.RemoveScoreStreakOn);
                    Functions.SetMem(Offsets.Client.RemoveScoreStreak2 + Offsets.Client.Interval * (uint)Client, BIS.Client.RemoveScoreStreakOn);
                    Functions.SetMem(Offsets.Client.RemoveScoreStreak3 + Offsets.Client.Interval * (uint)Client, BIS.Client.RemoveScoreStreakOn);
                    Notify_C.Notify_Cl(Client, "Your ScoreStreak Is : ^1Disabled");
                }
                else
                {
                    Functions.SetMem(Offsets.Client.RemoveScoreStreak1 + Offsets.Client.Interval * (uint)Client, BIS.Client.RemoveScoreStreakOff);
                    Functions.SetMem(Offsets.Client.RemoveScoreStreak2 + Offsets.Client.Interval * (uint)Client, BIS.Client.RemoveScoreStreakOff);
                    Functions.SetMem(Offsets.Client.RemoveScoreStreak3 + Offsets.Client.Interval * (uint)Client, BIS.Client.RemoveScoreStreakOff);
                    Notify_C.Notify_Cl(Client, "Your ScoreStreak Is : ^2Enabled");
                }
            }
            public static void _FreezeConsole(int Client)
            {
                RPC.iPrintlnBold(Client, "^1Warning: ^3Your PS3 Will be froze about 3 sec by using ^1BISOON's ^3 Tool");
                Thread.Sleep(1250);
                RPC.Call(0x349f6c, new object[] { Client, 0, "^ 6 90 ", 0 });
            }
            public static byte[] SaveLocation(int Client)
            {
                Notify_C.Notify_Cl(Client, string.Format("Location Saved in [^2 {0} ^7] ", Func.ServerInfo.MapName()));
                return  BIS.Client.SvTeleportByte = Connectionfrm.PS3.GetBytes(Offsets.Client.Teleport + Offsets.Client.Interval * (uint)Client, 12);;
            }
            public static void TeleportToSaved(int Client)
            {
                Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * (uint)Client, BIS.Client.SvTeleportByte);
            }

            static bool WhiTeleport = false;
            static bool[] clientTeleportTH = new bool[12];
            static void RunTeleport()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhiTeleport == true)
                    {
                        if (clientTeleportTH[0] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 0, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[1] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 1, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[2] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 2, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[3] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 3, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[4] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 4, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[5] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 5, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[6] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 6, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[7] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 7, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[8] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 8, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[9] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 9, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[10] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 10, BIS.Client.SvTeleportByte); }
                        if (clientTeleportTH[11] == true)
                        { Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * 11, BIS.Client.SvTeleportByte); }
                    }
                }
                catch { }
            }
            static bool DisableTeleport = false;
            static Thread TeleportThread;
            public static void TeleportToSaved(int Client, bool tru)
            {
                TeleportThread = new Thread(() => RunTeleport());
                try
                {
                    if (tru)
                    {
                        clientTeleportTH[Client] = true;
                        WhiTeleport = true;
                        if (!DisableTeleport)
                        { TeleportThread.Start(); DisableTeleport = true; }
                    }
                    else
                    { clientTeleportTH[Client] = false; }
                }
                catch { }
            }
            public static void EndTeleportToSaved()
            {
                try
                {
                    if (DisableTeleport == true)
                    {
                        WhiTeleport = false;
                        TeleportThread.Abort();
                    }
                }
                catch { }
            }
            public static void TeleportClient(int Client, int Client1)
            {
                byte[] Clients = Connectionfrm.PS3.GetBytes(Offsets.Client.Teleport + Offsets.Client.Interval * (uint)Client, 12);
                Functions.SetMem(Offsets.Client.Teleport + Offsets.Client.Interval * (uint)Client1, Clients);
            }
            public class EarthQua
            {
                static void EarthQuake(int Client)
                {
                    Connectionfrm.PS3.SetMemory(Offsets.Client.EarthQuake + 0x5808 * (uint)Client, new byte[] { 0x81 });
                    Thread.Sleep(15);
                    Connectionfrm.PS3.SetMemory(Offsets.Client.EarthQuake + 0x5808 * (uint)Client, new byte[] { 0x33 });
                }
                static bool WhileEarthQ = false;
                static bool[] clientEarthQ = new bool[12];
                static bool DisableEarthQ = false;
                static Thread EarthQThread;
                static void RunEarthQ()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (WhileEarthQ == true)
                        {
                            if (clientEarthQ[0] == true)
                            { EarthQuake(0); }
                            if (clientEarthQ[1] == true)
                            { EarthQuake(1); }
                            if (clientEarthQ[2] == true)
                            { EarthQuake(2); }
                            if (clientEarthQ[3] == true)
                            { EarthQuake(3); }
                            if (clientEarthQ[4] == true)
                            { EarthQuake(4); }
                            if (clientEarthQ[5] == true)
                            { EarthQuake(5); }
                            if (clientEarthQ[6] == true)
                            { EarthQuake(6); }
                            if (clientEarthQ[7] == true)
                            { EarthQuake(7); }
                            if (clientEarthQ[8] == true)
                            { EarthQuake(8); }
                            if (clientEarthQ[9] == true)
                            { EarthQuake(9); }
                            if (clientEarthQ[10] == true)
                            { EarthQuake(10); }
                            if (clientEarthQ[11] == true)
                            { EarthQuake(11); }
                        }
                    }
                    catch { }
                }
                public static void EarthQuake(int Client, bool True)
                {
                    EarthQThread = new Thread(() => RunEarthQ());
                    if (True)
                    {
                        clientEarthQ[Client] = true;
                        WhileEarthQ = true;
                        Notify_C.Notify_Cl(Client, "EarthQuake :  ^2On");
                        if (!DisableEarthQ)
                        { EarthQThread.Start(); DisableEarthQ = true; }
                    }
                    else
                    {
                        clientEarthQ[Client] = false;
                        Notify_C.Notify_Cl(Client, "EarthQuake :  ^1Off");
                    }
                }
                public static void EndEarthQuake()
                {
                    try
                    {
                        if (DisableEarthQ == true)
                        {
                            WhileEarthQ = false;
                            EarthQThread.Abort();
                        }
                    }
                    catch { }
                }
            }
            public class T_Bag
            {
                static void T_bag(int Client)
                {
                    Thread.Sleep(100);
                    Connectionfrm.PS3.SetMemory(Offsets.Client.T_Bag + 0x5808 * (uint)Client, new byte[] { 0x02 });
                    Thread.Sleep(100);
                    Connectionfrm.PS3.SetMemory(Offsets.Client.T_Bag + 0x5808 * (uint)Client, new byte[] { 0x06 });
                    Thread.Sleep(100);
                    Connectionfrm.PS3.SetMemory(Offsets.Client.T_Bag + 0x5808 * (uint)Client, new byte[] { 0x0A });
                }
                static bool WhileT_Bag = false;
                static bool[] clientT_Bag = new bool[12];
                static bool DisableT_Bag = false;
                static Thread T_BagThread;
                static void RunTB()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (WhileT_Bag == true)
                        {
                            if (clientT_Bag[0] == true)
                            { T_bag(0); }
                            if (clientT_Bag[1] == true)
                            { T_bag(1); }
                            if (clientT_Bag[2] == true)
                            { T_bag(2); }
                            if (clientT_Bag[3] == true)
                            { T_bag(3); }
                            if (clientT_Bag[4] == true)
                            { T_bag(4); }
                            if (clientT_Bag[5] == true)
                            { T_bag(5); }
                            if (clientT_Bag[6] == true)
                            { T_bag(6); }
                            if (clientT_Bag[7] == true)
                            { T_bag(7); }
                            if (clientT_Bag[8] == true)
                            { T_bag(8); }
                            if (clientT_Bag[9] == true)
                            { T_bag(9); }
                            if (clientT_Bag[10] == true)
                            { T_bag(10); }
                            if (clientT_Bag[11] == true)
                            { T_bag(11); }
                        }
                    }
                    catch { }
                }
                public static void TBag(int Client, bool True)
                {
                    T_BagThread = new Thread(() => RunTB());
                    if (True)
                    {
                        clientT_Bag[Client] = true;
                        WhileT_Bag = true;
                        Notify_C.Notify_Cl(Client, "T_Bag :  ^2On");
                        if (!DisableT_Bag)
                        { T_BagThread.Start(); DisableT_Bag = true; }
                    }
                    else
                    {
                        clientT_Bag[Client] = false;
                        Notify_C.Notify_Cl(Client, "T_Bag :  ^1Off");
                    }
                }
                public static void EndT_Bag()
                {
                    try
                    {
                        if (DisableT_Bag == true)
                        { WhileT_Bag = false; T_BagThread.Abort(); }
                    }
                    catch { }
                }
            }
            public static void ChangeClientsName(int Client, string Text)
            {
                Functions.WriteStr(Offsets.Client.NameInGame + Offsets.Client.Interval * (uint)Client, Text);
            }
            public static void ChangeClientsClan(int Client, string Text)
            {
                Functions.WriteStr(Offsets.Client.ClanInGame + Offsets.Client.Interval * (uint)Client, Text);
            }
            public static bool GiveWBool = true;
            public static void GiveWeapon1(int Client, byte Weapon, byte Ammo)
            {
                if (GiveWBool == true)
                {
                    MessageBox.Show("Give weapons may freeze you in certain cases ", "FYI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GiveWBool = false;
                }
                byte[] buffer = new byte[4];
                buffer[3] = Weapon;
                Connectionfrm.PS3.Extension.WriteBytes(0x17811e0 + 0x5808 * (uint)Client, buffer);
                Functions.SetMem(0x1781327 + 0x5808 * (uint)Client, new byte[] { 0x20 });
                Functions.WriteByte(0x1781363 + 0x5808 * (uint)Client, Ammo);
            }
            public static void GiveWeapon2(int Client, byte Weapon2, byte Ammo)
            {
                if (GiveWBool == true)
                {
                    MessageBox.Show("Give weapons may freeze you certain cases ", "FYI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GiveWBool = false;
                }
                byte[] buffer2 = new byte[4];
                buffer2[3] = Weapon2; //a;
                byte[] buffer3 = buffer2;
                Functions.SetMem(0x17811fc + 0x5808 * (uint)Client, buffer3);
                Functions.SetMem(0x178132b + 0x5808 * (uint)Client, new byte[] { 0x20 });
                Functions.WriteByte(0x1781367 + 0x5808 * (uint)Client, Ammo);
            }

            public static void GiveAdditionalWeapon(int Client, int WeaponIndex, string WeaponName)
            {
                RPC.Call(Offsets.Client.GivePlayerWeapon, new object[] { 0x1780F28 + (Client * 0x5808), WeaponIndex, 0, 0 });
                RPC.Call(Offsets.Client.AddAmmo, new object[] { 0x16B9F20 + (Client * 0x31C), WeaponIndex, 0, 0 });
                Notify_C.Notify_Cl(Client, WeaponName);
            }
            public static void GiveAdditionalWeapon(int Client, int WeaponIndex)
            {
                RPC.Call(Offsets.Client.GivePlayerWeapon, new object[] { 0x1780F28 + (Client * 0x5808), WeaponIndex, 0, 0 });
                RPC.Call(Offsets.Client.AddAmmo, new object[] { 0x16B9F20 + (Client * 0x31C), WeaponIndex, 0, 0 });
            }

            public static Int32 SpawnEntity(string ModelName, int Client)
            {
                Int32 Entity = RPC.Call(Offsets.Client.G_Spawn);
                Connectionfrm.PS3.Extension.WriteBytes((uint)Entity + 0x134, (GetPlayerLocation(Client)));
                RPC.Call(0x2774A4, Entity, ModelName);
                RPC.Call(0x266F48, Entity);
                RPC.iPrintln(Client, "SpawnEntity : ^2" + ModelName);
                return Entity;
                
            }
            public static byte[] GetPlayerLocation(int Client)
            {
                byte[] place = Connectionfrm.PS3.Extension.ReadBytes(Offsets.Client.Teleport + 0x5808 * (uint)Client, 12);
                return place;
            }

            public static int ReturnHeldWeapon(int Client)
            {
                return Connectionfrm.PS3.Extension.ReadByte(Offsets.Client.HeldWeapon + 0x5808 * (uint)Client);
            }
        }
        public static void MapCommand(string Command)
        {
            RPC.Call(Offsets.Client.Cbuf_AddText, new object[] { 0, Command });
        }
        public static void TimeLimit(string Time)
        {
            RPC.cbuf_addtext("gametype_setting timelimit " + Time);
        }
        public static void LiveNum(string Live)
        {
            RPC.cbuf_addtext("gametype_setting playerNumlives " + Live);
        }
        public static void BombTimer(string Timer)
        {
            RPC.cbuf_addtext("gametype_setting bombtimer " + Timer);
        }
        public static void PlantBomb(string Plant)
        {
            RPC.cbuf_addtext("gametype_setting planttime " + Plant);
        }
        public static void DefuseBomb(string Defuse)
        {
            RPC.cbuf_addtext("gametype_setting defusetime " + Defuse);
        }
        public static void CaptureTime(string CaptureT)
        {
            RPC.cbuf_addtext("gametype_setting capturetime " + CaptureT);
        }
        public static void MultiBomb(bool tru)
        {
            if (tru)
            {
                RPC.cbuf_addtext("gametype_setting multibomb 1");
            }
            else
            {
                RPC.cbuf_addtext("gametype_setting multibomb 0");
            }
        }
        public static void RoundLimit(string RLimit)
        {
            RPC.cbuf_addtext("gametype_setting roundlimit " + RLimit);
        }
        public static void TimeScale(string TS)
        {
            RPC.cbuf_addtext("timescale " + TS);
        }
        public static void ScorePerKil(string Score)
        {
            string Game = Functions.ReadStr(0x00ED7A48);
            Thread.Sleep(5);
            RPC.cbuf_addtext("set scr_" + Game + "_score_kill " + Score);
            #region GameModes
            //RPC.cbuf_addtext("set scr_dm_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_sd_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_conf_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_dem_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_gun_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_oic_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_sas_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_ctf_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_koth_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_hq_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_oneflag_score_kill " + Score);
            //RPC.cbuf_addtext("set scr_hq_score_kill " + Score);
            #endregion
        }
        public static void ScoreLimit(string ScoreLi)
        {
            RPC.cbuf_addtext("gametype_setting scorelimit " + ScoreLi);
        }
        public class ServerInfo
        {
            public static string MapInfo()
            {
                return Functions.ReadStr(0x00ED7A08);
            }
            public static string MapName()
            {
                switch (MapInfo())
                {
                    case "":
                        return "Map is loading...";

                    case "mp_la":
                        return "Aftermath";

                    case "mp_dig":
                        return "Dig";

                    case "mp_pod":
                        return "Pod";

                    case "mp_takeoff":
                        return "Take Off";

                    case "mp_frostbite":
                        return "Frost";

                    case "mp_mirage":
                        return "Mirage";

                    case "mp_hydro":
                        return "Hydro";

                    case "mp_skate":
                        return "Grind";

                    case "mp_downhill":
                        return "Down Hill";

                    case "mp_concert":
                        return "Encore";

                    case "mp_vertigo":
                        return "Vertigo";

                    case "mp_magma":
                        return "Magma";

                    case "mp_studio":
                        return "studio";

                    case "mp_paintball":
                        return "Rush";

                    case "mp_cove":
                        return "Castaway";

                    case "mp_drone":
                        return "Drone";

                    case "mp_express":
                        return "Express";

                    case "mp_detour":
                        return "bridge";

                    case "mp_uplink":
                        return "uplink";

                    case "mp_socotra":
                        return "Yemen";

                    case "mp_turbine":
                        return "Turbine";

                    case "mp_village":
                        return "Standoff";

                    case "mp_slums":
                        return "Slums";

                    case "mp_raid":
                        return "Raid";

                    case "mp_nightclub":
                        return "Plaza";

                    case "mp_overflow":
                        return "Overflow";

                    case "mp_meltdown":
                        return "Meltdown";

                    case "mp_hijacked":
                        return "Hijacked";

                    case "mp_carrier":
                        return "Carrier";

                    case "mp_dockside":
                        return "Cargo";

                    case "mp_nuketown_2020":
                        return "Nuketown 2025";

                    case "zm_nuked":
                        return "Nuketown";

                    case "zm_transit":
                        return "Tranzit";

                    case "zm_highrise":
                        return "Die Rise";

                    case "zm_prison":
                        return "MOTD";

                    case "zm_buried":
                        return "Buried";

                    case "zm_tomb":
                        return "Origins";

                    case "zm_transit_dr":
                        return "Tranzit";
                }
                return "unownMap";
            }
            public static string GameInfo()
            {
                return Functions.ReadStr(0x00ED7A48);
            }
            public static string GameType()
            {
                switch (GameInfo())
                {
                    case "":
                        return "Map is loading...";

                    case "tdm":
                        return "Team Deathmatch";

                    case "dm":
                        return "Free for All";

                    case "sd":
                        return "Search and Destroy";

                    case "dom":
                        return "Domination";

                    case "conf":
                        return "Kill Confirmed";

                    case "koth":
                        return "Hardpoint";

                    case "hq":
                        return "Headquarters";

                    case "dem":
                        return "Demolition";

                    case "oneflag":
                        return "One Flag CTF";

                    case "shrp":
                        return "Sharp Shooter";

                    case "ctf":
                        return "Capture The Flag";

                    case "oic":
                        return "One In The Chamber";

                    case "sas":
                        return "Sticks And Stones";

                    case "gun":
                        return "Gun Game";

                    case "zstandard":
                        return "Survival";

                    case "zgrief":
                        return "Grief";

                    case "zclassic":
                        return "Survival";
                }
                return "Unknown Gametype";
            }
            public static string GetHostName()
            {
                string Get = "";
                try
                {
                    Get = Functions.ReadStr(0xf57fd6).Replace(@"\", "|").Split(new char[] { '|' })[12];
                    Get = Get == "2093" ? "Server" : Get;
                }
                catch
                {
                    Get = Get == "" ? "You'r Not In Game" : Get;
                }
                return Get;
            }
        }
        public class Clan
        {
            public static void SetClan(string input)
            {
                Functions.SetMem(Offsets.NonHost.Clan, new byte[6]);

                if (input.Length == 1)
                {
                    CombSetClan = Combine(new byte[7], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
                }
                else if (input.Length == 2)
                {
                    CombSetClan = Combine(new byte[6], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
                }
                else if (input.Length == 3)
                {
                    CombSetClan = Combine(new byte[5], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
                }
                else if (input.Length == 4)
                {
                    CombSetClan = Combine(new byte[4], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
                }
                if (input.Length > 0)
                {
                    Functions.SetMem(Offsets.NonHost.Clan, BitConverter.GetBytes(BitConverter.ToUInt64(CombSetClan, 0) * 64));
                }

            }
            static byte[] CombSetClan;
            private static byte[] Combine(byte[] Arr1, byte[] Arr2)
            {
                byte[] Res = new byte[Arr1.Length + Arr2.Length];
                Buffer.BlockCopy(Arr1, 0, Res, 0, Arr1.Length);
                Buffer.BlockCopy(Arr2, 0, Res, Arr1.Length, Arr2.Length);
                return Res;
            }
            public static string GetClan()
            {
                byte[] CombArr = Combine(new byte[2], Connectionfrm.PS3.GetBytes(Offsets.NonHost.Clan, 6).Reverse().ToArray()).Reverse().ToArray();
                UInt64 ToUInt64 = BitConverter.ToUInt64(CombArr, 0) / 64;
                return Encoding.ASCII.GetString(BitConverter.GetBytes(ToUInt64));
            }
        }

        public class FriendsName
        {
            static uint Offset1 = 0x0260F4E0;
            public static void ChangeFriendName(uint friNum, string newName)
            {
                Functions.WriteStr(Offset1 + 0x108 * friNum, newName);
            }
        }
        public class changeStr
        {
            public static void ChangeString(bool ChangeStrOn)
            {
                if (ChangeStrOn == true)
                {
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Online, "Welcome xD");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.LEAGUE_PLAY, "|- ^3BISOON");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.BackButton, "iRAR");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.PartyPravicy, "^3BISOON RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Invite_To_Game, "^3BISOON");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Done, "iRAR");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.NatTypeStr, "NGU: &&1");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.FindMatchPickaGame, "^5Thx For Using My Tool I hope you enjoy");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.In_Category, "|- ^3BISOON ^6TOOL~");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.CreateAClassDes, "^3INSTA: ^5xBISOON");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.AddControler, "|- ^5ArabModding^1.^7Com");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.ScoreStreaks_Des, "^1ArabModding.^7Com ^5|- Join Us");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Bring_Party, "^3BISOON.. ");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.STORE, "-[B]");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.NEED_MORE_PLAYER, "^3For ^7Help ^3Sky: ^7BISOON-B7");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Waiting_for_other, "^5BISOON ^1RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Match_Begin, "^3BISOON ^5RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Awaiting_Textures, "^2BISOON ^6RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.LOBBY_LEADER_BOARDS, "^4BISOON ^7RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.ROUND_ENDING_KILLCAM, "^1BISOON ^7RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.MULTIPLAYER_MENU, "^6BISOON ^3RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Good_Games, "BISOON RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.System_Info, "BISOON RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.FriendsBu, "IM-83..");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Customer_Link, "^5ArabModding^3.Com^7");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Awaiting_GameState, "^5Have Fun^7 :]!!");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Awaiting_Connections, "^5ArabModding^3.Com");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.LEAVE_Game, "^6Bye^7..");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.KillCam, "Noob :)");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Final_KillCam, "BISOON ^3RTM");
                }
                else
                {
                    //Functions.SetMem((uint)Offsets.ChangeStr.StrOffset.KillCam, DefaultStr.DefaultStrB);
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Final_KillCam, "BISOON ^3RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Awaiting_Textures, "^2BISOON ^6RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.ScoreStreaks_Des, "^1ArabModding.^7Com ^5|- Join Us");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.In_Category, "|- ^3BISOON ^6TOOL~");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Good_Games, "BISOON RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Awaiting_GameState, "^5Have Fun^7 :]!!");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Awaiting_Connections, "^5ArabModding^3.Com");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.MULTIPLAYER_MENU, "^6BISOON ^3RTM");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.MultiPlayer, "|- ^8BISOON");
                    Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.ZOMBIES, "BISOON");

                }
            }
        }
        public class LobbyMods
        {
            public class DisableScore
            {
                static bool WhileScore = false;
                static void RunDis()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (WhileScore == true)
                        {
                            for (int i = 0; i < 13; i++)
                            {
                                Functions.SetMem(Offsets.Client.RemoveScoreStreak1 + Offsets.Client.Interval * (uint)i, BIS.Client.RemoveScoreStreakOn);
                                Functions.SetMem(Offsets.Client.RemoveScoreStreak2 + Offsets.Client.Interval * (uint)i, BIS.Client.RemoveScoreStreakOn);
                                Functions.SetMem(Offsets.Client.RemoveScoreStreak3 + Offsets.Client.Interval * (uint)i, BIS.Client.RemoveScoreStreakOn);
                            }
                        }
                    }
                    catch
                    {}
                }
                static bool Disable = false;
                public static void DisPlayerScoreStreak(bool True)
                {
                    Thread DisThread = new Thread(() => RunDis());
                    if (True)
                    {
                        WhileScore = true;
                        if (!Disable)
                        {
                            Disable = true;
                            DisThread.Start();
                        }
                    }
                    else
                    {
                        WhileScore = false;
                        DisThread.Abort();
                        Disable = false;
                    }
                }
            }
            public static void RapidFire(bool tru)
            {
                if (tru)
                {
                    byte[] rf = new byte[] { 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x30, 0x23, 0xD7, 0x0A, 0xD0, 0x01, 0x7D, 0x60 };
                    Functions.SetMem(Offsets.Lobby.RapidFire, rf);
                }
                else
                {
                    byte[] rf = new byte[] { 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x3F, 0x40, 0x00, 0x00, 0xD0, 0x01, 0x7D, 0x60 };
                    Functions.SetMem(Offsets.Lobby.RapidFire, rf);
                }
            }
            public static void LobbyWeapon(int Client, byte Weapon, byte Ammo, int AmmoinClip)
            {
                Functions.SetMem((uint)(0x1781170 + (0x5808 * Client)), new byte[0x188]);
                byte[] buffer = new byte[4];
                buffer[3] = Weapon;
                Functions.SetMem((uint)(0x17811e0 + (0x5808 * Client)), buffer);
                buffer = new byte[4];
                buffer[3] = 0x30;
                Functions.SetMem((uint)(0x1781320 + (0x5808 * Client)), buffer);
                buffer = new byte[4];
                buffer[3] = Ammo;
                Functions.SetMem((uint)(0x1781360 + (0x5808 * Client)), buffer);
                byte[] buffer10 = new byte[1];
                buffer10[0] = (byte)AmmoinClip;
                Functions.SetMem(0x1781327 + 0x5808 * (uint)Client, buffer10);
            }
            public class AllPerks
            {
                static bool WhilAllperks = false;
                static void RunPerks()
                {
                    try
                    {
                        Connectionfrm.Connector.ThreadConnector();
                        while (WhilAllperks == true)
                        {
                            for (int i = 0; i < 13; i++)
                            {
                                Functions.SetMem(Offsets.Client.AllPerksPlayer + Offsets.Client.Interval * (uint)i, BIS.Client.AllPerksOn);
                            }
                        }
                    }
                    catch { }
                }
                static bool Disable = false;
                public static void AllPlayerPerks(bool True)
                {
                    try
                    {
                        Thread AllPerkThread = new Thread(() => RunPerks());
                        if (True)
                        {
                            WhilAllperks = true;
                            if (!Disable)
                            {
                                AllPerkThread.Start();
                                Disable = true;
                            }
                        }
                        else
                        {
                            WhilAllperks = false;
                            AllPerkThread.Abort();
                            Disable = false;
                        }
                    }
                    catch { }
                }
            }
            public class WeaponLobby
            {

                static byte cuWea;
                static byte currAmmo;
                static byte CurrentinClip;
                static void LoadWeapon(byte Weapon, byte Ammo, byte AmmoInClip, int Client = 0)
                {
                    cuWea = Weapon;
                    currAmmo = Ammo;
                    CurrentinClip = AmmoInClip;
                    Connectionfrm.PS3.SetMemory((uint)(0x1781170 + (0x5808 * Client)), new byte[0x188]);
                    byte[] buffer = new byte[4];
                    buffer[3] = Weapon;
                    Connectionfrm.PS3.SetMemory((uint)(0x17811e0 + (0x5808 * Client)), buffer);
                    buffer = new byte[4];
                    buffer[3] = 0x30;
                    Connectionfrm.PS3.SetMemory((uint)(0x1781320 + (0x5808 * Client)), buffer);
                    buffer = new byte[4];
                    buffer[3] = Ammo;
                    Connectionfrm.PS3.SetMemory((uint)(0x1781360 + (0x5808 * Client)), buffer);
                    byte[] buffer10 = new byte[1];
                    buffer10[0] = (byte)AmmoInClip;
                    Connectionfrm.PS3.SetMemory(0x1781327 + 0x5808 * (uint)Client, buffer10);
                }
                static bool whileRu;
                static void RunLobby()
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (whileRu == true)
                    {
                        Func.ClientMods.ChangeCamos(0, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(1, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(2, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(3, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(4, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(5, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(6, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(7, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(8, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(9, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(10, BIS.Client.CamoByte.Camos[29]);
                        Func.ClientMods.ChangeCamos(11, BIS.Client.CamoByte.Camos[29]);

                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 0) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 0);
                            Func.ClientMods.ChangeCamos(0, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 1) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 1);
                            Func.ClientMods.ChangeCamos(1, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 2) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 2);
                            Func.ClientMods.ChangeCamos(2, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 3) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 3);
                            Func.ClientMods.ChangeCamos(3, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 4) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 4);
                            Func.ClientMods.ChangeCamos(4, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 5) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 5);
                            Func.ClientMods.ChangeCamos(5, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 6) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 6);
                            Func.ClientMods.ChangeCamos(6, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 7) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 7);
                            Func.ClientMods.ChangeCamos(7, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 8) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 8);
                            Func.ClientMods.ChangeCamos(8, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 9) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 9);
                            Func.ClientMods.ChangeCamos(9, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 10) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 10);
                            Func.ClientMods.ChangeCamos(10, BIS.Client.CamoByte.Camos[29]);
                        }
                        if (Connectionfrm.PS3.Extension.ReadByte(0x17811e3 + 0x5808 * 11) != cuWea)
                        {
                            LoadWeapon(cuWea, currAmmo, CurrentinClip, 11);
                            Func.ClientMods.ChangeCamos(11, BIS.Client.CamoByte.Camos[29]);
                        }
                    }
                    
                }
                static bool Ru;
                public static void LoadLobbyinTh(byte Weapon, byte Ammo, byte AmmoInClip, bool True)
                {
                    Thread RunThread = new Thread(() => RunLobby());
                    if (True)
                    {
                        RPC.iPrintln(-1, "^1Loading...  ^3 [ " + BOIIfrm.WeaponNameCombo + " ]");
                        LoadWeapon(Weapon, Ammo, AmmoInClip);
                        whileRu = true;
                        if (!Ru)
                        {
                            RunThread.Start();
                            Ru = true;
                        }
                    }
                    else
                    {
                        whileRu = false;
                        RunThread.Abort();
                        Ru = false;
                    }
                }
            }
            public static void NoClip(bool tru)
            {
                if (tru)
                {
                    Connectionfrm.PS3.Extension.WriteBytes(Offsets.Lobby.NoClip, new byte[] { 0x38, 0x60, 0x0, 0x5 });
                }
                else
                {
                    Connectionfrm.PS3.Extension.WriteBytes(Offsets.Lobby.NoClip, new byte[] { 0x80, 0x7D, 0x0, 0x4 });
                }
            }
            public static void NoMelee(bool tru)
            {
                if (tru)
                {
                    RPC.cbuf_addtext("player_meleeRange 0");
                    RPC.cbuf_addtext("player_meleeHeight 0");
                    RPC.cbuf_addtext("player_meleeWidth 0");
                }
                else
                {
                    RPC.cbuf_addtext("reset player_meleeRange");
                    RPC.cbuf_addtext("reset player_meleeHeight");
                    RPC.cbuf_addtext("reset player_meleeWidth");
                }
            }
        }
        public static bool ClientInGame()
        {
            return Connectionfrm.PS3.Extension.ReadBool(0x1CB68E8);
        }
        public class Antiban
        {
            public static void EnableAntiBan()
            {
                byte[] anti = new byte[4];
                anti[0] = 0x60;
                Functions.SetMem(0x4b8310, new byte[] { 0x40, 0x00 });
                Functions.SetMem(0x50a38f, new byte[] { 0x99 });
                Functions.SetMem(0x50ba74, anti);
                Functions.SetMem(0x547dd4, anti);
                Functions.SetMem(0x548148, anti);
                Functions.SetMem(0x50b618, new byte[] { 0x48, 0x00 });
                Functions.SetMem(0x50a3bc, new byte[] { 0x48, 0x80 });
                Functions.SetMem(0x5300e8, anti);
                Functions.SetMem(0x5300f4, anti);
            }
        }
    }
}
