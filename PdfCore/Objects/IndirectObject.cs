using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class IndirectObject<T>:IIndirectObject where T: PdfObject
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
        internal string Print()
        {
            return $"{IndirectObjectNumber} {GenerationNumber} obj \r\n {Object.Print()} \r\n endobj";
        }
    }
}