using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Ops_II_By_BISOON
{
    class Functions
    {
        public static void SetMem(uint Offset, byte[] value)
        {
            Connectionfrm.PS3.SetMemory(Offset, value);
        }
        public static void WriteUInt16(uint offset, ushort Value)
        {
            Connectionfrm.PS3.SetMemory(offset, BitConverter.GetBytes(Value).Reverse<byte>().ToArray<byte>());
        }
        public static void WriteFlo(uint Offset, float Input)
        {
            Connectionfrm.PS3.Extension.WriteFloat(Offset, Input);
        }
        public static void WriteStr(uint Offset, string Input)
        {
            Connectionfrm.PS3.Extension.WriteString(Offset, Input);
        }
        public static string ReadStr(uint Offset)
        {
            return Connectionfrm.PS3.Extension.ReadString(Offset);
        }
        public static void WriteByte(uint Offset, byte Input)
        {
            Connectionfrm.PS3.Extension.WriteByte(Offset, Input);
        }
        public static byte[] ReverseBytes(byte[] inArray)
        {
            Array.Reverse(inArray);
            return inArray;
        }
        public static void WriteSingle(uint address, float[] input)
        {
            int length = input.Length;
            byte[] array = new byte[length * 4];
            for (int i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (int)(i * 4));
            }
            Connectionfrm.PS3.SetMemory(address, array);
        }
        public static void WriteSingle(uint address, float input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            Connectionfrm.PS3.SetMemory(address, array);
        }
        public static float ReadSingle(uint address)
        {
            byte[] memory = Connectionfrm.PS3.GetBytes(address, 4);
            Array.Reverse(memory, 0, 4);
            return BitConverter.ToSingle(memory, 0);
        }
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = Connectionfrm.PS3.GetBytes(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length - 1 + 1];
            for (int i = 0; i <= length - 1; i++)
            {
                numArray[i] = System.Convert.ToSingle(BitConverter.ToSingle(memory, ((length - 1) - i) * 4));
            }
            return numArray;
        }
    }
}
