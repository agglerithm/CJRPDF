using ImagesCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore
{
    public abstract class PdfPrintable:PrintableData
    {
        internal long EndOffset { get; set; }
        protected readonly BinaryWriter _writer;
        protected readonly MemoryStream _memStr;

        public PdfPrintable()
        {
            _memStr = new MemoryStream();
            _writer = new BinaryWriter(_memStr);
        } 

        private byte[] GetBuffer(long offset)
        {
            var buff = Print();
            EndOffset = offset + buff.Length;
            return buff;
        }

        protected byte[] BufferFromString(string val)
        {
            _writer.Write(val);
            return FinishBuffer();
        }
        protected byte[] FinishBuffer()
        {
            _writer.Flush();
            return _memStr.ToArray();
        }
        public long AppendToStream(Stream strm, long offset)
        {
            var buff = GetBuffer(offset);
            strm.Write(buff, 0, buff.Length);
            return EndOffset;
        }
    }
}
