using System;
using System.Collections;
using System.Data; 

namespace PocoToPdfReport
{
    public class PdfReportTable<T> : PdfReportComponent, IPdfReportTable where T:class
    {
        public PdfReportTable(PdfReportPageLayout pageLayout)
        {
            Layout = new PdfReportTableLayout<T>(pageLayout);
            Rows= new PdfRowCollection<T>(Layout);
        }
        public PdfReportTableLayout<T> Layout { get; set; } 
        public PdfRowCollection<T> Rows { get; set; }
        public void AddDataCollection(IEnumerable  collection)
        { 
            foreach (var obj in collection)
            {
                if(obj.GetType() != typeof(T))
                    throw new StrongTypingException("Type of collection does not match type of table!");
                Rows.AddRow((T)obj);
            }
        }


        public PdfPTable Render()
        {
            var tbl = new PdfPTable(Layout.Columns.Count);
            Render(tbl);
            return tbl;
        }

        private void AddHeader(PdfPTable tbl)
        {
            int colCount = 0;
            int numCols = Layout.Columns.Count; 
            tbl.HeaderRows = 1; 
            foreach (var col in Layout.Columns.ColumnDefinitions)
            {
                var phrase = new Phrase(col.ColumnName);
                var cell = new PdfPCell(Layout.HeaderLayout.PhraseLayout.Apply(phrase)) {Role = PdfName.HEADERS};
                Layout.HeaderLayout.Apply(cell);
                if (colCount == numCols)
                    cell.BorderWidthRight = cell.BorderWidth;
                tbl.AddCell(cell);
            }
        }

        public Type CollectionType
        {
            get { return typeof(T); }
        }

        public override void Render(PdfPTable table)
        {
            AddHeader(table);
            Rows.RenderAll(table);
        }
    }

    internal class PdfName
    {
        public static object HEADERS;
    }
}