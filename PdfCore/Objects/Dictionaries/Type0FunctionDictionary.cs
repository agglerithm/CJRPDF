using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class Type0FunctionDictionary : FunctionDictionary
    {
        public PdfInteger Size { get; set; }
        public PdfInteger BitsPerSample { get; set; }
        public PdfObject Order { get; set; }
        public PdfObject Encode { get; set; }
        public PdfObject Decode { get; set; }

    }
}