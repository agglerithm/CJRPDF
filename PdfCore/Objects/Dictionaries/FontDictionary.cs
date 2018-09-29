using System.Security.Cryptography.X509Certificates;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class FontDictionary :PdfDictionary{
        protected FontDictionary(string subtype):base("Font", subtype)
        { 
            Encoding = new EncodingDictionary();
        }
        public EncodingDictionary Encoding { get; set; }
        public PdfStream ToUnicode { get; set; }
    }
}