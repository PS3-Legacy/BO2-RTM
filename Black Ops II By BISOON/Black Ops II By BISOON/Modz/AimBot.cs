using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class AimBot
    {
        public static void StartAimBot(int Client)
        {
            if (BitConverter.ToUInt32(Connectionfrm.PS3.Extension.ReadBytes(0x17863A4 + 0x5808 * (uint)Client, 4), 0) == 2147487744U)
            {
                SetClientViewAngles(Client, GetNearestPlayer(Client, true));
            }
        }
        public static void StartAimBotNoAimingRequired(int Client)
        {
            SetClientViewAngles(Client, GetNearestPlayer(Client, true));
        }
        public static void StartUnfairAimBot(int Client)
        {
            if (BitConverter.ToUInt32(Connectionfrm.PS3.Extension.ReadBytes(0x17863A4 + 0x5808 * (uint)Client, 4), 0) == 2147487744U)
            {
                SetClientViewAngles(Client, GetNearestPlayer(Client, true));
                if (BitConverter.ToUInt32(Connectionfrm.PS3.Extension.ReadBytes(0x17863A4 + 0x5808 * (uint)Client, 4), 0) == 2147487744U + 128)
                {
                    RPC.Player_Die(Client, GetNearestPlayer(Client, true), 0, Func.ClientMods.ReturnHeldWeapon(Client));
                }
            }
        }
        static int GetNearestPlayer(int clientIndex, bool EnemyOnly = false)
        {
            int nearestClient = 0;
            float nearestDistance = 99999999;
            for (int i = 0; i <= 11; i++)
            {
                if (i != clientIndex)
                {
                    if ((ClientIsInGame(i)) && ClientIsAlive(i))
                    {
                        if (Connectionfrm.PS3.Extension.ReadInt32(0x178642C + 0x5808 * (uint)clientIndex) != 0 && EnemyOnly)
                        {
                            if (!ClientIsSameTeam(clientIndex, i))
                            {
                                float Distance = System.Convert.ToSingle(Distance3D(GetPlayerPosition(clientIndex), GetPlayerPosition(i)));
                                if (Distance < nearestDistance)
                                {
                                    nearestDistance = Distance;
                                    nearestClient = i;
                                }
                            }
                        }
                        else
                        {
                            float Distance = System.Convert.ToSingle(Distance3D(GetPlayerPosition(clientIndex), GetPlayerPosition(i)));
                            if (Distance < nearestDistance)
                            {
                                nearestDistance = Distance;
                                nearestClient = i;
                            }
                        }
                    }
                }
            }
            return nearestClient;
        }
        static bool ClientIsSameTeam(int clientIndex, int otherPlayer)
        {
            return (Connectionfrm.PS3.Extension.ReadInt32(0x178642C + 0x5808 * (uint)clientIndex) == Connectionfrm.PS3.Extension.ReadInt32(0x178642C + 0x5808 * (uint)otherPlayer));
        }
        static bool ClientIsInGame(int clientIndex)
        {
            return (Connectionfrm.PS3.Extension.ReadInt32(0x1780F28 + 0x5808 * (uint)clientIndex) != 0);
        }
        static bool ClientIsAlive(int clientIndex)
        {
            return (Connectionfrm.PS3.Extension.ReadInt32(0x17864F8 + 0x5808 * (uint)clientIndex) == 0);
        }
        public static float Distance3D(float[] point1, float[] point2)
        {
            float deltax = point2[0] - point1[0];
            float deltay = point2[1] - point1[1];
            float deltaz = point2[2] - point1[2];
            return Convert.ToSingle(Math.Sqrt((deltax * deltax) + (deltay * deltay) + (deltaz * deltaz)));
        }
        public static void SetClientViewAngles(int clientIndex, int Victim)
        {
            float[] Vec = getVector(GetPlayerPosition(clientIndex), GetPlayerPosition(Victim));
            Vec[2] -= System.Convert.ToSingle(CheckStance(Victim));
            Vec[2] += System.Convert.ToSingle(CheckStanceAttacker(clientIndex));
            float[] Angles = vectoangles(Vec);
            setViewAngles((uint)clientIndex, Angles);
        }
        static void setViewAngles(UInt32 clientIndex, float[] Angles)
        {
            WriteFloat(0x10040000, Angles);
            RPC.Call(0x1E1BF0, G_Entity(System.Convert.ToInt32(clientIndex)), 0x10040000);
        }
        static void WriteFloat(uint address, float[] input)
        {
            int length = input.Length;
            byte[] array = new byte[length * 4];
            for (int i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (int)(i * 4));
            }
            Connectionfrm.PS3.SetMemory(address, array);
        }
        public static UInt32 G_Entity(int Client, UInt32 Mod = 0)
        {
            return (uint)(0x16B9F20 + (0x31C * Client) + Mod);
        }
        static float[] vectoangles(float[] Angles)
        {
            float forward = default(float);
            float yaw = default(float);
            float pitch = default(float);
            float[] angles_Renamed = new float[3];
            if (Angles[1] == 0 && Angles[0] == 0)
            {
                yaw = 0;
                if (Angles[2] > 0)
                {
                    pitch = 90.0F;
                }
                else
                {
                    pitch = 270.0F;
                }
            }
            else
            {
                if (Angles[0] != -1)
                {
                    yaw = System.Convert.ToSingle(Math.Atan2(Angles[1], Angles[0]) * 180.0F / Math.PI);
                }
                else if (Angles[1] > 0)
                {
                    yaw = 90.0F;
                }
                else
                {
                    yaw = 270;
                }
                if (yaw < 0)
                {
                    yaw += 360.0F;
                }

                forward = System.Convert.ToSingle(Math.Sqrt(Angles[0] * Angles[0] + Angles[1] * Angles[1]));
                pitch = System.Convert.ToSingle(Math.Atan2(Angles[2], forward) * 180.0F / Math.PI);
                if (pitch < 0)
                {
                    pitch += 360.0F;
                }
            }
            angles_Renamed[0] = System.Convert.ToSingle(-pitch);
            angles_Renamed[1] = yaw;
            angles_Renamed[2] = 0;

            return angles_Renamed;
        }
        static float CheckStanceAttacker(int clientIndex)
        {
            int CurrentStance = Connectionfrm.PS3.Extension.ReadByte(0x1781027 + 0x5808 * (uint)clientIndex);
            if (CurrentStance == 0x8 || CurrentStance == 0xA || CurrentStance == 0x48 || CurrentStance == 0x4A)
            {
                return 46.0F;
            }
            if (CurrentStance == 0x4 || CurrentStance == 0x6 || CurrentStance == 0x44 || CurrentStance == 0x46)
            {
                return 18.0F;
            }
            return 0.0F;
        }
        static float CheckStance(int clientIndex)
        {
            int CurrentStance = Connectionfrm.PS3.Extension.ReadByte(0x1781027 + 0x5808 * (uint)clientIndex);
            if (CurrentStance == 0x8 || CurrentStance == 0xA || CurrentStance == 0x48 || CurrentStance == 0x4A)
            {
                return 44.0F;
            }
            if (CurrentStance == 0x4 || CurrentStance == 0x6 || CurrentStance == 0x44 || CurrentStance == 0x46)
            {
                return 14.0F;
            }
            return 0.0F;
        }
        static float[] getVector(float[] point1, float[] point2)
        {
            return new Single[] { (point2[0] - point1[0]), (point2[1] - point1[1]), (point2[2] - point1[2]) };
        }
        public static float[] GetPlayerPosition(int clientIndex)
        {
            float[] Position = ReadFloat(0x1780F50 + 0x5808 * (uint)clientIndex, 3);
            return Position;
        }
        static float[] ReadFloat(UInt32 address, int length)
        {
            byte[] memory = GetMemory(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length - 1 + 1];
            for (int i = 0; i <= length - 1; i++)
            {
                numArray[i] = BitConverter.ToSingle(memory, ((length - 1) - i) * 4);
            }
            return numArray;
        }
        public static byte[] GetMemory(uint Offset, int Length)
        {
            byte[] Buffer = new byte[Length];
            Connectionfrm.PS3.GetMemory(Offset, Buffer);
            return Buffer;
        }

        static byte[] ReverseBytes(byte[] inArray)
        {
            Array.Reverse(inArray);
            return inArray;
        }
    }
}
