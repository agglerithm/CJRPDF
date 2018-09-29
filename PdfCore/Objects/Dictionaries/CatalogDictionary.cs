using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class CatalogDictionary : PdfDictionary
    {
        public CatalogDictionary() : base("Catalog") { }
        public string Version { get; set; }
        public PdfDictionary Extensions { get; set; }
        public IndirectObject<PageTreeNode> Pages { get; set; }
        public object PageLabels { get; set; }
        public PdfDictionary Names  { get; set; }
        public PdfDictionary Dests { get; set; }
        public PdfDictionary ViewerPreferences { get; set; }
        public string PageLayout { get; set; }
        public string PageMode { get; set; }
        public PdfDictionary AdditionalActions { get; set; }
        public IndirectObject<PdfStream> Metadata { get; set; }
        public PdfDictionary StructTreeRoot { get; set; }
        public PdfArray OutputIntents { get; set; }

        public PdfDictionary PieceInfo
        {
            get; set; 

        }
        public string Lang { get; set; }
    }
}