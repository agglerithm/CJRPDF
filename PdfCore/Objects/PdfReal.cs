using CJRPDF.PdfCore.Objects;

namespace PdfCore.Objects
{
    public class PdfReal : PdfObject
    {
        public PdfReal(float num)
        {
            SetValue(num);
        }
        public override byte[] Print()
        {
            _writer.Write($"{(float) Value}");
            return FinishBuffer();
        }
        public void SetValue(float num)
        {
            Value = num;
        }
    }
}