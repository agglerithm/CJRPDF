using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfTrailerDictionary : PdfDictionary
    {
        public PdfTrailerDictionary()
        {
            Type = new PdfNameObject("Trailer");
        }
        public int Size { get; set; }
        public int? Prev { get; set; }
        public PdfDictionary Root { get; set; }
        public PdfDictionary Encrypt { get; set; }
        public PdfDictionary Info { get; set; }
        public PdfArray Id { get; set; }
        internal override string Print()
        {
            Add("Size", new PdfInteger(Size));
            if(Prev.HasValue)
                Add("Prev", new PdfInteger(Prev.Value));
            Add("Root", Root);
            Add("Encrypt", Encrypt);
            Add("Info", Info);
            Add("ID", Id);
            return base.Print();
        }
    }
}