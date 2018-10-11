using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfDateObject:PdfObject
    {
        public override byte[] Print()
        {
            return BufferFromString($"(D:{GetDate()}+00'00'"); 
        }

        private string GetDate()
        {
            return ((DateTime)Value).ToString("yyyyMMddhhmmss");
        }
    }
}
