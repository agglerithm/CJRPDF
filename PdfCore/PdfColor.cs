using System;
using System.IO;

namespace CJRPDF.PdfCore
{

    public class PdfColor : PdfPrintable
    {
        public decimal Red { get; set; }
        public decimal Blue { get; set; }
        public decimal Green { get; set; }
        public override byte[] Print()
        { 
            _writer.Write($"[{Red} {Green} {Blue}]");
            return FinishBuffer();
        }
    }
}