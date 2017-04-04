using Black_Ops_II_By_BISOON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class BO2TypeWriter
    {
        public class Hudelem
        {

            public class Offsets
            {
                public static UInt32 G_HudElems = 0x15DDB00;
                public static UInt32 G_LocalizedStringIndex = 0x275B84;
                public static UInt32 level_locals_t = 0x1608100;
            }

            public static UInt32 abilityFlag = 0x84;
            public static UInt32 alignOrg = 0x72;
            public static UInt32 alignScreen = 0x73;
            public static UInt32 clientOffset = 0x7C;
            public static UInt32 color = 0x18;
            public static UInt32 duration = 0x38;
            public static UInt32 ElemIndex = 0x15DDB00;
            public static UInt32 ElemInterval = 0x88;
            public static UInt32 fadeStartTime = 0x20;
            public static UInt32 fadeTime = 0x54;
            public static UInt32 flag2 = 0x7A;
            public static UInt32 flags = 0x4C;
            public static UInt32 font = 0x71;
            public static UInt32 fontScale = 12;
            public static UInt32 fontScaleStartTime = 20;
            public static UInt32 fontScaleTime = 0x52;
            public static UInt32 fromAlignOrg = 0x76;
            public static UInt32 fromAlignScreen = 0x77;
            public static UInt32 fromColor = 0x1C;
            public static UInt32 fromFontScale = 0x10;
            public static UInt32 fromHeight = 0x5E;
            public static UInt32 fromWidth = 0x5C;
            public static UInt32 fromX = 40;
            public static UInt32 fromY = 0x2C;
            public static UInt32 fxBirthTime = 0x48;
            public static UInt32 fxDecayDuration = 0x6A;
            public static UInt32 fxDecayStartTime = 0x68;
            public static UInt32 fxLetterTime = 0x66;
            public static UInt32 fxRedactDecayDuration = 110;
            public static UInt32 fxRedactDecayStartTime = 0x6C;
            public static UInt32 glowColor = 0x44;
            public static UInt32 height = 90;
            public static UInt32 HudsLength = 0x88;
            public static UInt32 label = 0x56;
            public static UInt32 materialIndex = 0x74;
            public static UInt32 moveStartTime = 0x30;
            public static UInt32 moveTime = 0x62;
            public static UInt32 offscreenMaterialIdx = 0x75;
            public static UInt32 scaleStartTime = 0x24;
            public static UInt32 scaleTime = 0x60;
            public static UInt32 sort = 0x40;
            public static UInt32 soundID = 120;
            public static UInt32 targetEntNum = 80;
            public static UInt32 team = 0x80;
            public static UInt32 text = 0x62;
            public static UInt32 time = 0x34;
            public static UInt32 type = 0x6D;
            public static UInt32 ui3dWindow = 0x4F;
            public static UInt32 value = 60;
            public static UInt32 width = 0x58;
            public static UInt32 xOffset = 0;
            public static UInt32 yOffset = 4;
            public static UInt32 zOffset = 8;

            public static void WriteBytes(UInt32 address, byte[] input)
            {
                Connectionfrm.PS3.SetMemory(address, input);
            }

            public static byte[] GetMemory(UInt32 offset, int length)
            {
                byte[] buffer = new byte[length - 1 + 1];
                Connectionfrm.PS3.GetMemory(offset, buffer);
                return buffer;
            }

            public class HUD
            {
                public static string centerString(string[] StringArray)
                {
                    int num3 = 0;
                    int length = 0;
                    int num2 = 0;
                    string str = "";
                    for (num3 = 0; num3 <= StringArray.Length - 1; num3++)
                    {
                        if (StringArray[num3].Length > length)
                        {
                            length = StringArray[num3].Length;
                        }
                    }
                    for (num3 = 0; num3 <= StringArray.Length - 1; num3++)
                    {
                        str = "";
                        if (StringArray[num3].Length < length)
                        {
                            num2 = length - StringArray[num3].Length;
                            if (StringArray[num3].Contains("[{+"))
                            {
                                num2 += 13;
                            }
                            for (int i = 0; i <= num2 - 1; i++)
                            {
                                str = str + " ";
                            }
                        }
                        StringArray[num3] = str + StringArray[num3];
                    }
                    string str2 = "";
                    for (num3 = 0; num3 <= StringArray.Length - 1; num3++)
                    {
                        str2 = str2 + StringArray[num3]; //+ Constants.vbLf
                    }
                    return ("^7" + str2);
                }

                public static void ChangeAlpha(int index, int r, int g, int b, int alpha)
                {
                    UInt32 num = Offsets.G_HudElems + (Convert.ToUInt32(index) * 0x88);
                    Connectionfrm.PS3.SetMemory(num + Hudelem.color, RGBA(r, g, b, alpha));
                }

                public static void Huds_DestroyAll()
                {
                    for (UInt32 i = 60; i <= 1023; i++)
                    {
                        Connectionfrm.PS3.SetMemory(HudStruct.G_Hudelems + (i * HudStruct.IndexSize), new byte[HudStruct.IndexSize - 1 + 1]);
                    }
                }

                public static void Objective_DestroyAll()
                {
                    for (UInt32 i = 3; i <= 0x1F; i++)
                    {
                        UInt32 address = ObjStruct.ObjectiveIndex + (i * ObjStruct.ObjectiveIndexLength);
                        Hudelem.WriteBytes(address, new byte[ObjStruct.ObjectiveIndexLength - 1 + 1]);
                    }
                }

                public static void ChangeFont(UInt32 elemIndex, short font)
                {
                    UInt32 num = Offsets.G_HudElems + (elemIndex * 0x88);
                    Connectionfrm.PS3.Extension.WriteInt16(num + 0x70, font);
                }

                public static void ChangeFontScale(int elemIndex, double fontScale)
                {
                    UInt32 num = Offsets.G_HudElems + (Convert.ToUInt32(elemIndex) * 0x88);
                    Connectionfrm.PS3.Extension.WriteFloat(num + Hudelem.fontScale, (float)fontScale);
                }

                public static void ChangeFontScaleOverTime(UInt32 elem, short Time, double OldFont, double NewFont)
                {
                    UInt32 num = Offsets.G_HudElems + (elem * 0x88);
                    Connectionfrm.PS3.Extension.WriteFloat(num + Hudelem.fromFontScale, (float)OldFont);
                    Connectionfrm.PS3.Extension.WriteUInt32(num + Hudelem.fontScaleStartTime, getLevelTime());
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.fontScaleTime, Time);
                    Connectionfrm.PS3.Extension.WriteFloat(num + Hudelem.fontScale, (float)NewFont);
                }

                public static void ChangeText(int index, short Text)
                {
                    UInt32 num = Offsets.G_HudElems + (Convert.ToUInt32(index) * 0x88);
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.label, Text);
                }

                public static void ChangeText(UInt32 Element, string Text)
                {
                    Connectionfrm.PS3.Extension.WriteInt32(Element + Hudelem.text, G_LocalizedStringIndex(Text));
                }

                public static void ChangeTextSub(int index, string Text)
                {
                    UInt32 num = Offsets.G_HudElems + (Convert.ToUInt32(index) * 0x88);
                    Connectionfrm.PS3.SetMemory(num + Hudelem.type, ReverseBytes(BitConverter.GetBytes(1)));
                    Connectionfrm.PS3.SetMemory(num + 0x79, new byte[] { 0xFF });
                    Connectionfrm.PS3.Extension.WriteInt32(num + Hudelem.text, G_LocalizedStringIndex(Text));
                }

                public static void ChangeWidth(int elemIndex, short width)
                {
                    UInt32 num = Offsets.G_HudElems + (Convert.ToUInt32(elemIndex) * 0x88);
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.width, width);
                }

                public static void DestroyAll()
                {
                    for (int i = 0; i <= 399; i++)
                    {
                        DestroyElem(i);
                    }
                }

                public static void DestroyElem(int index)
                {
                    UInt32 offset__1 = Offsets.G_HudElems + (Convert.ToUInt32(index) * 0x88);
                    Connectionfrm.PS3.SetMemory(offset__1, new byte[136]);
                }

                public static void doTypeWriter(UInt32 Index, int clientIndex, string Text, short font, double fontSize, float x, float y, UInt16
                    fxLetterTime, UInt16 fxDecayStartTime, UInt16 fxDecayDuration, int r, int g, int b, int a, int r1, int g1, int b1,
                    int a1)
                {
                    UInt32 offset__1 = Offsets.G_HudElems + (Convert.ToUInt32(Index) * 0x88);
                    byte[] buffer = ReverseBytes(BitConverter.GetBytes(Convert.ToInt32(clientIndex)));
                    Connectionfrm.PS3.SetMemory(offset__1, new byte[136]);
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.type, ReverseBytes(BitConverter.GetBytes(1)));
                    Connectionfrm.PS3.SetMemory(offset__1 + 0x79, new byte[] { 0xFF });
                    Connectionfrm.PS3.Extension.WriteInt32(offset__1 + Hudelem.text, G_LocalizedStringIndex(Text));
                    Connectionfrm.PS3.Extension.WriteFloat(offset__1 + Hudelem.fontScale, (float)fontSize);
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.xOffset, ToHexFloat(x));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.yOffset, ToHexFloat(y));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.color, RGBA(r, g, b, a));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.glowColor, RGBA(r1, g1, b1, a1));
                    Connectionfrm.PS3.Extension.WriteInt16(offset__1 + 0x70, font);
                    Connectionfrm.PS3.SetMemory(offset__1 + 0x70, new byte[] { 1 });
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.clientOffset, buffer);
                    Connectionfrm.PS3.Extension.WriteUInt32(offset__1 + Hudelem.flags, Connectionfrm.PS3.Extension.ReadUInt32(offset__1 + 0x4C) | 0x800);
                    Connectionfrm.PS3.Extension.WriteUInt32(offset__1 + Hudelem.fxBirthTime, getLevelTime());
                    Connectionfrm.PS3.Extension.WriteUInt16(offset__1 + Hudelem.fxLetterTime, fxLetterTime);
                    Connectionfrm.PS3.Extension.WriteUInt16(offset__1 + Hudelem.fxDecayStartTime, fxDecayStartTime);
                    Connectionfrm.PS3.Extension.WriteUInt16(offset__1 + Hudelem.fxDecayDuration, fxDecayDuration);
                }

                public static void doTypeWriterCustom(UInt32 Index, UInt16 fxLetterTime, UInt16 fxDecayStartTime, UInt16 fxDecayDuration)
                {
                    UInt32 num = Offsets.G_HudElems + (Convert.ToUInt32(Index) * 0x88);
                    Connectionfrm.PS3.Extension.WriteUInt32(num + Hudelem.flags, Connectionfrm.PS3.Extension.ReadUInt32(num + 0x4C) | 0x800);
                    Connectionfrm.PS3.Extension.WriteUInt32(num + Hudelem.fxBirthTime, getLevelTime());
                    Connectionfrm.PS3.Extension.WriteUInt16(num + Hudelem.fxLetterTime, fxLetterTime);
                    Connectionfrm.PS3.Extension.WriteUInt16(num + Hudelem.fxDecayStartTime, fxDecayStartTime);
                    Connectionfrm.PS3.Extension.WriteUInt16(num + Hudelem.fxDecayDuration, fxDecayDuration);
                }

                public static void FadeAlphaOverTime(UInt32 elem, short Time, int OldAlpha, int NewAlpha)
                {
                    UInt32 num = Offsets.G_HudElems + (elem * 0x88);
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(OldAlpha));
                    Connectionfrm.PS3.SetMemory(num + 0x1F, bytes);
                    Connectionfrm.PS3.Extension.WriteUInt32(num + Hudelem.fadeStartTime, getLevelTime());
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.fadeTime, Time);
                    byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(NewAlpha));
                    Connectionfrm.PS3.SetMemory(num + 0x1B, buffer);
                }

                public static void FadeOverTime(UInt32 elem, short Time, int R, int G, int B, int A)
                {
                    UInt32 num = Offsets.G_HudElems + (elem * 0x88);
                    byte[] memory = Hudelem.GetMemory(num + Hudelem.color, 1);
                    byte[] buffer = Hudelem.GetMemory((num + Hudelem.color) + 1, 1);
                    byte[] buffer3 = Hudelem.GetMemory((num + Hudelem.color) + 2, 1);
                    byte[] buffer4 = Hudelem.GetMemory((num + Hudelem.color) + 3, 1);
                    Connectionfrm.PS3.SetMemory(num + Hudelem.fromColor, memory);
                    Connectionfrm.PS3.SetMemory((num + Hudelem.fromColor) + 1, buffer);
                    Connectionfrm.PS3.SetMemory((num + Hudelem.fromColor) + 2, buffer3);
                    Connectionfrm.PS3.SetMemory((num + Hudelem.fromColor) + 3, buffer4);
                    Connectionfrm.PS3.Extension.WriteUInt32(num + Hudelem.fadeStartTime, getLevelTime());
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.fadeTime, Time);
                    Connectionfrm.PS3.SetMemory(num + Hudelem.color, RGBA(R, G, B, A));
                }

                public static int G_LocalizedStringIndex(string Text)
                {
                    return RPC.Call(Offsets.G_LocalizedStringIndex, new object[] { Text });
                }

                private static int GetClientTime(UInt32 clientIndex)
                {
                    byte[] buffer = new byte[4];
                    Connectionfrm.PS3.GetMemory(0x177B828 + (clientIndex * 0x5808), buffer);
                    return BitConverter.ToInt32(ReverseBytes(buffer), 0);
                }

                public static UInt32 getLevelTime()
                {
                    return Connectionfrm.PS3.Extension.ReadUInt32(Offsets.level_locals_t + 0x798);
                }

                public static UInt32 HudElem_Alloc(bool Reset = false)
                {
                    if (Reset)
                    {
                        HudAlloc.IndexSlot = 50;
                    }
                    UInt32 num = Hudelem.ElemIndex + (HudAlloc.IndexSlot * Hudelem.ElemInterval);
                    HudAlloc.IndexSlot++;
                    return num;
                }

                public static UInt32 MoveOverTime(UInt32 elem, short Time, float X, float Y)
                {
                    UInt32 offset__1 = Offsets.G_HudElems + (elem * 0x88);
                    Connectionfrm.PS3.Extension.WriteFloat(offset__1 + Hudelem.fromX, Connectionfrm.PS3.Extension.ReadFloat(offset__1));
                    Connectionfrm.PS3.Extension.WriteFloat(offset__1 + Hudelem.fromY, Connectionfrm.PS3.Extension.ReadFloat(offset__1 + Hudelem.yOffset));
                    Connectionfrm.PS3.Extension.WriteInt32(offset__1 + Hudelem.moveStartTime, System.Convert.ToInt32(getLevelTime()));
                    Connectionfrm.PS3.Extension.WriteInt16(offset__1 + Hudelem.moveTime, Time);
                    Connectionfrm.PS3.Extension.WriteFloat(offset__1, X);
                    Connectionfrm.PS3.Extension.WriteFloat(offset__1 + Hudelem.yOffset, Y);
                    return offset__1;
                }

                public static void MoveShaderX(UInt32 index, float X)
                {
                    Connectionfrm.PS3.Extension.WriteFloat((Offsets.G_HudElems + (index * 0x88)) + Hudelem.xOffset, X);
                }

                public static void MoveShaderXY(UInt32 index, float X, float Y)
                {
                    Connectionfrm.PS3.Extension.WriteFloat((Offsets.G_HudElems + (index * 0x88)) + Hudelem.xOffset, X);
                    Connectionfrm.PS3.Extension.WriteFloat((Offsets.G_HudElems + (index * 0x88)) + Hudelem.yOffset, Y);
                }

                public static void MoveShaderY(UInt32 index, float Y)
                {
                    Connectionfrm.PS3.Extension.WriteFloat((Offsets.G_HudElems + (index * 0x88)) + Hudelem.yOffset, Y);
                }

                public static void PlaySound(UInt32 elemIndex, string SoundID, UInt32 Duration)
                {
                    UInt32 num = Offsets.G_HudElems + (elemIndex * 0x88);
                    Connectionfrm.PS3.Extension.WriteString(num + Hudelem.soundID, SoundID);
                    Connectionfrm.PS3.Extension.WriteUInt32(num + Hudelem.duration, Duration);
                }

                public static byte[] ReverseBytes(byte[] inArray)
                {
                    Array.Reverse(inArray);
                    return inArray;
                }

                public static byte[] RGBA(decimal R, decimal G, decimal B, decimal A)
                {
                    byte[] buffer = new byte[4];
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(R));
                    byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(G));
                    byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(B));
                    byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(A));
                    buffer[0] = bytes[0];
                    buffer[1] = buffer3[0];
                    buffer[2] = buffer4[0];
                    buffer[3] = buffer5[0];
                    return buffer;
                }

                public static void ScaleOverTime(UInt32 elem, short Time, short Width, short Height)
                {
                    UInt32 num = Offsets.G_HudElems + (elem * 0x88);
                    Connectionfrm.PS3.Extension.WriteFloat(num + Hudelem.fromHeight, Connectionfrm.PS3.Extension.ReadFloat(num + Hudelem.height));
                    Connectionfrm.PS3.Extension.WriteFloat(num + Hudelem.fromWidth, Connectionfrm.PS3.Extension.ReadFloat(num + Hudelem.width));
                    Connectionfrm.PS3.Extension.WriteInt32(num + Hudelem.scaleStartTime, System.Convert.ToInt32(getLevelTime()));
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.scaleTime, Time);
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.height, Height);
                    Connectionfrm.PS3.Extension.WriteInt16(num + Hudelem.width, Width);
                }

                public static void SetGlow(int elemIndex, int r1, int g1, int b1, int a1)
                {
                    UInt32 num = Offsets.G_HudElems + (Convert.ToUInt32(elemIndex) * 0x88);
                    Connectionfrm.PS3.SetMemory(num + Hudelem.glowColor, RGBA(r1, g1, b1, a1));
                    Thread.Sleep(20);
                }

                public static void SetGlowText(int elemIndex, int client, string Text, short font, double fontScale, float x, float y,
                    UInt32 align, int sort, int R, int G, int B, int A, int R1, int G1, int B1,
                    int A1)
                {
                    UInt32 offset__1 = Offsets.G_HudElems + (Convert.ToUInt32(elemIndex) * 0x88);
                    byte[] buffer = ReverseBytes(BitConverter.GetBytes(Convert.ToInt32(client)));
                    Connectionfrm.PS3.SetMemory(offset__1, new byte[136]);
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.type, ReverseBytes(BitConverter.GetBytes(1)));
                    Connectionfrm.PS3.SetMemory(offset__1 + 0x79, new byte[] { 0xFF });
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.fontScale, new byte[] { 0x3F, 0xC0 });
                    Connectionfrm.PS3.Extension.WriteInt32(offset__1 + Hudelem.text, G_LocalizedStringIndex(Text));
                    Connectionfrm.PS3.Extension.WriteFloat(offset__1 + Hudelem.fontScale, (float)fontScale);
                    Connectionfrm.PS3.Extension.WriteInt16(offset__1 + 0x70, font);
                    Connectionfrm.PS3.SetMemory(offset__1 + 0x70, new byte[] { 1 });
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.xOffset, ToHexFloat(x));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.yOffset, ToHexFloat(y));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.color, RGBA(R, G, B, A));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.color, RGBA(R1, G1, B1, A1));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.clientOffset, buffer);
                    Connectionfrm.PS3.Extension.WriteBytes(offset__1 + Hudelem.flags, new byte[] { 0x1 });
                }

                public static void SpinText(UInt32 Index, int Radius, int X, int Y)
                {
                    int num = X;
                    int num2 = Y;
                    int num3 = Radius;
                    int num4 = 0;
                    while (true)
                    {
                        double num5 = num + (Math.Sin(num4) * num3);
                        double num6 = num2 + (Math.Cos(num4) * num3);
                        MoveShaderXY(Index, System.Convert.ToInt32(Math.Truncate(num5)), System.Convert.ToInt32(Math.Truncate(num6)));
                        Thread.Sleep(100);
                        num4++;
                    }
                }

                public static void StoreIcon(int elemIndex, UInt32 client, short shader, short Width, short Height, float x, float y,
                    UInt32 align, float sort, int r, int g, int b,
                    int a)
                {
                    UInt32 offset__1 = Offsets.G_HudElems + (Convert.ToUInt32(elemIndex) * 0x88);
                    byte[] buffer = ReverseBytes(BitConverter.GetBytes(client));
                    Connectionfrm.PS3.SetMemory(offset__1, new byte[136]);
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.type, ReverseBytes(BitConverter.GetBytes(8)));
                    Connectionfrm.PS3.SetMemory(offset__1 + 0x79, new byte[] { 0xFF });
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.fontScale, new byte[] { 0x3F, 0xC0 });
                    Connectionfrm.PS3.Extension.WriteInt32(offset__1 + Hudelem.font, shader);
                    Connectionfrm.PS3.Extension.WriteInt16(offset__1 + Hudelem.height, Height);
                    Connectionfrm.PS3.Extension.WriteInt16(offset__1 + Hudelem.width, Width);
                    Connectionfrm.PS3.SetMemory((offset__1 + Hudelem.moveTime) + 4, ReverseBytes(BitConverter.GetBytes(sort)));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.xOffset, ToHexFloat(x));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.yOffset, ToHexFloat(y));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.color, RGBA(r, g, b, a));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.clientOffset, buffer);
                }

                public static void StoreTextElem(int elemIndex, int client, string Text, short font, double fontScale, float x, float y,
                    UInt32 align, int sort, int R, int G, int B,
                    int A)
                {
                    UInt32 offset__1 = Offsets.G_HudElems + (Convert.ToUInt32(elemIndex) * 0x88);
                    byte[] buffer = ReverseBytes(BitConverter.GetBytes(Convert.ToInt32(client)));
                    Connectionfrm.PS3.SetMemory(offset__1, new byte[136]);
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.type, ReverseBytes(BitConverter.GetBytes(1)));
                    Connectionfrm.PS3.SetMemory(offset__1 + 0x79, new byte[] { 0xFF });
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.fontScale, new byte[] { 0x3F, 0xC0 });
                    Connectionfrm.PS3.Extension.WriteInt32(offset__1 + Hudelem.text, G_LocalizedStringIndex(Text));
                    Connectionfrm.PS3.Extension.WriteFloat(offset__1 + Hudelem.fontScale, (float)fontScale);
                    Connectionfrm.PS3.Extension.WriteInt16(offset__1 + 0x70, font);
                    Connectionfrm.PS3.SetMemory(offset__1 + 0x70, new byte[] { 1 });
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.xOffset, ToHexFloat(x));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.yOffset, ToHexFloat(y));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.color, RGBA(R, G, B, A));
                    Connectionfrm.PS3.SetMemory(offset__1 + Hudelem.clientOffset, buffer);
                    Connectionfrm.PS3.Extension.WriteBytes(offset__1 + Hudelem.flags, new byte[] { 0x1 });
                }

                public static byte[] ToHexFloat(float Axis)
                {
                    byte[] bytes = BitConverter.GetBytes(Axis);
                    Array.Reverse(bytes);
                    return bytes;
                }

                public static void ZigZagText(UInt32 elemIndex, short Speed)
                {
                    UInt32 num = Offsets.G_HudElems + (elemIndex * 0x88);
                    float num2 = 0.0F;
                    Connectionfrm.PS3.SetMemory(num + Hudelem.xOffset, ToHexFloat(-400.0F));
                    while (true)
                    {
                        float num4 = 0;
                        float num5 = 0;
                        float num3 = System.Convert.ToSingle(Connectionfrm.PS3.Extension.ReadFloat(num + Hudelem.xOffset));
                        if (num2 == 480.0F)
                        {
                            return;
                        }
                        switch (0)
                        {
                            case -400:
                                num2 += 120.0F;
                                num4 = num2;
                                num5 = 800.0F;
                                MoveOverTime(elemIndex, Speed, num5, num4);
                                break;

                            case 800:
                                num2 += 120.0F;
                                num4 = num2;
                                num5 = -400.0F;
                                MoveOverTime(elemIndex, Speed, num5, num4);
                                break;
                        }
                        Thread.Sleep(Speed);
                    }
                }

                public sealed class HudAlloc
                {
                    private HudAlloc()
                    {
                    }
                    public static UInt32 g_hudelem = 0x15DDB00;
                    public static UInt32 IndexSlot = 50;
                }

                public class HudStruct
                {
                    public static UInt32 abilityFlag = 0x84;
                    public static UInt32 alignOrg = 0x72;
                    public static UInt32 alignScreen = 0x73;
                    public static UInt32 clientOffset = 0x7C;
                    public static UInt32 color = 0x18;
                    public static UInt32 duration = 0x38;
                    public static UInt32 fadeStartTime = 0x20;
                    public static UInt32 fadeTime = 0x54;
                    public static UInt32 flag2 = 0x7A;
                    public static UInt32 flags = 0x4C;
                    public static UInt32 Font = 0x71;
                    public static UInt32 fontScaleStartTime = 20;
                    public static UInt32 fontScaleTime = 0x52;
                    public static UInt32 FontSize = 12;
                    public static UInt32 fromAlignOrg = 0x76;
                    public static UInt32 fromAlignScreen = 0x77;
                    public static UInt32 fromColor = 0x1C;
                    public static UInt32 fromFontScale = 0x10;
                    public static UInt32 fromHeight = 0x5E;
                    public static UInt32 fromWidth = 0x5C;
                    public static UInt32 fromX = 40;
                    public static UInt32 fromY = 0x2C;
                    public static UInt32 fxBirthTime = 0x48;
                    public static UInt32 fxDecayDuration = 0x6A;
                    public static UInt32 fxDecayStartTime = 0x68;
                    public static UInt32 fxLetterTime = 0x66;
                    public static UInt32 fxRedactDecayDuration = 110;
                    public static UInt32 fxRedactDecayStartTime = 0x6C;
                    public static UInt32 G_Hudelems = 0x15DDB00;
                    public static UInt32 glowColor = 0x44;
                    public static UInt32 Height = 90;
                    public static UInt32 IndexSize = 0x88;
                    public static UInt32 label = 0x56;
                    public static UInt32 materialIndex = 0x74;
                    public static UInt32 moveStartTime = 0x30;
                    public static UInt32 moveTime = 0x62;
                    public static UInt32 offscreenMaterialIndex = 0x75;
                    public static UInt32 scaleStartTime = 0x24;
                    public static UInt32 scaleTime = 0x60;
                    public static UInt32 sort = 0x40;
                    public static UInt32 soundID = 120;
                    public static UInt32 targetEntNum = 80;
                    public static UInt32 team = 0x80;
                    public static UInt32 text = 100;
                    public static UInt32 time = 0x34;
                    public static UInt32 type = 0x70;
                    public static UInt32 ui3dWindow = 0x79;
                    public static UInt32 value = 60;
                    public static UInt32 Width = 0x58;
                    public static UInt32 X = 0;
                    public static UInt32 Y = 4;
                    public static UInt32 Z = 8;

                    public class Align
                    {
                        public static UInt32 BOTTOM_CENTER = 0x9A;
                        public static UInt32 BOTTOM_LEFT = 0x8A;
                        public static UInt32 BOTTOM_RIGHT = 170;
                        public static UInt32 CENTER_LEFT = 130;
                        public static UInt32 CENTER_MIDDLE = 0x92;
                        public static UInt32 CENTER_RIGHT = 0xA2;
                        public static UInt32 TOP_CENTERED = 120;
                        public static UInt32 TOP_LEFT = 0x88;
                        public static UInt32 TOP_RIGHT = 0xA8;
                    }

                    public class Typewriter
                    {
                        public static UInt32 Classic = 0x4000;
                        public static UInt32 Normal = 0x800;
                    }
                }

                public class ObjStruct
                {
                    public static UInt32 MaterialIndex = 0x1C;
                    public static UInt32 ObjectiveIndex = 0x1608194;
                    public static UInt32 ObjectiveIndexLength = 0x30;
                    public static UInt32 Origin = 4;
                    public static UInt32 State = 40;
                    public static UInt32 targetEntNum = 0x10;
                    public static UInt32 Team = 0x2D;
                    public static UInt32 X = 4;
                    public static UInt32 Y = 8;
                    public static UInt32 Z = 12;
                }
            }
        }
    }

