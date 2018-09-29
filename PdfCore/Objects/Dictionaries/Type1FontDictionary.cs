namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class Type1FontDictionary : FontDictionary
    {
        public Type1FontDictionary(string subtype) : base(subtype)
        {
            
        }
        public string Name { get; set; }
        public object BaseFont { get; set; }
        public string FirstChar { get; set; }
        public string LastChar { get; set; }
        public PdfArray Widths { get; set; }
        public FontDescriptorDictionary FontDescriptor { get; set; }

    }
}