using System.Collections.Generic;
using System.Text;

namespace CJRPDF.PdfCore
{
    public class PdfFileTrailer:PdfPrintable
    {
        private readonly List<PdfTrailerEntry> _entries = new List<PdfTrailerEntry>();
        internal override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine("trailer");
            sb.Append("<<");
            sb.Append(_entries.PrintAll());
            sb.Append(">>");
            sb.AppendLine("startxref");
            sb.AppendLine(XrefOffset.ToString());
            sb.AppendLine("%%EOF");
            return sb.ToString();
        }

        public void AddEntry(string key, string value)
        {
            _entries.Add(new PdfTrailerEntry(key, value));
        }
        public long XrefOffset { get; set; }
    }

    public class PdfTrailerEntry:PdfPrintable
    {
        public PdfTrailerEntry(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }
        public string Value { get; }
        internal override string Print()
        {
            return $"{Key} {Value}\r\n";
        }
    }
}