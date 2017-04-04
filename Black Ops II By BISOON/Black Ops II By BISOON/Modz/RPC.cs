namespace Black_Ops_II_By_BISOON
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    internal class RPC
    {
        public static uint g_entity = 0x16b9f20;
        public static uint G_SetMoel = 0x2774a4;
        public static uint entitySize = 0x31c;
        private static uint function_address = 0x7aa050;

        public static int Call(uint func_address, params object[] parameters)
        {
            int length = parameters.Length;
            int index = 0;
            uint num3 = 0;
            uint num4 = 0;
            uint num5 = 0;
            uint num6 = 0;
            while (index < length)
            {
                if (parameters[index] is int)
                {
                    Connectionfrm.PS3.Extension.WriteInt32(0x10020000 + (num3 * 4), (int) parameters[index]);
                    
                    num3++;
                }
                else if (parameters[index] is uint)
                {
                    Connectionfrm.PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), (uint)parameters[index]);

                    num3++;
                }
                else
                {
                    uint num7;
                    if (parameters[index] is string)
                    {
                        num7 = 0x10022000 + (num4 * 0x400);
                        Connectionfrm.PS3.Extension.WriteString(num7, Convert.ToString(parameters[index]));

                        Connectionfrm.PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);

                        num3++;
                        num4++;
                    }
                    else if (parameters[index] is float)
                    {
                        Connectionfrm.PS3.Extension.WriteFloat(0x10020024 + (num5 * 4), (float)parameters[index]);
 
                        num5++;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] input = (float[]) parameters[index];
                        num7 = 0x10021000 + (num6 * 4);
                        Functions.WriteSingle(num7, input);
                        Connectionfrm.PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);

                        num3++;
                        num6 += (uint) input.Length;
                    }
                }
                index++;
            }

            Connectionfrm.PS3.Extension.WriteUInt32(0x1002004c, func_address);
            Thread.Sleep(20);
            return Connectionfrm.PS3.Extension.ReadInt32(0x10020050);
        }

        public static int Init()
        {
            function_address = 0x7aa050;
            BISOON();
            return 0;
        }

        public static void iPrintln(int client, string txt)
        {
            SV_GameSendServerCommand(client, "O \"" + txt + "\"");
        }

        public static void iPrintlnBold(int client, string txt)
        {
            SV_GameSendServerCommand(client, "< \"" + txt + "\"");
        }

        public static void BISOON()
        {
            if (Connectionfrm.PS3.GetBytes(function_address, 4) == new byte[] { 0xf8, 0x21, 0xff, 0x91 })
            {
                MessageBox.Show("Already Enabled");
            }
            else
            {
                Connectionfrm.PS3.SetMemory(function_address, new byte[] { 0x4e, 0x80, 0, 0x20 });
                Thread.Sleep(20);
                /* HxD (6/10/2016 2:25:34 PM)
    StartOffset: 00000000, EndOffset: 0000008B, Length: 0000008C */

                byte[] rawData = {
    0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80,
    0x3C, 0x60, 0x10, 0x02, 0x81, 0x83, 0x00, 0x4C, 0x2C, 0x0C, 0x00, 0x00,
    0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08,
    0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14,
    0x81, 0x23, 0x00, 0x18, 0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20,
    0xC0, 0x23, 0x00, 0x24, 0xC0, 0x43, 0x00, 0x28, 0xC0, 0x63, 0x00, 0x2C,
    0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xC0, 0xC3, 0x00, 0x38,
    0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48,
    0x80, 0x63, 0x00, 0x00, 0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21,
    0x3C, 0x80, 0x10, 0x02, 0x38, 0xA0, 0x00, 0x00, 0x90, 0xA4, 0x00, 0x4C,
    0x90, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6,
    0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20
};

                Connectionfrm.PS3.SetMemory(function_address + 4, rawData);
                Connectionfrm.PS3.SetMemory(0x10020000, new byte[0x2854]);
                Connectionfrm.PS3.SetMemory(function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
            }
        }

        public static void SV_GameSendServerCommand(int client, string command)
        {
            Call(0x349f6c, new object[] { client, 0, command });
        }
        public static void G_SetModel(int Client, string Model)
        {
            RPC.Call(G_SetMoel, new object[] { g_entity + ((uint)(entitySize * Client)), Model });
        }
        public static void SvKick(int Client, string Reason)
        {
            RPC.SV_GameSendServerCommand(Client, "5 \"\n" + Reason + "\"");
        }
        public static void KickClient(int Client)
        {
            RPC.cbuf_addtext("clientKick " + Client);
        }
        public static void BlurClient(int Client, bool On)
        {
            if (On)
            {
                SV_GameSendServerCommand(Client, "d 100000000 20");
                Func.Notify_C.Notify_Cl(Client, "Blur : ^2On");
            }
            else
            {
                SV_GameSendServerCommand(Client, "d 0 0");
                Func.Notify_C.Notify_Cl(Client, "Blur : ^1Off");
            } 
        }
        public static void PS3Freeze(int Client)
        {
            iPrintlnBold(Client, "^1Warning: ^3Your PS3 Will be froze about 3 sec by using ^1BISOON's ^3 Tool");
            Thread.Sleep(2500);
            SV_GameSendServerCommand(Client, "^ 6 90 ");
        }
        public static void Player_Die(int Killer, int Victim, int meansOfDeath = 18, int iWeapon = 0)
        {
            UInt32 Attacker = G_Entity(Killer);
            UInt32 Inflictor = G_Entity(Victim);
            RPC.Call(0x001FD370, Inflictor, Attacker, Attacker, 0xFF, meansOfDeath, iWeapon, 0xD0300AD4C);
            Thread.Sleep(100);

        }
        public static UInt32 G_Entity(int entityIndex, UInt32 Mod = 0x00)
        {
            return (0x0016B9F20 + (UInt32)Mod) + ((UInt32)entityIndex * 0x31C);
        }
        public static void cbuf_addtext(string Command)
        {
            RPC.Call(0x313c18, 0, Command);
        }
        public static void Vision(int Client, string vision)
        {
            RPC.SV_GameSendServerCommand(Client, "2 1060 \"" + vision + "\"");
        }
        public static void Clone(int Client)
        {
            Connectionfrm.PS3.Extension.WriteBytes(0x1F63C4, new byte[] { 0x38, 0x60, 0x0, 0x0 });
            Connectionfrm.PS3.Extension.WriteInt16(0x1F63C4 + 2, (short)Client);
            RPC.Call(0x01F6388, Client);
        }
        public static void Fov(int fov)
        {
            SV_GameSendServerCommand(-1, "^ 5 " + fov);
        }
        public static void KillCamDuration(int Duration)
        {
            RPC.cbuf_addtext("set scr_killcam_time " + Duration);
        }
        public static void G_InitalizeAmmo(int Client)
        {
            RPC.Call(0x1E6698, 0x16B9F20 + 0x31C * (uint)Client);
        }
        public static void Add_Ammo(int Client, int Ammo)
        {
            RPC.Call(0x2089A8, 0x16B9F20 + 0x31C * (uint)Client, ReturnHeldWeapon(Client), Ammo, Ammo, Ammo, Ammo);
        }
        public static int ReturnHeldWeapon(int Client)
        {
            return Connectionfrm.PS3.Extension.ReadByte(0x17810E3 + 0x5808 * (uint)Client);
        }

        public static void playSound(Int32 clientIndex, String soundName)
        {
            Int32 soundIndex = RPC.Call(0x4f45bc, soundName);
            RPC.SV_GameSendServerCommand(clientIndex, "B " + soundIndex);
        }
        public static String char_to_wchar(String text)
        {
            String wchar = text;
            for (Int32 i = 0; i < text.Length; i++)
            {
                wchar = wchar.Insert(i * 2, "\0");
            }
            return wchar;
        }

        public static String doKeyboard(Int32 KeyboardType = 2, String Title = "Title", String PresetText = "", Int32 MaxLength = 20)
        {
            Connectionfrm.PS3.Extension.WriteByte(0x467507, (Byte)KeyboardType);
            RPC.Call(0x46710C, 0xD67E980, char_to_wchar(Title), char_to_wchar(PresetText), MaxLength, 0xD57560);
            while (Connectionfrm.PS3.Extension.ReadInt32(0xD82140) != 0)
                continue;
            return Connectionfrm.PS3.Extension.ReadString(0x03090E22);
        }
        public static int precacheShader(string Shader)
        {
            Connectionfrm.PS3.Extension.WriteInt32(0x1608100 + 0x40, 1);
            return RPC.Call(0x275e80, Shader);
        }
        public static void G_EntAttach(int entityIndex, string modelName, string tagName)
        {
            Int32 tag = RPC.Call(0x48E718, tagName);
            RPC.Call(0x27769c, G_Entity(entityIndex), modelName, tag, 0);
        }
        public static void AddEvent(Int32 clientIndex, Int32 Event, Object eventParams)
        {
            RPC.Call(0x2797b0, G_Entity(clientIndex), Event, eventParams);
        }
        public static void playRumble(Int32 clientIndex, Int32 RumbleIndex)
        {
            if (RumbleIndex != 0)
            { AddEvent(clientIndex, 0x70, RumbleIndex); }
        }
    }
}

