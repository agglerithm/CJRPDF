using System.Text;
using PdfCore;

namespace CJRPDF.PdfCore
{
    //Determines how objects are stored, accessed, and updated in a PDF file
    public class PdfFileStructure:PdfPrintable
    {
        public PdfFileStructure()
        {
            Header = "%PDF-1.7";
        }
        public string Header { get; set; }
        public PdfFileBody Body { get; set; }
        public PdfCrossReferenceTable CrossReferenceTable { get; set; }
        public PdfFileTrailer Trailer { get; set; }
        public override byte[] Print()
        {
            _writer.Write(Header);
            _writer.Write(Body.Print());
            _writer.Write(Trailer.Print());
            _writer.Write(CrossReferenceTable.Print());
            _writer.Write("%EOF");

            return FinishBuffer();
        }
    }
}