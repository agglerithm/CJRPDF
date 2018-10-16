using System;
using CJRPDF.PdfCore.Utilities;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
 
    public class PdfStreamDictionary:PdfDictionary
    {
        public PdfStreamDictionary():base("Stream")
        { 
        }

        protected PdfStreamDictionary(string type) : base(type)
        {
            
        }

        public IndirectObject<PdfInteger> SetData(string data)
        {
            DefilteredLength = data.Length;
            Value = FlateDecode.DeflateString(data);
            Length = new IndirectObject<PdfInteger>(new PdfInteger(Buffer.Length), 0, 0);
            return Length;
        }

        private byte[] Buffer
        {
            get { return (byte[]) Value; }
        }
        public IndirectObject<PdfInteger> SetData(byte[] data)
        {
            DefilteredLength = data.Length;
            Value = data.DeflateString();
            Length = new IndirectObject<PdfInteger>(new PdfInteger(Buffer.Length), 0,0);
            return Length;
        }

        public override byte[] Print()
        { 
            if(Length == null)
                throw new Exception("Length reference cannot be null!");
            Add("Length", Length.ObjectReference);
            Add("Filter", Filter);
            Add("DecodeParms",DecodeParms); 
            Add("DL", new PdfInteger(DefilteredLength));
            return base.Print();  
        }
        public IndirectObject<PdfInteger> Length { get; set; }
        public PdfObject Filter { get; set; }
        public PdfObject  DecodeParms { get; set; } 
         

        [ObjectLabel("Dl")]
        public int DefilteredLength { get; set; }
    } 
}
