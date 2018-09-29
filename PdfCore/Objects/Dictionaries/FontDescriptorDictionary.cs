using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class FontDescriptorDictionary:PdfDictionary
    {
        public FontDescriptorDictionary() : base("FontDescriptor")
        {

        }
        public string FontName { get; set; }
        public string FontFamily { get; set; }
        public PdfNameObject FontStretch { get; set; }
        public int FontWeight { get; set; }
        public int Flags { get; set; }
        public PdfRectangle FontBBox { get; set; }
        public int ItalicAngle { get; set; }
        public int Ascent { get; set; }
        public int Descent { get; set; }
        public int Leading { get; set; }
        public int CapHeight { get; set; }
        public int XHeight { get; set; }
        public int StemV { get; set; }
        public int StemH { get; set; }
        public int AvgWidth { get; set; }
        public int MaxWidth { get; set; }
        public int MissingWidth { get; set; }
        public PdfStream FontFile { get; set; }
        public PdfStream FontFile2 { get; set; }
        public PdfStream FontFile3 { get; set; }
        public PdfStringObject CharSet { get; set; }
    }
}