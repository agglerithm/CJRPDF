using System;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects.Dictionaries
{
    public class PdfRectangle:PdfObject
    {
        private int _llx;
        private int _lly;
        private int _urx;
        private int _ury;

        public PdfRectangle(int llx, int lly, int urx, int ury)
        {
            _llx = llx;
            _lly = lly;
            _urx = urx;
            _ury = ury;
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}