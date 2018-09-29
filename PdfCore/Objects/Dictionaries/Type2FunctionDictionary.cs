using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class Type2FunctionDictionary : FunctionDictionary
    {
        public PdfArray C0 { get; set; }
        public PdfArray C1 { get; set; }
        public PdfObject N { get; set; }
    }
}