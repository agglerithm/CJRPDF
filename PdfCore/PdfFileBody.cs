using System.Collections.Generic;
using CJRPDF.PdfCore.Objects;
using PdfCore.Objects;

namespace PdfCore
{
    public class PdfFileBody
    {
        private List<IIndirectObject> _objects = new List<IIndirectObject>();

        public IEnumerable<IIndirectObject> Objects
        {
            get { return _objects; } 
        }
        
        public void Add<T>(T obj, int id, int genNum) where T:PdfObject
        {
           _objects.Add(new IndirectObject<T>(obj, id, genNum)); 
        }
    }
}