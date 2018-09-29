using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class Type0FontDictionary : FontDictionary
    {
        public Type0FontDictionary(string subtype) : base(subtype)
        {

        }
        public PdfObject BaseFont { get; set; }
        public PdfArray DescendantFonts { get; set; }
    }
}