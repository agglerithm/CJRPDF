
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CJRPDF.PdfCore.Objects;

namespace CJRPDF.PdfCore
{
    public class PdfFile: PdfObject, IPdfReadable
    {
        public PdfFile()
        {
            FileStructure = new PdfFileStructure();
            DocumentStructure = new PdfDocumentStructure();
            ObjectType = PdfObjectType.File;
        }

        public PdfFile(FileStream strm)
        {
            throw new NotImplementedException();
        }

        public PdfFileStructure FileStructure { get; private set; }
        public PdfDocumentStructure DocumentStructure { get; private set; }
        public override byte[] Print()
        {
            return FileStructure.Print();
        }

        public PdfFile Read(Stream strm)
        {
            throw new NotImplementedException();
        }
    }
}
