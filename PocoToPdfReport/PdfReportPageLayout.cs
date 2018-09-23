

namespace PocoToPdfReport
{
    public class PdfReportPageLayout :PdfReportLayout<Document>
    {
        public PdfReportPageLayout()
        {
            PageSize = PageSize.A4; 
        }
        public override Document Apply(Document document)
        { 
            document.SetPageSize(PageSize);
            return document;
            //document.SetMargins(MarginLeft, MarginRight, MarginTop, MarginBottom); 
        }

        public float MarginBottom
        {
            get { return PageSize.Bottom;}  
        }

        public float MarginTop
        {
            get { return PageSize.Top; } 
        }

        public float MarginRight
        {
            get { return PageSize.Right; } 
        }

        public float MarginLeft
        {
            get {return PageSize.Left; } 
        }

        public Rectangle PageSize { get; set; }
    }

    public class Rectangle
    {
        public float Left { get; set; }
        public float Top { get; set; }
        public float Bottom { get; set; }
        public float Right { get; set; }
        public Rectangle A4 { get; set; }
    }
}