using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PdfObjectStreamDictionary:PdfDictionary
    {
 
        public PdfObjectStreamDictionary():base("ObjStm")
        { 
        }
        public PdfStream Extends { get; set; }
        public int ObjectCount { get; set; }
        public int ByteOffset { get; set; }
    }
}
