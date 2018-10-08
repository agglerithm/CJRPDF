using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfNameObject:PdfObject
    { 

        public PdfNameObject(string name)
        {
            Value = name;
        }

        public override string Print()
        {
            return EscapeSequences.ReverseSolidus + ReplaceSpecialCharacters(Value);
        }

        public static string Print(string name)
        { 
            return EscapeSequences.ReverseSolidus + ReplaceSpecialCharacters(name);
        }
        private static object ReplaceSpecialCharacters(object value)
        {
            var val = (string)value;
            val = val.Replace("#", SpecialChars.Number.GetEncoding());
            val = val.Replace(" ", WhiteSpace.Space.GetEncoding()); 
            return val;
        }
    }
}