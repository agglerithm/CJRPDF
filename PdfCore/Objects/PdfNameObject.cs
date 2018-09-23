namespace PdfCore.Objects
{
    public class PdfNameObject:PdfObject
    { 

        public PdfNameObject(string name)
        {
            Value = name;
        }

        internal override string Print()
        {
            return EscapeSequences.ReverseSolidus + ReplaceSpecialCharacters(Value);
        }

        private object ReplaceSpecialCharacters(object value)
        {
            var val = (string)value;
            val = val.Replace("#", SpecialChars.Number.GetEncoding());
            val = val.Replace(" ", WhiteSpace.Space.GetEncoding()); 
            return val;
        }
    }
}