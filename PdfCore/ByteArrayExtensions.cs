using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore
{
    public static class ByteArrayExtensions
    {
        public static byte[] StringToBuff(this string text)
        {
            return Encoding.ASCII.GetBytes(text);
        }
    }
}
