using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PdfFontDictionary:PdfDictionary
    {
        public override byte[] Print()
        {
            return base.Print();
        }

        public PdfFontDictionary(string subtype) : base("Font", subtype)
        {
        }
    }
}
