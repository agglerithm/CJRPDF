using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PageTreeNode:PdfDictionary
    {
        public PageTreeNode():base("Pages")
        { 
        }

        public IndirectObject<PdfObject> Parent { get; set; }
        public PdfArray Kids { get; set; }
        public int Count { get; set; }
    }
}
