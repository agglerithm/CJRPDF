using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfCore;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PageTreeNode:PdfDictionary
    {
        public PageTreeNode():base("Pages")
        { 
        }

        public IndirectObject<PdfObject> Parent { get; set; }
        public PdfArray Kids { get; set; }
        public int Count { get; set; }
    }
}
