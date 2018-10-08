using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CJRPDF.PdfCore
{
    public class PdfUnion : PdfPrintable
    {
        public PdfUnion()
        {
            Numbers = new List<int>();
        }
        public List<int> Numbers { get; set; }
        public override string Print()
        {
            if (!Numbers.Any())
                return null;
            if (Numbers.Count == 1)
                return Numbers.First().ToString();
            var sb = new StringBuilder();
            sb.Append("[");
            foreach (var num in Numbers)
            {
                sb.Append($"{num} ");
            }
            sb.AppendLine("]");
            return sb.ToString();
        }
    }
}