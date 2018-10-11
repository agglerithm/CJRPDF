using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore.Objects.Layout
{
    public class StructureElement:PdfPrintable
    {
        public string Placement { get; set; }
        public string WritingMode { get; set; }
        public PdfColor BackgroundColor { get; set; }
        public PdfColor BorderColor { get; set; }
        public string BorderStyle { get; set; }
        public string BorderThickness { get; set; }
        public PdfColor Color { get; set; }
        public string Padding { get; set; }
        public string SpaceBefore { get; set; }
        public string SpaceAfter { get; set; }
        public string StartIndent { get; set; }
        public string EndIndent { get; set; }
        public override byte[] Print()
        {
            throw new NotImplementedException();
        }
    }

    public class TextElement : StructureElement
    {
        public string TextIndent { get; set; }
        public string TextAlign { get; set; }
    }

    public class PdfTableElement : TextElement
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }

    public class PdfTableRectangle : PdfTableElement
    { 
        public string BlockAlign { get; set; }
        public string InlineAlign { get; set; }
        public string TBorderStyle { get; set; }
        public string TPadding { get; set; }
    }
}
