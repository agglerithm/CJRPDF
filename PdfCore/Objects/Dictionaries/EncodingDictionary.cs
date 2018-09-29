namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class EncodingDictionary : PdfDictionary
    {
        public EncodingDictionary():base("Encoding")
        { 
        }
        public int BaseEncoding { get; set; }
        public PdfArray Differences { get; set; }
    }
}