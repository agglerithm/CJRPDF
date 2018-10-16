using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class IndirectObjectReference:PdfObject
    {
        public override byte[] Print()
        {
            return BufferFromString($"{IndirectObjectNumber} {GenerationNumber} R\r\n");  
        }

        public int GenerationNumber { get; set; }

        public int IndirectObjectNumber { get; set; }
    }
}