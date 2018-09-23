 

namespace PocoToPdfReport
{
    public class PdfRowDefinition<T>:PdfReportComponent where T:class
    {  
        private readonly T _object;
        private readonly PdfReportTableLayout<T> _layout;

        public PdfRowDefinition(PdfReportTableLayout<T> layout, T data)
        {
            _layout = layout;
            _object = data;
        } 
        public override void Render(PdfPTable table)
        {
            int colCount = 0;
            int numCols = _layout.Columns.Count;
            foreach (var col in _layout.Columns.ColumnDefinitions)
            {
                colCount++;
                var cell = GetCell(col.GetValue(_object), table.Rows.Count % 2 == 1);
                if (colCount == numCols)
                    cell.BorderWidthRight = cell.BorderWidth;
                table.AddCell(cell);

            }
        }
 

        private PdfPCell GetCell(string val, bool odd)
        {
            var phrase = new Phrase(val) ;
            var cell = new PdfPCell(_layout.CellLayout.PhraseLayout.Apply(phrase));
            _layout.CellLayout.Apply(cell);
            if (odd)
                cell.BackgroundColor = _layout.OddRowsBackgroundColor;
            return cell;
        }
    }
}