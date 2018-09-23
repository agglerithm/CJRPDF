
namespace PocoToPdfReport
{ 
    public class PdfReportCellLayout:PdfReportLayout<PdfPCell>
    { 
        public PdfReportCellLayout()
        {
            HorizontalAllignment = Element.ALIGN_CENTER;
            FixedHeight = 6;
            VerticalAllignment = Element.ALIGN_CENTER;
            BackgroundColor = BaseColor.WHITE;
            Padding = 2;
            Border = 1;
            BorderWidth = 1;
            MinimumHeight = 6;
            PhraseLayout = new PdfReportPhraseLayout();
        }

        public PdfReportPhraseLayout PhraseLayout { get;  }

        public float BorderWidth { get; set; }

        public override PdfPCell Apply(PdfPCell cell)
        { 
            cell.BackgroundColor = BackgroundColor;
            cell.VerticalAlignment = VerticalAllignment;
            cell.FixedHeight = FixedHeight;
            cell.HorizontalAlignment = HorizontalAllignment; 
            cell.Padding = Padding;
            cell.BorderWidth = BorderWidth;
            cell.BorderWidthLeft = BorderWidth;
            cell.BorderWidthRight = 0;
            cell.MinimumHeight = MinimumHeight;
            return cell;
        }

        public float MinimumHeight { get; set; }

        public float Padding { get; set; }

        public BaseColor BackgroundColor { get; set; }

        public int HorizontalAllignment { get; set; }
        public int VerticalAllignment{ get; set; }
        public float FixedHeight { get; set; }
        public int Border { get; set; } 
        public float BorderWidthRight { get; set; }
        public float BorderWidthLeft { get; set; }
    }

    public class Element
    {
        public static int ALIGN_CENTER { get; private set; }
    }

    public class PdfPCell
    {
        public PdfPCell(Phrase phrase)
        {
            throw new System.NotImplementedException();
        }

        public BaseColor BackgroundColor { get; set; }
        public int VerticalAlignment { get; set; }
        public float MinimumHeight { get; set; }
        public float BorderWidthRight { get; set; }
        public float FixedHeight { get; set; }
        public int HorizontalAlignment { get; set; }
        public float Padding { get; set; }
        public float BorderWidth { get; set; }
        public float BorderWidthLeft { get; set; }
        public Phrase Phrase { get; set; }
        public object Role { get; set; }
    }

    public class Phrase
    {
        public Phrase(string text)
        {
            throw new System.NotImplementedException();
        }

        public Phrase()
        {
            throw new System.NotImplementedException();
        }

        public Font Font { get; set; }

        public void SetLeading(float fixedLeading, float multipliedLeading)
        {
            throw new System.NotImplementedException();
        }
    }
}