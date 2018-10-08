using System.Collections.Generic;
using CJRPDF.PdfCore.Objects.Dictionaries;

namespace CJRPDF.PdfCore.Objects.Layout
{
    public class PdfTable : PdfTableRectangle
    {
        public PdfRectangle BBox { get; set; } 
        public PdfColumnCollection Columns { get; set; }
        public List<PdfTableRectangle> Cells { get; set; } 
    }
}