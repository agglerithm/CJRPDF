using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore.Utilities
{
    public class PdfFileReader
    {
        public PdfFile Load(string fileName)
        {
            using (var strm = File.OpenRead(fileName))
            {
                return Load(strm);
            }
        }

        private PdfFile Load(FileStream strm)
        {
            return new PdfFile(strm);
        }
    }
}
