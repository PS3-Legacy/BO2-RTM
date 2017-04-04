using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class CarePackageBullet
    {
        public static float[] TraceBullet(int clientIndex, float TracerDistance)
        {
            int Trace = 0x25D2B00;
            float[] Start = getOrigin(clientIndex);
            float[] End = PlayerAnglesToForward(clientIndex, TracerDistance);
            G_LocationalTrace(Trace, Start, End);
            float[] BulletTrace = new float[3];
            BulletTrace = new float[] { (((End[0] - Start[0]) * Functions.ReadSingle((uint)Trace + 0x10) + Start[0])), (((End[1] - Start[1]) * Functions.ReadSingle((uint)Trace + 0x10) + Start[1])), (((End[2] - Start[2]) * Functions.ReadSingle((uint)Trace + 0x10) + Start[2])) };
            return BulletTrace;
        }
        public static float[] getOrigin(int client)
        {
            return Functions.ReadSingle(0x1780F28 + 0x28, 3);
        }
        public static float[] G_GetPlayerViewOrigin(int Client)
        {
            return Functions.ReadSingle(0x1780F5C + 0x5808 * (uint)Client, 3);
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
        public static void G_LocationalTrace(int Trace, float[] Start, float[] End)
        {
            RPC.Call(0x35C338, Trace, Start, End, 0, 0x280E8B3, 0);
        }
        public static void CarePackageGun(int Client)
        {
            if ( BitConverter.ToUInt32(Connectionfrm.PS3.Extension.ReadBytes(0x1780F28 + 0x547C + ((uint)Client * 0x5808), 4),0) == 128)
            {
                SpawnEntity("t6_wpn_supply_drop_ally", TraceBullet(Client, 9999f), getOrigin(Client));
            }
        }
        public static void SpawnEntity(string Model, float[] Origin, float[] Angles)
        {
            uint gentitys = (uint)RPC.Call(0x278AC0);
            Functions.WriteSingle(gentitys + 0x134, Origin);
            Functions.WriteSingle(gentitys + 0x140, Angles);
            RPC.Call(0x2774A4, gentitys, Model);
            RPC.Call(0x266F48, gentitys);
        }
    }

}
