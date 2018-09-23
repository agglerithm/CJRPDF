using System;
using System.Collections.Generic;

namespace PocoToPdfReport
{
    public class PdfColumnCollection<T> where T:class
    {
        private readonly List<PdfColumnDefinition<T>> _columnDefs;

        public PdfColumnCollection()
        {
            _columnDefs = new List<PdfColumnDefinition<T>>();

        }
        public IEnumerable<PdfColumnDefinition<T>> ColumnDefinitions
        {
            get { return _columnDefs; }
        }

        public int Count { get
        {
            return _columnDefs.Count; 
        } }

        public void AddColumnDefinition(string columnName, Func<T, string> assignment, float width = 50)
        {
            _columnDefs.Add(new PdfColumnDefinition<T>(assignment,columnName, width));
        }
    }
}