using System;

namespace PocoToPdfReport
{
    public class PdfColumnDefinition<T> where T:class 
    {
        private readonly Func<T,string> _assignment;

        public PdfColumnDefinition(Func<T, string> assignment, string colName, float width)
        {
            _assignment = assignment;
            ColumnName = colName;
            Width = width;
        }

        public string ColumnName { get; }
        public float Width { get; set; }

        public string GetValue(T obj)
        {
            return _assignment(obj);
        }

    }
}