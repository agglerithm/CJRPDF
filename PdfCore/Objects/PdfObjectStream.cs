using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfObjectStream:PdfPrintable
    {
        private readonly List<IndirectObjectReference> _list = new List<IndirectObjectReference>();
        public override string Print()
        {
            return _list.PrintAll();
        }

        public void Add(IndirectObjectReference @ref)
        {
            _list.Add(@ref);
        }
    }
}
