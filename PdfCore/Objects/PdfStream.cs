using System.Text;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfStream : PdfObject
    {
        private PdfDictionary _dictionary;

        public PdfStream()
        {
            _dictionary = new PdfDictionary();
        }

        internal override string Print()
        {
            var sb = new StringBuilder();
            _dictionary.Add("Length", new PdfInteger(0));
            sb.AppendLine(_dictionary.Print());
            sb.AppendLine("stream");
            sb.AppendLine("endstream");
            return sb.ToString();
        }

        public void AddFilter(PdfObject filter)
        {
            _dictionary.Add("Filter", filter);
        }
        public void AddDecodeParms(PdfObject decode)
        {
            _dictionary.Add("DecodeParms", decode);
        }
        public void AddFileSpecification(PdfObject fileSpec)
        {
            _dictionary.Add("F", fileSpec);
        }
        public void AddFFilter(PdfObject ffilter)
        {
            _dictionary.Add("FFilter", ffilter);
        }
        public void AddFDecodeParms(PdfObject fdecode)
        {
            _dictionary.Add("FDecodeParms", fdecode);
        }

        public void AddDl(int num)
        {
            _dictionary.Add("DL", new PdfInteger(num));
        }
    }
}