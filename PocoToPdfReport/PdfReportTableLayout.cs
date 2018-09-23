using System;
using System.Linq; 

namespace PocoToPdfReport
{
    public class PdfReportTableLayout<T>:PdfReportLayout<PdfPTable> where T:class 
    {
        private readonly PdfReportPageLayout _pageLayout;

        public PdfReportTableLayout(PdfReportPageLayout layout)
        {
            Columns = new PdfColumnCollection<T>();
            _pageLayout = layout;
            CellLayout = new PdfReportCellLayout();
            HeaderLayout = new PdfReportCellLayout();
            WidthPercentage = 100;
            OddRowsBackgroundColor = BaseColor.WHITE;

        }
        public   PdfColumnCollection<T> Columns { get;  }
        public override PdfPTable Apply(PdfPTable table)
        { 
            if(Columns == null)
                throw new Exception("Column definitions have not been initialized!");
            table.WidthPercentage = WidthPercentage;
            table.SetWidthPercentage(GetAbsoluteWidths(),_pageLayout.PageSize);
            return table;

        }

        public float WidthPercentage { get; set; }

        public PdfReportCellLayout CellLayout { get; }
        public BaseColor OddRowsBackgroundColor { get; set; }
        public PdfReportCellLayout HeaderLayout { get; set; }
        public float BorderWidth
        {
            get { return CellLayout.BorderWidth; }
            set
            {
                HeaderLayout.BorderWidth = value;
                CellLayout.BorderWidth = value;
            }
        }
        public float FontSize
        {
            get { return CellLayout.PhraseLayout.FontSize; }
            set
            {
                HeaderLayout.PhraseLayout.FontSize = value;
                CellLayout.PhraseLayout.FontSize = value;
            }
        }

        private float[] GetAbsoluteWidths()
        {
            return Columns.ColumnDefinitions.Select(cd => cd.Width).ToArray();
        }
    }
}