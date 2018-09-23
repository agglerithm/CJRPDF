using System.Drawing;


namespace PocoToPdfReport
{
    public class PdfReportHeaderFooter : IPdfReportChild<PdfPTable>, IPdfReportFont
    { 

        public PdfReportHeaderFooter()
        {
            BackgroundColor = BaseColor.WHITE;
            FontType = Font.FontFamily.TIMES_ROMAN;
            FontSize = 18;
            FontStyle = FontStyle.Normal;
            FontName = BaseFont.TIMES_ROMAN;
            FontEncoding = BaseFont.CP1252;
            Embedded = BaseFont.EMBEDDED;
            FontColor = BaseColor.BLACK;
        }
        public string Text { get; set; }
        public PdfPTable Render()
        {
            var baseFont = BaseFont.CreateFont(FontName, FontEncoding, Embedded);
            var font = new Font(baseFont,FontSize);
            font.SetColor(FontColor.R, FontColor.G, FontColor.B);
            font.SetStyle(FontStyle.ToString());
            font.SetFamily(FontType.ToString());

            var cell = new PdfPCell(new Phrase(Text))
            {
                BorderWidth = 0,
                VerticalAlignment = 1,
                HorizontalAlignment = 1
            };
            var tbl = new PdfPTable(1);
            tbl.DefaultCell.Phrase = new Phrase(){Font = font};
            tbl.AddCell(cell);
            tbl.WidthPercentage = 100; 
            return tbl;
        }

        public BaseColor BackgroundColor { get; set; }


        public Font.FontFamily FontType { get; set; }
        public float FontSize { get; set; }
        public FontStyle FontStyle { get; set; }
        public BaseColor FontColor { get; set; }
        public string FontName { get; set; }
        public string FontEncoding { get; set; }
        public bool Embedded { get; set; }
    }

    public class BaseFont
    {
        public static string TIMES_ROMAN;
        public static string CP1252;
        public static bool EMBEDDED;

        public static Font CreateFont(string fontName, string fontEncoding, bool embedded)
        {
            throw new System.NotImplementedException();
        }
    }
}