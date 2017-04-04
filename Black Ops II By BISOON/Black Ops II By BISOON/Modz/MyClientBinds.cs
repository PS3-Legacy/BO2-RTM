using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class MyClientBinds
    {
        public class GM
        {
            static bool[] GodMod_Bind = new bool[12];
            static void GodMod(int Client)
            {
                Thread.Sleep(500);
                if (ButtonzPressed.ButtonPressed(Client, ButtonzPressed.Buttons.R2_Crouch))
                {
                    if (GodMod_Bind[Client] == false)
                    {
                        Functions.SetMem(Offsets.Client.GodMode + 0x5808 * (uint)Client, new byte[] { 0x05 });
                        RPC.iPrintln(Client, "God Mod : ^2On");
                        GodMod_Bind[Client] = true;
                    }
                    else
                    {
                        Functions.SetMem(Offsets.Client.GodMode + 0x5808 * (uint)Client, new byte[] { 0x08 });
                        RPC.iPrintln(Client, "God Mod : ^1Off");
                        GodMod_Bind[Client] = false;
                    }
                }
            }
            static bool WhileOn = false;
            static bool DisableS = false;
            static bool[] clientIndex = new bool[12];
            static Thread THREAD;
            static void RunMod()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhileOn == true)
                    {
                        if (clientIndex[0] == true)
                        { GodMod(0); }
                        if (clientIndex[1] == true)
                        { GodMod(1); }
                        if (clientIndex[2] == true)
                        { GodMod(2); }
                        if (clientIndex[3] == true)
                        { GodMod(3); }
                        if (clientIndex[4] == true)
                        { GodMod(4); }
                        if (clientIndex[5] == true)
                        { GodMod(5); }
                        if (clientIndex[6] == true)
                        { GodMod(6); }
                        if (clientIndex[7] == true)
                        { GodMod(7); }
                        if (clientIndex[8] == true)
                        { GodMod(8); }
                        if (clientIndex[9] == true)
                        { GodMod(9); }
                        if (clientIndex[10] == true)
                        { GodMod(10); }
                        if (clientIndex[11] == true)
                        { GodMod(11); }
                    }
                }
                catch { }
            }
            public static void GodMod(int Client, bool True)
            {
                THREAD = new Thread(() => RunMod());
                try
                {
                    if (True)
                    {
                        clientIndex[Client] = true;
                        WhileOn = true;
                        RPC.iPrintln(Client, "[ ^1God Mod^7 ] Bind is ^2Enabled ^7| ^5 Press ^7( [{+frag}] + Crouch )^5 To Switch Between Them ^7[ ^2On ^7|^1 Off ^7]");
                        if (!DisableS)
                        { THREAD.Start(); DisableS = true; }
                    }
                    else
                    {
                        clientIndex[Client] = false;
                        RPC.iPrintln(Client, "God Mod Bind is ^1Disabled");
                    }
                }
                catch { }
            }
            public static void ENDMODZ()
            {
                try
                {
                    if (DisableS == true)
                    {
                        WhileOn = false;
                        THREAD.Abort();
                    }
                }
                catch { }
            }
           
        }

        public class VSAT
        {
            static bool[] cl_Bind = new bool[12];
            static void Modz(int Client)
            {
                Thread.Sleep(500);
                if (ButtonzPressed.ButtonPressed(Client, ButtonzPressed.Buttons.R3))
                {
                    if (cl_Bind[Client] == false)
                    {
                        Functions.SetMem(Offsets.Client.VSATInGame + 0x5808 * (uint)Client, new byte[] { 0x0F });
                        RPC.iPrintln(Client, "VSAT : ^2On");
                        cl_Bind[Client] = true;
                    }
                    else
                    {
                        Functions.SetMem(Offsets.Client.VSATInGame + 0x5808 * (uint)Client, new byte[] { 0x00 });
                        RPC.iPrintln(Client, "VSAT : ^1Off");
                        cl_Bind[Client] = false;
                    }
                }
            }
            static bool WhileOn = false;
            static bool DisableS = false;
            static bool[] clientIndex = new bool[12];
            static Thread THREAD;
            static void RunMod()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhileOn == true)
                    {
                        if (clientIndex[0] == true)
                        { Modz(0); }
                        if (clientIndex[1] == true)
                        { Modz(1); }
                        if (clientIndex[2] == true)
                        { Modz(2); }
                        if (clientIndex[3] == true)
                        { Modz(3); }
                        if (clientIndex[4] == true)
                        { Modz(4); }
                        if (clientIndex[5] == true)
                        { Modz(5); }
                        if (clientIndex[6] == true)
                        { Modz(6); }
                        if (clientIndex[7] == true)
                        { Modz(7); }
                        if (clientIndex[8] == true)
                        { Modz(8); }
                        if (clientIndex[9] == true)
                        { Modz(9); }
                        if (clientIndex[10] == true)
                        { Modz(10); }
                        if (clientIndex[11] == true)
                        { Modz(11); }
                    }
                }
                catch { }
            }
            public static void TheMod(int Client, bool True)
            {
                THREAD = new Thread(() => RunMod());
                try
                {
                    if (True)
                    {
                        clientIndex[Client] = true;
                        WhileOn = true;
                        RPC.iPrintln(Client, "[ ^1VSAT^7 ] Bind is ^2Enabled ^7| ^5 Press [{+melee}] To Switch Between Them ^7[ ^2On ^7|^1 Off ^7]");
                        if (!DisableS)
                        { THREAD.Start(); DisableS = true; }
                    }
                    else
                    {
                        clientIndex[Client] = false;
                        RPC.iPrintln(Client, "VSAT Bind is ^1Disable");
                    }
                }
                catch { }
            }
            public static void ENDMODZ()
            {
                try
                {
                    if (DisableS == true)
                    {
                        WhileOn = false;
                        THREAD.Abort();
                    }
                }
                catch { }
            }
        }

        public class Speed
        {
            static bool[] cl_Bind = new bool[12];
            static void Modz(int Client)
            {
                Thread.Sleep(500);
                if (ButtonzPressed.ButtonPressed(Client, ButtonzPressed.Buttons.Square))
                {
                    if (cl_Bind[Client] == false)
                    {
                        Functions.SetMem(Offsets.Client.PlayerSpeedInGame + 0x5808 * (uint)Client, new byte[] { 0x40 });
                        RPC.iPrintln(Client, "Speed : ^2On");
                        cl_Bind[Client] = true;
                    }
                    else
                    {
                        Functions.SetMem(Offsets.Client.PlayerSpeedInGame + 0x5808 * (uint)Client, new byte[] { 0x3F });
                        RPC.iPrintln(Client, "Speed : ^1Off");
                        cl_Bind[Client] = false;
                    }
                }
            }
            static bool WhileOn = false;
            static bool DisableS = false;
            static bool[] clientIndex = new bool[12];
            static Thread THREAD;
            static void RunMod()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhileOn == true)
                    {
                        if (clientIndex[0] == true)
                        { Modz(0); }
                        if (clientIndex[1] == true)
                        { Modz(1); }
                        if (clientIndex[2] == true)
                        { Modz(2); }
                        if (clientIndex[3] == true)
                        { Modz(3); }
                        if (clientIndex[4] == true)
                        { Modz(4); }
                        if (clientIndex[5] == true)
                        { Modz(5); }
                        if (clientIndex[6] == true)
                        { Modz(6); }
                        if (clientIndex[7] == true)
                        { Modz(7); }
                        if (clientIndex[8] == true)
                        { Modz(8); }
                        if (clientIndex[9] == true)
                        { Modz(9); }
                        if (clientIndex[10] == true)
                        { Modz(10); }
                        if (clientIndex[11] == true)
                        { Modz(11); }
                    }
                }
                catch { }
            }
            public static void TheMod(int Client, bool True)
            {
                THREAD = new Thread(() => RunMod());
                try
                {
                    if (True)
                    {
                        clientIndex[Client] = true;
                        WhileOn = true;
                        RPC.iPrintln(Client, "[ ^1Speed^7 ] Bind is ^2Enabled ^7| ^5 Press [{+usereload}] To Switch Between Them ^7[ ^2On ^7|^1 Off ^7]");
                        if (!DisableS)
                        { THREAD.Start(); DisableS = true; }
                    }
                    else
                    {
                        clientIndex[Client] = false;
                        RPC.iPrintln(Client, "Speed Bind is ^1Disable");
                    }
                }
                catch { }
            }
            public static void ENDMODZ()
            {
                try
                {
                    if (DisableS == true)
                    {
                        WhileOn = false;
                        THREAD.Abort();
                    }
                }
                catch { }
            }
        }

        public class NightVision
        {
            static bool[] cl_Bind = new bool[12];
            static void Modz(int Client)
            {
                Thread.Sleep(500);
                if (ButtonzPressed.ButtonPressed(Client, ButtonzPressed.Buttons.L2_Crouch))
                {
                    if (cl_Bind[Client] == false)
                    {
                        Functions.SetMem(Offsets.Client.NightVision + 0x5808 * (uint)Client, new byte[] { 0x10 });
                        RPC.iPrintln(Client, "Green Vision : ^2On");
                        cl_Bind[Client] = true;
                    }
                    else
                    {
                        Functions.SetMem(Offsets.Client.NightVision + 0x5808 * (uint)Client, new byte[] { 0x00 });
                        RPC.iPrintln(Client, "Green Vision : ^1Off");
                        cl_Bind[Client] = false;
                    }
                }
            }
            static bool WhileOn = false;
            static bool DisableS = false;
            static bool[] clientIndex = new bool[12];
            static Thread THREAD;
            static void RunMod()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhileOn == true)
                    {
                        if (clientIndex[0] == true)
                        { Modz(0); }
                        if (clientIndex[1] == true)
                        { Modz(1); }
                        if (clientIndex[2] == true)
                        { Modz(2); }
                        if (clientIndex[3] == true)
                        { Modz(3); }
                        if (clientIndex[4] == true)
                        { Modz(4); }
                        if (clientIndex[5] == true)
                        { Modz(5); }
                        if (clientIndex[6] == true)
                        { Modz(6); }
                        if (clientIndex[7] == true)
                        { Modz(7); }
                        if (clientIndex[8] == true)
                        { Modz(8); }
                        if (clientIndex[9] == true)
                        { Modz(9); }
                        if (clientIndex[10] == true)
                        { Modz(10); }
                        if (clientIndex[11] == true)
                        { Modz(11); }
                    }
                }
                catch { }
            }
            public static void TheMod(int Client, bool True)
            {
                THREAD = new Thread(() => RunMod());
                try
                {
                    if (True)
                    {
                        clientIndex[Client] = true;
                        WhileOn = true;
                        RPC.iPrintln(Client, "[ ^1NightVision^7 ] Bind is ^2Enabled ^7| ^5 Press ^7( Crouch + [{+smoke}] )^5 To Switch Between Them ^7[ ^2On ^7|^1 Off ^7]");
                        if (!DisableS)
                        { THREAD.Start(); DisableS = true; }
                    }
                    else
                    {
                        clientIndex[Client] = false;
                        RPC.iPrintln(Client, "Speed Bind is ^1Disable");
                    }
                }
                catch { }
            }
            public static void ENDMODZ()
            {
                try
                {
                    if (DisableS == true)
                    {
                        WhileOn = false;
                        THREAD.Abort();
                    }
                }
                catch { }
            }
        }

        public class RandomWeapon
        {
            static int BIIS;
            static void Modz(int Client)
            {
                Thread.Sleep(1300);
                if (ButtonzPressed.ButtonPressed(Client, ButtonzPressed.Buttons.L2))
                {
                    BIIS = new Random().Next( 0, BIS.Client.Weapon_Index_RPC.Length);
                    Func.ClientMods.GiveAdditionalWeapon(Client, BIS.Client.Weapon_Index_RPC[BIIS]);
                    RPC.iPrintln(Client, BIS.Client.WeaponName_RPC[BIIS] + "^2   Given");
                }
            }
            static bool WhileOn = false;
            static bool DisableS = false;
            static bool[] clientIndex = new bool[12];
            static Thread THREAD;
            static void RunMod()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhileOn == true)
                    {
                        if (clientIndex[0] == true)
                        { Modz(0); }
                        if (clientIndex[1] == true)
                        { Modz(1); }
                        if (clientIndex[2] == true)
                        { Modz(2); }
                        if (clientIndex[3] == true)
                        { Modz(3); }
                        if (clientIndex[4] == true)
                        { Modz(4); }
                        if (clientIndex[5] == true)
                        { Modz(5); }
                        if (clientIndex[6] == true)
                        { Modz(6); }
                        if (clientIndex[7] == true)
                        { Modz(7); }
                        if (clientIndex[8] == true)
                        { Modz(8); }
                        if (clientIndex[9] == true)
                        { Modz(9); }
                        if (clientIndex[10] == true)
                        { Modz(10); }
                        if (clientIndex[11] == true)
                        { Modz(11); }
                    }
                }
                catch { }
            }
            public static void TheMod(int Client, bool True)
            {
                THREAD= new Thread(() => RunMod());
                try
                {
                    if (True)
                    {
                        clientIndex[Client] = true;
                        WhileOn = true;
                        RPC.iPrintln(Client, "[ Random Weapon^7 ] Bind is ^2Enabled ^7| ^5 Press ^7( [{+smoke}] )^5 To Get New Weapon");
                        if (!DisableS)
                        { THREAD.Start(); DisableS = true; }
                    }
                    else
                    {
                        clientIndex[Client] = false;
                        RPC.iPrintln(Client, "Random Weapon Bind is ^1Disable");
                    }
                }
                catch { }
            }
            public static void ENDMODZ()
            {
                try
                {
                    if (DisableS == true)
                    {
                        WhileOn = false;
                    }
                }
                catch { }
            }
        }

        public class RandomCamo
        {
            static int BIIS;
            static void Modz(int Client)
            {
                Thread.Sleep(1200);
                if (ButtonzPressed.ButtonPressed(Client, ButtonzPressed.Buttons.R2))
                {
                    int Rand = new Random().Next(1, 9);
                    BIIS = new Random().Next(0, BIS.Client.CamoByte.RandomCamos.Length);
                    Func.ClientMods.ChangeCamos(Client, BIS.Client.CamoByte.Camos[BIIS]);
                    RPC.iPrintln(Client, "^" + Rand + BIS.Client.CamoByte.CamoString[BIIS] + " ^7  Given");
                }
            }
            static bool WhileOn = false;
            static bool DisableS = false;
            static bool[] clientIndex = new bool[12];
            static Thread THREAD;
            static void RunMod()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    while (WhileOn == true)
                    {
                        if (clientIndex[0] == true)
                        { Modz(0); }
                        if (clientIndex[1] == true)
                        { Modz(1); }
                        if (clientIndex[2] == true)
                        { Modz(2); }
                        if (clientIndex[3] == true)
                        { Modz(3); }
                        if (clientIndex[4] == true)
                        { Modz(4); }
                        if (clientIndex[5] == true)
                        { Modz(5); }
                        if (clientIndex[6] == true)
                        { Modz(6); }
                        if (clientIndex[7] == true)
                        { Modz(7); }
                        if (clientIndex[8] == true)
                        { Modz(8); }
                        if (clientIndex[9] == true)
                        { Modz(9); }
                        if (clientIndex[10] == true)
                        { Modz(10); }
                        if (clientIndex[11] == true)
                        { Modz(11); }
                    }
                }
                catch { }
            }
            public static void TheMod(int Client, bool True)
            {
                THREAD = new Thread(() => RunMod());
                try
                {
                    if (True)
                    {
                        clientIndex[Client] = true;
                        WhileOn = true;
                        RPC.iPrintln(Client, "[ Random Weapon^7 ] Bind is ^2Enabled ^7| ^5 Press ^7( [{+frag}] )^5 To Get New Camo");
                        if (!DisableS)
                        { THREAD.Start(); DisableS = true; }
                    }
                    else
                    {
                        clientIndex[Client] = false;
                        RPC.iPrintln(Client, "Speed Bind is ^1Disabled");
                    }
                }
                catch { }
            }
            public static void ENDMODZ()
            {
                try
                {
                    if (DisableS == true)
                    {
                        WhileOn = false;
                        THREAD.Abort();
                    }
                }
                catch { }
            }
        }

        public static void EndMyClientsBind()
        {
            GM.ENDMODZ();
            VSAT.ENDMODZ();
            Speed.ENDMODZ();
            NightVision.ENDMODZ();
            RandomWeapon.ENDMODZ();
            RandomCamo.ENDMODZ();
        }

    }
}
