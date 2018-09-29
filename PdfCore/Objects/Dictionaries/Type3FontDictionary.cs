namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class Type3FontDictionary : FontDictionary
    {
        protected Type3FontDictionary() : base("Type3")
        {
         
        }
        public string Name { get; set; }
        public PdfRectangle FontBBox { get; set; }
        public PdfRectangle FontMatrix { get; set; }
        public PdfDictionary CharProcs { get; set; }
        public string FirstChar { get; set; }
        public string LastChar { get; set; }
        public PdfArray Widths { get; set; }
        public FontDescriptorDictionary FontDescriptor { get; set; }
        public ResourceDictionary Resources { get; set; }
    }
}