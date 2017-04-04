using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class SpawnHelicopter
    {
        public static uint G_SpawnHelicopter(uint Owner, string Type, string Model, float[] Origin, float[] Angles)
        {
            uint Entity = (uint)RPC.Call(0x278ac0);
            Functions.WriteSingle(Entity + 0x134, Origin);
            Functions.WriteSingle(Entity + 0x140, Angles);
            RPC.Call(0x22C3b8, Entity, Owner, Type, Model);
            return Entity;
        }
        public static Single[] GetTagOrigin(Int32 entityIndex, String tagName = "j_head")
        {
            Int32 Entity = (Int32)G_Entity(entityIndex);
            Int32 tagId = RPC.Call(0x48ed68, tagName.ToLower(), 0);
            RPC.Call(0x278004, Entity, tagId, 0x2600270);
            return Functions.ReadSingle(0x2600270, 3);
        }
        public static float[] getViewAngles(int Client)
        {
            return Functions.ReadSingle(0x1780F28 + 0x56BC + 0x5808 * (uint)Client, 3);
        }
        public static UInt32 G_Entity(int Client, UInt32 Mod = 0)
        {
            return (uint)(0x16B9F20 + (0x31C * Client) + Mod);
        }
    }
}
