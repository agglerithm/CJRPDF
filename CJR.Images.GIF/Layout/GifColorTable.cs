using System;
using System.Collections.Generic;
using CJR.Images.Core;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class ColorEntry : PrintableData
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public override byte[] Print()
        {
            return new byte[] { Red, Green, Blue };
        }
    }
    public class GifColorTable:PrintableData
    {
        public List<ColorEntry> Colors { get; set; }
        public override byte[] Print()
        {
            throw new NotImplementedException();
        }
    }
}