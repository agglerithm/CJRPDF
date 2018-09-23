

using System.Collections.Generic;

namespace PocoToPdfReport
{
    public class PdfReportParagraphLayout : PdfReportLayout<Paragraph>, IPdfReportFont
    {
        public override Paragraph Apply(Paragraph pg)
        {
            var font = new Font(FontType, FontSize, (int)FontStyle, FontColor);
            var cnk = new Chunk(pg.Content, font);
            cnk.SetBackground(BackgroundColor);
            pg.Chunks.Add(cnk);
            return pg;
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

    public class Paragraph
    {
        public object Content { get; set; }
        public List<Chunk> Chunks { get; set; }
    }
}