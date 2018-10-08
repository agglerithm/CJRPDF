using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using PdfCore;

namespace CJRPDF.PdfCore
{
    public class PdfCrossReferenceTable:PdfPrintable
    {
        private readonly List<PdfCrossReferenceSection> _sections = new List<PdfCrossReferenceSection>();

        public void Add(PdfCrossReferenceSection section)
        {
            section.CurrentObjectNumber = CurrentObjectNumber;
            CurrentObjectNumber += section.EntryCount;
            _sections.Add(section);
        }

        public int CurrentObjectNumber { get; set; }

        public override string Print()
        {
            return _sections.PrintAll();
        }
    }

    public class PdfCrossReferenceSection : PdfPrintable
    {
        private readonly List<PdfCrossReferenceSubSection> _subSections = new List<PdfCrossReferenceSubSection>();
        public int CurrentObjectNumber { get; set; }
        public int EntryCount { get { return _subSections.Sum(s => s.EntryCount); } }

        public void Add(PdfCrossReferenceSubSection subSection)
        {
            subSection.CurrentObjectNumber = CurrentObjectNumber;
            CurrentObjectNumber += subSection.EntryCount;
            _subSections.Add(subSection);
        }
        public override string Print()
        { 
            return $"xref\r\n{_subSections.PrintAll()}";
        }
    }

    public class PdfCrossReferenceSubSection : PdfPrintable
    {
        private readonly List<PdfCrossReferenceEntry> _entries = new List<PdfCrossReferenceEntry>();

        public int FirstObjectNumber { get; private set; }
        public int EntryCount { get { return _entries.Count; } }
        public PdfCrossReferenceSubSection(List<PdfCrossReferenceEntry> entries)
        {
            _entries = entries;
        }
         
        public int CurrentObjectNumber { get; set; } 

        public void Add(PdfCrossReferenceEntry entry)
        {
            FirstObjectNumber = CurrentObjectNumber;
            CurrentObjectNumber ++;
            _entries.Add(entry);
        }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{FirstObjectNumber} {EntryCount}");
            sb.Append(_entries.PrintAll() );
            return sb.ToString();
        }
        
    }
    public class PdfCrossReferenceEntry : PdfPrintable
    {
        public PdfCrossReferenceEntry(long offset, int genNum)
        {
            ByteOffset = offset;
            GenerationNumber = genNum;
        }
        public long ByteOffset { get; }
        public int GenerationNumber { get; }
        public string InUseKeyword { get { return IsFreeEntry ? "f":"n"; } }
        public bool IsFreeEntry { get; set; }

        public override string Print()
        {
            return $"{ByteOffset.ToString("#########")} {GenerationNumber.ToString("#####")} {InUseKeyword} \r\n";
        }
    }
}