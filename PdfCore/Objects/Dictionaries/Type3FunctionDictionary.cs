namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class Type3FunctionDictionary : FunctionDictionary
    {
        public PdfArray Functions { get; set; }
        public PdfArray Bounds { get; set; }
        public PdfArray Encodes { get; set; }
    }
}