
namespace PocoToPdfReport
{
    public interface IPdfReportFont
    {
        Font.FontFamily FontType { get; set; }
        float FontSize { get; set; }
        FontStyle FontStyle { get; set; }
        BaseColor FontColor { get; set; }
        string FontName { get; set; }
        string FontEncoding { get; set; }
        bool Embedded { get; set; }
    }

    public class BaseColor
    {
        public static BaseColor BLACK;
        public static BaseColor WHITE { get; private set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }

    public class Font
    {
        public Font(Font baseFont, float fontSize)
        {
            throw new System.NotImplementedException();
        }

        public Font(FontFamily fontType, float fontSize, int fontStyle, BaseColor fontColor)
        {
            throw new System.NotImplementedException();
        }

        public class FontFamily
        {
            public static FontFamily TIMES_ROMAN;
            public static FontFamily HELVETICA;
        }

        public void SetColor(int o, int o1, int o2)
        {
            throw new System.NotImplementedException();
        }

        public void SetStyle(string toString)
        {
            throw new System.NotImplementedException();
        }

        public void SetFamily(string toString)
        {
            throw new System.NotImplementedException();
        }
    }
}