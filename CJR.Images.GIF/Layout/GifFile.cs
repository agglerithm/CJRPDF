using System;
using System.Collections.Generic;
using ImagesCore;

namespace CJR.Images.GIF.Layout
{
    public class GifFile:PrintableData
    {
        public string FileName { get; set; }

        public byte[] Buffer { get; set; }

        public string Version { get; set; }

        public GifHeader Header { get; set; }
        public override byte[] Print()
        {
            throw new NotImplementedException();
        }
    }

    public class ColorEntry
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }
    public class GlobalColorTable
    {
        public List<ColorEntry> Colors { get; set; }
    }
    public class GifHeader : PrintableData
    {
        public string Version { get; set; }
        public GifLogicalScreenDescriptor LogicalScreenDescriptor { get; set; }

        public override byte[] Print()
        {
            throw new NotImplementedException();
        }
    }

    public class GifLogicalScreenDescriptor : PrintableData
    {
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public GifScreenAndColorMapInfo ScreenAndColorMapInfo { get; set; }
        public byte BackgroundColor { get; set; }
        public int AspectRatio { get; set; }

        public override byte[] Print()
        {
            throw new NotImplementedException();
        }
    }
}
