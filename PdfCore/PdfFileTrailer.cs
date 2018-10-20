using System.Collections.Generic;
using System.Text;

namespace CJRPDF.PdfCore
{
    public class PdfFileTrailer:PdfPrintable
    {
        private readonly List<PdfTrailerEntry> _entries = new List<PdfTrailerEntry>();
        public override byte[] Print()
        { 
            _writer.Write($"trailer{EscapeSequences.CRLF}");
            _writer.Write($"<<{EscapeSequences.CRLF}");
            _writer.Write(_entries.PrintAll());
            _writer.Write($">>{EscapeSequences.CRLF}");
            _writer.Write($"startxref{EscapeSequences.CRLF}");
            _writer.Write(XrefOffset.ToString());
            _writer.Write($"{EscapeSequences.CRLF}%%EOF");
            return FinishBuffer();
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
        public override byte[] Print()
        {
            return BufferFromString($"{Key} {Value}{EscapeSequences.CRLF}");
        }
    }
}