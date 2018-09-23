using System;
using System.Collections;
using System.Collections.Generic; 
using PocoToPdfReport;

namespace PocoToPdfReport
{
    public interface IPdfReportTable :IPdfReportChild<PdfPTable>
    {
        void AddDataCollection(IEnumerable  collection);
        Type CollectionType { get; } 
    }

    public class PdfPTable
    {
        public PdfPTable(int i)
        {
            throw new NotImplementedException();
        }

        public PdfPCell DefaultCell { get; set; }
        public float WidthPercentage { get; set; }
        public int HeaderRows { get; set; }
        public List<object> Rows { get; set; }

        public void AddCell(PdfPCell cell)
        {
            throw new NotImplementedException();
        }

        public void SetWidthPercentage(float[] getAbsoluteWidths, Rectangle pageSize)
        {
            throw new NotImplementedException();
        }
    }
}