using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PdfObjectStreamDictionary: PdfStreamDictionary
    { 
        public PdfObjectStreamDictionary():base("ObjStm")
        { 
        }
        public PdfObjectStreamDictionary Extends { get; set; }
        [ObjectLabel("N")]
        public int ObjectCount { get; set; }
        [ObjectLabel("First")]
        public int ByteOffset { get; set; }

        public void Add(IIndirectObject obj)
        {
            if (obj.ReferencedType is PdfStreamDictionary ||
                obj.ReferencedType is EncryptionDictionary ||
                (obj.GenerationNumber != 0))
                throw new PdfInvalidAssignmentException(obj.ReferencedType); 
        }

        public override byte[] Print()
        {
            Add("Extends",Extends);
            Add("N", new PdfInteger(ObjectCount));
            Add("First", new PdfInteger(ByteOffset));
            return base.Print();
        }
    }
}