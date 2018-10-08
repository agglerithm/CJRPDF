using System.Collections.Generic;

namespace CJRPDF.PdfCore.Objects.Layout
{
    public class PdfColumnCollection
    {
        public PdfColumnCollection()
        {
            ColumnWidths = new List<int>();
        }
        public int ColumnCount { get; set; }
        public List<int> ColumnWidths { get; set; }
        public int ColumnGap { get; set; }
    }
}