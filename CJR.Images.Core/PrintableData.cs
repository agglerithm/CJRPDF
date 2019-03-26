using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImagesCore
{
    public abstract class PrintableData
    {
        protected readonly BinaryWriter _writer;
        protected readonly MemoryStream _memStr;

        public PrintableData()
        {
            _memStr = new MemoryStream();
            _writer = new BinaryWriter(_memStr);
        }
        public abstract byte[] Print();


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

    }
}
