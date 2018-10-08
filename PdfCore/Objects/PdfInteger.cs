namespace PdfCore.Objects
{
    public class PdfInteger : PdfObject
    { 

        public PdfInteger(int num)
        {
            SetValue(num);
        }

        public override string Print()
        {
            return $"{(int)Value}";
        }

        public void SetValue(int num)
        {
            Value = num;
        }
    }
}