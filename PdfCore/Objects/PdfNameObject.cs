using System.IO;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfNameObject:PdfObject
    { 

        public PdfNameObject(string name)
        {
            Value = name;
        }

        public override byte[] Print()
        {
            return BufferFromString(EscapeSequences.ReverseSolidus + ReplaceSpecialCharacters(Value));
        }

        public static byte[] Print(string name)
        {
            var memStr = new MemoryStream();
            var writer = new BinaryWriter(memStr);
            writer.Write(EscapeSequences.ReverseSolidus + ReplaceSpecialCharacters(name));
            writer.Flush();
            return memStr.ToArray();
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