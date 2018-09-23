

namespace PocoToPdfReport
{
    public enum FontStyle { Normal = 0, Bold = 1, Italic = 2, Underline = 4, Strikethru = 8 }

    public class PdfReportPhraseLayout : PdfReportLayout<Phrase>, IPdfReportFont
    {
        public PdfReportPhraseLayout()
        { 
            FontType = Font.FontFamily.HELVETICA;
            FontSize = 12;
            FontColor = BaseColor.BLACK;
            FontStyle = FontStyle.Normal;
            FixedLeading = float.NaN;
        }

        public override Phrase Apply(Phrase phrase)
        { 
            phrase.Font = new Font(FontType, FontSize, (int)FontStyle, FontColor);
            phrase.SetLeading(FixedLeading, MultipliedLeading); 
            return phrase;
        }

        public float MultipliedLeading { get; set; }

        public float FixedLeading { get; set; }

        public Font.FontFamily FontType { get; set; }
        public float FontSize { get; set; }
        public FontStyle FontStyle { get; set; }
        public BaseColor FontColor { get; set; }
        public string FontName { get; set; }
        public string FontEncoding { get; set; }
        public bool Embedded { get; set; }
    }
}