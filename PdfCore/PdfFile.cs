
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore
{
    public class PdfFile
    {
        public PdfFile()
        {
            FileStructure = new PdfFileStructure();
            DocumentStructure = new PdfDocumentStructure();
        }
        public PdfFileStructure FileStructure { get; private set; }
        public PdfDocumentStructure DocumentStructure { get; private set; }
    }
}
