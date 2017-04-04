using System;
using System.Collections.Generic;
using System.Text;

namespace Black_Ops_II_By_BISOON
{
    public static class ClassNames
    {
        public class ClassNamesOffsets
        {
            #region Offsets per class
            //public static uint Cl1 = 0x2707AC7;
            //public static uint Cl2 = 0x2707AD7;
            //public static uint Cl3 = 0x2707AE7;
            //public static uint Cl4 = 0x2707AF7;
            //public static uint Cl5 = 0x2707B07;
            //public static uint Cl6 = 0x2707B17;
            //public static uint Cl7 = 0x2707B27;
            //public static uint Cl8 = 0x2707B37;
            //public static uint Cl9 = 0x2707B47;
            //public static uint Cl10 = 0x2707B57;
            #endregion
            public static uint Cl1 = 0x2707AC7;
            public static uint Cl2 = Cl1 + 0x10;
            public static uint Cl3 = Cl2 + 0x10;
            public static uint Cl4 = Cl3 + 0x10;
            public static uint Cl5 = Cl4 + 0x10;
            public static uint Cl6 = Cl5 + 0x10;
            public static uint Cl7 = Cl6 + 0x10;
            public static uint Cl8 = Cl7 + 0x10;
            public static uint Cl9 = Cl8 + 0x10;
            public static uint Cl10 = Cl9 + 0x10;
        }
        public static byte[] Multiply(this byte[] A, byte[] B)
        {
            List<byte> list = new List<byte>();
            int num = 0;
            for (int i = 0; i < A.Length; i++)
            {
                byte b = 0;
                for (int j = 0; j < B.Length; j++)
                {
                    short num2 = (short)(A[i] * B[j] + b);
                    b = (byte)(num2 >> 8);
                    byte b2 = (byte)num2;
                    num = i + j;
                    if (num < list.Count)
                    {
                        list = ClassNames._add_(list, b2, num, 0);
                    }
                    else
                    {
                        list.Add(b2);
                    }
                }
                if (b > 0)
                {
                    if (num + 1 < list.Count)
                    {
                        list = ClassNames._add_(list, b, num + 1, 0);
                    }
                    else
                    {
                        list.Add(b);
                    }
                }
            }
            return list.ToArray();
        }
        private static List<byte> _add_(List<byte> A, byte b, int idx = 0, byte rem = 0)
        {
            List<byte> result;
            if (idx < A.Count)
            {
                short num = (short)(A[idx] + b);
                A[idx] = (byte)(num % 256);
                rem = (byte)((num - (short)A[idx]) % 255);
                if (rem > 0)
                {
                    result = ClassNames._add_(A, rem, idx + 1, 0);
                    return result;
                }
            }
            else
            {
                A.Add(b);
            }
            result = A;
            return result;
        }
        public static void SetClass(uint offset, string input)
        {
            Functions.SetMem(offset, new byte[16]);
            byte[] b = new byte[] { 4 };
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            Functions.SetMem(offset, bytes.Multiply(b));
        }
    }
}