namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PatternDictionary : PdfDictionary
    {
        public string PatternType { get; set; }

        public PatternDictionary() : base("Pattern", null)
        {
        }
    }
}