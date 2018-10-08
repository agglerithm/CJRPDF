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
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(Delimiters.LeftSquareBracket);
            foreach (var obj in list)
            {
                sb.Append($"{obj.Print()} ");
            }

            sb.Append(Delimiters.RightSquareBracket);
            return sb.ToString();

        }
    }
}