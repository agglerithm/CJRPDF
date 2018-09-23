using CJRPDF.PdfCore;

namespace PdfCore.Objects
{   
    public enum PdfObjectType { Boolean, Integer, Real, String, Name, Array, Dictionary, Stream, Null }
    //Basic components of a PDF document
    public abstract class PdfObject:PdfPrintable
    {
        public PdfObjectType ObjectType { get; protected set; }
        public object Value { get; set; }
    }
}