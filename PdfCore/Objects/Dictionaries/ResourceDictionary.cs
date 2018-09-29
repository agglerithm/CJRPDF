namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class ResourceDictionary : PdfDictionary
    {
        public PdfDictionary ExtGState { get; set; }
        public ColorSpaceDictionary ColorSpace { get; set; }
        public PatternDictionary Pattern { get; set; }
        public PdfDictionary Shading { get; set; }
        public PdfDictionary XObject { get; set; }
        public PdfDictionary Font { get; set; }
        public PdfArray ProcSet { get; set; }
        public PdfDictionary Properties { get; set; }
    }
}