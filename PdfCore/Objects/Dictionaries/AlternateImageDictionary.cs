using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class AlternateImageDictionary : ImageDictionary
    {
        public PdfStream Image { get; set; }
        public bool DefaultForPrinting { get; set; }
        public PdfDictionary OptionalContent { get; set; }
    }
}