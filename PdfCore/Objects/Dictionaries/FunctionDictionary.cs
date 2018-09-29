using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class FunctionDictionary : PdfDictionary
    {
        public PdfNameObject FunctionType { get; set; }
        public PdfArray Domain { get; set; }
        public PdfArray Range { get; set; }
    }
}