using System.Collections.Generic;
using System.Text;
using PdfCore;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfArray : PdfObject
    {
        public PdfArray()
        {
            Value = new List<PdfObject>();
            ObjectType = PdfObjectType.Array;
            
        }
        private List<PdfObject> list
        {
            get
            {
                return (List<PdfObject>)Value;
            }
        }
        public override byte[] Print()
        { 
            _writer.Write(Delimiters.LeftSquareBracket);
            foreach (var obj in list)
            {
                _writer.Write($"{obj.Print()} ");
            }

            _writer.Write(Delimiters.RightSquareBracket);
            return FinishBuffer();

        }
    }
}