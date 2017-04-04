using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class DoHeartWriter
    {
        public static int Heart;
        public static float location = 80;
        public static void SetText_SW(int Client, string Name, bool Bool)
        {
            if (Bool == true)
            {
                Heart = (int)(Huds.SetText(Client, Name, 0, 3, location, 15, 255, 255, 255, 255, 94, 42, 85, 200));
            }
            if (Bool == false)
            {
                Huds.DestroyElement((uint)Heart);
            }
        }
        public class Huds
        {
            public class Offsets
            {
                public static UInt32 G_HudElems = 0x15DDB00;
                public static UInt32 G_LocalizedStringIndex = 0x275B84;
                public static UInt32 level_locals_t = 0x1608100;
                public static UInt32 HudelemSize = 0x88;
            }
            public class HElems
            {
                public static UInt32 ElemIndex = 0x15DDB00;
                public static UInt32 HudsLength = 0x88;
                public static UInt32 abilityFlag = 0x84;
                public static UInt32 alignOrg = 0x72;
                public static UInt32 alignScreen = 0x73;
                public static UInt32 color = 0x18;
                public static UInt32 duration = 0x38;
                public static UInt32 fadeStartTime = 0x20;
                public static UInt32 fadeTime = 0x54;
                public static UInt32 flag2 = 0x7A;
                public static UInt32 flags = 0x4C;
                public static UInt32 Font = 0x70;
                public static UInt32 FontSize = 0xC;
                public static UInt32 fontScaleStartTime = 0x14;
                public static UInt32 fontScaleTime = 0x52;
                public static UInt32 fromAlignOrg = 0x76;
                public static UInt32 fromAlignScreen = 0x77;
                public static UInt32 fromColor = 0x1C;
                public static UInt32 fromFontScale = 0x10;
                public static UInt32 fromHeight = 0x5E;
                public static UInt32 fromWidth = 0x5C;
                public static UInt32 fromX = 0x28;
                public static UInt32 fromY = 0x2C;
                public static UInt32 fxBirthTime = 0x48;
                public static UInt32 fxDecayDuration = 0x6A;
                public static UInt32 fxDecayStartTime = 0x68;
                public static UInt32 fxLetterTime = 0x66;
                public static UInt32 fxRedactDecayDuration = 110;
                public static UInt32 fxRedactDecayStartTime = 0x6C;
                public static UInt32 glowColor = 0x44;
                public static UInt32 Height = 0x5A;
                public static UInt32 label = 0x56;
                public static UInt32 materialIndex = 0x71;
                public static UInt32 moveStartTime = 0x30;
                public static UInt32 moveTime = 0x62;
                public static UInt32 offscreenMaterialIdx = 0x75;
                public static UInt32 clientOffset = 0x7C;
                public static UInt32 scaleStartTime = 0x24;
                public static UInt32 scaleTime = 0x60;
                public static UInt32 sort = 0x40;
                public static UInt32 soundID = 0x78;
                public static UInt32 targetEntNum = 80;
                public static UInt32 team = 0x80;
                public static UInt32 text = 0x62;
                public static UInt32 time = 0x34;
                public static UInt32 type = 0x6D;
                public static UInt32 ui3dWindow = 0x4F;
                public static UInt32 value = 60;
                public static UInt32 Width = 0x58;
                public static UInt32 X = 0x0;
                public static UInt32 Y = 0x4;
                public static UInt32 Z = 0x8;
            }

            public static int G_LocalizedStringIndex(string Text)
            {
                return RPC.Call(Offsets.G_LocalizedStringIndex, new object[] { Text });
            }

            public static void ChangeText(UInt32 Element, string Text)
            {
                Connectionfrm.PS3.Extension.WriteInt32(Element + HElems.text, G_LocalizedStringIndex(Text));
            }
            public static byte[] RGBA(decimal R, decimal G, decimal B, decimal A)
            {
                byte[] RGBA_Renamed = new byte[4];
                byte[] RVal = BitConverter.GetBytes(Convert.ToInt32(R));
                byte[] GVal = BitConverter.GetBytes(Convert.ToInt32(G));
                byte[] BVal = BitConverter.GetBytes(Convert.ToInt32(B));
                byte[] AVal = BitConverter.GetBytes(Convert.ToInt32(A));
                RGBA_Renamed[0] = RVal[0];
                RGBA_Renamed[1] = GVal[0];
                RGBA_Renamed[2] = BVal[0];
                RGBA_Renamed[3] = AVal[0];
                return RGBA_Renamed;
            }

            public static UInt32 GetLevelTime()
            {
                return Connectionfrm.PS3.Extension.ReadUInt32(Offsets.level_locals_t + 0x798);
            }

            private static UInt32 HudElem_Alloc()
            {
                for (uint i = 30; i <= 1023; i++)
                {
                    UInt32 offset = Offsets.G_HudElems + ((i) * 0x88);
                    if (Connectionfrm.PS3.Extension.ReadInt16(offset + 0x70) == 0)
                    {
                        Connectionfrm.PS3.SetMemory(offset, new byte[136]);
                        return offset;
                    }
                }
                return 0;
            }

            public static UInt32 SetShader(int clientIndex, int Material, short width, short height, float x, float y, int r = 255, int g = 255, int b = 255, int a = 255)
            {
                UInt32 elem = HudElem_Alloc();
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.type, 8);
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.materialIndex, Material);
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.Height, height);
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.Width, width);
                Connectionfrm.PS3.Extension.WriteFloat(elem + HElems.X, x);
                Connectionfrm.PS3.Extension.WriteFloat(elem + HElems.Y, y);
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.clientOffset, clientIndex);
                Connectionfrm.PS3.SetMemory(elem + 0x79, new byte[] { 0xFF });
                Connectionfrm.PS3.SetMemory(elem + HElems.color, RGBA(r, g, b, a));
                return elem;
            }

            public static UInt32 SetText(int clientIndex, string Text, short Font, double FontSize, float x, float y, int r = 255, int g = 255, int b = 255, int a = 255, int glowr = 255, int glowg = 255, int glowb = 255, int glowa = 0)
            {
                UInt32 elem = HudElem_Alloc();
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.type, 1);
                Connectionfrm.PS3.Extension.WriteFloat(elem + HElems.FontSize, (float)FontSize);
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.Font, Font);
                Connectionfrm.PS3.Extension.WriteFloat(elem + HElems.X, x);
                Connectionfrm.PS3.Extension.WriteFloat(elem + HElems.Y, y);
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.clientOffset, clientIndex);
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.text, G_LocalizedStringIndex(Text));
                Connectionfrm.PS3.SetMemory(elem + HElems.color, RGBA(r, g, b, a));
                Connectionfrm.PS3.SetMemory(elem + HElems.glowColor, RGBA(glowr, glowg, glowb, glowa));
                Connectionfrm.PS3.SetMemory(elem + 0x79, new byte[] { 0xFF });
                Connectionfrm.PS3.SetMemory(elem + HElems.Font, new byte[] { 0x1 });
                return elem;
            }

            public static void DestroyElement(UInt32 Element)
            {
                Connectionfrm.PS3.SetMemory(Element, new byte[HElems.HudsLength - 1 + 1]);
            }

            public static void DestroyAllElems()
            {
                for (UInt32 i = 0; i <= 1023; i++)
                {
                    DestroyElement(i);
                }
            }

            public static void FadeOverTime(UInt32 elem, short Time, byte R = 0, byte G = 0, byte B = 0, byte A = 0)
            {
                Connectionfrm.PS3.Extension.WriteBytes(elem + HElems.fromColor, Connectionfrm.PS3.Extension.ReadBytes(elem + HElems.color, 4));
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.fadeTime, Time);
                Connectionfrm.PS3.Extension.WriteUInt32(elem + HElems.fadeStartTime, GetLevelTime());
                Connectionfrm.PS3.Extension.WriteBytes(elem + HElems.color, new byte[] { R, G, B, A });
            }
            public static void FadeAlphaOverTime(UInt32 elem, short Time, byte A = 0)
            {
                byte b = Connectionfrm.PS3.Extension.ReadByte(elem + HElems.color);
                byte b2 = Connectionfrm.PS3.Extension.ReadByte(elem + (HElems.color + 1));
                byte b3 = Connectionfrm.PS3.Extension.ReadByte(elem + (HElems.color + 2));
                Connectionfrm.PS3.Extension.WriteBytes(elem + HElems.fromColor, Connectionfrm.PS3.Extension.ReadBytes(elem + HElems.color, 4));
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.fadeTime, Time);
                Connectionfrm.PS3.Extension.WriteUInt32(elem + HElems.fadeStartTime, GetLevelTime());
                Connectionfrm.PS3.Extension.WriteBytes(elem + HElems.color, new byte[] { b, b2, b3, A });
            }
            public static void FontScaleOverTime(UInt32 elem, double FontSize, short time)
            {
                Connectionfrm.PS3.Extension.WriteFloat(elem + HElems.fromFontScale, Connectionfrm.PS3.Extension.ReadFloat(elem + HElems.FontSize));
                Connectionfrm.PS3.Extension.WriteUInt32(elem + HElems.fontScaleStartTime, GetLevelTime());
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.fontScaleTime, time);
                Connectionfrm.PS3.Extension.WriteFloat(elem + HElems.FontSize, (float)FontSize);
            }
            public static void MoveOverTime(UInt32 Elem, short time, float x, float y)
            {
                Connectionfrm.PS3.Extension.WriteFloat(Elem + HElems.fromX, Connectionfrm.PS3.Extension.ReadFloat(Elem));
                Connectionfrm.PS3.Extension.WriteFloat(Elem + HElems.fromY, Connectionfrm.PS3.Extension.ReadFloat(Elem + HElems.Y));
                Connectionfrm.PS3.Extension.WriteInt32(Elem + HElems.moveStartTime, System.Convert.ToInt32(GetLevelTime()));
                Connectionfrm.PS3.Extension.WriteInt16(Elem + HElems.moveTime, time);
                Connectionfrm.PS3.Extension.WriteFloat(Elem, x);
                Connectionfrm.PS3.Extension.WriteFloat(Elem + HElems.Y, y);
            }
            public static void ScaleOverTime(UInt32 elem, short time, short width, short height)
            {
                Connectionfrm.PS3.Extension.WriteUInt32(elem + HElems.scaleStartTime, GetLevelTime());
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.fromHeight, Connectionfrm.PS3.Extension.ReadInt16(elem + HElems.Width));
                Connectionfrm.PS3.Extension.WriteInt32(elem + HElems.fromWidth, Connectionfrm.PS3.Extension.ReadInt16(elem + HElems.Height));
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.Width, width);
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.Height, height);
                Connectionfrm.PS3.Extension.WriteInt16(elem + HElems.scaleTime, time);
            }
        }
    }
}
