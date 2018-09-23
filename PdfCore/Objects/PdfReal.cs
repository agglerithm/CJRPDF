namespace PdfCore.Objects
{
    public class PdfReal : PdfObject
    {
        public PdfReal(float num)
        {
            SetValue(num);
        }
        internal override string Print()
        {
            return $"{(float) Value}";
        }
        public void SetValue(float num)
        {
            Value = num;
        }
    }
}