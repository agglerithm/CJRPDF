using System.Text;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfStringObject : PdfObject
    {
        public override byte[] Print()
        {
            if (!IsHex) return BufferFromString($"({(string) Value})"); 
            _writer.Write(Delimiters.LessThan);
            var val = (byte[]) Value;
            foreach (var b in val)
            {
                _writer.Write(b.ToString("X"));
            }

            _writer.Write(Delimiters.GreaterThan);
            return FinishBuffer(); 
        }

        public bool IsHex { get; set; }
    }
}