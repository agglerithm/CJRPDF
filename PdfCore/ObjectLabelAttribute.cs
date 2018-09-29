using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore
{
    public class ObjectLabelAttribute:Attribute
    {
        public ObjectLabelAttribute(string label)
        {
            Label = label;
        }

        public string Label { get;   }
    }
}
