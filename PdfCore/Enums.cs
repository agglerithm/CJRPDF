namespace CJRPDF.PdfCore
{
    public enum WhiteSpace { Null = 0, HorizontalTab = 9, LineFeed = 10, FormFeed = 12, CarriageReturn = 13, Space = 32 }

    public enum SpecialChars
    {
        Bang = 33, Quote = 34, Number = 35, Dollar=36, Percent=37, Ampersand=38, SingleQuote=39, LeftParen = 40, RightParen = 41, Star = 42, Plus=43, Dash=45, Dot = 46, Slash = 47, Colon = 58, SemiColon = 59,
        LessThan = 60, Equals = 61, GreaterThan = 62, Question = 63, At = 64, LeftSquare = 91, Backslash = 92, RightSquare = 93, Caret = 94, Underscore = 95, LeftCurly = 123, Pipe = 124, RightCurly = 125, Tilde = 126, Delete = 127
    }

    public enum DecodeFilter { ASCIIHexDecode, ASCII85Decode, LZWDecode, FlateDecode, RunLengthDecode, CCITTFaxDecode, JBIG2Decode, DCTDecode, JPXDecode, Crypt}

    public enum TextRenderingMode { FillText, StrokeText, FillThenStroke, Invisible, FillThenAddToPath, StrokeThenAddToPath, FillStrokeAdd, AddToPath}
    public enum FontFlags { FixedPitch = 1, Serif = 2, Symbolic = 4, Script = 8, Nonsymbolic = 32, Italic = 64, AllCap = 65536, SmallCap = 131072, ForceBold = 262144}
    public enum FunctionType { Sampled, ExponentialInterpolation = 2, Stitching, PostscriptCalc}
    public enum LineCapStyle { Butt, Round, ProjectingSquare}
    public enum LineJointStyle { Miter, Round, Bevel }
    public enum MatrixTypes { Translations, Scaling, Rotations, Skew }
    public enum ColorSpace { Pattern, Separation, DeviceRGB, CalRGB, DeviceCmyk, DeviceGray, Indexed, Lab}
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

    public class Operators
    {
        public class TextObject
        {
            public const string BeginText = "BT";
            public const string EndText = "ET";
        }

        public class TextState
        {
            public const string SetCharSpacing = "Tc";
            public const string SetWordSpacing = "Tw";
            public const string SetHorizontalScaling = "Tz";
            public const string SetTextLeading = "TL";
            public const string SpecifyFontName = "Tf";
            public const string TextRenderingMode = "Tr";
            public const string SetTextRise = "Ts";
        }

        public class TextPositioning
        { 
            public const string AdjustTranslationComponents = "Td";
            public const string AdjustTranslationComponentsWithSideEffect = "TD";
            public const string SetTextAndTextLineMatrices = "Tm";
            public const string MoveToStartOfNextLine = "T*"; 
        }

        public class TextShowing
        {

            public const string PrintTextString = "Tj";
            public const string PaintGlyphs = "TJ";
            public const string MoveToNextLineAndPrintString = "'";
            public const string MoveToNextLineAndPrintStringWithSpacing = "\"";
        }

        public class Type3Fonts
        {
            public const string SetGlyphWidth = "d0";
            public const string SetGlyphWidthAndBoundingBox = "d1";
        }

        public class Color
        {

            public const string SetColorSpace = "CS";
            public const string SetColorSpaceNonStroking = "cs";
            public const string SetColor = "SC";
            public const string SetColorAndSpecifyOtherSpaces = "SCN";
            public const string SetColorNonStroking = "sc";
            public const string SetColorAndSpecifyOtherSpacesNonStroking = "scn";
            public const string SetStrokingColorDeviceGray = "G";
            public const string SetStrokingColorDeviceGrayNonStroking = "g";
            public const string SetStrokingColorRGB = "RG";
            public const string SetStrokingColorRGBNonStroking = "rg";
            public const string SetStrokingColorCMYK = "K";
            public const string SetStrokingColorCMYKNonStroking = "k";
        }

        public const string ShadingPattern = "sh";

        public class InlineImage
        {

            public const string BeginInlineImage = "BI";
            public const string BeginInlineImageData = "ID";
            public const string EndImage = "EI";
        }

        public const string XObjects = "Do";

        public class MarkedContent
        {
            public const string MarkedContentPoint = "MP";
            public const string OptionalMarkedContentPoint = "DP";
            public const string BeginMarkedContent = "BMC";
            public const string BeginStreamContentSection = "BDC";
            public const string EndMarkedContent = "EMC";
        }

        public class Compatibility
        {
            public const string EndCompatibilitySection = "EX";
            public const string BeginCompatibilitySection = "BX";
        }
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