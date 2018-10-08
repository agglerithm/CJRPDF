using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore
{
    public abstract class PdfPrintable
    {
        internal long EndOffset { get; set; }
        public abstract string Print();

        private byte[] GetBuffer(long offset)
        {
            var buff = Print().StringToBuff();
            EndOffset = offset + buff.Length;
            return buff;
        }

        public long AppendToStream(Stream strm, long offset)
        {
            var buff = GetBuffer(offset);
            strm.Write(buff, 0, buff.Length);
            return EndOffset;
        }
    }
}
