using System.Collections.Generic;
using System.Text;
using CJRPDF.PdfCore.Objects;
using PdfCore.Objects;

namespace CJRPDF.PdfCore
{
    public class PdfFileBody:PdfPrintable
    {
        private readonly List<IIndirectObject> _objects = new List<IIndirectObject>();

        public IEnumerable<IIndirectObject> Objects
        {
            get { return _objects; } 
        }
        
        public void Add<T>(T obj, int id, int genNum) where T:PdfObject
        {
           _objects.Add(new IndirectObject<T>(obj, id, genNum)); 
        }

        public override byte[] Print()
        { 
            foreach (var obj in _objects)
            {
                _writer.Write(obj.Print());
            }
            return FinishBuffer();
        }
    }
}