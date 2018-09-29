using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class IndirectObjectReference:PdfObject
    {
        internal override string Print()
        { return $"{IndirectObjectNumber} {GenerationNumber} R";  
        }

        public int GenerationNumber { get; set; }

        public int IndirectObjectNumber { get; set; }
    }
}