using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class AdvancedNoClip
    {
        public static void AdvancedNoclip(int Client)
        {
            SetVelocity(Client, new float[] { ReturnVelocity(Client)[0], ReturnVelocity(Client)[1], 42.5f });

            if (BitConverter.ToUInt32(Connectionfrm.PS3.Extension.ReadBytes(0x1780F28 + 0x547C + ((uint)Client * 0x5808), 4), 0) == 1088)
            {
                SetOrigin(Client, PlayerAnglesToForward(Client, 85));
            }
        }

        public static float[] ReturnVelocity(int Client)
        {
            return Functions.ReadSingle((0x1780F28 + 0x34) + 0x5808 * (uint)Client, 3);
        }
        public static void SetOrigin(int Client, float[] Origin)
        {
            Functions.WriteSingle((0x1780F28 + 0x28) + 0x5808 * (uint)Client, Origin);
        }
        public static float[] PlayerAnglesToForward(int clientIndex, float Distance = 200f)
        {
            float[] Angles = Functions.ReadSingle((0x1780F28 + 0x56BC) + 0x5808 * (uint)clientIndex, 3);
            float[] Position = Functions.ReadSingle((0x1780F28 + 0x28) + 0x5808 * (uint)clientIndex, 3);
            float angle, sr, sp, sy, cr, cp, cy, PiDiv;
            PiDiv = ((float)Math.PI / 180f);
            angle = Angles[1] * PiDiv;
            sy = (float)Math.Sin(angle);
            cy = (float)Math.Cos(angle);
            angle = Angles[0] * PiDiv;
            sp = (float)Math.Sin(angle);
            cp = (float)Math.Cos(angle);
            angle = Angles[2] * PiDiv;
            sr = (float)Math.Sin(angle);
            cr = (float)Math.Cos(angle);
            float[] Forward = new float[] { (cp * cy * Distance) + Position[0], (cp * sy * Distance) + Position[1], (-sp * Distance) + Position[2] };
            return Forward;
        }
        public static void SetVelocity(Int32 clientIndex, Single[] Velocity)
        {
            Functions.WriteSingle((0x1780F28 + 0x34) + 0x5808 * (uint)clientIndex, 3);
        }
    }
}
