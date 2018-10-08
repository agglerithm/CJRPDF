using System;

namespace CJRPDF.PdfCore
{
    public class PdfColor : PdfPrintable
    {
        public decimal Red { get; set; }
        public decimal Blue { get; set; }
        public decimal Green { get; set; }
        public override string Print()
        {
            return $"[{Red} {Green} {Blue}]";
        }
    }
}