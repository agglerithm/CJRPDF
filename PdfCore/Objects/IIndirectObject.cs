﻿namespace CJRPDF.PdfCore.Objects
{
    public interface IIndirectObject
    {
        int IndirectObjectNumber { get; set; }
        IndirectObjectReference ObjectReference { get;   }
        int GenerationNumber { get; set; }
    }
}