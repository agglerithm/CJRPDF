using System;
using System.Security.Cryptography.X509Certificates;
using PdfCore.Objects;

namespace CJRPDF.PdfCore.Objects
{
    public interface IIndirectObject
    {
        int IndirectObjectNumber { get; set; }
        IndirectObjectReference ObjectReference { get;   }
        int GenerationNumber { get; set; }
        Type ReferencedType { get; }
        byte[] Print();
    }
}