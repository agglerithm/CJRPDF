namespace PdfCore
{
    public enum WhiteSpace { Null = 0, HorizontalTab = 9, LineFeed = 10, FormFeed = 12, CarriageReturn = 13, Space = 32 }

    public enum SpecialChars
    {
        Bang = 33, Quote = 34, Number = 35, Dollar=36, Percent=37, Ampersand=38, SingleQuote=39, LeftParen = 40, RightParen = 41, Star = 42, Plus=43, Dash=45, Dot = 46, Slash = 47, Colon = 58, SemiColon = 59,
        LessThan = 60, Equals = 61, GreaterThan = 62, Question = 63, At = 64, LeftSquare = 91, Backslash = 92, RightSquare = 93, Caret = 94, Underscore = 95, LeftCurly = 123, Pipe = 124, RightCurly = 125, Tilde = 126, Delete = 127
    }

    public enum DecodeFilter { ASCIIHexDecode, ASCII85Decode, LZWDecode, FlateDecode, RunLengthDecode, CCITTFaxDecode, JBIG2Decode, DCTDecode, JPXDecode, Crypt}
    public static class Delimiters
    {
        public const string LeftParenthesis = "(";
        public const string RightParenthesis = ")";
        public const string LessThan = "<";
        public const string GreaterThan = ">";
        public const string LeftSquareBracket = "[";
        public const string RightSquareBracket = "]";
        public const string LeftCurlyBracket = "{";
        public const string RightCurlyBracket = "}";
        public const string Comment = "%";
    }

    public static class EscapeSequences
    {
        public const string LineFeed = "\\n";
        public const string CarriageReturn = "\\r";
        public const string HorizontalTab = "\\t";
        public const string Backspace = "\\b";
        public const string FormFeed = "\\f";
        public const string LeftParenthesis = "\\(";
        public const string RightParenthesis = "\\)";
        public const string ReverseSolidus = "\\";
    }

    public static class EncodingExtensions
    {
        public static string GetEncoding(this SpecialChars sc)
        {
            return $"#{(int) sc:x8}";
        }
        public static string GetEncoding(this WhiteSpace ws)
        {
            return $"#{(int)ws:x8}";
        }
    }
}