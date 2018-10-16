using System;

namespace CJRPDF.PdfCore.Operations
{
    public abstract class PdfChildOperation : PdfOperation
    {
        protected readonly PdfOperation _parent;

        protected PdfChildOperation(PdfOperation op)
        {
            _parent = op;
        }

        public override PdfOperation Add(string s)
        {
            return _parent.Add(s);
        }

        public abstract PdfOperation GetBlock(Func<PdfOperation> func);
    }
}