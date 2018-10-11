using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfCore.Objects;

namespace CJRPDF.PdfCore
{
    public static class PdfObjectExtensions
    {
        public static byte[] PrintAll<T>(this IEnumerable<T> lst) where T : PdfPrintable
        {
            var memStr = new MemoryStream();
            var writer = new BinaryWriter(memStr);
            foreach (var obj in lst)
            {
                writer.Write(obj.Print());
            }
            writer.Flush();
            return memStr.ToArray();
        }
    }
}
