using System;

namespace CJRPDF.PdfCore.Operations
{
    public class TextOperation : PdfChildOperation
    {
        public TextOperation(PdfOperation op) : base(op)
        {
        }

        public PdfOperation GetBlock(Func<PdfOperation> func)
        {
            var op = BeginText().Invoke(func) as TextOperation;
            return op.EndText();
        }
        public PdfOperation BeginText()
        {
            return Add("BT");
        }

        public PdfOperation EndText()
        {
            return Add("ET");
        }
    }
}