using System;
using System.Linq;
using System.Text;

namespace ImagesCore
{
    public static class ByteArrayExtensions
    {
        public static byte[] StringToBuff(this string text)
        {
            return Encoding.ASCII.GetBytes(text);
        }

        public static byte[] GetBytes(this UInt16 num)
        {
            return BitConverter.GetBytes(num);
        }

        public static byte[] GetBytes(this byte num)
        {
            return new byte[] {num};
        }
        public static byte[] Concatenate(this byte[] arr, params byte[][] arrs)
        {
            var len = arr.Length + arrs.Sum(a => a.Length);
            var retVal = new byte[len];
            var ndx = 0;
            arr.CopyTo(retVal,ndx);
            ndx += arr.Length;
            foreach (var a in arrs)
            {
                a.CopyTo(retVal, ndx);
                ndx += a.Length;
            } 
            return retVal;
        }
    }
}
