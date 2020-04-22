namespace CJRPDF.PdfCore.Objects
{   
    public enum PdfObjectType { Boolean, Integer, Real, String, Name, Array, Dictionary, Stream, File, Null }
    //Basic components of a PDF document
    public abstract class PdfObject:PdfPrintable
    {
        public PdfObjectType ObjectType { get; protected set; }
        public object Value { get; set; }
    }
}