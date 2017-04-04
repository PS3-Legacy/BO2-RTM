using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class ZMTeleport
    {
        
        static uint TeleportOffset = 0x1780F50;
        
        public class Locations
        {
            public class Buried
            {
                public static void Teleport(int Client, int Place)
                {
                    if (Place == 0)
                    {
                        float[] Bank = new float[] { -407.5783f, -360.7638f, 8.125f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, Bank);
                    }
                    else if (Place == 1)
                    {
                        float[] WeaponsRoom = new float[] { -400.4583f, -1229.859f, 8.125f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, WeaponsRoom);
                    }
                    else if (Place == 2)
                    {
                        float[] MuleKick = new float[] { -268.4938f, 72.35909f, 8.125f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, MuleKick);
                    }
                    else if (Place == 3)
                    {
                        float[] Box2 = new float[] { -590.6044f, -289.3354f, -29.8397f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, Box2);
                    }
                    else if (Place == 4)
                    {
                        float[] Prison = new float[] { 512.3202f, -1313.716f, 246.057f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, Prison);
                    }
                    else if (Place == 5)
                    {
                        float[] WitchedHouse = new float[] { 2538.729f, 230.8944f, 88.125f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, WitchedHouse);
                    }
                    else if (Place == 6)
                    {
                        float[] MazeStart = new float[] { 3704.279f, 151.0696f, 4.124999f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, MazeStart);
                    }
                    else if (Place == 7)
                    {
                        float[] Maze = new float[] { 3704.279f, 151.0696f, 4.124999f };
                        Functions.WriteSingle(TeleportOffset + 0x5808 * (uint)Client, Maze);
                    }
                    Connectionfrm.PS3.SetMemory(0x1786348 + 0x5808 * (uint)Client, new byte[] { 0x04 });
                }
                
            }
        }
    }
}
