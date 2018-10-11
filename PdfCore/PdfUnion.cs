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
        public override byte[] Print()
        {
            if (!Numbers.Any())
                return null;
            if (Numbers.Count == 1)
                return BufferFromString(Numbers.First().ToString()); 
            _writer.Write("[");
            foreach (var num in Numbers)
            {
                _writer.Write($"{num} ");
            }
            _writer.Write("]");
            return FinishBuffer();
        }
    }
}