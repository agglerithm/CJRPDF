using System.Collections.Generic; 

namespace PocoToPdfReport
{
    public class PdfRowCollection<T> where T : class
    {
        private readonly List<PdfRowDefinition<T>> _rowDefs; 
        private readonly PdfReportTableLayout<T> _layout;

        public PdfRowCollection(PdfReportTableLayout<T> layout)
        { 
            _rowDefs = new List<PdfRowDefinition<T>>();
            _layout = layout;
        }
  
        public void AddRow(T data)
        {
            _rowDefs.Add(new PdfRowDefinition<T>(_layout, data));
        }

        public void RenderAll(PdfPTable table)
        {
            _layout.Apply(table);
            foreach (var row in _rowDefs)
                row.Render(table);
        }
    }
}