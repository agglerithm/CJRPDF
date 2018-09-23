using System.Collections.Generic;
using System.IO;
using System.Web; 
using PocoToPdfReport;

namespace PocoToPdfReport
{
    public class PdfReport
    {
        private readonly List<IPdfReportChild<IElement>> _children; 
        private readonly Document _doc;

        public PdfReport( )
        {
            _children = new List<IPdfReportChild<IElement>>();
            PageLayout = new PdfReportPageLayout();
            _doc = new Document();
        }

        public PdfReportPageLayout PageLayout { get; set; }
 
 
        public void AddChild<T>(IPdfReportChild<T> child) where T:class,IElement
        {
            _children.Add(child);
        }
        private void Render()
        { 
            PageLayout.Apply(_doc);
            _doc.Open();
            foreach (var child in _children)
            {
                var obj = child.Render();  
                _doc.Add(obj); 
            }
            _doc.Close(); 
        }

        public void WriteToStream(Stream outStrm)
        { 
            var writer = PdfWriter.GetInstance(_doc, outStrm);  
            Render();
            writer.Close();
        }
 
    }

    public class PdfWriter
    {
        public static PdfWriter GetInstance(Document doc, Stream outStrm)
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Document
    {
        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Open()
        {
            throw new System.NotImplementedException();
        }

        public void Add(IElement element)
        {
            throw new System.NotImplementedException();
        }

        public void SetPageSize(Rectangle pageSize)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IElement
    {
    }
}