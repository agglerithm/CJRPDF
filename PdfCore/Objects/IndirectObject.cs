using System;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class IndirectObject<T>:PdfObject, IIndirectObject where T: PdfObject
    {
        public IndirectObject(T pdfObject, int id, int genNum)
        {
            Object = pdfObject;
            IndirectObjectNumber = id;
            GenerationNumber = genNum;
        }

        public T Object { get; set; }

        public int IndirectObjectNumber { get; set; }
        public IndirectObjectReference ObjectReference { get; set; }
        public int GenerationNumber { get; set; }
        public Type ReferencedType { get { return typeof (T); } }

        public override byte[] Print()
        {
            _writer.Write($"{IndirectObjectNumber} {GenerationNumber} obj \r\n");
            _writer.Write(Object.Print());
            _writer.Write("\r\n endobj");
            return FinishBuffer();
        }
    }
}