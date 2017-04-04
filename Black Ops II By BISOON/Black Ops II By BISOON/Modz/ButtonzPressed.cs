using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class ButtonzPressed
    {
        public struct Buttons
        {
            public static UInt32 X = 8192;
            public static UInt32 O = 16384;
            public static UInt32 Square = 4;
            public static UInt32 L3 = 1088;
            public static UInt32 R3 = 32;
            public static UInt32 L2 = 256;
            public static UInt32 R2 = 512;
            public static UInt32 L1 = 2147487744U;
            public static UInt32 R1 = 128;
            public static UInt32 Crouch = 16384;
            public static UInt32 Prone = 32768;
            public static UInt32 L1andR1 = 2147487744U + 128;
            public static UInt32 R2_Crouch = 16896;
            public static UInt32 L2_Crouch = 16640;
        }
        public static bool ButtonPressed(int clientIndex, UInt32 Button)
        {
            byte[] Sticky = Connectionfrm.PS3.Extension.ReadBytes(0x1780F28 + 0x547C + ((uint)clientIndex * 0x5808), 4);
            UInt32 Buttonz = BitConverter.ToUInt32(Sticky, 0);
            if (Buttonz == Button)
            {
                return true;
            }
            return false;
        }
    }
    public class DPAD
    {
        public static UInt32 DPADUp = 0x34;
        public static UInt32 DPADDown = 0x38;
        public static UInt32 DPADLeft = 0x3C;
        public static UInt32 DPADRight = 0x40;
        public static bool DPADPressed(int Client, UInt32 Button)
        {
            int ButtonIndex = System.Convert.ToInt32(Connectionfrm.PS3.Extension.ReadInt32(0x94608C + Button));
            int B1 = Connectionfrm.PS3.Extension.ReadInt32(0x17865E0);//1780F28
            int B2 = Connectionfrm.PS3.Extension.ReadInt32(0x1780F28 + 0x56A0);
            if ((B1 == ButtonIndex) || (B2 == ButtonIndex))
            {
                return true;
            }
            return false;
        }
    }
}
