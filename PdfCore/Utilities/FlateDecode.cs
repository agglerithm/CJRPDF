using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore.Utilities
{
    static class FlateDecode
    {
        public static byte[] DeflateString(string str)
        {
            return DeflateString(ASCIIEncoding.ASCII.GetBytes(str));
        }

        public static byte[] DeflateString(byte[] buffer)
        {
            byte[] compressed = null;
            var strm = new MemoryStream();
            using (var deflate = new DeflateStream(strm, CompressionMode.Compress))
            {
                deflate.Write(buffer,0,buffer.Length);
            }
            return strm.ToArray();
        }
    }
}
