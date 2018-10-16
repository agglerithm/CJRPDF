using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CJRPDF.PdfCore.Operations
{
    public class PdfOperation:PdfPrintable
    {
        private readonly StringBuilder _sb = new StringBuilder();
        public GraphicsOperation Graphics { get; set; } 
        public TextOperation Text { get; set; }
        
        public PdfOperation()
        {
            Graphics = new GraphicsOperation(this);
            Text = new TextOperation(this);
        }

        public virtual PdfOperation Add(string s)
        {
            _sb.AppendLine(s);
            return this;
        }

        public override byte[] Print()
        {
            throw new NotImplementedException();
        }

        public PdfOperation BeginCompatibilitySection()
        {

            return Add("BX");

        }

        public PdfOperation EndCompatibilitySection()
        {
            return Add("EX"); 
        }


        public PdfOperation Invoke(Func<PdfOperation> func)
        {
            return func();
        }
    }
}
