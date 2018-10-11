using CJRPDF.PdfCore.Objects;

namespace PdfCore.Objects
{
    public class PdfInteger : PdfObject
    { 

        public PdfInteger(int num)
        {
            SetValue(num);
        }

        public override byte[] Print()
        {
            _writer.Write($"{(int)Value}");
            return FinishBuffer();
        }

        public void SetValue(int num)
        {
            Value = num;
        }
    }
}