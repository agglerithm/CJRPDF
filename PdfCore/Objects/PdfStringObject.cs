using System.Text;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfStringObject : PdfObject
    {
        public override string Print()
        {
            if (!IsHex) return $"({(string) Value})";
            var sb = new StringBuilder();
            sb.Append(Delimiters.LessThan);
            var val = (byte[]) Value;
            foreach (var b in val)
            {
                sb.Append(b.ToString("X"));
            }

            sb.Append(Delimiters.GreaterThan);
            return sb.ToString(); 
        }

        public bool IsHex { get; set; }
    }
}