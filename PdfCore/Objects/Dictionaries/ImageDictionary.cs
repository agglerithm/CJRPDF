using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class ImageDictionary:PdfDictionary {
        public ImageDictionary():base("XObject", "Image") { }
        public int Width { get; set; }
        public int Height { get; set; }
        //name or array 
        public PdfObject ColorSpace { get; set; }
        public int BitsPerComponent { get; set; }
        public string Intent { get; set; }
        public bool ImageMask { get; set; }
        //stream or array 
        public PdfObject Mask { get; set; }

        public PdfArray Decode
        {
            get; set; 
        }
        public bool Interpolate { get; set; }
        public PdfArray Alternates { get; set; }
        public PdfStreamDictionary SMask { get; set; }
        public int SMaskInData { get; set; }
        public string Name { get; set; }
        public int StructParent { get; set; }
        public byte[] ID { get; set; }
        public PdfDictionary OPI { get; set; }
        public PdfStreamDictionary Metadata { get; set; }
        public PdfDictionary OptionalContent { get; set; }
    }
}