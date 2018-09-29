using System;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
 
    public class PdfStreamDictionary:PdfDictionary
    {
        public PdfStreamDictionary():base("Stream")
        { 
        }

        internal override string Print()
        { 
            if(Length == null)
                throw new Exception("Length reference cannot be null!");
            Add("Length", Length.ObjectReference);
            Add("Filter", Filter);
            Add("DecodeParms",DecodeParms); 
            Add("DL", new PdfInteger(DefilteredLength));
            return base.Print();  
        }
        public IndirectObject<PdfInteger> Length { get; set; }
        public PdfObject Filter { get; set; }
        public PdfObject  DecodeParms { get; set; } 
         

        [ObjectLabel("Dl")]
        public int DefilteredLength { get; set; }
    } 
}
