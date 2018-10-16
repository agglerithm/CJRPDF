using System;
using System.Security.Policy;
using CJRPDF.PdfCore.Objects;

namespace CJRPDF.PdfCore.Operations
{
    public class PathOperation : PdfChildOperation
    {
        public PathOperation(PdfOperation op) : base(op)
        {
        }

        public override PdfOperation GetBlock(Func<PdfOperation> func)
        {
            throw new NotImplementedException();
        }

        public PdfOperation BeginSubpath(int x, int y)
        {
            return Add("");
        }
        
        public PdfOperation AppendLineSegment(int x, int y)
        {
            return Add("");
        }

        public PdfOperation AppendBezierCurve(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return Add("");
        }

        public PdfOperation CloseCurrentSubpath()
        {
            return Add("");
        }
        
        public PdfOperation AppendRectangle(int x, int y, int width, int height)
        {
            return Add("");
        }

        public PdfOperation StrokePath()
        {
            return Add("");
        }
        public PdfOperation CloseAndStrokePath()
        {
            return Add("");
        }

        public PdfOperation FillPath(int rule)
        {
            return Add("");
        }

        public PdfOperation FillAndStrokePath(int rule)
        {
            return Add("");
        }

        public PdfOperation CloseFillStrokePath(int rule)
        {
            return Add("");
        }

        public PdfOperation EndPath()
        {
            return Add("n");
        }

        public PdfOperation ModifyCurrentClippingPath(int rule)
        {
            return Add("");
        }

    }

    public class ColorsOperation : PdfChildOperation
    {
        public ColorsOperation(PdfOperation op) : base(op)
        {
        }

        public override PdfOperation GetBlock(Func<PdfOperation> func)
        {
            throw new NotImplementedException();
        }

        public PdfOperation SetColorSpace(string cs, bool isStrokingOperation)
        {
            return Add("");
        }

        public PdfOperation SetColor(params string[] names)
        {
            return Add("");
        }
    }
    public class LinesOperation : PdfChildOperation
    {
        public LinesOperation(PdfOperation op) : base(op)
        {
        }

        public override PdfOperation GetBlock(Func<PdfOperation> func)
        {
            throw new NotImplementedException();
        }

        public PdfOperation SetLineWidth(decimal width)
        {
            return Add("");
        }

        public PdfOperation SetLineCap(LineCapStyle lcs)
        {
            return Add("");
        }

        public PdfOperation SetLineJoint(LineJointStyle ljs)
        {
            return Add("");
        }

        public PdfOperation SetLineDashPattern(int[] dashArray, int dashPhase)
        {
            return Add("");
        } 
    }
    public class GraphicsOperation : PdfChildOperation
    {
        public GraphicsOperation(PdfOperation operation) : base(operation)
        {
        }

        public PdfOperation Push()
        {
            _parent.Add("q");
            return _parent;
        }

        public PdfOperation Pop()
        {
            _parent.Add("Q");
            return _parent;
        }

        public override PdfOperation GetBlock(Func<PdfOperation> func)
        {
            throw new NotImplementedException();
        }

        public PdfOperation ConcatenateMatrix(PdfMatrix matrix)
        {
            return this;
        }

        public PdfOperation SetMiterLimit()
        {
            return Add("");
        }

        public PdfOperation SetColorRenderingIntent()
        {
            return Add("");
        }

        public PdfOperation SetFlatness(int flatness)
        {
            return Add("");
        }

        public PdfOperation SetDictionaryName(string name)
        {
            return Add("");
        } 
    }

    public class PdfMatrix:PdfObject
    {
        public override byte[] Print()
        {
            throw new NotImplementedException();
        }
    }
}