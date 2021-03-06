﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CJRPDF.PdfCore.Utilities;

namespace CJRPDF.PdfCore.Objects
{
    public class PdfObjectStream:PdfPrintable
    {
        private readonly List<IndirectObjectReference> _list = new List<IndirectObjectReference>();
        public override byte[] Print()
        {
            return _list.PrintAll();
        }

        public void Add(IndirectObjectReference @ref)
        {
            _list.Add(@ref);
        }
    }
}
