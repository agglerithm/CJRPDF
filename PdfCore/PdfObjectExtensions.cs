using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfCore.Objects;

namespace CJRPDF.PdfCore
{
    public static class PdfObjectExtensions
    {
        public static string PrintAll<T>(this IEnumerable<T> lst) where T : PdfPrintable
        {
            var sb = new StringBuilder();
            foreach (var obj in lst)
            {
                sb.Append(obj.Print());
            }
            return sb.ToString();
        }
    }
}
