using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore
{
    public abstract class PdfPrintable
    {
        internal long EndOffset { get; set; }
        internal abstract string Print();

        public byte[] GetBuffer(long offset)
        {
            var buff = Print().StringToBuff();
            EndOffset = offset + buff.Length;
            return buff;
        }
    }
}
