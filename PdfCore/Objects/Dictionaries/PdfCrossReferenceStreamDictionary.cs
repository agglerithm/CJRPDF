namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PdfCrossReferenceStreamDictionary:PdfDictionary
    {
        public PdfCrossReferenceStreamDictionary():base("XRef")
        { 
        }

        public int Size { get; set; }
        public PdfArray Index { get; set; }
        [ObjectLabel("W")]
        public PdfArray FieldLengths { get; set; }
    }
}
